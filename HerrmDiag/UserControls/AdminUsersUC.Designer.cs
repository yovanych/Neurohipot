namespace HerrmDiag.UserControls
{
    partial class AdminUsersUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsersUC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.contextMenuStripUserListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsddbEditar = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCambiarPass = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambiarCat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbVista = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmVIconosG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVIconosP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVLista = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.contextMenuStripUserListView.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.listViewUser);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 310);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Usuarios ";
            // 
            // listViewUser
            // 
            this.listViewUser.ContextMenuStrip = this.contextMenuStripUserListView;
            this.listViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewUser.ForeColor = System.Drawing.Color.DarkBlue;
            this.listViewUser.LargeImageList = this.imageListLarge;
            this.listViewUser.Location = new System.Drawing.Point(3, 16);
            this.listViewUser.MultiSelect = false;
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.ShowItemToolTips = true;
            this.listViewUser.Size = new System.Drawing.Size(491, 291);
            this.listViewUser.SmallImageList = this.imageListSmall;
            this.listViewUser.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewUser.TabIndex = 0;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.SelectedIndexChanged += new System.EventHandler(this.listViewUser_SelectedIndexChanged);
            // 
            // contextMenuStripUserListView
            // 
            this.contextMenuStripUserListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.cambiarCategoríaToolStripMenuItem});
            this.contextMenuStripUserListView.Name = "contextMenuStripUserListView";
            this.contextMenuStripUserListView.Size = new System.Drawing.Size(183, 70);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar C&ontraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // cambiarCategoríaToolStripMenuItem
            // 
            this.cambiarCategoríaToolStripMenuItem.Name = "cambiarCategoríaToolStripMenuItem";
            this.cambiarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cambiarCategoríaToolStripMenuItem.Text = "Cambiar &Categoría";
            this.cambiarCategoríaToolStripMenuItem.Click += new System.EventHandler(this.cambiarCategoríaToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsddbEditar,
            this.toolStripSeparator3,
            this.tsddbVista});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(503, 25);
            this.toolStrip.TabIndex = 8;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(69, 22);
            this.tsbAdd.Text = "Agregar";
            this.tsbAdd.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // tsddbEditar
            // 
            this.tsddbEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEliminar,
            this.toolStripSeparator2,
            this.tsmCambiarPass,
            this.tsmCambiarCat});
            this.tsddbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsddbEditar.Image")));
            this.tsddbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbEditar.Name = "tsddbEditar";
            this.tsddbEditar.Size = new System.Drawing.Size(66, 22);
            this.tsddbEditar.Text = "Editar";
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsmEliminar.Text = "Eliminar";
            this.tsmEliminar.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmCambiarPass
            // 
            this.tsmCambiarPass.Name = "tsmCambiarPass";
            this.tsmCambiarPass.Size = new System.Drawing.Size(180, 22);
            this.tsmCambiarPass.Text = "Cambiar contraseña";
            this.tsmCambiarPass.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // tsmCambiarCat
            // 
            this.tsmCambiarCat.Name = "tsmCambiarCat";
            this.tsmCambiarCat.Size = new System.Drawing.Size(180, 22);
            this.tsmCambiarCat.Text = "Cambiar categoría";
            this.tsmCambiarCat.Click += new System.EventHandler(this.cambiarCategoríaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbVista
            // 
            this.tsddbVista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVIconosG,
            this.tsmVIconosP,
            this.tsmVLista,
            this.tsmVCascada});
            this.tsddbVista.Image = ((System.Drawing.Image)(resources.GetObject("tsddbVista.Image")));
            this.tsddbVista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbVista.Name = "tsddbVista";
            this.tsddbVista.Size = new System.Drawing.Size(61, 22);
            this.tsddbVista.Text = "Vista";
            // 
            // tsmVIconosG
            // 
            this.tsmVIconosG.Name = "tsmVIconosG";
            this.tsmVIconosG.Size = new System.Drawing.Size(164, 22);
            this.tsmVIconosG.Text = "Iconos grandes";
            this.tsmVIconosG.Click += new System.EventHandler(this.iconosGrandesToolStripMenuItem_Click);
            // 
            // tsmVIconosP
            // 
            this.tsmVIconosP.Name = "tsmVIconosP";
            this.tsmVIconosP.Size = new System.Drawing.Size(164, 22);
            this.tsmVIconosP.Text = "Iconos pequeños";
            this.tsmVIconosP.Click += new System.EventHandler(this.iconosPequeñosToolStripMenuItem_Click);
            // 
            // tsmVLista
            // 
            this.tsmVLista.Name = "tsmVLista";
            this.tsmVLista.Size = new System.Drawing.Size(164, 22);
            this.tsmVLista.Text = "Lista";
            this.tsmVLista.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // tsmVCascada
            // 
            this.tsmVCascada.Name = "tsmVCascada";
            this.tsmVCascada.Size = new System.Drawing.Size(164, 22);
            this.tsmVCascada.Text = "Cascada";
            this.tsmVCascada.Click += new System.EventHandler(this.cascadaToolStripMenuItem_Click);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "U32.png");
            this.imageListLarge.Images.SetKeyName(1, "Ufo.ico");
            this.imageListLarge.Images.SetKeyName(2, "Ico1.jpg");
            this.imageListLarge.Images.SetKeyName(3, "Ico1.bmp");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "u24.png");
            this.imageListSmall.Images.SetKeyName(1, "Ico1.bmp");
            this.imageListSmall.Images.SetKeyName(2, "Goofy.ico");
            // 
            // AdminUsersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminUsersUC";
            this.Size = new System.Drawing.Size(503, 341);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStripUserListView.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripDropDownButton tsddbEditar;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarPass;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarCat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsddbVista;
        private System.Windows.Forms.ToolStripMenuItem tsmVIconosG;
        private System.Windows.Forms.ToolStripMenuItem tsmVIconosP;
        private System.Windows.Forms.ToolStripMenuItem tsmVLista;
        private System.Windows.Forms.ToolStripMenuItem tsmVCascada;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUserListView;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarCategoríaToolStripMenuItem;
    }
}
