using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public class Pares_Visuales_Asociados_2 : Prueba_Psicológica
    {
        #region Parametros
        #region Predeterminados
        internal static Color[] Pcolores = new[]{Color.Red, Color.Blue,
                                                                 Color.Yellow, Color.Green,
                                                                 Color.Violet, Color.Cyan};
        internal static int PExposicion = 10000;
        internal static int Pdescanso = 1000;
        #endregion

        private readonly int exposicion;
        private readonly int descanso;
        public Color[] Colores;
        #endregion

        #region Campos
        private readonly Test_PVA[] tests;
        private readonly Thread th;
        private readonly Control control;
        private Test_PVA actual;
        private bool ejemplificando;
        private int ronda;
        public bool EnCurso;
        private readonly string codigoPaciente;

        #endregion

        #region Costructores
        public Pares_Visuales_Asociados_2( Control c, string codigoPaciente, int exposicion, int descanso, Color[] colores, ImageSet listaIMG )
            : base( null )
        {
            this.codigoPaciente = codigoPaciente;
            this.exposicion = exposicion;
            this.descanso = descanso;
            this.Colores = colores;
            tests = new Test_PVA[3];
            cargar_imagenes( listaIMG );
            this.control = c;
            var ThSt = new ThreadStart( St );
            th = new Thread( ThSt );
            EnCurso = false;
            ejemplificando = false;
            ronda = -1;
        }
        public Pares_Visuales_Asociados_2( Control c, string codigoPaciente, ImageSet listaIMG )
            : this( c, codigoPaciente, PExposicion, Pdescanso, Pcolores, listaIMG )
        { }
        #endregion

        private void cargar_imagenes( ImageSet listaPVA )
        {
            var img = new Image[6];

            for ( int j = 0; j < 6; j++ )
            {
                img[j] = listaPVA[j];
            }
            tests[0] = new Test_PVA( img, new[] { 2, 4, 1, 5, 0, 3 }, Colores );
            tests[1] = new Test_PVA( img, new[] { 0, 1, 5, 3, 2, 4 }, Colores );
            tests[2] = new Test_PVA( img, new[] { 4, 5, 3, 2, 0, 1 }, Colores );
        }

        #region Overrides of Prueba_Psicológica

        public override void Start()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear( Color.DimGray );
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
                int A = 0;
                for ( int i = 0; i < tests.Length; i++ )
                    A+= tests[i].Aciertos;
                Resultado = new Resultado_PVA( PVA_Type.PVA_2, this.codigoPaciente, A, DateTime.Now, false );

            }
            this.EnCurso = false;
            this.th.Abort();
        }

        public override void click( int x, int y )
        {
            if ( !ejemplificando && this.EnCurso )
            {
                int columna = -1;
                int fila = -1;
                int W = this.control.Width;
                int H = this.control.Height;

                if ( x >= W / 2 && x <= 11 * W / 16 )
                    columna = 0;
                else if ( x >= 3 * W / 4 && x <= 15 * W / 16 )
                    columna = 1;

                if ( y >= H / 10 && y <= 3 * H / 10 )
                    fila = 0;
                else if ( y >= 4 / 10 && y <= 6 * H / 10 )
                    fila = 1;
                else if ( y >= 7 / 10 && y <= 9 * H / 10 )
                    fila = 2;

                bool dentro = (fila != -1 && columna != -1);

                if ( dentro )
                {
                    var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
                    Brush brush = new SolidBrush( Color.LightYellow );
                    Graphics g = control.CreateGraphics();
                    int indice = 2 * fila + columna;
                    if ( actual.diana( Colores[indice], this.ronda ) )
                    {
                        g.FillRectangle( new SolidBrush( Color.DimGray ), W / 8, 3 * H / 5 + 10, W / 4, H / 5 );
                        g.DrawString( "Correcto", f, brush, W / 8, 3 * H / 5 + 20 );
                    }
                    else
                    {
                        g.FillRectangle( new SolidBrush( Color.DimGray ), W / 8, 3 * H / 5 + 10, W / 4, H / 5 );
                        g.DrawString( "Incorrecto", f, brush, W / 8, 3 * H / 5 + 20 );
                    }
                    //this.ya = true;
                }
            }
        }

        #endregion

        #region Metodos privados
        private void St()
        {
            this.EnCurso = true;
            ronda = -1;
            int W = this.control.Width;
            int H = this.control.Height;
            int a_f = W/4;
            int a_c = 3*W/16;
            int b_f = H/5;
            Graphics g = control.CreateGraphics();
            g.Clear( Color.DimGray );
            ejemplificando = false;

            actual = tests[0];
            for ( int k = 0; k < 6; k++ )
            {
                if ( k != 0 )
                    Thread.Sleep( descanso );
                ronda++;
                //ya = false;
                g.DrawImage( actual.matriz[k], W/8, 2*H/5, a_f, b_f );
                g.FillRectangle( new SolidBrush( Colores[0] ), W/2, H/10, a_c, H/5 );
                g.FillRectangle( new SolidBrush( Colores[1] ), 3*W/4, H/10, a_c, H/5 );
                g.FillRectangle( new SolidBrush( Colores[2] ), W/2, 4*H/10, a_c, H/5 );
                g.FillRectangle( new SolidBrush( Colores[3] ), 3*W/4, 4*H/10, a_c, H/5 );
                g.FillRectangle( new SolidBrush( Colores[4] ), W/2, 7*H/10, a_c, H/5 );
                g.FillRectangle( new SolidBrush( Colores[5] ), 3*W/4, 7*H/10, a_c, H/5 );
                Thread.Sleep( exposicion );
                g.Clear( Color.DimGray );
            }
            ronda = -1;
            this.EnCurso = false;
            int A = 0;
            for ( int i = 0; i < tests.Length; i++ )
                A+= tests[i].Aciertos;
            Resultado = new Resultado_PVA( PVA_Type.PVA_2, this.codigoPaciente, A, DateTime.Now, true );
            var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
            Brush brush = new SolidBrush( Color.LightYellow );
            g.DrawString( "Ha terminado la prueba", f, brush, 40, 30 );
        }
        #endregion

    }
}
