using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany.ASC.Homogeneas
{
    public partial class FormASC : FormWithResultNUtils
    {
        #region Campos
        public Atencion_Sostenida_Compleja asc;
        public int index, index1, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion;
        readonly ImgSet.ImageSet imagen;
        private readonly string codigo_paciente;
        private TypeOf_AS_Test tipo_estimulo;
        bool ensayo;
        #endregion

        #region Constructor

        public FormASC(
            bool ensayo,
            string codigo_paciente, 
            int index, 
            int index1, 
            ImgSet.ImageSet imagen, 
            int bloques, 
            int estimulos, 
            int visualizacion, 
            int ocultamiento, 
            int tecla_reaccion,
            Color fondo, TypeOf_AS_Test tipo_estimulo
            )
        {
            this.ensayo = ensayo;
            this.codigo_paciente = codigo_paciente;
            this.index = index;
            this.tecla_reaccion = tecla_reaccion;
            this.index1 = index1;
            this.imagen = imagen;
            this.bloques = bloques;
            this.estimulos = estimulos;
            this.visualizacion = visualizacion;
            this.ocultamiento = ocultamiento;
            this.tecla_reaccion = tecla_reaccion;
            this.tipo_estimulo = tipo_estimulo;
            this.asc = new Atencion_Sostenida_Compleja( null, index, index1, bloques, estimulos, imagen.Count );
            InitializeComponent();
            this.BackColor = fondo;
            //Dimensiones de la pantalla
            Rectangle r = Screen.PrimaryScreen.Bounds;
            //Poniendo las dimensiones de la ventana
            //del tamaño de la pantalla
            this.Height = r.Height;
            this.Width = r.Width;
            int w = (this.Width - this.panel.Width) / 2;
            int h = (this.Height - this.panel.Height) / 2;
            //Posición del panel.
            this.panel.Top = h;
            this.panel.Left = w;
            //Posicion del label
            Feedback.Top = this.Height - 100;
            Feedback.Left = 100;
            Feedback.Font = new Font(FontFamily.GenericSansSerif, 30);
            Feedback.Hide();
            timer.Interval = 1000;
            timer.Start();
        }
        #endregion

        #region Override
        public override sealed Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }
        #endregion

        #region Eventos

        private void timer_Tick(object sender, EventArgs e)
        {
            if (asc.count == 100 * bloques && asc.hide)
            {
                if (asc.miliseg > 0) asc.omisiones[(asc.count - 1) / 100]++;
                
                if (!ensayo)
                {
                    asc.Calcula_estadistica();
                    Resultado = new Resultado_ASC(this.codigo_paciente, asc.omisiones, asc.equivocaciones, asc.aciertos, asc.aciertos_ext, asc.medias_tr, asc.desviaciones_tr, asc.tiempos, DateTime.Now, true, tipo_estimulo);
                }
                this.Dispose();
            }
            else
            {
                if (asc.hide == false)
                {
                    panel.BackgroundImage = null;
                    asc.hide = true;
                    timer.Interval = ocultamiento;
                }
                else
                {
                    bool omision=false;
                    if (asc.miliseg > 0)
                    {
                        omision = true;
                        asc.omisiones[(asc.count - 1) / 100]++;
                        asc.miliseg = 0;
                        if (ensayo) 
                        {
                            Feedback.Show();
                            Feedback.Text = "Estimulo no reconocido";
                        }
                    }

                    this.panel.BackgroundImage = imagen[asc.secuencia_imagen[asc.count]];
                    asc.count++;
                    asc.hide = false;
                    asc.activo = true;
                    if (asc.secuencia[asc.count - 1]) asc.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer.Interval = visualizacion;
                    if (ensayo && !omision) Feedback.Hide();
                }
            }
        }

        private void FormASC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == this.tecla_reaccion )
            {
                KeyHasBeenPressed();
                if( asc.miliseg > 0)
                {
                    int x = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    asc.click(x, 0);
                    if (ensayo) 
                    {
                        Feedback.Show();
                        Feedback.Text = "Acierto";
                    }
                }
                else if (asc.activo)
                {
                    asc.click(0, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = "Error";
                    }
                }
            }

            if (e.KeyValue == 27 && asc.count > 0)
            {
                if (!ensayo)
                {
                    asc.Calcula_estadistica();
                    Resultado = new Resultado_ASC(this.codigo_paciente, asc.omisiones, asc.equivocaciones, asc.aciertos, asc.aciertos_ext, asc.medias_tr, asc.desviaciones_tr, asc.tiempos, DateTime.Now, false, this.tipo_estimulo);
                }
                this.Dispose();
            }
        }
        private void FormASC_KeyUp( object sender, KeyEventArgs e )
        {
            KeyHasBeenRelease();
        }

        private void FormASC_KeyPress( object sender, KeyPressEventArgs e )
        {

        }
        #endregion

        
    }
}