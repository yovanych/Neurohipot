using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany.ASC.Homogeneas
{
    public partial class FormASCL : FormWithResultNUtils
    {
        #region Campos
        public Atencion_Sostenida_Compleja_Letras ascl;
        public int index, index1, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion;
        readonly ImgSet.ImageSet imagen;
        readonly string secuencia_letras;
        private readonly string codigo_paciente;
        readonly bool ensayo;
        #endregion

        #region Constructores
        public FormASCL(
            bool ensayo,
            string codigo_paciente, 
            int index, 
            int index1, 
            string secuencia_letras,
            int bloques, 
            int estimulos, 
            int visualizacion, 
            int ocultamiento, 
            int tecla_reaccion,
            Color fondo,
            Color color_letra)
        {
            this.ensayo = ensayo;
            this.codigo_paciente = codigo_paciente;
            this.index = index;
            this.tecla_reaccion = tecla_reaccion;
            this.index1 = index1;
            this.secuencia_letras = secuencia_letras;
            this.bloques = bloques;
            this.estimulos = estimulos;
            this.visualizacion = visualizacion;
            this.ocultamiento = ocultamiento;
            this.tecla_reaccion = tecla_reaccion;
            this.ascl = new Atencion_Sostenida_Compleja_Letras( null, index, index1, bloques, estimulos, this.secuencia_letras.Length);
            InitializeComponent();
            this.BackColor = fondo;
            this.label.BackColor = fondo;
            this.label.ForeColor = color_letra;
            this.label.TextAlign = ContentAlignment.MiddleCenter;
            //Dimensiones de la pantalla
            Rectangle r = Screen.PrimaryScreen.Bounds;
            //Poniendo las dimensiones de la ventana
            //del tamaño de la pantalla
            this.Height = r.Height;
            this.Width = r.Width;
            int w = (this.Width - 180) / 2;
            int h = (this.Height - 180) / 2;
            this.label.Top = h;
            this.label.Left = w;
            //Posicion del label
            Feedback.Top = this.Height - 100;
            Feedback.Left = 100;
            Feedback.Font = new Font(FontFamily.GenericSansSerif, 30);
            Feedback.Hide();
           
            timer.Interval = 1000;
            timer.Start();
        }
        #endregion

        #region events

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ascl.count == 100 * bloques && ascl.hide)
            {
                if (ascl.miliseg > 0) ascl.omisiones[(ascl.count - 1) / 100]++;
                if (!ensayo)
                {
                    ascl.Calcula_estadistica();
                    Resultado = new Resultado_ASC(this.codigo_paciente, ascl.omisiones, ascl.equivocaciones, ascl.aciertos, ascl.aciertos_ext, ascl.medias_tr, ascl.desviaciones_tr, ascl.tiempos, DateTime.Now, true, TypeOf_AS_Test.H_Letras);
                }
                this.Dispose();
            }
            else
            {
                if (ascl.hide == false)
                {

                    this.label.Text = "";
                    //panel.BackgroundImage = null;
                    ascl.hide = true;
                    timer.Interval = ocultamiento;
                }
                else
                {
                    bool omision = false;
                    if (ascl.miliseg > 0)
                    {
                        omision = true;
                        ascl.omisiones[(ascl.count - 1) / 100]++;
                        ascl.miliseg = 0;
                        if (ensayo)
                        {
                            Feedback.Show();
                            Feedback.Text = @"Estimulo no reconocido";
                        }
                    }

                    this.label.Text = secuencia_letras[ascl.secuencia_imagen[ascl.count]]+"";
                   // this.panel.BackgroundImage = imagen[asc.secuencia_imagen[asc.count]];
                    ascl.count++;
                    ascl.hide = false;
                    ascl.activo = true;
                    if (ascl.secuencia[ascl.count - 1]) ascl.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer.Interval = visualizacion;
                    if (ensayo && !omision) Feedback.Hide();
                }
            }
        }

        private void FormASCL_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == this.tecla_reaccion)
            {
                KeyHasBeenPressed();
                if (ascl.miliseg > 0)
                {
                    int x = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    ascl.click(x, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = @"Acierto";
                    }
                }
                else if (ascl.activo)
                {
                    ascl.click(0, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = @"Error";
                    }
                }
            }

            if (e.KeyValue == 27 && ascl.count > 0)
            {
                if (!ensayo)
                {
                    ascl.Calcula_estadistica();
                    Resultado = new Resultado_ASC(this.codigo_paciente, ascl.omisiones, ascl.equivocaciones, ascl.aciertos, ascl.aciertos_ext, ascl.medias_tr, ascl.desviaciones_tr, ascl.tiempos, DateTime.Now, false, TypeOf_AS_Test.H_Letras);
                }
                this.Dispose();
            }
        }

        private void FormASCL_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyValue == this.tecla_reaccion )
                KeyHasBeenRelease();
        }
        #endregion
    }
}
