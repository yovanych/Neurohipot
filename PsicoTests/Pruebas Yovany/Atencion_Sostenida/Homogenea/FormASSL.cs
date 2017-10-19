using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany.ASS.Homogeneas
{
    public partial class FormASSL : FormWithResultNUtils
    {
        #region Campos
        private IContainer components;
	    private readonly string codigo_paciente;

	    //int demora = 0;
	    readonly Atencion_Sostenida_Simple ass;

	    readonly int bloques;
	    readonly int estimulos;
	    readonly int visualizacion;
	    readonly int ocultamiento;
	    readonly int tecla_reaccion;
	    readonly string imagen;
        readonly Color color_letra;
        readonly bool ensayo;
        #endregion

        #region Constructor
        public FormASSL(
            bool ensayo,
            string codigoPaciente, 
            string imagen, 
            int index,
            int bloques, 
            int estimulos, 
            int visualizacion, 
            int ocultamiento, 
            int tecla_reaccion,
            Color fondo, Color color_letra)
		{
            this.ensayo = ensayo;
		    this.codigo_paciente = codigoPaciente;
            this.imagen = imagen;
            this.tecla_reaccion = tecla_reaccion;
            this.bloques = bloques;
            this.estimulos = estimulos;
            this.visualizacion = visualizacion;
            this.ocultamiento = ocultamiento;
            this.color_letra = color_letra;
            InitializeComponent();
            this.BackColor = fondo;
			//Dimensiones de la pantalla
			Rectangle r = Screen.PrimaryScreen.Bounds;

			//Poniendo las dimensiones de la ventana
			//del tamaño de la pantalla
			this.Height = r.Height;
			this.Width = r.Width;
            this.label.Width = this.Width / 2;
            this.label.Height = this.Height / 2;
			int w = (this.Width - 180)/2;
			int h = (this.Height - 180)/2;
            //Posicion del label
            Feedback.Top = this.Height - 100;
            Feedback.Left = 100;
            Feedback.Font = new Font(FontFamily.GenericSansSerif, 30);
            Feedback.Hide();
            this.label.TextAlign = ContentAlignment.BottomLeft;
            
            

            label.ForeColor = color_letra;
			//Posición del panel.
			this.label.Top = h;
			this.label.Left = w;
            ass = new Atencion_Sostenida_Simple( null, index, this.bloques, this.estimulos, imagen.Length );
            timer_muestra.Interval = 1000;
            timer_muestra.Start();
			
		}
        #endregion

        #region Eventos
        //private void timer_contador_Tick(object sender, EventArgs e)
        //{
        //    ass.milisec++;
        //}

        private void timer_muestra_Tick_1(object sender, EventArgs e)
        {
            if (ass.count == this.bloques * 100 && ass.hide)
            {
                if (ass.miliseg != 0) ass.omisiones[(ass.count - 1) / 100]++;
                if (!ensayo)
                {
                    ass.Calcula_estadistica();
                    Resultado = new Resultado_ASS(this.codigo_paciente, ass.omisiones, ass.equivocaciones, ass.aciertos, ass.aciertos_ext, ass.medias_tr, ass.desviaciones_tr,
                        ass.tiempos, DateTime.Now, true, TypeOf_AS_Test.H_Letras);
                }
                this.Dispose();
            }
            else
            {
                if (ass.hide == false)
                {
                    label.Text = "";
                    ass.hide = true;
                    timer_muestra.Interval = ocultamiento;
                }
                else
                {
                    bool omision=false;
                    if (ass.miliseg > 0)
                    {
                        omision = true;
                        ass.omisiones[(ass.count - 1) / 100]++;
                        ass.miliseg = 0;
                        if (ensayo)
                        {
                            Feedback.Show();
                            Feedback.Text = @"Estimulo no reconocido";
                        }
                    }

                    this.label.Text = imagen[ass.secuencia_imagen[ass.count]] + "";
                    ass.count++;
                    ass.hide = false;
                    ass.activo = true;
                    if (ass.secuencia[ass.count - 1]) ass.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer_muestra.Interval = visualizacion;
                    if (ensayo && !omision) Feedback.Hide();
                }
            }
        }

        private void FormASSL_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == this.tecla_reaccion)
            {
                KeyHasBeenPressed();
                if (ass.miliseg > 0)
                {
                    int x = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    ass.click(x, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = @"Acierto";
                    }
                }
                else if (ass.activo)
                {
                    ass.click(0, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = @"Error";
                    }
                }
            }

            if (e.KeyValue == 27 && ass.count > 0)
            {
                if (!ensayo)
                {
                    ass.Calcula_estadistica();
                    Resultado = new Resultado_ASS(this.codigo_paciente, ass.omisiones, ass.equivocaciones, ass.aciertos, ass.aciertos_ext, ass.medias_tr, ass.desviaciones_tr,
                        ass.tiempos, DateTime.Now, false, TypeOf_AS_Test.H_Letras);
                }
                this.Dispose();
            }

        }

        private void FormASSL_KeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyValue == this.tecla_reaccion)
                KeyHasBeenRelease();
        }
        #endregion
    }
}
