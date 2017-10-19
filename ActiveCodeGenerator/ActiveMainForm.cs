using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActiveCodeGenerator.Properties;
using Encrypting;
using pica;

namespace ActiveCodeGenerator
{
    public partial class ActiveMainForm : Form
    {
        public ActiveMainForm()
        {
            InitializeComponent();
        }

        private void tbGeneracion_TextChanged( object sender, EventArgs e )
        {
            this.button.Enabled = this.TestButton.Enabled = ValidCode();
        }

        private bool ValidCode()
        {
            const string numPattern = @"(([0-9]+)\-)+([0-9]+)";
            var functionRegex = new Regex(string.Format( @"^{0}:[A-Z]\[{0}\]$", numPattern), RegexOptions.Singleline );
            return functionRegex.IsMatch( this.tbGeneracion.Text );
        }

        private void button_Click( object sender, EventArgs e )
        {
            this.folderBrowserDialog.ShowDialog( this );
            string path = this.folderBrowserDialog.SelectedPath;
            try
            {
                var c = new Code{ ActiveCode = Encryptor.Encrypt( this.tbGeneracion.Text ) };
                c.Save( string.Format( "{0}\\{1}", path, Resources.FILE_name ) );
            }
            catch ( Exception )
            {
                this.labelMensaje.Text = Resources.MSG_Problemas;
                return;
            }
            this.labelMensaje.Text = (string.IsNullOrEmpty( path )) ? "":Resources.MSG_OK;
        }

        private void TestButton_Click( object sender, EventArgs e )
        {
            string path = this.folderBrowserDialog.SelectedPath;
            string s = Code.Load( string.Format( "{0}\\{1}", path, Resources.FILE_name ) );
            string news = Encryptor.Decrypt( s );
            this.labelMensaje.Text = ( news.Equals( this.tbGeneracion.Text ) )
                                    ? Resources.MSG_TestOK
                                    : Resources.MSG_TestFAIL;
        }
    }
}
