using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BusinessObjects;
using ImgSet;
using DALayer;

namespace PsicoTests.Alejandro
{
    public enum Estado_PVA { Par, Seis, Descanso, Nulo }
    
    public class Pares_Visuales_Asociados : Prueba_Psicológica
    {
        #region Parametros
        #region Predeterminados
        public static Color[] Pcolores = new[]{Color.Red, Color.Blue,
                                               Color.Yellow, Color.Green,
                                               Color.Violet, Color.Cyan};
        public static int Ppresentacion = 6000;
        public static int Pmuestra = 6000;
        public static int Pdescanso = 1000;
        #endregion

        private readonly int presentacion;
        private readonly int muestra;
        private readonly int descanso;
        public Color[] Colores;
        private readonly string codigoPaciente;
        #endregion

        private readonly Test_PVA[] tests;
        private readonly Thread th;
        private readonly Control control;
        private Test_PVA actual;
        private Estado_PVA estado;
        private int ronda;
        public bool EnCurso;

        #region Constructores
        public Pares_Visuales_Asociados( Control c, string codigoPaciente, int presentacion, int muestra, int descanso, Color[] colores, ImageSet listaPVA )
            : base( null )
        {
            tests = new Test_PVA[3];
            this.codigoPaciente = codigoPaciente;
            this.control = c;
            var ThSt = new ThreadStart( St );
            th = new Thread( ThSt );
            EnCurso = false;
            estado = Estado_PVA.Nulo;
            ronda = -1;
            this.presentacion = presentacion;
            this.muestra = muestra;
            this.descanso = descanso;
            this.Colores = colores;
            cargar_imagenes( listaPVA );
        }
        public Pares_Visuales_Asociados( Control c, ImageSet listaPVA, string codigoPaciente )
            : this( c, codigoPaciente, Ppresentacion, Pmuestra, Pdescanso, Pcolores, listaPVA )
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

        public override void Start()
        {
            Graphics g = control.CreateGraphics();
            g.Clear( Color.DimGray );
            if ( th.ThreadState == ThreadState.Unstarted )
            {
                Resultado = null;
                th.Start();
            }
        }

        public override void Stop()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear( Color.DimGray );
            if ( EnCurso )
            {
                int A = 0;
                for ( int i = 0; i < tests.Length; i++ )
                    A+= tests[i].Aciertos;
                Resultado = new Resultado_PVA( PVA_Type.PVA_1, this.codigoPaciente, A, DateTime.Now, false );
            }
            this.EnCurso = false;
            this.th.Abort();
            estado = Estado_PVA.Nulo;
        }

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

            for ( int i = 0; i < 3; i++ )
            {
                if ( i != 0 )
                    Thread.Sleep( descanso );
                actual = tests[i];
                estado = Estado_PVA.Par;
                for ( int k = 0; k < 6; k++ )
                {
                    g.DrawImage( actual.matriz[actual.orden_mostrar[k]], W/8, 2*H/5, a_f, b_f );
                    g.FillRectangle( new SolidBrush( actual.color[actual.orden_mostrar[k]] ), 5*W/8, 2*H/5, W/4, H/5 );
                    Thread.Sleep( presentacion );
                    g.Clear( Color.DimGray );
                }

                estado = Estado_PVA.Seis;
                for ( int k = 0; k < 6; k++ )
                {
                    ronda++;
                    g.DrawImage( actual.matriz[k], W/8, 2*H/5, a_f, b_f );
                    g.FillRectangle( new SolidBrush( Colores[0] ), W/2, H/10, a_c, H/5 );
                    g.FillRectangle( new SolidBrush( Colores[1] ), 3*W/4, H/10, a_c, H/5 );
                    g.FillRectangle( new SolidBrush( Colores[2] ), W/2, 4*H/10, a_c, H/5 );
                    g.FillRectangle( new SolidBrush( Colores[3] ), 3*W/4, 4*H/10, a_c, H/5 );
                    g.FillRectangle( new SolidBrush( Colores[4] ), W/2, 7*H/10, a_c, H/5 );
                    g.FillRectangle( new SolidBrush( Colores[5] ), 3*W/4, 7*H/10, a_c, H/5 );
                    Thread.Sleep( muestra );
                    g.Clear( Color.DimGray );
                }
                estado = Estado_PVA.Descanso;
                ronda = -1;
            }
            this.EnCurso = false;
            int A = 0;
            for ( int i = 0; i < tests.Length; i++ )
                A+= tests[i].Aciertos;
            Resultado = new Resultado_PVA(PVA_Type.PVA_1, this.codigoPaciente, A, DateTime.Now, true );
            var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
            Brush brush = new SolidBrush( Color.LightYellow );
            g.DrawString( "Ha terminado la prueba", f, brush, 40, 30 );

        }

        public override void click( int x, int y )
        {

            if ( estado == Estado_PVA.Seis && this.EnCurso )
            {
                int columna = -1;
                int fila = -1;
                bool dentro = false;
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

                dentro = (fila != -1 && columna != -1);

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
                }
            }
        }
    }
}
