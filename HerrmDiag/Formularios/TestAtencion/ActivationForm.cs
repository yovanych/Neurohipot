using System;
using System.IO;
using System.Windows.Forms;
using HerrmDiag.Activation;
using HerrmDiag.Properties;

namespace HerrmDiag.TestAtencion
{
    public partial class ActivationForm : Form
    {
        public ActivationForm(Config c)
        {
            InitializeComponent();
            this.tbGeneracion.Text  = c.GenerationSettings.GenerationCode;
        }

        private void tbActivación_TextChanged( object sender, EventArgs e )
        {
            this.button.Enabled = ValidCode();
        }

        private bool ValidCode()
        {
            return this.tbActivacion.Text.Trim().Length > 0;
        }

        private void button_Click( object sender, EventArgs e )
        {
            var stream = new FileStream( this.tbActivacion.Text, FileMode.Open );
            var newStream = new FileStream( Resources.FILE_ActKey, FileMode.OpenOrCreate );
            stream.CopyTo( newStream );
            stream.Close();
            newStream.Close();
            this.Close();
        }

        private void buttonExaminar_Click( object sender, EventArgs e )
        {
            this.openFileDialog.ShowDialog( this );
            this.tbActivacion.Text = this.openFileDialog.FileName;
        }
    }
}
