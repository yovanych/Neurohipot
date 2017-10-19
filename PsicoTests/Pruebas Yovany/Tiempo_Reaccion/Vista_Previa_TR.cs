using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace PsicoTests.Yovany
{
    public class Vista_Previa_TR : IVistaPrevia
    {
        public ArrayList tiempos;
        public bool hide = true;
        public int count = 0;
        public int milisec = 0;
        public Color color_target, color_target1;



        public Color[] secuencia_color;
        public int[] omisiones;
        public int[] equivocaciones;
        public int[] aciertos;
        public Timer t1;

        public Control control;
        public Label label1;
        string[] prueba;
        public Color[] colores;
        public int contador;
        bool visible;
        readonly Random random;
        readonly int x;
        readonly int y;


        public Vista_Previa_TR(Control c)
        {
            random = new Random(Environment.TickCount);
            this.color_target = Color.White;
            this.color_target1 = Color.Black;
            this.control = c;
            visible = false;
            contador = 0;
            this.x = c.Width;
            this.y = c.Height;



            colores = new[] { color_target1, color_target1, color_target1, color_target, color_target, color_target1, color_target, color_target, color_target1, color_target1 };
            t1 = new Timer { Interval = 500 };


            t1.Tick += t1_tick;

            this.t1.Start();

        }

        public void t1_tick(object sender, EventArgs e)
        {
            if (contador == 10)
            {
                contador = 0;
            }
            if (visible)
            {
                visible = false;
                Graphics g = this.control.CreateGraphics();
                Color back = this.control.BackColor;
                g.FillEllipse(new SolidBrush(back), x / 3, (y - x / 3) / 2, x / 3, x / 3);
                this.t1.Interval = this.random.Next(400, 4000);
            }
            else
            {
                visible = true;
                Graphics g = this.control.CreateGraphics();
                Color back = this.control.BackColor;
                g.FillEllipse(new SolidBrush(colores[contador]), x / 3, (y - x / 3) / 2, x / 3, x / 3);
                this.t1.Interval = 500;
                contador++;

            }
        }
        public void t2_tick(object sender, EventArgs e)
        {

        }

        public void Start()
        { }

        public void Stop()
        {
            t1.Stop();

        }

        public void click(int x, int y)
        {

        }

        public void Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
