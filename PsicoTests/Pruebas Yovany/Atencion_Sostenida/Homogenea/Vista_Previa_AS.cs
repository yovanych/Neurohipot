using System;
using System.Drawing;
using System.Windows.Forms;

namespace PsicoTests.Yovany.VistaPrevia
{
    public class Vista_Previa_AS : IVistaPrevia
    {
        #region Campos
        public bool hide = true;
        public int count;
        public Timer t1;
        public Timer t2;
        public Control c;

        public Panel panel;
        readonly int[] prueba;
        public int contador;
        bool visible;
        readonly ImgSet.ImageSet imagen;
        #endregion 

        #region constructores
        public Vista_Previa_AS( Color colorFondo, ImgSet.ImageSet imagen, Control c )
        {
            visible = false;
            contador = 0;
            int x = c.Width;
            int y = c.Height;
            this.imagen = imagen;
            panel = new Panel
            {
                BackgroundImageLayout = ImageLayout.Stretch
            };
            this.panel.Width = x/3;
            this.panel.Height = y/2;
            this.c = c;
            this.c.BackColor = colorFondo;

            this.panel.Location = new Point( x / 3, y / 4 );
            this.c.Controls.Add( this.panel );
            prueba = new[] { 3, 7, 3, 6, 17, 12, 9, 10, 1, 14 };
            t1 = new Timer { Interval = 500 };
            t2 = new Timer { Interval = 1 };
            t1.Tick += t1_tick;
            t2.Tick += t2_tick;
            this.t1.Start();
        }
        #endregion

        #region Events
        public void t1_tick( object sender, EventArgs e )
        {
            if ( contador == 10 )
                contador = 0;
            if ( visible )
            {
                visible = false;
                this.panel.Visible = false;
            }
            else
            {
                visible = true;
                this.panel.BackgroundImage = imagen[this.prueba[contador]];
                this.contador++;
                this.panel.Visible = true;
            }
        }
        public void t2_tick( object sender, EventArgs e )
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
        public void Paint( object sender, PaintEventArgs e )
        {
            this.panel.Show();
        }
        #endregion
    }
}
