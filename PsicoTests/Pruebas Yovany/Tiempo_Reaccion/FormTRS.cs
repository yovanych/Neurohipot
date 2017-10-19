using System;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;

namespace PsicoTests.Yovany
{
    public partial class FormTRS : FormWithResultNUtils
    {
        private readonly Random random;
        private readonly TiempoReaccion.Figura figura;

        //int demora = 0;
        readonly TiempoReaccionSimple ass;
        readonly Color color_target;

        readonly int tecla_reaccion;
        //Graphics g;
        //Color back;
        public int  diametro;
        readonly Point[] p;
        private readonly string codigoPaciente;
        


        public FormTRS(string codigoPaciente, int tecla_reaccion, Color color_target, int estimulos, int visualizacion,  int reaccion, TiempoReaccion.Figura figura)
		{                
           
            random = new Random(Environment.TickCount);
            this.codigoPaciente = codigoPaciente;
            //this.g = this.CreateGraphics();
            //this.back = this.BackColor;
            this.tecla_reaccion = tecla_reaccion;
            this.figura = figura;
            this.color_target = color_target;

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
			
			ass = new TiempoReaccionSimple (null,color_target, estimulos, reaccion, visualizacion);
            timer1.Interval = visualizacion;
            p = new Point[3];
            p[0] = new Point(0, this.panel1.Height);
            p[1] = new Point(this.panel1.Height, this.panel1.Width);
            p[2] = new Point(this.panel1.Width / 2, 0);
            timer1.Start();			
		}
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ass.count == ass.estimulos)
            {
                double mediaEnTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                double mediaFueraTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                Resultado = new Resultado_TRS(codigoPaciente, 
                    ass.tiempostiempo.Count, 
                    mediaEnTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempostiempo, mediaEnTiempo ),
                    ass.tiempospasado.Count,
                    mediaFueraTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempospasado, mediaFueraTiempo ),
                    ass.omisiones,
                    ass.reaccanti, 
                    DateTime.Now, 
                    true );
                this.Dispose();
            }
            
            if (ass.hide == false)
            {
                this.panel1.Invalidate();
                ass.hide = true;
                timer1.Interval = ass.reaccion;
            }
            else
            {
                if (this.timer1.Interval == ass.reaccion)
                {
                    this.timer1.Interval = random.Next(ass.reaccion + 200, ass.reaccion + 2500);
                    if (ass.time != 0)
                    {
                        ass.time = 0;
                        ass.omisiones++;
                    }
                }
                else
                {
                    ass.time = DateTime.Now.Millisecond + DateTime.Now.Second*1000 + DateTime.Now.Minute*60000 + DateTime.Now.Hour*3600000;
                     this.panel1.Invalidate();
                    ass.count++;
                    ass.hide = false;
                    timer1.Interval = ass.visualizacion;
                }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ass.milisec++;
        }

        private void FormTRS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == this.tecla_reaccion && ass.count > 0)
            {
                int y = DateTime.Now.Millisecond;
                int x = ass.time;
                ass.click(DateTime.Now.Millisecond + DateTime.Now.Second*1000 + DateTime.Now.Minute*60000 + DateTime.Now.Hour*3600000);
            }
            
            if (e.KeyValue == 27 && ass.count > 0)
            {
                double mediaEnTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                double mediaFueraTiempo = StatFunctionLibrary.media( ass.tiempostiempo );
                Resultado = new Resultado_TRS(codigoPaciente,
                    ass.tiempostiempo.Count,
                    mediaEnTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempostiempo, mediaEnTiempo ),
                    ass.tiempospasado.Count,
                    mediaFueraTiempo,
                    StatFunctionLibrary.desv_est( ass.tiempospasado, mediaFueraTiempo ),
                    ass.omisiones,
                    ass.reaccanti,
                    DateTime.Now,
                    false);
                this.Dispose();
            }

        }    
     

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            Color cr = this.ass.hide ? this.panel1.BackColor : this.color_target;

            if (this.figura == TiempoReaccion.Figura.Cuadrado)
                g.FillRectangle(new SolidBrush(cr), 0, 0, this.panel1.Width, this.panel1.Height);
            else if (this.figura == TiempoReaccion.Figura.Circulo)
                g.FillEllipse(new SolidBrush(cr), 0, 0, this.panel1.Width, this.panel1.Height);
            else
                g.FillPolygon(new SolidBrush(cr), p);
            
        }
    }
}