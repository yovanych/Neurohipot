using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfMemoriaDeFiguras : Form
    {

        public FormConfMemoriaDeFiguras(Config c)
        {
            this.confMemoriaFigurasUC1.Configuracion = c;
            this.confMemoriaFigurasUC1.ShowCancelButton = true;
            InitializeComponent();
        }

        #region Eventos
        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bPredeterminados_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}