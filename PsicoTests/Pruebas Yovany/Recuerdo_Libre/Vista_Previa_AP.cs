using System;
using System.Drawing;
using System.Windows.Forms;

namespace PsicoTests.Yovany
{
    public class Vista_Previa_AP : IVistaPrevia
    {
        public bool hide = true;
        public int count = 0;
        public int milisec = 0;
        public Color color_target;
        public string letra_target;
        public string[] letras;
        public string[] secuencia_letra;
        public Color[] secuencia_color;
        public int[] omisiones;
        public int[] equivocaciones;
        public int[] aciertos;
        public Timer t1;
        public Timer t2;
        private readonly Control c;
        public Label label1;
        public TextBox tb;
        readonly string[] prueba;
        public int contador;
        bool visible;


        public Vista_Previa_AP(Control c)
        {
            visible = false;
            contador = 0;

            int x = c.Width;
            int y = c.Height;
            label1 = new Label();
            this.label1.Width = 2 * x / 3;
            this.label1.Height = 2 * y / 3;
            this.label1.Location = new Point(x / 6, y / 6);
            this.label1.Font = new Font("Arial", x / 12);
            this.label1.Text = "";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            
            this.c = c;
            this.c.Controls.Add(this.label1);
            this.c.Controls.Add(this.tb);
            prueba = new[] { "sombra", "correr", "rojo", "estrella", "descansar" };
            t1 = new Timer {Interval = 500};
            t2 = new Timer {Interval = 1000};
            t1.Tick += t1_tick;
            t2.Tick += t2_tick;
            this.t1.Start();

        }

        public void t1_tick(object sender, EventArgs e)
        {
            if (contador == 5)
            {
                label1.Visible = false;
                this.t1.Stop();
                this.t2.Start();
                return;
            }
            if (visible)
            {
                visible = false;
                this.label1.Visible = false;
            }
            else
            {
                visible = true;
                this.label1.ForeColor = Color.Red;
                this.label1.Text = this.prueba[contador];
                this.contador++;
                this.label1.Visible = true;
            }
        }
        public void t2_tick(object sender, EventArgs e)
        {
            if (contador == 6)
            {
                contador = 0;
                t2.Stop();
                t1.Start();
            }
            if (this.contador == 5)
            {
                contador = 6;
            }


        }

        public void Start()
        { }

        public void Stop()
        {
            t1.Stop();
            this.c.Controls.Clear();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            this.label1.Show();
        }
    }
}
