using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DALayer;
using HerrmDiag.Formularios.CommonForms;
using HerrmDiag.Properties;

namespace HerrmDiag.UserControls
{
    public partial class AdminPacientesUC : UserControl
    {
        #region campos
        private Aplicador ap;
        public Aplicador Aplicador 
        { 
            set 
            { 
                this.ap = value;
                if (ap.User.Categoria == Categoria_Usuario.Aplicador)
                {
                    this.eliminarToolStripMenuItem.Enabled = false;
                    this.editarToolStripMenuItem.Enabled = false;
                }
                loadAll(false);
            }
        }

        public ComboBox ComboBoxPaciente { get; set; }
        #endregion

        #region Propiedades
        public bool HasPatientSelected
        {
            get { return this.listViewPacientes.SelectedItems.Count != 0; }
        }
        public string GetPatientCade
        {
            get { return (HasPatientSelected) ? this.listViewPacientes.SelectedItems[0].SubItems[1].Text : string.Empty; }
        }
        public string GetPatientName
        {
            get { return (HasPatientSelected) ? this.listViewPacientes.SelectedItems[0].SubItems[2].Text : string.Empty; }
        }
        #endregion

        public AdminPacientesUC()
        {
            InitializeComponent();
        }

        #region Eventos publicos
        public delegate void SelectedChanged_Delegate(object sender, EventArgs e);
        public event SelectedChanged_Delegate SelectedPatientChanged;
        private void listViewPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MenuStrip.Enabled = this.HasPatientSelected;
            SetEnableStatus(this.HasPatientSelected, tsbEditar, tsbEliminar, tsbReporte);
            if (SelectedPatientChanged != null)
                SelectedPatientChanged(sender, e);
        }
        #endregion

        #region Eventos
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjecutarEliminarPac();
            Cargar_Pacientes();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editp = new EditPaciente(this.ap, Opciones.Editar, this.listViewPacientes);
            editp.ShowDialog(this);
        }

        private void tsbmTodos_Click(object sender, EventArgs e)
        {
            loadAll(true);
        }

        private void tsbmPacientes_Click(object sender, EventArgs e)
        {
            var editp = new EditPaciente(this.ap, Opciones.Buscar, this.listViewPacientes);
            editp.ShowDialog(this);
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            var editp = new EditPaciente(this.ap, Opciones.Agregar, this.listViewPacientes);
            editp.ShowDialog(this);
            Cargar_Pacientes();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            EjecutarEliminarPac();
            Cargar_Pacientes();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            var editp = new EditPaciente(this.ap, Opciones.Editar, this.listViewPacientes);
            editp.ShowDialog(this);
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            this.MenuStrip.Enabled = (this.listViewPacientes.SelectedItems.Count != 0);
        }
        #endregion

        #region Metodos privados
        private void loadAll(bool showMessage)
        {
            this.listViewPacientes.Items.Clear();
            List<Paciente> l = ap.buscar_Paciente(new List<Busqueda>());
            if (l != null)
                foreach (Paciente p in l)
                    AddItemToListView(p);
            if (!showMessage) return;
            var c = new Resp(Resources.MSG_SearchFinished);
            c.ShowDialog(this);
        }
        private void EjecutarEliminarPac()
        {
            var c = new Confirm(Resources.MSG_Paciente_ConfirmDelete);
            c.ShowDialog(this);
            if (this.listViewPacientes.SelectedItems.Count == 0 || !c.Respuesta) return;
            string cod = this.listViewPacientes.SelectedItems[0].SubItems[1].Text;
            ap.Eliminar_Paciente(cod);
            this.listViewPacientes.Items.Remove(listViewPacientes.SelectedItems[0]);
        }
        private void AddItemToListView(Paciente p)
        {
            var i = new ListViewItem();
            i.SubItems.Add(p.Codigo);
            i.SubItems.Add(p.Nombre);
            i.SubItems.Add(p.Apellido1);
            i.SubItems.Add(p.Apellido2);
            i.SubItems.Add(p.Edad.ToString());
            i.SubItems.Add(p.Sexo.ToString());
            i.SubItems.Add(p.Escolaridad);
            i.SubItems.Add(p.Direccion);
            this.listViewPacientes.Items.Add(i);
        }
        private static void SetEnableStatus(bool enabled, params ToolStripButton[] controls)
        {
            foreach (ToolStripButton control in controls)
                control.Enabled = enabled;
        }
        private void Cargar_Pacientes()
        {
            this.ComboBoxPaciente.Items.Clear();
            List<string> lista = ap.Lista_CodigoPacientes();
            foreach (string s in lista)
                this.ComboBoxPaciente.Items.Add(s);
            this.ComboBoxPaciente.Text = "";
        }
        #endregion

        private void tsbReporte_Click( object sender, EventArgs e )
        {
            if (this.listViewPacientes.SelectedItems.Count == 0) return;
            string cod = this.listViewPacientes.SelectedItems[0].SubItems[1].Text;
            Paciente p = ap.Seleccionar_Paciente(cod);

            Resultado_AS res = ap.ExtractResultFromPaciente();
            if ( res == null )
            {
                var resp = new Resp( "Este paciente no ha realizado ninguna prueba", "Paciente sin consultarse" );
                resp.ShowDialog( this );
                return;
            }
            var e2pdf = new FormExport2PDF(p, res);
            e2pdf.ShowDialog( this );
        }
    }
}
