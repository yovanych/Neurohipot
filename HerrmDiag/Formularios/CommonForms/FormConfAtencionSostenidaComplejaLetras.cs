using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfAtencionSostenidaComplejaLetras : Form
    {
        public FormConfAtencionSostenidaComplejaLetras(Config c)
        {
            InitializeComponent();
            this.confASCLetrasUC1.Configuracion = c;
        }

        #region Eventos
        
        private void bAceptar_Click(object sender, EventArgs e)
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