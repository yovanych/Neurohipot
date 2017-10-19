using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany
{
    public partial class FormTR : FormWithResultNUtils
    {
        private Timer timer_muestra;
        private Timer timer_contador;
        private readonly Random random;
        Point[] p;

        //int demora = 0;
        readonly TiempoReaccion ass;


        readonly int tecla_reaccion;
        readonly int tecla_reaccion1;
        Graphics g;
        Color back;
        readonly TiempoReaccion.Figura figura;
        private readonly string codigoPaciente;

        public FormTR(string codigoPaciente, Color color_target, Color color_target1, int estimulos, int visualizacion, int reaccion, int tecla_reaccion, int tecla_reaccion1, TiempoReaccion.Figura figura)
		{
            random = new Random(Environment.TickCount);
            this.g = this.CreateGraphics();
            this.back = this.BackColor;
            this.tecla_reaccion = tecla_reaccion;
            this.tecla_reaccion1 = tecla_reaccion1;
            this.figura = figura;
            this.codigoPaciente = codigoPaciente;
			
			InitializeComponent();
			//Dimensiones de la pantalla
			Rectangle rect = Screen.PrimaryScreen.Bounds;

			//Poniendo las dimensiones de la ventana
			//del tamaño de la pantalla
			this.Height = rect.Height;
			this.Width = rect.Width;
            this.panel1.Width = this.Width / 2;
            this.panel1.Height = this.Width / 2;
            this.panel1.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.panel1.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.panel1.Height) / 2);
            this.panel1.BackColor = this.BackColor;
			
			ass = new TiempoReaccion (null, color_target, color_target1, estimulos, visualizacion, reaccion);
            timer_muestra.Interval = visualizacion;
            p = new Point[3];
            p[0] = new Point(0, this.panel1.Height);
            p[1] = new Point(this.panel1.Height, this.panel1.Width);
            p[2] = new Point(this.panel1.Width / 2, 0);
            timer_muestra.Start();
			
		}

        private void timer_muestra_Tick(object sender, EventArgs e)
        {
            if (ass.count == ass.estimulos)
            {
                double mediaEnTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                double mediaFueraTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                Resultado = new Resultado_TRC(codigoPaciente,
                    ass.tiempostiempo.Count,
                    mediaEnTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempostiempo, mediaEnTiempo ),
                    ass.tiempospasado.Count,
                    mediaFueraTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempospasado, mediaFueraTiempo ),
                    ass.omisiones,
                    ass.reaccanti,
                    ass.equivocaciones,
                    DateTime.Now,
                    true);
                this.Dispose();
            }

            if (ass.hide == false)
            {
                this.panel1.Invalidate();
                ass.hide = true;
                this.timer_muestra.Interval = ass.reaccion;
            }
            else
            {
                if (this.timer_muestra.Interval == ass.reaccion)
                {
                    this.timer_muestra.Interval = random.Next(ass.reaccion + 200, ass.reaccion + 2500);
                    if (ass.time != 0)
                    {
                        ass.time = 0;
                        ass.omisiones++;
                    }
                }
                else
                {

                    ass.time = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    this.panel1.Invalidate();
                    ass.count++;
                    ass.hide = false;
                    timer_muestra.Interval = ass.visualizacion;
                }

            }
        }

        private void timer_contador_Tick(object sender, EventArgs e)
        {
            ass.milisec++;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == this.tecla_reaccion && ass.count > 0)
            {

                ass.click(DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000, 0);
            }
            if (e.KeyValue ==this.tecla_reaccion1 && ass.count > 0)
            {

                ass.click(DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000, 1);
            }
            if (e.KeyValue == 27 && ass.count > 0)
            {
                double mediaEnTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                double mediaFueraTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                Resultado = new Resultado_TRC(codigoPaciente,
                    ass.tiempostiempo.Count,
                    mediaEnTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempostiempo, mediaEnTiempo ),
                    ass.tiempospasado.Count,
                    mediaFueraTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempospasado, mediaFueraTiempo ),
                    ass.omisiones,
                    ass.reaccanti,
                    ass.equivocaciones,
                    DateTime.Now,
                    false);
                this.Dispose();
            }

        }        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Color c;
            if (this.ass.hide)
                c = this.panel1.BackColor;
            else
            {
                
                int x = this.random.Next(1,100);
                if (x > 50)
                {
                    ass.color_activo = 0;
                    c = ass.color_target;
                }
                else
                {
                    ass.color_activo = 1;
                    c = ass.color_target1;
                }
                
            }
            if (this.figura == TiempoReaccion.Figura.Circulo)
                g.FillEllipse(new SolidBrush(c), 0, 0, this.panel1.Width, this.panel1.Height);
            else if (this.figura == TiempoReaccion.Figura.Cuadrado)
                g.FillRectangle(new SolidBrush(c), 0, 0, this.panel1.Width, this.panel1.Height);
            else
                g.FillPolygon(new SolidBrush(c), p);

        }
    }
}