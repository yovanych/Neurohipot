using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImgSet;
using DALayer;

namespace PsicoTests.Alejandro
{
    /// <summary>
    /// Summary description for Memoria_Figuras.
    /// </summary>
    public class Memoria_Figuras : Prueba_Psicológica
    {
        #region Parametros
            #region Predeterminados
            public static int Ppresentacion = 15000;
            public static int Pmuestra = 30000;
            public static int Pdescanso = 5000;
            #endregion
        private readonly int presentacion;
        private readonly int muestra;
        private readonly int descanso;
        #endregion

        #region Campos
        private readonly Color fondo = Color.DimGray;
        private readonly Test_MF[] tests;
        private readonly Thread th;
        private readonly Control control;
        private readonly Random rand;
        private Test_MF actual;        
        private Estado_MF estado;
        public bool EnCurso;
        private readonly string codigoPaciente;
        #endregion

        #region Costructores
        public Memoria_Figuras(Control control, int presentacion, int muestra, int descanso, ImageSet listaMF, string codigo_paciente)
            : base(null)
        {
            rand = new Random(Environment.TickCount);
            tests = new Test_MF[3];
            cargar_imagenes(listaMF);
            this.control = control;
            var ThSt = new ThreadStart(St);
            th = new Thread(ThSt);
            EnCurso = false;
            estado = Estado_MF.Nulo;
            this.presentacion = presentacion;
            this.muestra = muestra;
            this.descanso = descanso;
            this.codigoPaciente = codigo_paciente;
        }
        public Memoria_Figuras(Control control, ImageSet listaMF, string codigo_paciente)
            : this( control, Ppresentacion, Pmuestra, Pdescanso, listaMF, codigo_paciente )
        { }
        #endregion

        #region Metodos privados
        private void cargar_imagenes(ImageSet listaMF)
        {
            var ind = new int[27];
            for (int i = 0; i < 27; i++)
                ind[i] = i;
            for (int i = 0; i < 27; i++)
            {
                int k = rand.Next(0, 26 - i);
                int temp = ind[k];
                ind[k] = ind[26 - i];
                ind[26 - i] = temp;
            }
            var img = new Image[9];
            for (int i = 0; i < 9; i++ )
                img[i] = listaMF[i];
            tests[0] = new Test_MF(img, new[] { 0, 1, 8 });

            img = new Image[9];
            for (int i = 0; i < 9; i++)
                img[i] = listaMF[i+9];
            tests[1] = new Test_MF(img, new[] { 2, 3, 7 });

            img = new Image[9];
            for (int i = 0; i < 9; i++)
                img[i] = listaMF[i + 18];            
            tests[2] = new Test_MF(img, new[] { 4, 5, 6 });            
        }
        
        private void St()
        {
            this.EnCurso = true;
            int W = this.control.Width;
            int H = this.control.Height;
            int a = 2 * this.control.Width / 9;
            int b = 2 * this.control.Height / 9;
            Graphics g = control.CreateGraphics();
            g.Clear(fondo);

            for (int i = 0; i < 3; i++)
            {
                if(i != 0)
                    Thread.Sleep(descanso);
                actual = tests[i];
                estado = Estado_MF.Tres;
                g.DrawImage(actual.matriz[tests[i].indices[0]], W / 18, 7 * H / 18, a, b);
                g.DrawImage(actual.matriz[tests[i].indices[1]], 7 * W / 18, 7 * H / 18, a, b);
                g.DrawImage(actual.matriz[tests[i].indices[2]], 13 * W / 18, 7 * H / 18, a, b);

                Thread.Sleep(presentacion);
                g.Clear(fondo);

                estado = Estado_MF.Nueve;
                g.DrawImage(actual.matriz[0], W / 18, H / 18, a, b);
                g.DrawImage(actual.matriz[1], 7 * W / 18, H / 18, a, b);
                g.DrawImage(actual.matriz[2], 13 * W / 18, H / 18, a, b);

                g.DrawImage(actual.matriz[3], W / 18, 7 * H / 18, a, b);
                g.DrawImage(actual.matriz[4], 7 * W / 18, 7 * H / 18, a, b);
                g.DrawImage(actual.matriz[5], 13 * W / 18, 7 * H / 18, a, b);

                g.DrawImage(actual.matriz[6], W / 18, 13 * H / 18, a, b);
                g.DrawImage(actual.matriz[7], 7 * W / 18, 13 * H / 18, a, b);
                g.DrawImage(actual.matriz[8], 13 * W / 18, 13 * H / 18, a, b);

                Thread.Sleep(muestra);
                g.Clear(fondo);
                actual.fin_test();
                this.estado = Estado_MF.Descanso;
            }
            this.estado = Estado_MF.Nulo;
            this.EnCurso = false;
            
            int A = 0, O = 0, E = 0;
            foreach ( Test_MF t in tests )
            {
                A += t.Aciertos;
                O += t.Omisiones;
                E += t.Errores;
            }
            Resultado = new Resultado_MF( this.codigoPaciente, E, O, A, DateTime.Now, true );
            var f = new Font(FontFamily.GenericSansSerif, 25, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.LightYellow);
            g.DrawString("Ha terminado la prueba", f, brush, 40, 30);
                        
        }
        #endregion

        #region Overrides of Prueba_Psicológica

        public override void Start()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear( fondo );
            if ( th.ThreadState == ThreadState.Unstarted )
            {
                Resultado = null;
                th.Start();
            }
        }

        public override void Stop()
        {
            if ( EnCurso )
            {
                int A = 0, O = 0, E = 0;
                foreach ( Test_MF t in tests )
                {
                    A += t.Aciertos;
                    O += t.Omisiones;
                    E += t.Errores;
                }
                this.Resultado = new Resultado_MF( this.codigoPaciente, E, O, A, DateTime.Now, true );
            }
            this.EnCurso = false;
            this.th.Abort();
            this.estado = Estado_MF.Nulo;
        }

        public override void click( int x, int y )
        {
            if ( estado == Estado_MF.Nueve && this.EnCurso )
            {
                int columna;
                int fila;
                int W = this.control.Width;
                int H = this.control.Height;

                if ( x <= W / 3 )
                    columna = 0;
                else if ( x > W / 3 && x <= 2 * W / 3 )
                    columna = 1;
                else
                    columna = 2;

                if ( y <= H / 3 )
                    fila = 0;
                else if ( y > H / 3 && y <= 2 * H / 3 )
                    fila = 1;
                else
                    fila = 2;

                bool dentro = (y >= fila * H / 3 + H / 18 && y <= fila * H / 3 + 5 * H / 18 && x >= columna * W / 3 + W / 18 && x <= columna * W / 3 + 5 * W / 18);

                if ( dentro )
                {
                    var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
                    Brush brush = new SolidBrush( Color.LightYellow );
                    Graphics g = control.CreateGraphics();
                    g.DrawString( actual.diana( fila, columna ) ? "Correcto" : "Incorrecto", f, brush,
                                  columna * W / 3 + W / 18, fila * H / 3 + 5 * H / 18 + 5 );
                }
            }

        }                       

        #endregion
    }
    
    public enum Estado_MF {Tres, Nueve, Descanso, Nulo}
}
