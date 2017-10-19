using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormConfRecuerdoLibre : Form
    {
        
        public FormConfRecuerdoLibre(Config c)
        {
            InitializeComponent();
            this.confRecuerdoLibreUC1.Configuracion = c;
            this.confRecuerdoLibreUC1.ShowCancelButton = true;
        }
        
        #region Eventos
        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
        }
        #endregion

        
    }
   
}