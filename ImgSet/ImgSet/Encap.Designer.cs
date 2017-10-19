namespace ImgSet
{
    partial class Encap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encap));
            this.pictureBoxEj = new System.Windows.Forms.PictureBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.openFileImagenes = new System.Windows.Forms.OpenFileDialog();
            this.openFileCapsula = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoImagen = new System.Windows.Forms.ComboBox();
            this.cbPrueba = new System.Windows.Forms.ComboBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.bEncapsular = new System.Windows.Forms.Button();
            this.bCargarImágenes = new System.Windows.Forms.Button();
            this.bCargarCapsula = new System.Windows.Forms.Button();
            this.bEliminarVarias = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxEj
            // 
            this.pictureBoxEj.Location = new System.Drawing.Point(10, 17);
            this.pictureBoxEj.Name = "pictureBoxEj";
            this.pictureBoxEj.Size = new System.Drawing.Size(147, 146);
            this.pictureBoxEj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEj.TabIndex = 2;
            this.pictureBoxEj.TabStop = false;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(10, 169);
            this.nud.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(147, 20);
            this.nud.TabIndex = 1;
            this.nud.ValueChanged += new System.EventHandler(this.numericUpDownEj_ValueChanged);
            // 
            // openFileImagenes
            // 
            this.openFileImagenes.FileName = "openFileDialog1";
            this.openFileImagenes.Filter = "Imagenes|*.jpg";
            this.openFileImagenes.Multiselect = true;
            this.openFileImagenes.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileImagenes_FileOk);
            // 
            // openFileCapsula
            // 
            this.openFileCapsula.Filter = "Encap files|*.ips";
            this.openFileCapsula.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileCapsula_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTipoImagen);
            this.groupBox1.Controls.Add(this.cbPrueba);
            this.groupBox1.Controls.Add(this.tbPath);
            this.groupBox1.Controls.Add(this.bBrowse);
            this.groupBox1.Controls.Add(this.bEncapsular);
            this.groupBox1.Controls.Add(this.bCargarImágenes);
            this.groupBox1.Controls.Add(this.bCargarCapsula);
            this.groupBox1.Controls.Add(this.bEliminarVarias);
            this.groupBox1.Controls.Add(this.bEliminar);
            this.groupBox1.Controls.Add(this.nud);
            this.groupBox1.Controls.Add(this.pictureBoxEj);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 309);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cbTipoImagen
            // 
            this.cbTipoImagen.FormattingEnabled = true;
            this.cbTipoImagen.Items.AddRange(new object[] {
            "Imágenes",
            "Figuras abstractas",
            "Letras"});
            this.cbTipoImagen.Location = new System.Drawing.Point(10, 248);
            this.cbTipoImagen.Name = "cbTipoImagen";
            this.cbTipoImagen.Size = new System.Drawing.Size(281, 21);
            this.cbTipoImagen.TabIndex = 5;
            // 
            // cbPrueba
            // 
            this.cbPrueba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrueba.FormattingEnabled = true;
            this.cbPrueba.Items.AddRange(new object[] {
            "Atención Sostenida 1",
            "Atencion Sostenida 2"});
            this.cbPrueba.Location = new System.Drawing.Point(10, 221);
            this.cbPrueba.Name = "cbPrueba";
            this.cbPrueba.Size = new System.Drawing.Size(281, 21);
            this.cbPrueba.TabIndex = 5;
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.Color.White;
            this.tbPath.Location = new System.Drawing.Point(10, 195);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(203, 20);
            this.tbPath.TabIndex = 4;
            // 
            // bBrowse
            // 
            this.bBrowse.BackColor = System.Drawing.Color.DimGray;
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.ForeColor = System.Drawing.Color.White;
            this.bBrowse.Location = new System.Drawing.Point(221, 195);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(70, 23);
            this.bBrowse.TabIndex = 3;
            this.bBrowse.Text = "Carpeta";
            this.bBrowse.UseVisualStyleBackColor = false;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // bEncapsular
            // 
            this.bEncapsular.BackColor = System.Drawing.Color.DimGray;
            this.bEncapsular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEncapsular.ForeColor = System.Drawing.Color.White;
            this.bEncapsular.Location = new System.Drawing.Point(10, 275);
            this.bEncapsular.Name = "bEncapsular";
            this.bEncapsular.Size = new System.Drawing.Size(128, 23);
            this.bEncapsular.TabIndex = 3;
            this.bEncapsular.Text = "Encapsular";
            this.bEncapsular.UseVisualStyleBackColor = false;
            this.bEncapsular.Click += new System.EventHandler(this.bEncapsular_Click);
            // 
            // bCargarImágenes
            // 
            this.bCargarImágenes.BackColor = System.Drawing.Color.DimGray;
            this.bCargarImágenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCargarImágenes.ForeColor = System.Drawing.Color.White;
            this.bCargarImágenes.Location = new System.Drawing.Point(163, 104);
            this.bCargarImágenes.Name = "bCargarImágenes";
            this.bCargarImágenes.Size = new System.Drawing.Size(128, 23);
            this.bCargarImágenes.TabIndex = 3;
            this.bCargarImágenes.Text = "Cargar Imágenes";
            this.bCargarImágenes.UseVisualStyleBackColor = false;
            this.bCargarImágenes.Click += new System.EventHandler(this.bCargarImágenes_Click);
            // 
            // bCargarCapsula
            // 
            this.bCargarCapsula.BackColor = System.Drawing.Color.DimGray;
            this.bCargarCapsula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCargarCapsula.ForeColor = System.Drawing.Color.White;
            this.bCargarCapsula.Location = new System.Drawing.Point(163, 75);
            this.bCargarCapsula.Name = "bCargarCapsula";
            this.bCargarCapsula.Size = new System.Drawing.Size(128, 23);
            this.bCargarCapsula.TabIndex = 3;
            this.bCargarCapsula.Text = "Cargar Cápsula";
            this.bCargarCapsula.UseVisualStyleBackColor = false;
            this.bCargarCapsula.Click += new System.EventHandler(this.bCargarCapsula_Click);
            // 
            // bEliminarVarias
            // 
            this.bEliminarVarias.BackColor = System.Drawing.Color.DimGray;
            this.bEliminarVarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarVarias.ForeColor = System.Drawing.Color.White;
            this.bEliminarVarias.Location = new System.Drawing.Point(163, 46);
            this.bEliminarVarias.Name = "bEliminarVarias";
            this.bEliminarVarias.Size = new System.Drawing.Size(128, 23);
            this.bEliminarVarias.TabIndex = 3;
            this.bEliminarVarias.Text = "Eliminar Imagenes...";
            this.bEliminarVarias.UseVisualStyleBackColor = false;
            this.bEliminarVarias.Click += new System.EventHandler(this.bEliminarVarias_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.BackColor = System.Drawing.Color.DimGray;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.ForeColor = System.Drawing.Color.White;
            this.bEliminar.Location = new System.Drawing.Point(163, 17);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(128, 23);
            this.bEliminar.TabIndex = 3;
            this.bEliminar.Text = "Eliminar Imagen";
            this.bEliminar.UseVisualStyleBackColor = false;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // Encap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 309);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Encap";
            this.Text = "Encap v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEj;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.OpenFileDialog openFileImagenes;
        private System.Windows.Forms.OpenFileDialog openFileCapsula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bEncapsular;
        private System.Windows.Forms.Button bCargarImágenes;
        private System.Windows.Forms.Button bCargarCapsula;
        private System.Windows.Forms.Button bEliminarVarias;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ComboBox cbTipoImagen;
        private System.Windows.Forms.ComboBox cbPrueba;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button bBrowse;

    }
}

