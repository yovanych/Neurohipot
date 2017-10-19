using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public enum Opciones { Buscar, Agregar, Editar }

    public partial class EditPaciente : Form
    {
        private readonly Opciones op;
        private readonly Aplicador ap;
        private readonly ListView listViewPacientes;        

        #region Constructores
        public EditPaciente(Aplicador ap, Opciones op, ListView l)
        {
            this.ap = ap;
            this.op = op;
            this.listViewPacientes = l;
            InitializeComponent();
            this.buttonAction.Text = op.ToString();
            this.cbLugar.Enabled = op != Opciones.Buscar;
            loadCombosAplicacion();
            switch (op)
            {
                case Opciones.Agregar:
                    this.Text = Resources.TITLE_AddPatient;
                    break;
                case Opciones.Editar:
                    {
                        string codigo = this.listViewPacientes.SelectedItems[0].SubItems[1].Text;
                        Paciente ale = ap.Obtener_Paciente(codigo);
                        this.Text = string.Format("{0} [{1}]", Resources.TITLE_EditPatient, ale.Codigo);                

                        this.textBoxNombre.Text = ale.Nombre;
                        this.textBoxApellido1.Text = ale.Apellido1;
                        this.textBoxApellido2.Text = ale.Apellido2;
                        this.textBoxCodigo.Text = ale.Codigo;
                        this.textBoxCodigo.ReadOnly = true;
                        this.domainUpDownSexo.Text = ale.Sexo.ToString();
                        this.dtpFechaNacimiento.Value = ale.Fecha_Nacimiento;
                        this.textBoxDireccion.Text = ale.Direccion;
                        this.textBoxNivel.Text = ale.Escolaridad;
                    }
                    break;
                default:
                    this.linkLabel1.Visible = true;
                    this.Text = Resources.ComboValue_ASS_Colores;
                    this.textBoxCodigo.Enabled = true;
                    break;
            }
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        #endregion

        #region Eventos
        private void buttonAction_Click(object sender, EventArgs e)
        {
            string nombre = this.textBoxNombre.Text;
            string apellido1 = this.textBoxApellido1.Text;
            string apellido2 = this.textBoxApellido2.Text;
            string codigo = this.textBoxCodigo.Text;
            string direccion = this.textBoxDireccion.Text;
            DateTime f = this.dtpFechaNacimiento.Value;
            Sexo s = (this.domainUpDownSexo.Text == @"Masculino") ? Sexo.Masculino : Sexo.Femenino;
            string n = textBoxNivel.Text;
            string aplicador = this.ap.User.Nombre;
            string lugar = this.cbLugar.Text;

            switch (this.op)
            {
                case Opciones.Buscar:

                    #region Buscar
                    this.listViewPacientes.Items.Clear();
                    var criterios = new List<Busqueda>();
                    if (this.checkBoxNombre.Checked)
                    {
                        var b = new Busqueda {campo = Criterios_Busqueda.nombre, valor = nombre};
                        criterios.Add(b);
                    }
                    if (this.checkBoxApellido1.Checked)
                    {
                        var b = new Busqueda {campo = Criterios_Busqueda.apellido1, valor = apellido1};
                        criterios.Add(b);
                    }
                    if (this.checkBoxApellido2.Checked)
                    {
                        var b = new Busqueda {campo = Criterios_Busqueda.apellido2, valor = apellido2};
                        criterios.Add(b);
                    }
                    if (this.checkBoxCodigo.Checked)
                    {
                        var b = new Busqueda {campo = Criterios_Busqueda.codigo, valor = codigo};
                        criterios.Add(b);
                    }
                    if (this.checkBoxSexo.Checked)
                    {
                        var b = new Busqueda
                                    {
                                        campo = Criterios_Busqueda.sexo,
                                        valor = (this.domainUpDownSexo.Text == @"Masculino") ? "M" : "F"
                                    };
                        criterios.Add(b);
                    }
                    List<Paciente> pacientes = ap.buscar_Paciente(criterios);
                    if (pacientes != null)
                    {
                        foreach (Paciente p in pacientes)
                        {
                            AddItemToListView(p);
                        }
                    }
                    var resp = new Resp(Resources.MSG_SearchFinished);
                    resp.ShowDialog(this);
                    this.Dispose();
                    #endregion

                    break;
                case Opciones.Agregar:
                    
                    #region Agregar
                    try
                    {
                        var new_pac = new Paciente();
                        if (new_pac.Existe_Paciente(codigo))
                        {
                            var r = new Resp(Resources.MSG_Paciente_CodeNotAvailable);
                            r.ShowDialog(this);
                            return;
                        }
                        //if (!FunctionLibrary.InRange(
                        //    FunctionLibrary.GetAge(f), 
                        //    FunctionLibrary.AgeFirstLevel, 
                        //    FunctionLibrary.AgeMaxSecondLevel))
                        //{
                        //    var r = new Resp(Resources.MSG_Edad_NotInRange);
                        //    r.ShowDialog(this);
                        //    return;
                        //}
                        if (!ap.insertarPaciente(codigo, nombre, apellido1, apellido2, direccion, f, s, n, aplicador, lugar))
                        {
                            this.ap.Configuracion.recuperar(this.ap.Lista_CodigoPacientes());
                            codigo = this.ap.Configuracion.siguiente_codigo();
                            MessageBox.Show(this, Resources.MSG_LostConfig + codigo);
                            this.ap.insertarPaciente( codigo, nombre, apellido1, apellido2, direccion, f, s, n, aplicador, lugar );
                        }
                        var p = new Paciente();
                        p.LoadByID(codigo);
                        AddItemToListView(p);
                        var rr = new Resp(Resources.MSG_Paciente_AddOK);
                        rr.ShowDialog(this);
                        LimpiarFormularioPaciente();
                    }
                    catch (Exception)
                    {
                        var c = new Resp(Resources.MSG_Paciente_InputDataError);
                        c.ShowDialog(this);
                    }
                    #endregion
                    
                    break;
                case Opciones.Editar:

                    #region Editar
                    try
                    {
                        ap.Modificar_Paciente( codigo, nombre, apellido1, apellido2, direccion, f, s, n, aplicador, lugar );
                        var p = new Paciente();
                        p.LoadByID(codigo);
                        this.listViewPacientes.Items.Clear();
                        AddItemToListView(p);
                        var r = new Resp(Resources.MSG_Paciente_EditOK);
                        r.ShowDialog(this);
                    }
                    catch (Exception)
                    {
                        var c = new Resp(Resources.MSG_Paciente_InputDataError);
                        c.ShowDialog(this);
                        return;
                    }
                    #endregion
                    
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.checkBoxNombre.Checked = this.checkBoxApellido1.Checked = 
            this.checkBoxApellido2.Checked = this.checkBoxCodigo.Checked = 
            this.checkBoxSexo.Checked = true;
        }
        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string cod = this.ap.Configuracion.siguiente_codigo();
            this.textBoxCodigo.Text = cod;
        }
        private void llNuevoLugar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var editLugar = new EditLugar();
            editLugar.ShowDialog(this);
            loadCombosAplicacion();
        }
        #endregion

        #region Metodos privados
        private void loadCombosAplicacion()
        {
            var l = new Lugar();
            List<Lugar> listaLugares = l.Lista_Lugares();
            this.cbLugar.DataSource = listaLugares;
            this.cbLugar.DisplayMember = "Lugar";
            this.cbLugar.ValueMember = "Id_Lugar";
            
        }
        private void LimpiarFormularioPaciente()
        {
            this.textBoxNombre.Text = this.textBoxApellido1.Text = this.textBoxApellido2.Text =
            this.textBoxCodigo.Text = this.textBoxDireccion.Text = "";
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
        #endregion
        
    }
    
}