using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DALayer;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class AddUser : Form
    {
        private readonly Aplicador ap;
        private readonly ListView listViewUser;
        public AddUser(Aplicador ap, ListView list)
        {
            InitializeComponent();
            this.listViewUser = list;
            this.ap = ap;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonAdicionarUs_Click(object sender, EventArgs e)
        {
            string login = this.textBoxNombreAdd.Text;
            string pass1 = this.textBoxPass1Add.Text;
            string pass2 = this.textBoxPass2Add.Text;
            if ( PassEmpty(pass1, pass2) )
            {
                var c = new Resp( Resources.MSG_PaswordMandatory );
                c.ShowDialog( this );
                return;
            }
            if (!PassEquals(pass1, pass2))
            {
                var c = new Resp( Resources.MSG_CheckBothPassWD );
                c.ShowDialog(this);
                return;
            }
            if (!aceptLogin(login))
            {
                var c = new Resp(Resources.MSG_Usuario_LoginNotAcepted);
                c.ShowDialog(this);
                return;
            }

            var cat = (this.radioButtonAp.Checked) ? Categoria_Usuario.Aplicador : Categoria_Usuario.Administrador;
            try
            {
                if (ap.agragar_Usuario(login, pass1, cat))
                {
                    var c = new Resp(Resources.MSG_Usuario_AddOK);
                    c.ShowDialog(this);
                    this.textBoxNombreAdd.Text = "";
                    this.textBoxPass1Add.Text = "";
                    this.textBoxPass2Add.Text = "";
                    Cargar_Usuarios();
                }
                else
                {
                    var c = new Resp(Resources.MSG_Usuario_LoginNotAvailable);
                    c.ShowDialog(this);
                }
            }
            catch (Exception)
            {
                var c = new Resp(Resources.MSG_DB_AccessError);
                c.ShowDialog(this);
            }
        }
        private void Info_TextChanged( object sender, EventArgs e )
        {
            this.buttonAdd.Enabled = aceptLogin( this.textBoxNombreAdd.Text ) && 
                !PassEmpty(textBoxPass1Add.Text, textBoxPass2Add.Text) &&
                PassEquals(textBoxPass1Add.Text, textBoxPass2Add.Text);
        }
        
        #region Metodos Privados
        private static bool PassEquals(string pass1, string pass2)
        {
            return pass1 == pass2;
        }
        private static bool PassEmpty(string pass1, string pass2)
        {
            return string.IsNullOrEmpty( pass1 ) || string.IsNullOrEmpty( pass2 );
        }
        private static bool aceptLogin(IEnumerable<char> login)
        {
            return login.Count() >= 10 && login.Count() <= 12 && login.All(t => t != ' ');
        }
        private void Cargar_Usuarios()
        {
            this.listViewUser.Items.Clear();
            List<UsuarioStruct> l = ap.Listar_Usuarios();
            foreach (UsuarioStruct u in l)
            {
                var i = new ListViewItem(u.login, 0) {ToolTipText = u.category.ToString()};
                this.listViewUser.Items.Add(i);
            }
        }
        #endregion
        
    }
}