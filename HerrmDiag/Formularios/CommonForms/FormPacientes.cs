using System;
using System.Windows.Forms;


namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormPacientes : Form
    {
        public FormPacientes(Aplicador ap, ComboBox comboBoxPaciente)
        {
            InitializeComponent();
            this.adminPacientesUC1.Aplicador = ap;
            this.adminPacientesUC1.ComboBoxPaciente = comboBoxPaciente;
        }

        #region Eventos
        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.statusLabel.Text = string.Format("{0} - {1}", adminPacientesUC1.GetPatientCade,
                adminPacientesUC1.GetPatientName);
        }
        #endregion
    }

    
}