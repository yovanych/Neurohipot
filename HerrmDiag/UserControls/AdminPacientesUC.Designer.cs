namespace HerrmDiag.UserControls
{
    partial class AdminPacientesUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AdminPacientesUC ) );
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.tsbBuscar = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbmTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbmPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAgregar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbReporte = new System.Windows.Forms.ToolStripButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listViewPacientes = new System.Windows.Forms.ListView();
            this.columnIni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnApellido2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEdad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDireccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.tsbBuscar,
            this.toolStripSeparator4,
            this.tsbAgregar,
            this.tsbEliminar,
            this.tsbEditar,
            this.tsbReporte} );
            this.toolBar.Location = new System.Drawing.Point( 0, 0 );
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size( 653, 25 );
            this.toolBar.TabIndex = 48;
            this.toolBar.Text = "toolStrip1";
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.tsbmTodos,
            this.tsbmPacientes} );
            this.tsbBuscar.Image = ((System.Drawing.Image)(resources.GetObject( "tsbBuscar.Image" )));
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size( 74, 22 );
            this.tsbBuscar.Text = "Buscar";
            // 
            // tsbmTodos
            // 
            this.tsbmTodos.Name = "tsbmTodos";
            this.tsbmTodos.Size = new System.Drawing.Size( 133, 22 );
            this.tsbmTodos.Text = "Todos";
            this.tsbmTodos.Click += new System.EventHandler( this.tsbmTodos_Click );
            // 
            // tsbmPacientes
            // 
            this.tsbmPacientes.Name = "tsbmPacientes";
            this.tsbmPacientes.Size = new System.Drawing.Size( 133, 22 );
            this.tsbmPacientes.Text = "Pacientes...";
            this.tsbmPacientes.Click += new System.EventHandler( this.tsbmPacientes_Click );
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size( 6, 25 );
            // 
            // tsbAgregar
            // 
            this.tsbAgregar.Image = ((System.Drawing.Image)(resources.GetObject( "tsbAgregar.Image" )));
            this.tsbAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregar.Name = "tsbAgregar";
            this.tsbAgregar.Size = new System.Drawing.Size( 69, 22 );
            this.tsbAgregar.Text = "Agregar";
            this.tsbAgregar.Click += new System.EventHandler( this.tsbAgregar_Click );
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Enabled = false;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject( "tsbEliminar.Image" )));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size( 70, 22 );
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler( this.tsbEliminar_Click );
            // 
            // tsbEditar
            // 
            this.tsbEditar.Enabled = false;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject( "tsbEditar.Image" )));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size( 57, 22 );
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler( this.tsbEditar_Click );
            // 
            // tsbReporte
            // 
            this.tsbReporte.Enabled = false;
            this.tsbReporte.Image = ((System.Drawing.Image)(resources.GetObject( "tsbReporte.Image" )));
            this.tsbReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReporte.Name = "tsbReporte";
            this.tsbReporte.Size = new System.Drawing.Size( 68, 22 );
            this.tsbReporte.Text = "Reporte";
            this.tsbReporte.Click += new System.EventHandler( this.tsbReporte_Click );
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add( this.listViewPacientes );
            this.groupBox.Location = new System.Drawing.Point( 3, 26 );
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size( 647, 380 );
            this.groupBox.TabIndex = 49;
            this.groupBox.TabStop = false;
            this.groupBox.Text = " Sujetos ";
            // 
            // listViewPacientes
            // 
            this.listViewPacientes.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnIni,
            this.columnCodigo,
            this.columnNombre,
            this.columnApellido1,
            this.columnApellido2,
            this.columnEdad,
            this.columnSexo,
            this.columnNivel,
            this.columnDireccion} );
            this.listViewPacientes.ContextMenuStrip = this.MenuStrip;
            this.listViewPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPacientes.FullRowSelect = true;
            this.listViewPacientes.Location = new System.Drawing.Point( 3, 16 );
            this.listViewPacientes.MultiSelect = false;
            this.listViewPacientes.Name = "listViewPacientes";
            this.listViewPacientes.Size = new System.Drawing.Size( 641, 361 );
            this.listViewPacientes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewPacientes.TabIndex = 7;
            this.listViewPacientes.UseCompatibleStateImageBehavior = false;
            this.listViewPacientes.View = System.Windows.Forms.View.Details;
            this.listViewPacientes.SelectedIndexChanged += new System.EventHandler( this.listViewPacientes_SelectedIndexChanged );
            // 
            // columnIni
            // 
            this.columnIni.Text = "";
            this.columnIni.Width = 27;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 109;
            // 
            // columnApellido1
            // 
            this.columnApellido1.Text = "Primer Apellido";
            this.columnApellido1.Width = 115;
            // 
            // columnApellido2
            // 
            this.columnApellido2.Text = "Segundo Apellido";
            this.columnApellido2.Width = 126;
            // 
            // columnEdad
            // 
            this.columnEdad.Text = "Edad";
            // 
            // columnSexo
            // 
            this.columnSexo.Text = "Sexo";
            this.columnSexo.Width = 80;
            // 
            // columnNivel
            // 
            this.columnNivel.Text = "Nivel de Escolaridad";
            this.columnNivel.Width = 100;
            // 
            // columnDireccion
            // 
            this.columnDireccion.Text = "Dirección";
            this.columnDireccion.Width = 150;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripSeparator1,
            this.resultadosToolStripMenuItem} );
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size( 118, 76 );
            this.MenuStrip.Opening += new System.ComponentModel.CancelEventHandler( this.contextMenuStrip1_Opening );
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size( 117, 22 );
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler( this.eliminarToolStripMenuItem_Click );
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size( 117, 22 );
            this.editarToolStripMenuItem.Text = "E&ditar";
            this.editarToolStripMenuItem.Click += new System.EventHandler( this.editarToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 114, 6 );
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size( 117, 22 );
            this.resultadosToolStripMenuItem.Text = "E&xportar";
            // 
            // AdminPacientesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox );
            this.Controls.Add( this.toolBar );
            this.Name = "AdminPacientesUC";
            this.Size = new System.Drawing.Size( 653, 409 );
            this.toolBar.ResumeLayout( false );
            this.toolBar.PerformLayout();
            this.groupBox.ResumeLayout( false );
            this.MenuStrip.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripSplitButton tsbBuscar;
        private System.Windows.Forms.ToolStripMenuItem tsbmTodos;
        private System.Windows.Forms.ToolStripMenuItem tsbmPacientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbAgregar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ListView listViewPacientes;
        private System.Windows.Forms.ColumnHeader columnIni;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnApellido1;
        private System.Windows.Forms.ColumnHeader columnApellido2;
        private System.Windows.Forms.ColumnHeader columnEdad;
        private System.Windows.Forms.ColumnHeader columnSexo;
        private System.Windows.Forms.ColumnHeader columnNivel;
        private System.Windows.Forms.ColumnHeader columnDireccion;
        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbReporte;
    }
}
