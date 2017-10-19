using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfParesVisualesAsociados : Form
    {

        public FormConfParesVisualesAsociados(Config c)
        {
            this.confParesVisualesAsociadosUC1.Configuracion = c;
            this.confParesVisualesAsociadosUC1.ShowCancelButton = true;
            InitializeComponent();           
        }

        #region Eventos
        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void bCancelar_Click( object sender, EventArgs e )
        {
            this.Dispose();
        }
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
        }
        #endregion

    }
}