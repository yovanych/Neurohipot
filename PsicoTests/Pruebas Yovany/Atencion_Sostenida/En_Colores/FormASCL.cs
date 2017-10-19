using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany.ASC.Colores
{
    public partial class FormASCL : FormWithResultNUtils
    {
        public Atencion_Sostenida_Compleja asc;
        public int index, index1, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion;
        ImgSet.ImageSet imagen;
        private readonly string codigoPaciente;

        public FormASCL(string codigoPaciente, int index, int index1, ImgSet.ImageSet imagen, int bloques, int estimulos, int visualizacion, int ocultamiento, int tecla_reaccion)
        {
            this.codigoPaciente = codigoPaciente;
            this.index = index;
            this.tecla_reaccion = tecla_reaccion;
            this.index1 = index1;
            this.imagen = imagen;
            this.bloques = bloques;
            this.estimulos = estimulos;
            this.visualizacion = visualizacion;
            this.ocultamiento = ocultamiento;
            this.tecla_reaccion = tecla_reaccion;
            this.asc = new Atencion_Sostenida_Compleja(null, index, index1, bloques, estimulos);
            InitializeComponent();
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
            timer.Interval = 1000;
            timer.Start();
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            if (asc.count == 100 * bloques && asc.hide)
            {
                if (asc.miliseg > 0) asc.omisiones[(asc.count - 1) / 100]++;

                int dim = asc.omisiones.Length;
                var aciertos_extrannos = new int[dim]; // no se está usando en esta versión
                var tiempos_reaccion = new double[dim]; // no se está usando en esta versión
                var desviaciones = new double[dim]; // no se está usando en esta versión
                this.Resultado = new Resultado_ASC(this.codigoPaciente, 
                    asc.omisiones, 
                    asc.equivocaciones, 
                    asc.aciertos, 
                    aciertos_extrannos,
                    tiempos_reaccion,
                    desviaciones,
                    asc.tiempos, 
                    DateTime.Now,
                    true,
                    TypeOf_AS_Test.C_Letras);
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
                    if (asc.miliseg > 0)
                    {
                        asc.omisiones[(asc.count - 1) / 100]++;
                        asc.miliseg = 0;
                    }


                    this.panel.BackgroundImage = imagen[asc.secuencia_imagen[asc.count]];
                    asc.count++;
                    asc.hide = false;
                    asc.activo = true;
                    if (asc.secuencia[asc.count - 1]) asc.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer.Interval = visualizacion;
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
                }
                else if (asc.activo)
                {
                    asc.click(0, 0);
                }
            }

            if (e.KeyValue == 27 && asc.count > 0)
            {
                int dim = asc.omisiones.Length;
                var aciertos_extrannos = new int[dim]; // no se está usando en esta versión
                var tiempos_reaccion = new double[dim]; // no se está usando en esta versión
                var desviaciones = new double[dim]; // no se está usando en esta versión
                this.Resultado = new Resultado_ASC(this.codigoPaciente,
                    asc.omisiones,
                    asc.equivocaciones,
                    asc.aciertos,
                    aciertos_extrannos,
                    tiempos_reaccion,
                    desviaciones,
                    asc.tiempos,
                    DateTime.Now,
                    false,
                    TypeOf_AS_Test.C_Letras);
                this.Dispose();
            }
        }

        private void FormASCL_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyValue == this.tecla_reaccion )
            {
                KeyHasBeenRelease();
            }
        }

       
    }
}