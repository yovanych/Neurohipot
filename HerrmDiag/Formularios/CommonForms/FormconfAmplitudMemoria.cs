using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormconfAmplitudMemoria : Form
    {
        public FormconfAmplitudMemoria(Config c)
        {
            this.confAmplitudMemoriaUC1.Configuracion = c;
            this.confAmplitudMemoriaUC1.ShowCancelButton = true;
            InitializeComponent();
        }

        private void confAmplitudMemoriaUC1_AfterAcept(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void confAmplitudMemoriaUC1_AfterCancel(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
