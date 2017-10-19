using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public partial class PVA_Form : FormWithResultNUtils
    {
        #region Campos

        public IPrueba p;
        private bool EnCurso;

        #endregion

        public PVA_Form( PVA_Type type, string codigoPaciente, int presentacion, int muestra, int descanso, Color[] colores, ImageSet imagenes)
        {
            InitializeComponent();
            p = type == PVA_Type.PVA_1 ?
                (IPrueba) new Pares_Visuales_Asociados(this.panel, codigoPaciente, presentacion, muestra, descanso, colores, imagenes)
                : new Pares_Visuales_Asociados_2(this.panel, codigoPaciente, muestra, descanso, colores, imagenes);
        }

        private void PVA_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (!EnCurso)
                {
                    EnCurso = true;
                    p.Start();
                    return;
                }
            }
            if (e.KeyValue == 27)
            {
                EnCurso = false;
                p.Stop();
                if (p is Prueba_Psicológica)
                    Resultado = ((Prueba_Psicológica)p).Resultado;
                this.Dispose();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.panel.CreateGraphics();
            var f = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            Brush brush = new SolidBrush(Color.LightYellow);
            g.DrawString("Oprima [Enter] para comenzar", f, brush, 10, this.panel.Height - 30);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.p.click(e.X, e.Y);
        }
    }
}
