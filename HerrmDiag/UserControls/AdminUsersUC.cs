using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DALayer;
using HerrmDiag.Formularios.CommonForms;
using HerrmDiag.Properties;

namespace HerrmDiag.UserControls
{
    public partial class AdminUsersUC : UserControl
    {
        #region Campos
        private Aplicador ap;
        public Aplicador Aplicador
        {
            set
            {
                this.ap = value;
                Cargar_Usuarios();
            }
        }
        #endregion

        #region Propiedades
        public bool HasUserSelected
        {
            get { return this.listViewUser.SelectedItems.Count != 0; }
        }
        public string GetUserName 
        {
            get { return (HasUserSelected) ? this.listViewUser.SelectedItems[0].Text : string.Empty; }
        }
        public string GetUserRole
        {
            get { return (HasUserSelected) ? this.listViewUser.SelectedItems[0].ToolTipText : string.Empty; }
        }
        #endregion

        public AdminUsersUC()
        {
            InitializeComponent();
        }

        #region Eventos Publicos
        public delegate void SelectedChanged_Delegate(object sender, EventArgs e);
        public event SelectedChanged_Delegate SelectedUserChanged;
        private void listViewUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageSelect();
            if (SelectedUserChanged != null)
                SelectedUserChanged(sender, e);
        }
        #endregion

        #region Eventos

        #region Vista
        private void iconosGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewUser.View = System.Windows.Forms.View.LargeIcon;
        }
        private void iconosPequeñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewUser.View = System.Windows.Forms.View.SmallIcon;
        }
        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewUser.View = System.Windows.Forms.View.List;
        }
        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewUser.View = System.Windows.Forms.View.Tile;
        }
        #endregion

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewUser.SelectedItems.Count == 0) return;
            string user = this.listViewUser.SelectedItems[0].Text;
            if (user.Equals(string.Empty))
            {
                var r = new Resp(Resources.MSG_Usuario_SelectAnUser);
                r.ShowDialog(this);
                return;
            }
            if (ap.User.Nombre == user)
            {
                var r = new Resp(Resources.MSG_Usuario_CantDelete);
                r.ShowDialog(this);
                return;
            }
            var c = new Confirm(Resources.MSG_Usuario_AskForDelete);
            c.ShowDialog(this);

            if (c.Respuesta)
            {
                if (!ap.Eliminar_Usuario(user))
                {
                    var r = new Resp(Resources.MSG_Usuario_CantDelete);
                    r.ShowDialog(this);
                    return;
                }
                Cargar_Usuarios();
            }
            ManageSelect();
        }
        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ad = new AddUser(this.ap, this.listViewUser);
            ad.ShowDialog(this);
            ManageSelect();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewUser.SelectedItems.Count > 0)
            {
                string user = this.listViewUser.SelectedItems[0].Text;
                var cp = new CambiarPass(this.ap, user);
                cp.ShowDialog(this);
            }
            ManageSelect();
        }
        private void cambiarCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listViewUser.SelectedItems.Count > 0)
            {
                string user = this.listViewUser.SelectedItems[0].Text;
                var cc = new CambiarCategoria(this.ap, user);
                cc.ShowDialog(this);
            }
            Cargar_Usuarios();
            ManageSelect();
        }

        #endregion

        #region Metodos Privados
        private bool aceptLogin(IEnumerable<char> login)
        {
            return login.All(t => t != ' ');
        }

        private void Cargar_Usuarios()
        {
            this.listViewUser.Items.Clear();
            List<UsuarioStruct> l = ap.Listar_Usuarios();
            foreach (var i in l.Select(u => new ListViewItem(u.login, 0) { ToolTipText = u.category.ToString() }))
                this.listViewUser.Items.Add(i);
        }
        private void ManageSelect()
        {
            this.tsddbEditar.Enabled = 
                this.contextMenuStripUserListView.Enabled = HasUserSelected;
            if (!HasUserSelected) return;
            bool notThisUser = (this.listViewUser.SelectedItems[0].Text != this.ap.User.Nombre);
            this.tsmEliminar.Enabled = notThisUser;
            this.cambiarCategoríaToolStripMenuItem.Enabled = notThisUser;
            this.eliminarToolStripMenuItem.Enabled = notThisUser;
            this.cambiarContraseñaToolStripMenuItem.Enabled = true;
        }
        #endregion
    }
}
