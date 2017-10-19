using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfAtencionSostenidaSimple : Form
    {
        public FormConfAtencionSostenidaSimple(Config c)
        {
            InitializeComponent();
            this.confASSImagenesUC1.Configuracion = c;
            this.confASSImagenesUC1.ShowCancelButton = true;
        }

        #region Eventos
        

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
            
        }
        #endregion       

    }
}