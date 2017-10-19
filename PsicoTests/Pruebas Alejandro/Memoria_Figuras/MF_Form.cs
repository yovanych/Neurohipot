using System.Drawing;
using System.Windows.Forms;
using DALayer;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public partial class MF_Form : FormWithResultNUtils
    {
        #region Campos

        public IPrueba p;
        private bool EnCurso;

        #endregion

        public MF_Form(ImageSet imagenes, int presentacion, int muestra, int descanso, string codigoPaciente)
        {
            InitializeComponent();
            p = new Memoria_Figuras(this.panel, presentacion, muestra, descanso, imagenes, codigoPaciente);
        }

        private void MF_Form_KeyDown( object sender, KeyEventArgs e )
        {
            if ( e.KeyValue == 13 )
            {
                if ( !EnCurso )
                {
                    EnCurso = true;
                    p.Start();
                    return;
                }
            }
            if ( e.KeyValue == 27 )
            {
                EnCurso = false;
                p.Stop();
                if ( p is Prueba_Psicológica )
                    Resultado = ((Prueba_Psicológica)p).Resultado;
                this.Dispose();
            }
        }

        private void panel_Paint( object sender, PaintEventArgs e )
        {
            Graphics g = this.panel.CreateGraphics();
            var f = new Font( FontFamily.GenericSansSerif, 15, FontStyle.Bold );
            Brush brush = new SolidBrush( Color.LightYellow );
            g.DrawString( "Oprima [Enter] para comenzar", f, brush, 10, this.panel.Height - 30 );
        }

        private void panel_MouseDown( object sender, MouseEventArgs e )
        {
            this.p.click( e.X, e.Y );
        }

    }
}
