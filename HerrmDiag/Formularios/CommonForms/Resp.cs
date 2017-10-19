using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class Resp : Form
    {        

        public Resp(string message)
        {
            InitializeComponent();
            this.label.Text = message;
            this.Width = this.label.Width + 91;
            this.buttonOK.Location = new Point(this.label.Width - 10, 40);
        }

        public Resp(string message, string caption):this(message)
        {
            this.Text = caption;
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public void mustrate(string mensaje, IWin32Window padre)
        {
            this.label.Text = mensaje;
            this.ShowDialog(padre);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }        
    }
}