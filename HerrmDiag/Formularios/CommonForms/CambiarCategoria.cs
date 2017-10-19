using System;
using System.Windows.Forms;
using DALayer;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class CambiarCategoria : Form
    {
        private readonly Aplicador ap;
        private readonly string user;
        public CambiarCategoria(Aplicador ap, string user)
        {
            InitializeComponent();
            this.ap = ap;
            this.user = user;
            Categoria_Usuario cat = ap.categoria(user);
            this.Text += string.Format( " [{0}]", user );
            switch (cat)
            {
                case Categoria_Usuario.Administrador:
                    this.radioButtonAdmin.Checked = true;
                    break;
                default:
                    this.radioButtonApp.Checked = true;
                    break;
            }
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Categoria_Usuario newCat = (this.radioButtonApp.Checked)? 
                Categoria_Usuario.Aplicador : Categoria_Usuario.Administrador;
            try
            {
                ap.cambiar_UserCat(this.user, newCat);
            }
            catch (Exception ex)
            {
                var no = new Resp(ex.Message);
                no.ShowDialog(this);
                return;
            }
            var ok = new Resp(Resources.MSG_ChangeCategoryOK);
            ok.ShowDialog(this);
            this.Dispose();
        }
    }
}