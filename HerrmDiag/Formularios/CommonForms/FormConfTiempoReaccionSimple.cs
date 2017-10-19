using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios
{
    public partial class FormConfTiempoReaccionSimple : Form
    {
        public FormConfTiempoReaccionSimple(Config c)
        {
            InitializeComponent();
            this.confTRSimpleUC1.Configuracion = c;
            this.confTRSimpleUC1.ShowCancelButton = true;
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
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
        }
        #endregion

        
    }
   
}