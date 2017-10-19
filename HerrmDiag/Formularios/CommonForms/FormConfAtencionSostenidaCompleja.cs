using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfAtencionSostenidaCompleja : Form
    {
        public FormConfAtencionSostenidaCompleja(Config c)
        {
            InitializeComponent();
            this.confASCImagenesUF1.Configuracion = c;
            this.confASCImagenesUF1.ShowCancelButton = true;                       
        }

        #region Eventos
        private void bAceptar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

    }
}