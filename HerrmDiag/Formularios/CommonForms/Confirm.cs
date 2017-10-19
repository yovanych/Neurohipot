using System;
using System.Drawing;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class Confirm : Form
    {
        private bool respuesta;

	    public bool Respuesta
	    {
		    get { return respuesta;}
		    set { respuesta = value;}
	    }

        public Confirm(string message)
        {
            InitializeComponent();
            respuesta = false;
            this.label.Text = message;
            this.Width = this.label.Width + 106;
            this.buttonNo.Location = new Point(this.label.Width - 92, 39);
            this.buttonSi.Location = new Point(this.label.Width - 11, 39);
        }

        public void mustrate(string mensaje, IWin32Window padre)
        {
            this.label.Text = mensaje;
            this.ShowDialog(padre);
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            this.respuesta = true;
            this.Dispose();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.respuesta = false;
            this.Dispose();
        }

    }
}