using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace PsicoTests.Yovany.VistaPrevia
{
    public class Vista_Previa_AS_Letras_Colores : IVistaPrevia
    {
        public ArrayList tiempos;
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
        readonly string[] prueba;
        public Color[] colores;
        public int contador;
        bool visible;


        public Vista_Previa_AS_Letras_Colores(string letra_target, Color color_target, Control c)
        {

            visible = false;
            contador = 0;
            int x = c.Width;
            int y = c.Height;
            label1 = new Label();
            this.label1.Width = x / 3;
            this.label1.Height = y / 3;

            this.label1.Location = new Point(x / 3, y / 3);
            this.label1.Font = new Font("Arial", x / 6);
            this.label1.Text = "";
            this.c = c;
            this.c.Controls.Add(this.label1);
            prueba = new[] { "F", "H", "Z", letra_target, "V", "Z", "W", "B", letra_target, "A" };
            colores = new[] { Color.Beige, Color.Beige, Color.Red, color_target, Color.Gray, Color.Yellow, Color.Wheat, Color.Green, color_target, Color.Goldenrod };
            t1 = new Timer {Interval = 500};
            t2 = new Timer {Interval = 1};
            t1.Tick += t1_tick;
            t2.Tick += t2_tick;
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
                this.label1.Visible = false;
            }
            else
            {
                visible = true;
                this.label1.ForeColor = this.colores[contador];
                this.label1.Text = this.prueba[contador];
                this.contador++;
                this.label1.Visible = true;
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
            this.c.Controls.Clear();
        }

        public void click(int x, int y)
        {
            if (this.secuencia_letra[this.count - 1] == this.letra_target && this.secuencia_color[this.count - 1] == this.color_target)
            {
                this.aciertos[(this.count - 1) / 100]++;
                tiempos.Add(this.milisec * 50 / 3);
                this.milisec = 0;
            }
            else
            {
                this.equivocaciones[(this.count - 1) / 100]++;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            this.label1.Show();
        }
    }
}
