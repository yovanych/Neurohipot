using System;
using System.Windows.Forms;
using System.Drawing;
using DALayer;


namespace PsicoTests.Alejandro
{
    public enum Estado_ET { Nulo, EnCurso, Terminado }
    public enum Reaccion_ET { Anticipado, Dentro, Correcto, Retardado, Omitido }

    public class Estimacion_Tiempo : Prueba_Psicológica
    {
        #region Parametros
        #region Predeterminados
        public static int PmaxEstimulos = 15;
        public static int PintervaloSalida = 1000;
        public static int PanchoEstimulo = 150;
        public static int PaltoEstimulo = 60;
        public static int PzonaOpaca = 400;
        public static int PareaCorrecta = 100;
        public static Color Pestimulo = Color.White;
        public static Color PcolorZonaOpaca = Color.Red;
        public static int PteclaReaccion = 32;
        #endregion
        private readonly int maxEstimulos;
        private readonly int intervaloSalida;
        private readonly int anchoEstimulo;
        private readonly int altoEstimulo;
        private readonly int zonaOpaca;
        private readonly int areaCorrecta;
        private Color estimulo;
        private Color colorZonaOpaca;
        private readonly int teclaReaccion;
        #endregion

        #region Variables de resultado
        public int Anticipados { get; private set; }
        public int Dentro { get; private set; }
        public int Correctos { get; private set; }
        public int Retardados { get; private set; }
        public int Omitidos { get; private set; }
        #endregion

        #region Variables de examen
        private int xInic, yInic;
        private readonly Brush estimuloBrush;
        private readonly Brush zonaBrush;
        private Point rangoSalida;
        private readonly int final;
        private readonly Random randSalida;
        private readonly Random randVelocidad;
        private int incremento;
        private readonly Timer timer1;
        private readonly MyPictureBox myPict;
        private readonly int ladoDerecho;
        private int contEst;
        private readonly string codigoPaciente;
        #endregion

        #region Variables Estado

        private Reaccion_ET reaccion_actual;
        public Estado_ET Estado { get; private set; }

        #endregion

        #region Constructores
        public Estimacion_Tiempo(Control c, string codigoPaciente, int maxEstimulos, int intervaloSalida,
                                    int anchoEstimulo, int altoEstimulo, int zonaOpaca, int areaCorrecta,
                                    Color estimulo, Color colorZonaOpaca, int teclaReaccion)
            : base(null)
        {
            this.codigoPaciente = codigoPaciente;
            this.maxEstimulos = maxEstimulos;
            this.intervaloSalida = intervaloSalida;
            this.anchoEstimulo = anchoEstimulo;
            this.altoEstimulo = altoEstimulo;
            this.zonaOpaca = zonaOpaca;
            this.areaCorrecta = areaCorrecta;
            this.estimulo = estimulo;
            this.colorZonaOpaca = colorZonaOpaca;
            this.teclaReaccion = teclaReaccion;
            this.contEst = 0;
            timer1 = new Timer();
            timer1.Tick += timer1_Tick;
            myPict = new MyPictureBox();

            randSalida = new Random(Environment.TickCount);
            randVelocidad = new Random(Environment.TickCount + 25);
            myPict = new MyPictureBox { Location = new Point(0, 0), Size = new Size(200, 200), Dock = DockStyle.Fill };
            myPict.Paint += pictureBox1_Paint;
            myPict.BackColor = Color.Black;

            c.Controls.Add(myPict);
            c.KeyDown += control_KeyDown;

            rangoSalida = new Point(40, Screen.PrimaryScreen.Bounds.Height - 40);
            final = Screen.PrimaryScreen.Bounds.Width + 30;

            estimuloBrush = new SolidBrush(estimulo);
            zonaBrush = new SolidBrush(colorZonaOpaca);
            ladoDerecho = (Screen.PrimaryScreen.Bounds.Width - zonaOpaca) / 2 + zonaOpaca;

            Estado = Estado_ET.Nulo;
            reaccion_actual = Reaccion_ET.Omitido;

            Anticipados = 0;
            Dentro = 0;
            Correctos = 0;
            Retardados = 0;
            Omitidos = 0;
        }
        #endregion

        #region Override
        public override void Start()
        {
            Anticipados = 0;
            Dentro = 0;
            Correctos = 0;
            Retardados = 0;
            Omitidos = 0;
            Estado = Estado_ET.EnCurso;
            reaccion_actual = Reaccion_ET.Omitido;
            reiniciar();
            timer1.Start();
        }
        public override void Stop()
        {
            Estado = Estado_ET.Terminado;
            reaccion_actual = Reaccion_ET.Omitido;
            this.myPict.Refresh();
            this.Resultado = new Resultado_ET(this.codigoPaciente,
                this.Correctos,
                this.Dentro,
                this.Anticipados,
                this.Omitidos,
                this.Retardados,
                DateTime.Now,
                true);
            timer1.Stop();
        }
        public override void click(int x, int y)
        {
            if (reaccion_actual == Reaccion_ET.Omitido)
            {
                if (x >= ladoDerecho - areaCorrecta && x <= ladoDerecho)
                    this.reaccion_actual = Reaccion_ET.Correcto;
                else if (x >= ladoDerecho - zonaOpaca && x <= ladoDerecho - areaCorrecta)
                    this.reaccion_actual = Reaccion_ET.Dentro;
                else if (x < ladoDerecho - zonaOpaca)
                    this.reaccion_actual = Reaccion_ET.Anticipado;
                else //if (x > ladoDerecho)
                    this.reaccion_actual = Reaccion_ET.Retardado;
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.myPict.Refresh();
            xInic += incremento;
            if (xInic >= final)
            {
                System.Threading.Thread.Sleep(intervaloSalida);
                reiniciar();
            }
        }

        private void reiniciar()
        {
            contEst++;
            this.xInic = -130;
            this.yInic = randSalida.Next(rangoSalida.X, rangoSalida.Y);
            int intervalo = randVelocidad.Next(1, 45);
            this.incremento = calculaIncremento(intervalo);
            this.timer1.Interval = intervalo;
            switch (this.reaccion_actual)
            {
                case Reaccion_ET.Anticipado:
                    this.Anticipados++;
                    break;
                case Reaccion_ET.Dentro:
                    this.Dentro++;
                    break;
                case Reaccion_ET.Correcto:
                    this.Correctos++;
                    break;
                case Reaccion_ET.Retardado:
                    this.Retardados++;
                    break;
                default: // case Reaccion_ET.Omitido:
                    this.Omitidos++;
                    break;
            }
            if (contEst > maxEstimulos)
            {
                Stop();
            }
            this.reaccion_actual = Reaccion_ET.Omitido;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Estado == Estado_ET.EnCurso)
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
                //e.Graphics.DrawLine(new Pen(estimuloBrush), ladoDerecho - areaCorrecta, 0, ladoDerecho - areaCorrecta, Screen.PrimaryScreen.Bounds.Width);            
            }
            else if (Estado == Estado_ET.Terminado)
            {
                var f = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular);
                Brush brush = new SolidBrush(Color.LightYellow);
                e.Graphics.DrawString("Ha concluido la prueba", f, brush, 40, 30);
            }
            else if (Estado == Estado_ET.Nulo)
            {
                var f = new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular);
                Brush brush = new SolidBrush(Color.LightYellow);
                e.Graphics.DrawString("Presione la tecla de reacción para comenzar la prueba", f, brush, 40, 30);
            }
        }

        private static int calculaIncremento(int intervalo)
        {
            return intervalo >= 1 && intervalo <= 45 ? 7 - (intervalo/11) : 3;
        }

        public void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == teclaReaccion)
            {
                if (Estado == Estado_ET.Nulo)
                    Start();
                else if (Estado == Estado_ET.EnCurso)
                {
                    int x = xInic + anchoEstimulo;
                    click(x, 4);
                }
            }
            if (e.KeyValue == 27)
            {
                if (Estado != Estado_ET.Terminado)
                    this.Resultado = new Resultado_ET(this.codigoPaciente,
                        this.Correctos,
                        this.Dentro,
                        this.Anticipados,
                        this.Omitidos,
                        this.Retardados,
                        DateTime.Now,
                        false);
                ((TimeEstimation)sender).Resultado = this.Resultado;
                ((TimeEstimation)sender).Dispose();
            }
        }
    }
    
}
