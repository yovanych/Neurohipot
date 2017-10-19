using System;
using System.Drawing;
using System.Windows.Forms;
using PsicoTests;

namespace HerrmDiag.Formularios
{
    public partial class FormConfTiempoReaccionCompleja : Form
    {

        public FormConfTiempoReaccionCompleja(Config c)
        {
            InitializeComponent();
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