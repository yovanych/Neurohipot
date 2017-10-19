using System;
using System.Windows.Forms;


namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios(Aplicador ap)
        {
            InitializeComponent();
            this.adminUsersUC1.Aplicador = ap;
        }

        #region Eventos
        
        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.StatusLabel.Text = string.Format("{0} - {1}",
                                    this.adminUsersUC1.GetUserName,
                                    this.adminUsersUC1.GetUserRole);
        }
        #endregion
    }
}