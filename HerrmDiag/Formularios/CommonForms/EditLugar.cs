using System;
using System.Windows.Forms;
using DALayer;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class EditLugar : Form
    {
        public EditLugar()
        {
            InitializeComponent();
        }

        private void buttonAction_Click( object sender, EventArgs e )
        {
            if ( !validate_controls() ) return;
            var lugar = new Lugar();
            lugar.Insert(this.tbNombre.Text, this.tbDescripcion.Text);
            this.Dispose();
        }

        private bool validate_controls()
        {
            if(this.tbNombre.Text.Trim() == string.Empty)
            {
                var r = new Resp("Debe especificar un nombre para el nuevo lugar");
                r.ShowDialog(this);
                return false;
            }
            return true;
        }
    }
}
