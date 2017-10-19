using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public class Vista_Previa_MF : IVistaPrevia
    {

        private readonly Color fondo = Color.DimGray;
        private Test_MF[] tests;
        private readonly Control c;
        private readonly Thread th;
        private Test_MF actual;

        #region Estado
        private int ronda;
        private Estado_MF estado;
        #endregion

        public Vista_Previa_MF( Control c, ImageSet listaIMG )
        {
            this.c = c;
            cargar_imagenes( listaIMG );
            var ThSt = new ThreadStart( St );
            th = new Thread( ThSt );
            ronda = -1;
            estado = Estado_MF.Nulo;
            this.c.Paint += this.Paint;
        }

        private void cargar_imagenes( ImageSet listaMF )
        {
            tests = new Test_MF[3];
            var img = new Image[9];
            for ( int i = 0; i < 9; i++ )
                img[i] = listaMF[i];
            tests[0] = new Test_MF( img, new[] { 2, 5, 6 } );

            img = new Image[9];
            for ( int i = 0; i < 9; i++ )
                img[i] = listaMF[i + 9];
            tests[1] = new Test_MF( img, new[] { 1, 6, 7 } );

            img = new Image[9];
            for ( int i = 0; i < 9; i++ )
                img[i] = listaMF[i + 18];
            tests[2] = new Test_MF( img, new[] { 7, 0, 2 } );
        }

        public void Start()
        {
            Graphics g = this.c.CreateGraphics();
            g.Clear( fondo );
            if ( th.ThreadState == ThreadState.Unstarted )
            {
                th.Start();
            }
        }

        public void Stop()
        {
            this.th.Abort();
            Graphics g = this.c.CreateGraphics();
            g.Clear( fondo );
            ronda = -1;
            estado = Estado_MF.Nulo;
        }

        private void St()
        {
            ronda++;
            while ( true )
            {
                estado = Estado_MF.Tres;
                this.Paint( null, null );
                Thread.Sleep( 3000 );

                estado = Estado_MF.Nueve;
                this.Paint( null, null );

                Thread.Sleep( 3000 );
                estado = Estado_MF.Descanso;

                //actual.fin_test();
                this.Paint( null, null );
                Thread.Sleep( 300 );
                ronda++;
                if ( ronda >= 3 )
                    ronda = 0;
            }
        }

        public void Paint( object sender, PaintEventArgs e )
        {
            int W = this.c.Width;
            int H = this.c.Height;
            int a = 2 * this.c.Width / 9;
            int b = 2 * this.c.Height / 9;
            Graphics g = c.CreateGraphics();
            g.Clear( fondo );
            if ( estado == Estado_MF.Tres )
            {
                actual = tests[ronda];
                g.DrawImage( actual.matriz[tests[ronda].indices[0]], W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual.matriz[tests[ronda].indices[1]], 7 * W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual.matriz[tests[ronda].indices[2]], 13 * W / 18, 7 * H / 18, a, b );
                return;
            }
            if ( estado == Estado_MF.Nueve )
            {
                g.DrawImage( actual.matriz[0], W / 18, H / 18, a, b );
                g.DrawImage( actual.matriz[1], 7 * W / 18, H / 18, a, b );
                g.DrawImage( actual.matriz[2], 13 * W / 18, H / 18, a, b );

                g.DrawImage( actual.matriz[3], W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual.matriz[4], 7 * W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual.matriz[5], 13 * W / 18, 7 * H / 18, a, b );

                g.DrawImage( actual.matriz[6], W / 18, 13 * H / 18, a, b );
                g.DrawImage( actual.matriz[7], 7 * W / 18, 13 * H / 18, a, b );
                g.DrawImage( actual.matriz[8], 13 * W / 18, 13 * H / 18, a, b );
                return;
            }
        }
    }
}
