using System;
using System.Windows.Forms;
using System.Drawing;

namespace PsicoTests.Yovany.VistaPrevia
{
    public class Vista_Previa_AS_Letras : IVistaPrevia
    {
        #region Campos
        public bool hide = true;
        public int count;
        public Timer t1;
        public Timer t2;
        public Control c;
        public Label label;     
        readonly int[] prueba;
        public int contador;
        bool visible;
        readonly string letras;
        #endregion 
        
        public Vista_Previa_AS_Letras(Color colorFondo, Color colorLetra, string letras, Control c) 
        {
            visible = false;
            contador = 0;
            int x = c.Width;
            int y = c.Height;
            this.letras = letras;
            this.c = c;

            label = new Label
                        {
                            Width = x/3,
                            Height = y/3,
                            BackColor = colorFondo,
                            ForeColor = colorLetra,
                            Font = new Font("calibri", 35),
                            Location = new Point(x/3, y/3),
                            TextAlign = ContentAlignment.MiddleCenter
                        };
            this.c.BackColor = colorFondo;
            this.c.Controls.Add(label);


            prueba = new[] { 3, 7, 0, 6, 4, 1, 9, 1, 1, 3 }; //Aqui poner indices menores que la longitud de letras
            t1 = new Timer { Interval = 500 };
            t2 = new Timer { Interval = 1 };
            t1.Tick += t1_tick;
            t2.Tick += t2_tick;
            this.t1.Start();
        }

        #region Events
        public void t1_tick(object sender, EventArgs e)
        {
            if (contador == 10)
                contador = 0;
            if (visible)
            {
                visible = false;
                this.label.Visible = false;
            }
            else
            {
                visible = true;
                this.label.Text = letras[this.prueba[contador]]+"";
                this.contador++;
                this.label.Visible = true;
            }
        }
        public void t2_tick(object sender, EventArgs e)
        {

        }
        #endregion
        
        #region Override
        public void Start()
        { }
        public void Stop()
        {
            t1.Stop();
            this.c.Controls.Clear();
        }
        public void Paint(object sender, PaintEventArgs e)
        {
            this.label.Show();
        }
        #endregion
        
    }
}
