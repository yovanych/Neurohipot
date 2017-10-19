using System;
using System.Windows.Forms;
using DALayer;

namespace HerrmDiag.TestAtencion
{
    public partial class Autent_User : Form
    {
        public Aplicador AP { get; private set; }
        private bool softwareActivated;

        public Autent_User()
        {
            InitializeComponent();
            this.AP = new Aplicador();
            this.textBox1.Focus();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if ( !this.softwareActivated ) return;

            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            if(AP.Abrir_Sesion(login, password))
            {
                var mf = new MainFormTA(AP);
                mf.Show();
                this.Hide();
                return;
            }
            this.label_err.Visible = true;
            this.textBox2.Text = "";
            this.textBox2.Focus();            
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.label_err.Visible = false;
            this.buttonOK.Enabled = this.textBox1.Text != "";
            if (e.KeyValue == 13)
                button1_Click(sender,  e);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void lbActivar_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            var af = new ActivationForm(this.AP.Configuracion);
            af.ShowDialog( this );
            FormStatus( this.AP.SoftwareActivado() );
        }

        private void FormStatus( bool activated )
        {
            this.buttonOK.Visible = activated;
            this.label3.Visible = this.lbActivar.Visible = !activated;
            this.softwareActivated = activated;

            //OperationsLog.LogOperation( string.Format( "Button Ok visible? {0}", buttonOK.Visible ? "yes" : "no" ) );
            //OperationsLog.LogOperation( string.Format( "Link Activar visible? {0}", lbActivar.Visible ? "yes" : "no" ) );
        }

        private void Autent_User_Load( object sender, EventArgs e )
        {
            bool activated = this.AP.SoftwareActivado();
            //OperationsLog.LogOperation( string.Format( "Load. Activated? {0}", activated ? "yes" : "no" ) );
            FormStatus( activated );
        }
    }
}