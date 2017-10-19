using System;
using System.Windows.Forms;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class CambiarPass : Form
    {
        private readonly string user;
        private readonly Aplicador ap;

        public CambiarPass(Aplicador ap)
        {
            InitializeComponent();
            this.ap = ap;
            this.user = ap.User.Nombre;
            this.Text += string.Format( " [{0}]", user );
        }
        public CambiarPass(Aplicador ap, string user)
        {
            InitializeComponent();
            this.ap = ap;
            this.user = user;
            this.Text += string.Format(" [{0}]", user);
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {            
            try
            {
                ap.cambiar_UserPass(user, this.textBoxPassAnt.Text, this.textBoxNewPass.Text, this.textBoxRepPass.Text);                
            }
            catch (Exception ex)
            {
                this.textBoxPassAnt.Text = "";
                this.textBoxNewPass.Text = "";
                this.textBoxRepPass.Text = "";
                var r = new Resp(ex.Message);
                r.ShowDialog(this);
                return;
            }
            var ok = new Resp(Resources.MSG_ChangePasswOK);
            ok.ShowDialog(this);
            this.Dispose();            
        }

        private void textBoxRepPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                buttonCambiar_Click(sender, e);
        }
    }
}