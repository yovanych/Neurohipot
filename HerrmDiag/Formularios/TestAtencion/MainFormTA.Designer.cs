namespace HerrmDiag.TestAtencion
{
    partial class MainFormTA
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainFormTA ) );
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.administradorDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lsbEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonConf = new System.Windows.Forms.Button();
            this.buttonEnsayo = new System.Windows.Forms.Button();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.checkBoxResultado = new System.Windows.Forms.CheckBox();
            this.groupBoxVistaPrevia = new System.Windows.Forms.GroupBox();
            this.checkBoxVistaPrevia = new System.Windows.Forms.CheckBox();
            this.panelPreView = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fbdExcelPath = new System.Windows.Forms.FolderBrowserDialog();
            this.sfdExcelFile = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider( this.components );
            this.testInformationUC1 = new HerrmDiag.UserControls.TestInformationUC();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxVistaPrevia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.ayudaToolStripMenuItem} );
            this.menuStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size( 685, 24 );
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem} );
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size( 60, 20 );
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size( 139, 22 );
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler( this.salirToolStripMenuItem_Click );
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.administradorDePacientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportarAExcelToolStripMenuItem} );
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size( 57, 20 );
            this.pacientesToolStripMenuItem.Text = "Su&jetos";
            // 
            // administradorDePacientesToolStripMenuItem
            // 
            this.administradorDePacientesToolStripMenuItem.Name = "administradorDePacientesToolStripMenuItem";
            this.administradorDePacientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.administradorDePacientesToolStripMenuItem.Size = new System.Drawing.Size( 316, 22 );
            this.administradorDePacientesToolStripMenuItem.Text = "Herramienta de Administracion de &Sujetos";
            this.administradorDePacientesToolStripMenuItem.Click += new System.EventHandler( this.administradorDePacientesToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 313, 6 );
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size( 316, 22 );
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a &Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler( this.exportarAExcelToolStripMenuItem_Click );
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.toolStripSeparator2,
            this.administradorDeUsuariosToolStripMenuItem} );
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size( 64, 20 );
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size( 323, 22 );
            this.cambiarContraseñaToolStripMenuItem.Text = "&Cambiar contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler( this.cambiarContraseñaToolStripMenuItem_Click_1 );
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size( 320, 6 );
            // 
            // administradorDeUsuariosToolStripMenuItem
            // 
            this.administradorDeUsuariosToolStripMenuItem.Name = "administradorDeUsuariosToolStripMenuItem";
            this.administradorDeUsuariosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.administradorDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size( 323, 22 );
            this.administradorDeUsuariosToolStripMenuItem.Text = "Herramienta de Administracion de &Usuarios";
            this.administradorDeUsuariosToolStripMenuItem.Click += new System.EventHandler( this.administradorDeUsuariosToolStripMenuItem_Click );
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.contenidoToolStripMenuItem} );
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size( 53, 20 );
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size( 159, 22 );
            this.acercaDeToolStripMenuItem.Text = "&Acerca de TAS...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler( this.acercaDeToolStripMenuItem_Click );
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size( 159, 22 );
            this.contenidoToolStripMenuItem.Text = "Contenido";
            this.contenidoToolStripMenuItem.Click += new System.EventHandler( this.contenidoToolStripMenuItem_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point( 6, 29 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 97, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Test seleccionado:";
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Items.AddRange( new object[] {
            "Atención Sostenida Compleja (Figuras)",
            "Atención Sostenida Compleja (Letras)",
            "Atención Sostenida Simple (Figuras)",
            "Atención Sostenida Simple (Letras)"} );
            this.comboBoxTest.Location = new System.Drawing.Point( 9, 45 );
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size( 249, 21 );
            this.comboBoxTest.Sorted = true;
            this.comboBoxTest.TabIndex = 0;
            this.comboBoxTest.SelectedIndexChanged += new System.EventHandler( this.comboBoxTest_SelectedIndexChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point( 6, 71 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 106, 13 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Sujeto seleccionado:";
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point( 9, 87 );
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size( 249, 21 );
            this.comboBoxPaciente.TabIndex = 1;
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler( this.comboBoxPaciente_SelectedIndexChanged );
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.lsbEstado} );
            this.statusStrip1.Location = new System.Drawing.Point( 0, 419 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size( 685, 22 );
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lsbEstado
            // 
            this.lsbEstado.Name = "lsbEstado";
            this.lsbEstado.Size = new System.Drawing.Size( 0, 17 );
            // 
            // buttonConf
            // 
            this.buttonConf.BackColor = System.Drawing.Color.DimGray;
            this.buttonConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConf.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonConf.ForeColor = System.Drawing.Color.White;
            this.buttonConf.Location = new System.Drawing.Point( 164, 334 );
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.Size = new System.Drawing.Size( 82, 35 );
            this.buttonConf.TabIndex = 6;
            this.buttonConf.Text = "&Configuración";
            this.buttonConf.UseVisualStyleBackColor = false;
            this.buttonConf.Click += new System.EventHandler( this.buttonConf_Click );
            // 
            // buttonEnsayo
            // 
            this.buttonEnsayo.BackColor = System.Drawing.Color.DimGray;
            this.buttonEnsayo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnsayo.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonEnsayo.ForeColor = System.Drawing.Color.White;
            this.buttonEnsayo.Location = new System.Drawing.Point( 93, 334 );
            this.buttonEnsayo.Name = "buttonEnsayo";
            this.buttonEnsayo.Size = new System.Drawing.Size( 65, 35 );
            this.buttonEnsayo.TabIndex = 5;
            this.buttonEnsayo.Text = "Ensa&yo";
            this.buttonEnsayo.UseVisualStyleBackColor = false;
            this.buttonEnsayo.Click += new System.EventHandler( this.buttonEnsayo_Click );
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.Color.DimGray;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonEjecutar.ForeColor = System.Drawing.Color.White;
            this.buttonEjecutar.Location = new System.Drawing.Point( 9, 334 );
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size( 78, 35 );
            this.buttonEjecutar.TabIndex = 4;
            this.buttonEjecutar.Text = "&Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler( this.buttonEjecutar_Click );
            // 
            // checkBoxResultado
            // 
            this.checkBoxResultado.AutoSize = true;
            this.checkBoxResultado.ForeColor = System.Drawing.Color.Black;
            this.checkBoxResultado.Location = new System.Drawing.Point( 9, 307 );
            this.checkBoxResultado.Name = "checkBoxResultado";
            this.checkBoxResultado.Size = new System.Drawing.Size( 198, 17 );
            this.checkBoxResultado.TabIndex = 3;
            this.checkBoxResultado.Text = "Mostrar resulatdos del test al finalizar";
            this.checkBoxResultado.UseVisualStyleBackColor = true;
            // 
            // groupBoxVistaPrevia
            // 
            this.groupBoxVistaPrevia.Controls.Add( this.checkBoxVistaPrevia );
            this.groupBoxVistaPrevia.Controls.Add( this.panelPreView );
            this.groupBoxVistaPrevia.Location = new System.Drawing.Point( 9, 114 );
            this.groupBoxVistaPrevia.Name = "groupBoxVistaPrevia";
            this.groupBoxVistaPrevia.Size = new System.Drawing.Size( 249, 187 );
            this.groupBoxVistaPrevia.TabIndex = 3;
            this.groupBoxVistaPrevia.TabStop = false;
            this.groupBoxVistaPrevia.Text = " Vista previa: ";
            // 
            // checkBoxVistaPrevia
            // 
            this.checkBoxVistaPrevia.AutoSize = true;
            this.checkBoxVistaPrevia.Checked = true;
            this.checkBoxVistaPrevia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVistaPrevia.ForeColor = System.Drawing.Color.Black;
            this.checkBoxVistaPrevia.Location = new System.Drawing.Point( 13, 157 );
            this.checkBoxVistaPrevia.Name = "checkBoxVistaPrevia";
            this.checkBoxVistaPrevia.Size = new System.Drawing.Size( 118, 17 );
            this.checkBoxVistaPrevia.TabIndex = 2;
            this.checkBoxVistaPrevia.Text = "Mostrar vista previa";
            this.checkBoxVistaPrevia.UseVisualStyleBackColor = true;
            this.checkBoxVistaPrevia.CheckedChanged += new System.EventHandler( this.checkBoxVistaPrevia_CheckedChanged );
            // 
            // panelPreView
            // 
            this.panelPreView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPreView.BackColor = System.Drawing.Color.DimGray;
            this.panelPreView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPreView.Location = new System.Drawing.Point( 13, 15 );
            this.panelPreView.Name = "panelPreView";
            this.panelPreView.Size = new System.Drawing.Size( 224, 136 );
            this.panelPreView.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add( this.testInformationUC1 );
            this.groupBox2.Location = new System.Drawing.Point( 264, 25 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 416, 384 );
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Información acerca del Test: ";
            // 
            // sfdExcelFile
            // 
            this.sfdExcelFile.DefaultExt = "xlsx";
            this.sfdExcelFile.FileName = "reporte";
            this.sfdExcelFile.Filter = "Excel 2007+ files|*.xlsx";
            this.sfdExcelFile.InitialDirectory = "Desktop";
            this.sfdExcelFile.Title = "Salvar a Excel";
            this.sfdExcelFile.FileOk += new System.ComponentModel.CancelEventHandler( this.sfdExcelFile_FileOk );
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // testInformationUC1
            // 
            this.testInformationUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testInformationUC1.Location = new System.Drawing.Point( 7, 19 );
            this.testInformationUC1.Name = "testInformationUC1";
            this.testInformationUC1.Size = new System.Drawing.Size( 403, 359 );
            this.testInformationUC1.TabIndex = 0;
            // 
            // MainFormTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 685, 441 );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.buttonConf );
            this.Controls.Add( this.buttonEnsayo );
            this.Controls.Add( this.statusStrip1 );
            this.Controls.Add( this.buttonEjecutar );
            this.Controls.Add( this.menuStrip1 );
            this.Controls.Add( this.checkBoxResultado );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.groupBoxVistaPrevia );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.comboBoxPaciente );
            this.Controls.Add( this.comboBoxTest );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size( 640, 450 );
            this.Name = "MainFormTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.MainForm_FormClosing );
            this.menuStrip1.ResumeLayout( false );
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout( false );
            this.statusStrip1.PerformLayout();
            this.groupBoxVistaPrevia.ResumeLayout( false );
            this.groupBoxVistaPrevia.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.CheckBox checkBoxResultado;
        private System.Windows.Forms.GroupBox groupBoxVistaPrevia;
        private System.Windows.Forms.CheckBox checkBoxVistaPrevia;
        private System.Windows.Forms.Panel panelPreView;
        private System.Windows.Forms.Button buttonEnsayo;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.ToolStripMenuItem administradorDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem administradorDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbdExcelPath;
        private System.Windows.Forms.ToolStripStatusLabel lsbEstado;
        private System.Windows.Forms.SaveFileDialog sfdExcelFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private UserControls.TestInformationUC testInformationUC1;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
    }
}

