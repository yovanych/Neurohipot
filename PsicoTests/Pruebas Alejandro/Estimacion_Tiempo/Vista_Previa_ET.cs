using System;
using System.Drawing;
using System.Windows.Forms;

namespace PsicoTests.Alejandro
{
    public class Vista_Previa_ET : IVistaPrevia
    {
        #region Parametros

        public int IntervaloSalida { get; set; }

        private int anchoEstimulo;
        public int AnchoEstimulo
        {
            get { return anchoEstimulo; }
            set { anchoEstimulo = value * 200 / 1024; }
        }

        private int altoEstimulo;
        public int AltoEstimulo
        {
            get { return altoEstimulo; }
            set { altoEstimulo = value * 200 / 1024; }
        }

        private int zonaOpaca;
        public int ZonaOpaca
        {
            get { return zonaOpaca; }
            set
            {
                zonaOpaca = value * 200 / 1024;
                ladoDerecho = (c.Width - this.zonaOpaca) / 2 + this.zonaOpaca;
            }
        }

        private int areaCorrecta;
        public int AreaCorrecta
        {
            get { return areaCorrecta; }
            set { areaCorrecta = value * 200 / 1024; }
        }

        private Color estimulo;
        public Color ColorEstimulo
        {
            get { return estimulo; }
            set
            {
                estimulo = value;
                this.estimuloBrush = new SolidBrush(estimulo);
            }
        }

        private Color colorZonaOpaca;
        public Color ColorZonaOpaca
        {
            get { return colorZonaOpaca; }
            set
            {
                colorZonaOpaca = value;
                this.zonaBrush = new SolidBrush(colorZonaOpaca);
            }
        }
        #endregion

        private int xInic, yInic;
        private Brush estimuloBrush, zonaBrush;
        private Point rangoSalida;
        private readonly int final;
        private readonly Random randSalida;
        private readonly Random randVelocidad;
        private int incremento;
        private readonly Timer timer1;
        private int ladoDerecho;
        private readonly MyPictureBox myPict;
        private readonly Control c;

        private Estado_ET estado;


        public Vista_Previa_ET(Control c, int intervaloSalida,
                                    int anchoEstimulo, int altoEstimulo, int zonaOpaca, int areaCorrecta,
                                    Color estimulo, Color colorZonaOpaca)
        {
            this.IntervaloSalida = intervaloSalida;
            this.anchoEstimulo = anchoEstimulo * 200 / 1024;
            this.altoEstimulo = altoEstimulo * 200 / 1024;
            this.zonaOpaca = zonaOpaca * 200 / 1024;
            this.areaCorrecta = areaCorrecta * 200 / 1024;

            this.estimulo = estimulo;
            this.colorZonaOpaca = colorZonaOpaca;
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;

            myPict = new MyPictureBox();

            this.c = c;
            randSalida = new Random(Environment.TickCount);
            randVelocidad = new Random(Environment.TickCount + 25);


            rangoSalida = new Point(5, c.Height - 5);
            final = c.Width;

            estimuloBrush = new SolidBrush(estimulo);
            zonaBrush = new SolidBrush(colorZonaOpaca);
            estado = Estado_ET.Nulo;
            ladoDerecho = (c.Width - this.zonaOpaca) / 2 + this.zonaOpaca;

        }

        public void Start()
        {
            myPict.Location = new Point(0, 0);
            myPict.Size = new Size(100, 100);
            myPict.Dock = DockStyle.Fill;
            myPict.Paint += Paint;
            myPict.BackColor = Color.Black;
            c.Controls.Add(myPict);
            estado = Estado_ET.EnCurso;
            reiniciar();
            timer1.Start();
        }
        public void Stop()
        {
            estado = Estado_ET.Terminado;
            this.c.Controls.Clear();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.myPict.Refresh();
            xInic += incremento;
            if (xInic >= final)
            {
                System.Threading.Thread.Sleep(IntervaloSalida);
                reiniciar();
            }
        }

        private void reiniciar()
        {
            this.xInic = -130;
            this.yInic = randSalida.Next(rangoSalida.X, rangoSalida.Y);
            int intervalo = randVelocidad.Next(1, 20);
            this.incremento = 1;
            this.timer1.Interval = intervalo;
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if (estado == Estado_ET.EnCurso)
            {
                // flecha
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                var flecha = new Point[7];
                flecha[0] = new Point(xInic, yInic);
                flecha[1] = new Point(xInic + 2 * (anchoEstimulo / 3), yInic);
                flecha[2] = new Point(xInic + 2 * (anchoEstimulo / 3), yInic - (altoEstimulo / 4));
                flecha[3] = new Point(xInic + anchoEstimulo, yInic + (altoEstimulo / 4));
                flecha[4] = new Point(xInic + 2 * (anchoEstimulo / 3), yInic + 3 * (altoEstimulo / 4));
                flecha[5] = new Point(xInic + 2 * (anchoEstimulo / 3), yInic + (altoEstimulo / 2));
                flecha[6] = new Point(xInic, yInic + (altoEstimulo / 2));
                e.Graphics.FillPolygon(estimuloBrush, flecha);
                // zona opaca
                e.Graphics.FillRectangle(zonaBrush, ladoDerecho - zonaOpaca, 0, zonaOpaca, Screen.PrimaryScreen.Bounds.Width);
                // area correcta (no se dibuja)
                Brush lineaBrush = new SolidBrush(Color.White);
                e.Graphics.DrawLine(new Pen(lineaBrush), ladoDerecho - areaCorrecta, 0, ladoDerecho - areaCorrecta, Screen.PrimaryScreen.Bounds.Width);
            }
        }


    }
}
