using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfAtencionSostenidaSimpleLetras : Form
    {
        
        public FormConfAtencionSostenidaSimpleLetras(Config c)
        {
            InitializeComponent();
            this.confASSLetrasUC1.Configuracion = c;
            this.confASSLetrasUC1.ShowCancelButton = true;
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
        private void bPredeterminados_Click(object sender, EventArgs e)
        {
        }
        #endregion       
       
        
    }
}
