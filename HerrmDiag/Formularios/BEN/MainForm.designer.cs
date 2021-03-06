namespace HerrmDiag.BEN
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.panelPreView = new System.Windows.Forms.Panel();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.buttonEnsayo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCambiarPass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxConf = new System.Windows.Forms.CheckBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInicio = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCerrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAyuda = new System.Windows.Forms.ToolStripButton();
            this.labelPrueba = new System.Windows.Forms.Label();
            this.comboBoxPrueba = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.labelPaciente = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPageExe = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.testInformationUC1 = new HerrmDiag.UserControls.TestInformationUC();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxConf = new System.Windows.Forms.GroupBox();
            this.tabPagePaci = new System.Windows.Forms.TabPage();
            this.adminPacientesUC1 = new HerrmDiag.UserControls.AdminPacientesUC();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.adminUsersUC1 = new HerrmDiag.UserControls.AdminUsersUC();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconosGrandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPageExe.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagePaci.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 663);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(922, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // panelPreView
            // 
            this.panelPreView.BackColor = System.Drawing.Color.DimGray;
            this.panelPreView.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelPreView.Location = new System.Drawing.Point(6, 11);
            this.panelPreView.Name = "panelPreView";
            this.panelPreView.Size = new System.Drawing.Size(200, 150);
            this.panelPreView.TabIndex = 3;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.Color.DimGray;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.ForeColor = System.Drawing.Color.White;
            this.buttonEjecutar.Location = new System.Drawing.Point(221, 93);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(87, 68);
            this.buttonEjecutar.TabIndex = 4;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // buttonEnsayo
            // 
            this.buttonEnsayo.BackColor = System.Drawing.Color.DimGray;
            this.buttonEnsayo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnsayo.ForeColor = System.Drawing.Color.White;
            this.buttonEnsayo.Location = new System.Drawing.Point(314, 105);
            this.buttonEnsayo.Name = "buttonEnsayo";
            this.buttonEnsayo.Size = new System.Drawing.Size(63, 56);
            this.buttonEnsayo.TabIndex = 4;
            this.buttonEnsayo.Text = "Ensayo";
            this.buttonEnsayo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEnsayo.UseVisualStyleBackColor = false;
            this.buttonEnsayo.Click += new System.EventHandler(this.buttonEnsayo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(221, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Mostrar vista previa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(922, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripExportar,
            this.toolStripSeparator4,
            this.toolStripCambiarPass,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "&Sistema";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.iniciarSesionToolStripMenuItem.Text = "&Iniciar Sesión";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Enabled = false;
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "&Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripExportar
            // 
            this.toolStripExportar.Name = "toolStripExportar";
            this.toolStripExportar.Size = new System.Drawing.Size(194, 22);
            this.toolStripExportar.Text = "E&xportar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // toolStripCambiarPass
            // 
            this.toolStripCambiarPass.Enabled = false;
            this.toolStripCambiarPass.Name = "toolStripCambiarPass";
            this.toolStripCambiarPass.Size = new System.Drawing.Size(194, 22);
            this.toolStripCambiarPass.Text = "C&ambiar Contraseña ...";
            this.toolStripCambiarPass.Click += new System.EventHandler(this.toolStripCambiarPass_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(191, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.salirToolStripMenuItem.Text = "Sa&lir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // checkBoxConf
            // 
            this.checkBoxConf.AutoSize = true;
            this.checkBoxConf.Checked = true;
            this.checkBoxConf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConf.Location = new System.Drawing.Point(221, 11);
            this.checkBoxConf.Name = "checkBoxConf";
            this.checkBoxConf.Size = new System.Drawing.Size(128, 17);
            this.checkBoxConf.TabIndex = 5;
            this.checkBoxConf.Text = "Mostrar configuración";
            this.checkBoxConf.UseVisualStyleBackColor = true;
            this.checkBoxConf.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInicio,
            this.toolStripButtonCerrar,
            this.toolStripSeparator5,
            this.toolStripButtonExportar,
            this.toolStripSeparator7,
            this.toolStripButtonAyuda});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(922, 30);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonInicio
            // 
            this.toolStripButtonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInicio.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInicio.Image")));
            this.toolStripButtonInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInicio.Name = "toolStripButtonInicio";
            this.toolStripButtonInicio.Size = new System.Drawing.Size(80, 19);
            this.toolStripButtonInicio.Text = "Iniciar Sesión";
            this.toolStripButtonInicio.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // toolStripButtonCerrar
            // 
            this.toolStripButtonCerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCerrar.Enabled = false;
            this.toolStripButtonCerrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCerrar.Image")));
            this.toolStripButtonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCerrar.Name = "toolStripButtonCerrar";
            this.toolStripButtonCerrar.Size = new System.Drawing.Size(80, 19);
            this.toolStripButtonCerrar.Text = "Cerrar Sesión";
            this.toolStripButtonCerrar.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonExportar
            // 
            this.toolStripButtonExportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonExportar.Enabled = false;
            this.toolStripButtonExportar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExportar.Image")));
            this.toolStripButtonExportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportar.Name = "toolStripButtonExportar";
            this.toolStripButtonExportar.Size = new System.Drawing.Size(54, 19);
            this.toolStripButtonExportar.Text = "Exportar";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 23);
            // 
            // toolStripButtonAyuda
            // 
            this.toolStripButtonAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAyuda.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAyuda.Image")));
            this.toolStripButtonAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAyuda.Name = "toolStripButtonAyuda";
            this.toolStripButtonAyuda.Size = new System.Drawing.Size(45, 19);
            this.toolStripButtonAyuda.Text = "Ayuda";
            // 
            // labelPrueba
            // 
            this.labelPrueba.AutoSize = true;
            this.labelPrueba.Location = new System.Drawing.Point(18, 18);
            this.labelPrueba.Name = "labelPrueba";
            this.labelPrueba.Size = new System.Drawing.Size(44, 13);
            this.labelPrueba.TabIndex = 8;
            this.labelPrueba.Text = "Prueba:";
            // 
            // comboBoxPrueba
            // 
            this.comboBoxPrueba.DropDownHeight = 140;
            this.comboBoxPrueba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrueba.Enabled = false;
            this.comboBoxPrueba.FormattingEnabled = true;
            this.comboBoxPrueba.IntegralHeight = false;
            this.comboBoxPrueba.Items.AddRange(new object[] {
            "Amplitud de Memoria",
            "Aprendizaje de Palabras",
            "Atención Sostenida Simple",
            "Estimación del Movimiento",
            "Memoria de Figuras",
            "Pares Visuales Asociados",
            "Pares Visuales Asociados (2)",
            "Tiempo de Reacción 1",
            "Tiempo de Reacción 2"});
            this.comboBoxPrueba.Location = new System.Drawing.Point(67, 14);
            this.comboBoxPrueba.Name = "comboBoxPrueba";
            this.comboBoxPrueba.Size = new System.Drawing.Size(248, 21);
            this.comboBoxPrueba.Sorted = true;
            this.comboBoxPrueba.TabIndex = 9;
            this.comboBoxPrueba.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrueba_SelectedIndexChanged);
            this.comboBoxPrueba.EnabledChanged += new System.EventHandler(this.comboBoxPrueba_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPaciente);
            this.groupBox2.Controls.Add(this.labelPaciente);
            this.groupBox2.Controls.Add(this.comboBoxPrueba);
            this.groupBox2.Controls.Add(this.labelPrueba);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(922, 42);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxPaciente
            // 
            this.comboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaciente.Enabled = false;
            this.comboBoxPaciente.FormattingEnabled = true;
            this.comboBoxPaciente.Location = new System.Drawing.Point(399, 15);
            this.comboBoxPaciente.Name = "comboBoxPaciente";
            this.comboBoxPaciente.Size = new System.Drawing.Size(248, 21);
            this.comboBoxPaciente.TabIndex = 9;
            this.comboBoxPaciente.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaciente_SelectedIndexChanged);
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(341, 18);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(52, 13);
            this.labelPaciente.TabIndex = 8;
            this.labelPaciente.Text = "Paciente:";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPageExe);
            this.tabControl2.Controls.Add(this.tabPagePaci);
            this.tabControl2.Controls.Add(this.tabPageUser);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 96);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(922, 567);
            this.tabControl2.TabIndex = 11;
            this.tabControl2.Visible = false;
            // 
            // tabPageExe
            // 
            this.tabPageExe.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageExe.Controls.Add(this.groupBox4);
            this.tabPageExe.Controls.Add(this.groupBox1);
            this.tabPageExe.Controls.Add(this.groupBoxConf);
            this.tabPageExe.Location = new System.Drawing.Point(4, 22);
            this.tabPageExe.Name = "tabPageExe";
            this.tabPageExe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExe.Size = new System.Drawing.Size(914, 541);
            this.tabPageExe.TabIndex = 0;
            this.tabPageExe.Text = "Ejecución";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.testInformationUC1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(335, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(576, 368);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Información referente a la prueba ";
            // 
            // testInformationUC1
            // 
            this.testInformationUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testInformationUC1.Location = new System.Drawing.Point(3, 16);
            this.testInformationUC1.Name = "testInformationUC1";
            this.testInformationUC1.Size = new System.Drawing.Size(570, 349);
            this.testInformationUC1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelPreView);
            this.groupBox1.Controls.Add(this.buttonEjecutar);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBoxConf);
            this.groupBox1.Controls.Add(this.buttonEnsayo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(335, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBoxConf
            // 
            this.groupBoxConf.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxConf.Location = new System.Drawing.Point(3, 3);
            this.groupBoxConf.Name = "groupBoxConf";
            this.groupBoxConf.Size = new System.Drawing.Size(332, 535);
            this.groupBoxConf.TabIndex = 6;
            this.groupBoxConf.TabStop = false;
            this.groupBoxConf.Text = " Configuración de la prueba ";
            // 
            // tabPagePaci
            // 
            this.tabPagePaci.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagePaci.Controls.Add(this.adminPacientesUC1);
            this.tabPagePaci.Location = new System.Drawing.Point(4, 22);
            this.tabPagePaci.Name = "tabPagePaci";
            this.tabPagePaci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaci.Size = new System.Drawing.Size(844, 541);
            this.tabPagePaci.TabIndex = 1;
            this.tabPagePaci.Text = "Pacientes";
            // 
            // adminPacientesUC1
            // 
            this.adminPacientesUC1.ComboBoxPaciente = null;
            this.adminPacientesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPacientesUC1.Location = new System.Drawing.Point(3, 3);
            this.adminPacientesUC1.Name = "adminPacientesUC1";
            this.adminPacientesUC1.Size = new System.Drawing.Size(838, 535);
            this.adminPacientesUC1.TabIndex = 17;
            // 
            // tabPageUser
            // 
            this.tabPageUser.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageUser.Controls.Add(this.adminUsersUC1);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(844, 541);
            this.tabPageUser.TabIndex = 2;
            this.tabPageUser.Text = "Usuarios";
            // 
            // adminUsersUC1
            // 
            this.adminUsersUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminUsersUC1.Location = new System.Drawing.Point(3, 3);
            this.adminUsersUC1.Name = "adminUsersUC1";
            this.adminUsersUC1.Size = new System.Drawing.Size(838, 535);
            this.adminUsersUC1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconosGrandeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.listaToolStripMenuItem,
            this.cascadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 92);
            // 
            // iconosGrandeToolStripMenuItem
            // 
            this.iconosGrandeToolStripMenuItem.Name = "iconosGrandeToolStripMenuItem";
            this.iconosGrandeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.iconosGrandeToolStripMenuItem.Text = "Iconos Grandes";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 22);
            this.toolStripMenuItem3.Text = "Iconos Pequeños";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Groups.bmp");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "GroupsSmall.bmp");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(922, 685);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "BEN v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPageExe.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagePaci.ResumeLayout(false);
            this.tabPageUser.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel panelPreView;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.Button buttonEnsayo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxConf;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrueba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPageExe;
        private System.Windows.Forms.TabPage tabPagePaci;
        private System.Windows.Forms.GroupBox groupBoxConf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;        
        
        private System.Windows.Forms.ToolStripButton toolStripButtonInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonCerrar;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonAyuda;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iconosGrandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripExportar;
        private System.Windows.Forms.ToolStripMenuItem toolStripCambiarPass;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private HerrmDiag.UserControls.AdminPacientesUC adminPacientesUC1;
        private HerrmDiag.UserControls.AdminUsersUC adminUsersUC1;
        private HerrmDiag.UserControls.TestInformationUC testInformationUC1;

        //private System.Windows.Forms.Label label16;
        //private System.Windows.Forms.Label label15;
        //private System.Windows.Forms.Label label14;
        //private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.NumericUpDown numericUpDown6;
        //private System.Windows.Forms.Label label18;
        //private System.Windows.Forms.Label label17;
        //private System.Windows.Forms.ComboBox comboBox3;
        //private System.Windows.Forms.Panel panel1;
        //private System.Windows.Forms.NumericUpDown numericUpDown10;
        //private System.Windows.Forms.NumericUpDown numericUpDown9;
        //private System.Windows.Forms.NumericUpDown numericUpDown8;
        //private System.Windows.Forms.NumericUpDown numericUpDown7;
        //private System.Windows.Forms.RadioButton radioButtonFiguras;
        //private System.Windows.Forms.RadioButton radioButtonLetras;
        //private System.Windows.Forms.Label label19;
        //private System.Windows.Forms.TextBox textBox1;
        //private System.Windows.Forms.Panel panel2;
        //private System.Windows.Forms.Label label20;
        //private System.Windows.Forms.Label label8;
        //private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.ComboBox comboBox2;
        //private System.Windows.Forms.ComboBox comboBox1;
        //private System.Windows.Forms.NumericUpDown numericUpDown5;
        //private System.Windows.Forms.NumericUpDown numericUpDown7;
        //private System.Windows.Forms.NumericUpDown numericUpDown2;
        //private System.Windows.Forms.NumericUpDown numericUpDown6;
        //private System.Windows.Forms.Label label14;
        //private System.Windows.Forms.NumericUpDown numericUpDown1;
        //private System.Windows.Forms.Label label13;
        //private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.Label label11;
        //private System.Windows.Forms.Label label10;
        //private System.Windows.Forms.Label label9;      
        

    }
}

