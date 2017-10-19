namespace HerrmDiag.UserControls
{
    partial class ConfASCLetrasUC
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
            this.lLetra2 = new System.Windows.Forms.Label();
            this.lLetra1 = new System.Windows.Forms.Label();
            this.lbcolorLetras = new System.Windows.Forms.LinkLabel();
            this.lbcolorFondo = new System.Windows.Forms.LinkLabel();
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.comboBoxTecla = new System.Windows.Forms.ComboBox();
            this.numericUpDownOcultamiento = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownVisualizacion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownEstimulos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBloques = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpEstimulo1 = new System.Windows.Forms.TabPage();
            this.lIndexImage1 = new System.Windows.Forms.Label();
            this.bRigth1 = new System.Windows.Forms.Button();
            this.bLeft1 = new System.Windows.Forms.Button();
            this.pbFondo1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tpEstimulo2 = new System.Windows.Forms.TabPage();
            this.lIndexImage2 = new System.Windows.Forms.Label();
            this.bRigth2 = new System.Windows.Forms.Button();
            this.bLeft2 = new System.Windows.Forms.Button();
            this.pbFondo2 = new System.Windows.Forms.PictureBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcultamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstimulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloques)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpEstimulo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tpEstimulo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.SuspendLayout();
            // 
            // lLetra2
            // 
            this.lLetra2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLetra2.AutoSize = true;
            this.lLetra2.BackColor = System.Drawing.Color.Transparent;
            this.lLetra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLetra2.Location = new System.Drawing.Point(100, 44);
            this.lLetra2.Name = "lLetra2";
            this.lLetra2.Size = new System.Drawing.Size(64, 63);
            this.lLetra2.TabIndex = 45;
            this.lLetra2.Text = "A";
            this.lLetra2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLetra1
            // 
            this.lLetra1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLetra1.AutoSize = true;
            this.lLetra1.BackColor = System.Drawing.Color.Transparent;
            this.lLetra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLetra1.Location = new System.Drawing.Point(100, 44);
            this.lLetra1.Name = "lLetra1";
            this.lLetra1.Size = new System.Drawing.Size(64, 63);
            this.lLetra1.TabIndex = 46;
            this.lLetra1.Text = "A";
            this.lLetra1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbcolorLetras
            // 
            this.lbcolorLetras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcolorLetras.AutoSize = true;
            this.lbcolorLetras.Location = new System.Drawing.Point(184, 158);
            this.lbcolorLetras.Name = "lbcolorLetras";
            this.lbcolorLetras.Size = new System.Drawing.Size(94, 13);
            this.lbcolorLetras.TabIndex = 43;
            this.lbcolorLetras.TabStop = true;
            this.lbcolorLetras.Text = "Color de las Letras";
            this.lbcolorLetras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbcolorLetra_LinkClicked);
            // 
            // lbcolorFondo
            // 
            this.lbcolorFondo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcolorFondo.AutoSize = true;
            this.lbcolorFondo.Location = new System.Drawing.Point(199, 135);
            this.lbcolorFondo.Name = "lbcolorFondo";
            this.lbcolorFondo.Size = new System.Drawing.Size(79, 13);
            this.lbcolorFondo.TabIndex = 44;
            this.lbcolorFondo.TabStop = true;
            this.lbcolorFondo.Text = "Color de Fondo";
            this.lbcolorFondo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbcolorFondo_LinkClicked);
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point(172, 417);
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size(106, 23);
            this.bPredeterminados.TabIndex = 40;
            this.bPredeterminados.Text = "Predeterminados";
            this.bPredeterminados.UseVisualStyleBackColor = false;
            this.bPredeterminados.Click += new System.EventHandler(this.buttonPredeterminados_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.DimGray;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(203, 446);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 39;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAceptar.BackColor = System.Drawing.Color.DimGray;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.ForeColor = System.Drawing.Color.White;
            this.bAceptar.Location = new System.Drawing.Point(6, 417);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 38;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // comboBoxTecla
            // 
            this.comboBoxTecla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTecla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecla.FormattingEnabled = true;
            this.comboBoxTecla.Items.AddRange(new object[] {
            "[Espacio]",
            "[Enter]"});
            this.comboBoxTecla.Location = new System.Drawing.Point(188, 107);
            this.comboBoxTecla.Name = "comboBoxTecla";
            this.comboBoxTecla.Size = new System.Drawing.Size(90, 21);
            this.comboBoxTecla.TabIndex = 31;
            // 
            // numericUpDownOcultamiento
            // 
            this.numericUpDownOcultamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownOcultamiento.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownOcultamiento.Location = new System.Drawing.Point(188, 81);
            this.numericUpDownOcultamiento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownOcultamiento.Name = "numericUpDownOcultamiento";
            this.numericUpDownOcultamiento.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownOcultamiento.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tecla de reacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tiempo de ocultamiento (ms):";
            // 
            // numericUpDownVisualizacion
            // 
            this.numericUpDownVisualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownVisualizacion.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Location = new System.Drawing.Point(188, 55);
            this.numericUpDownVisualizacion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Name = "numericUpDownVisualizacion";
            this.numericUpDownVisualizacion.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownVisualizacion.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tiempo de visualización (ms):";
            // 
            // numericUpDownEstimulos
            // 
            this.numericUpDownEstimulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEstimulos.Location = new System.Drawing.Point(188, 29);
            this.numericUpDownEstimulos.Name = "numericUpDownEstimulos";
            this.numericUpDownEstimulos.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownEstimulos.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Estímulos por bloque:";
            // 
            // numericUpDownBloques
            // 
            this.numericUpDownBloques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBloques.Location = new System.Drawing.Point(188, 3);
            this.numericUpDownBloques.Name = "numericUpDownBloques";
            this.numericUpDownBloques.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownBloques.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bloques a mostrar:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpEstimulo1);
            this.tabControl1.Controls.Add(this.tpEstimulo2);
            this.tabControl1.Location = new System.Drawing.Point(6, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(272, 246);
            this.tabControl1.TabIndex = 53;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // tpEstimulo1
            // 
            this.tpEstimulo1.Controls.Add(this.lIndexImage1);
            this.tpEstimulo1.Controls.Add(this.bRigth1);
            this.tpEstimulo1.Controls.Add(this.lLetra1);
            this.tpEstimulo1.Controls.Add(this.bLeft1);
            this.tpEstimulo1.Controls.Add(this.pbFondo1);
            this.tpEstimulo1.Controls.Add(this.trackBar1);
            this.tpEstimulo1.Location = new System.Drawing.Point(4, 22);
            this.tpEstimulo1.Name = "tpEstimulo1";
            this.tpEstimulo1.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstimulo1.Size = new System.Drawing.Size(264, 220);
            this.tpEstimulo1.TabIndex = 0;
            this.tpEstimulo1.Text = "Estímulo 1";
            this.tpEstimulo1.UseVisualStyleBackColor = true;
            // 
            // lIndexImage1
            // 
            this.lIndexImage1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lIndexImage1.AutoSize = true;
            this.lIndexImage1.Location = new System.Drawing.Point(107, 183);
            this.lIndexImage1.Name = "lIndexImage1";
            this.lIndexImage1.Size = new System.Drawing.Size(49, 13);
            this.lIndexImage1.TabIndex = 51;
            this.lIndexImage1.Text = "10 de 10";
            this.lIndexImage1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRigth1
            // 
            this.bRigth1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRigth1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRigth1.Location = new System.Drawing.Point(214, 178);
            this.bRigth1.Name = "bRigth1";
            this.bRigth1.Size = new System.Drawing.Size(42, 23);
            this.bRigth1.TabIndex = 38;
            this.bRigth1.Text = ">>";
            this.bRigth1.UseVisualStyleBackColor = true;
            this.bRigth1.Click += new System.EventHandler(this.derecha1_Click);
            // 
            // bLeft1
            // 
            this.bLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLeft1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLeft1.Location = new System.Drawing.Point(6, 178);
            this.bLeft1.Name = "bLeft1";
            this.bLeft1.Size = new System.Drawing.Size(42, 23);
            this.bLeft1.TabIndex = 37;
            this.bLeft1.Text = "<<";
            this.bLeft1.UseVisualStyleBackColor = true;
            this.bLeft1.Click += new System.EventHandler(this.izquierda1_Click);
            // 
            // pbFondo1
            // 
            this.pbFondo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFondo1.BackColor = System.Drawing.Color.Black;
            this.pbFondo1.Location = new System.Drawing.Point(28, 8);
            this.pbFondo1.Name = "pbFondo1";
            this.pbFondo1.Size = new System.Drawing.Size(208, 127);
            this.pbFondo1.TabIndex = 48;
            this.pbFondo1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(6, 141);
            this.trackBar1.Maximum = 26;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(250, 45);
            this.trackBar1.TabIndex = 35;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // tpEstimulo2
            // 
            this.tpEstimulo2.Controls.Add(this.lIndexImage2);
            this.tpEstimulo2.Controls.Add(this.lLetra2);
            this.tpEstimulo2.Controls.Add(this.bRigth2);
            this.tpEstimulo2.Controls.Add(this.bLeft2);
            this.tpEstimulo2.Controls.Add(this.pbFondo2);
            this.tpEstimulo2.Controls.Add(this.trackBar2);
            this.tpEstimulo2.Location = new System.Drawing.Point(4, 22);
            this.tpEstimulo2.Name = "tpEstimulo2";
            this.tpEstimulo2.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstimulo2.Size = new System.Drawing.Size(264, 220);
            this.tpEstimulo2.TabIndex = 1;
            this.tpEstimulo2.Text = "Estímulo 2";
            this.tpEstimulo2.UseVisualStyleBackColor = true;
            // 
            // lIndexImage2
            // 
            this.lIndexImage2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lIndexImage2.AutoSize = true;
            this.lIndexImage2.Location = new System.Drawing.Point(107, 183);
            this.lIndexImage2.Name = "lIndexImage2";
            this.lIndexImage2.Size = new System.Drawing.Size(49, 13);
            this.lIndexImage2.TabIndex = 50;
            this.lIndexImage2.Text = "10 de 10";
            this.lIndexImage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bRigth2
            // 
            this.bRigth2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRigth2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bRigth2.Location = new System.Drawing.Point(214, 178);
            this.bRigth2.Name = "bRigth2";
            this.bRigth2.Size = new System.Drawing.Size(42, 23);
            this.bRigth2.TabIndex = 43;
            this.bRigth2.Text = ">>";
            this.bRigth2.UseVisualStyleBackColor = true;
            this.bRigth2.Click += new System.EventHandler(this.derecha2_Click);
            // 
            // bLeft2
            // 
            this.bLeft2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bLeft2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bLeft2.Location = new System.Drawing.Point(6, 178);
            this.bLeft2.Name = "bLeft2";
            this.bLeft2.Size = new System.Drawing.Size(42, 23);
            this.bLeft2.TabIndex = 42;
            this.bLeft2.Text = "<<";
            this.bLeft2.UseVisualStyleBackColor = true;
            this.bLeft2.Click += new System.EventHandler(this.izquierda2_Click);
            // 
            // pbFondo2
            // 
            this.pbFondo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFondo2.BackColor = System.Drawing.Color.Black;
            this.pbFondo2.Location = new System.Drawing.Point(28, 8);
            this.pbFondo2.Name = "pbFondo2";
            this.pbFondo2.Size = new System.Drawing.Size(208, 127);
            this.pbFondo2.TabIndex = 47;
            this.pbFondo2.TabStop = false;
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.BackColor = System.Drawing.Color.White;
            this.trackBar2.Location = new System.Drawing.Point(6, 141);
            this.trackBar2.Maximum = 26;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(250, 45);
            this.trackBar2.TabIndex = 40;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // ConfASCLetrasUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbcolorLetras);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbcolorFondo);
            this.Controls.Add(this.bPredeterminados);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.comboBoxTecla);
            this.Controls.Add(this.numericUpDownOcultamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownVisualizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownEstimulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownBloques);
            this.Controls.Add(this.label1);
            this.Name = "ConfASCLetrasUC";
            this.Size = new System.Drawing.Size(283, 478);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcultamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstimulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloques)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpEstimulo1.ResumeLayout(false);
            this.tpEstimulo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tpEstimulo2.ResumeLayout(false);
            this.tpEstimulo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFondo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLetra2;
        private System.Windows.Forms.Label lLetra1;
        private System.Windows.Forms.LinkLabel lbcolorLetras;
        private System.Windows.Forms.LinkLabel lbcolorFondo;
        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ComboBox comboBoxTecla;
        private System.Windows.Forms.NumericUpDown numericUpDownOcultamiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownVisualizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownEstimulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBloques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpEstimulo1;
        private System.Windows.Forms.Label lIndexImage1;
        private System.Windows.Forms.Button bRigth1;
        private System.Windows.Forms.Button bLeft1;
        private System.Windows.Forms.PictureBox pbFondo1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TabPage tpEstimulo2;
        private System.Windows.Forms.Label lIndexImage2;
        private System.Windows.Forms.Button bRigth2;
        private System.Windows.Forms.Button bLeft2;
        private System.Windows.Forms.PictureBox pbFondo2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
