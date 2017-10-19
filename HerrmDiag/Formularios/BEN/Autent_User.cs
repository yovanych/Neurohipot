using System;
using System.Windows.Forms;

namespace HerrmDiag.BEN
{
    public partial class Autent_User : Form
    {
        private readonly Aplicador ap;        

        public Autent_User(Aplicador ap)
        {
            InitializeComponent();
            this.textBox1.Focus();
            this.ap = ap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se manda una consulta de autenticacion
            string login = this.textBox1.Text;
            string password = this.textBox2.Text;
            if (ap.Abrir_Sesion(login, password))
            {
                this.Dispose();
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

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.label_err.Visible = false;
            if (e.KeyValue == 13)
                button1_Click(sender, e);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}