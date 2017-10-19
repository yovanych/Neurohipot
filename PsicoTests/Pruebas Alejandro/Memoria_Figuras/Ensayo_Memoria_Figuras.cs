using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public class Ensayo_Memoria_Figuras : Ensayo_Prueba_Psicológica
    {
        private readonly Color fondo = Color.DimGray;
        private readonly Test_Ejemplo_MF[] ejemplos;
        private Test_Ejemplo_MF actual_ej;
        private readonly Thread th_ej;
        private readonly Control control;
        private bool ejemplificando;
        public bool EnCurso;

        public Ensayo_Memoria_Figuras( Control control, ImageSet listaEj )
        {

            ejemplos = new Test_Ejemplo_MF[3];
            cargar_imagenes( listaEj );
            this.control = control;
            var ThSt_ej = new ThreadStart( St_ej );
            th_ej = new Thread( ThSt_ej );
            EnCurso = false;
            ejemplificando = false;
        }

        private void cargar_imagenes( ImageSet listaEj )
        {
            var ej1 = new[] { listaEj[0], listaEj[1], listaEj[2] };
            ejemplos[0] = new Test_Ejemplo_MF( ej1, 1 );
            var ej2 = new[] { listaEj[3], listaEj[4], listaEj[5] };
            ejemplos[1] = new Test_Ejemplo_MF( ej2, 0 );
            var ej3 = new[] { listaEj[6], listaEj[7], listaEj[8] };
            ejemplos[2] = new Test_Ejemplo_MF( ej3, 2 );
        }

        public override void Start()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear( fondo );
            if ( th_ej.ThreadState == ThreadState.Unstarted )
            {
                th_ej.Start();
            }
        }

        public override void Stop()
        {
            this.EnCurso = false;
            this.th_ej.Abort();
        }

        private void St_ej()
        {
            this.EnCurso = true;
            int W = this.control.Width;
            int H = this.control.Height;
            int a = 2 * this.control.Width / 9;
            int b = 2 * this.control.Height / 9;
            Graphics g = control.CreateGraphics();
            g.Clear( fondo );

            for ( int i = 0; i < 3; i++ )
            {
                actual_ej = ejemplos[i];
                ejemplificando = true;
                //g.DrawString("(Entrenamiento) Oprima [Enter] para comenzar el examen", f, brush, 10, control.Height - 30);
                g.DrawImage( actual_ej.matriz[actual_ej.indice], 7 * W / 18, 7 * H / 18, a, b );


                Thread.Sleep( 5000 );
                g.FillRectangle( new SolidBrush( Color.DimGray ), 0, 0, control.Width, control.Height - 50 );

                ejemplificando = false;
                //g.DrawString("(Entrenamiento) Oprima [Enter] para comenzar el examen", f, brush, 10, control.Height - 30);
                g.DrawImage( actual_ej.matriz[0], W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual_ej.matriz[1], 7 * W / 18, 7 * H / 18, a, b );
                g.DrawImage( actual_ej.matriz[2], 13 * W / 18, 7 * H / 18, a, b );

                Thread.Sleep( 10000 );
                g.FillRectangle( new SolidBrush( Color.DimGray ), 0, 0, control.Width, control.Height - 50 );
                Thread.Sleep( 5000 );
            }
            this.EnCurso = false;

            var font = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
            Brush brush1 = new SolidBrush( Color.LightYellow );
            g.DrawString( "Ha terminado el entrenamiento, presione [Esc]", font, brush1, 40, 30 );
        }

        public override void click( int x, int y )
        {
            if ( !ejemplificando )
            {
                int columna;
                int fila = -1;
                int W = this.control.Width;
                int H = this.control.Height;

                if ( x <= W / 3 )
                    columna = 0;
                else if ( x > W / 3 && x <= 2 * W / 3 )
                    columna = 1;
                else
                    columna = 2;

                if ( y > H / 3 && y <= 2 * H / 3 )
                    fila = 1;

                bool dentro = (fila == 1 && y >= fila * H / 3 + H / 18 && y <= fila * H / 3 + 5 * H / 18 && x >= columna * W / 3 + W / 18 && x <= columna * W / 3 + 5 * W / 18);

                if ( dentro )
                {
                    var f = new Font( FontFamily.GenericSansSerif, 25, FontStyle.Bold );
                    Brush brush = new SolidBrush( Color.LightYellow );
                    Graphics g = control.CreateGraphics();
                    if ( actual_ej.diana( columna ) )
                    {
                        g.FillRectangle( new SolidBrush( fondo ), 40, 30, W / 4, H / 5 );
                        g.DrawString( "Correcto", f, brush, 40, 30 );
                    }
                    else
                    {
                        g.FillRectangle( new SolidBrush( fondo ), 40, 30, W / 4, H / 5 );
                        g.DrawString( "Incorrecto", f, brush, 40, 30 );
                    }
                }
            }
        }


    }
}
