using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public class Ensayo_Pares_Visuales_Asociados : Ensayo_Prueba_Psicológica
    {
        #region Parametros
        #region Predeterminados
        internal static Color[] Pcolores = new[]{Color.Red, Color.Blue,
													             Color.Yellow, Color.Green,
													             Color.Violet, Color.Cyan};
        internal static int Ppresentacion = 6000;
        internal static int Pmuestra = 6000;
        internal static int Pdescanso = 1000;
        #endregion

        public Color[] Colores;
        #endregion

        #region Variables locales
        private readonly Test_Ejemplo_PVA[] ejemplos;
        private readonly Thread th_ej;
        private readonly Control control;
        private Test_Ejemplo_PVA actual_ej;
        private bool ejemplificando;
        private int ronda;
        public bool EnCurso;
        #endregion

        #region Constructores
        public Ensayo_Pares_Visuales_Asociados( Control c, Color[] colores, ImageSet listaIMG )
        {
            ejemplos = new Test_Ejemplo_PVA[3];
            cargar_imagenes( listaIMG );
            this.control = c;
            var ThSt_ej = new ThreadStart( St_ej );
            th_ej = new Thread( ThSt_ej );
            EnCurso = false;
            ejemplificando = false;
            ronda = -1;
            this.Colores = colores;
        }
        public Ensayo_Pares_Visuales_Asociados( Control c, ImageSet listaIMG )
            : this( c, Pcolores, listaIMG )
        { }
        #endregion

        private void cargar_imagenes( ImageSet listaPVA )
        {
            var ej1 = new[] { listaPVA[0], listaPVA[1], listaPVA[2] };
            ejemplos[0] = new Test_Ejemplo_PVA( ej1, new[] { 2, 0, 1 } );
            var ej2 = new[] { listaPVA[3], listaPVA[4], listaPVA[5] };
            ejemplos[1] = new Test_Ejemplo_PVA( ej2, new[] { 1, 0, 2 } );
            var ej3 = new[] { listaPVA[6], listaPVA[7], listaPVA[8] };
            ejemplos[2] = new Test_Ejemplo_PVA( ej3, new[] { 2, 1, 0 } );
        }
        
        #region Overrides of Ensayo_Prueba_Psicológica

        public override void Start()
        {
            Graphics g = control.CreateGraphics();
            g.Clear( Color.DimGray );
            if ( th_ej.ThreadState == ThreadState.Unstarted )
            {
                th_ej.Start();
            }
        }

        public override void Stop()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear( Color.DimGray );
            this.EnCurso = false;
            this.th_ej.Abort();
        }

        public override void click( int x, int y )
        {
            if ( !ejemplificando && this.EnCurso )
            {
                int fila = -1;
                int W = this.control.Width;
                int H = this.control.Height;

                if ( y >= H / 10 && y <= 3 * H / 10 )
                    fila = 0;
                else if ( y >= 4 / 10 && y <= 6 * H / 10 )
                    fila = 1;
                else if ( y >= 7 / 10 && y <= 9 * H / 10 )
                    fila = 2;

                bool dentro = (fila != -1 && x >= 3 * W / 4 && x <= 15 * W / 16);

                if ( dentro )
                {
                    var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
                    Brush brush = new SolidBrush( Color.LightYellow );
                    Graphics g = control.CreateGraphics();
                    if ( actual_ej.diana( fila, this.ronda ) )
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

        #endregion

        #region Metodos privados
        private void St_ej()
        {
            this.EnCurso = true;
            ronda = -1;
            int W = this.control.Width;
            int H = this.control.Height;
            int a_f = W / 4;
            int a_c = 3 * W / 16;
            int b_f = H / 5;
            Graphics g = control.CreateGraphics();

            for ( int i = 0; i < 3; i++ )
            {
                actual_ej = ejemplos[i];

                ejemplificando = true;
                for ( int k = 0; k < 3; k++ )
                {
                    g.DrawImage( actual_ej.matriz[k], W / 8, 2 * H / 5, a_f, b_f );
                    g.FillRectangle( new SolidBrush( Colores[actual_ej.color[k]] ), 5 * W / 8, 2 * H / 5, W / 4, H / 5 );
                    Thread.Sleep( 6000 );
                    g.Clear( Color.DimGray );
                }

                ejemplificando = false;
                for ( int k = 0; k < 3; k++ )
                {
                    ronda++;
                    g.DrawImage( actual_ej.matriz[k], W / 8, 2 * H / 5, a_f, b_f );
                    g.FillRectangle( new SolidBrush( Colores[0] ), 3 * W / 4, H / 10, a_c, H / 5 );
                    g.FillRectangle( new SolidBrush( Colores[1] ), 3 * W / 4, 4 * H / 10, a_c, H / 5 );
                    g.FillRectangle( new SolidBrush( Colores[2] ), 3 * W / 4, 7 * H / 10, a_c, H / 5 );
                    Thread.Sleep( 6000 );
                    g.Clear( Color.DimGray );
                }
                Thread.Sleep( 1000 );
                ronda = -1;
            }
            this.EnCurso = false;
        }
        #endregion
    }
}
