﻿namespace HerrmDiag.UserControls
{
    partial class ConfASSLetrasColoresUC
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
            this.lIndexImage = new System.Windows.Forms.Label();
            this.lbColorLetras = new System.Windows.Forms.LinkLabel();
            this.lbColorFondo = new System.Windows.Forms.LinkLabel();
            this.lLetra = new System.Windows.Forms.Label();
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.buttonRigt1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
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
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcultamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstimulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.SuspendLayout();
            // 
            // lIndexImage
            // 
            this.lIndexImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lIndexImage.AutoSize = true;
            this.lIndexImage.Location = new System.Drawing.Point(124, 326);
            this.lIndexImage.Name = "lIndexImage";
            this.lIndexImage.Size = new System.Drawing.Size(49, 13);
            this.lIndexImage.TabIndex = 79;
            this.lIndexImage.Text = "10 de 10";
            this.lIndexImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbColorLetras
            // 
            this.lbColorLetras.AutoSize = true;
            this.lbColorLetras.Location = new System.Drawing.Point(5, 164);
            this.lbColorLetras.Name = "lbColorLetras";
            this.lbColorLetras.Size = new System.Drawing.Size(92, 13);
            this.lbColorLetras.TabIndex = 77;
            this.lbColorLetras.TabStop = true;
            this.lbColorLetras.Text = "Color Letra Diana:";
            this.lbColorLetras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbColorLetras_LinkClicked);
            // 
            // lbColorFondo
            // 
            this.lbColorFondo.AutoSize = true;
            this.lbColorFondo.Location = new System.Drawing.Point(5, 143);
            this.lbColorFondo.Name = "lbColorFondo";
            this.lbColorFondo.Size = new System.Drawing.Size(82, 13);
            this.lbColorFondo.TabIndex = 78;
            this.lbColorFondo.TabStop = true;
            this.lbColorFondo.Text = "Color de Fondo:";
            this.lbColorFondo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbColorFondo_LinkClicked);
            // 
            // lLetra
            // 
            this.lLetra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lLetra.AutoSize = true;
            this.lLetra.BackColor = System.Drawing.Color.Transparent;
            this.lLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLetra.Location = new System.Drawing.Point(174, 174);
            this.lLetra.Name = "lLetra";
            this.lLetra.Size = new System.Drawing.Size(64, 63);
            this.lLetra.TabIndex = 62;
            this.lLetra.Text = "A";
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point(182, 368);
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size(106, 23);
            this.bPredeterminados.TabIndex = 75;
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
            this.bCancelar.Location = new System.Drawing.Point(213, 397);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 74;
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
            this.bAceptar.Location = new System.Drawing.Point(8, 368);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 73;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLeft1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeft1.Location = new System.Drawing.Point(15, 321);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(42, 23);
            this.buttonLeft1.TabIndex = 71;
            this.buttonLeft1.Text = "<<";
            this.buttonLeft1.UseVisualStyleBackColor = true;
            this.buttonLeft1.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // buttonRigt1
            // 
            this.buttonRigt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRigt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRigt1.Location = new System.Drawing.Point(246, 321);
            this.buttonRigt1.Name = "buttonRigt1";
            this.buttonRigt1.Size = new System.Drawing.Size(42, 23);
            this.buttonRigt1.TabIndex = 72;
            this.buttonRigt1.Text = ">>";
            this.buttonRigt1.UseVisualStyleBackColor = true;
            this.buttonRigt1.Click += new System.EventHandler(this.derecha_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(8, 278);
            this.trackBar1.Maximum = 26;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(280, 45);
            this.trackBar1.TabIndex = 70;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            // 
            // comboBoxTecla
            // 
            this.comboBoxTecla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTecla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecla.FormattingEnabled = true;
            this.comboBoxTecla.Items.AddRange(new object[] {
            "[Espacio]",
            "[Enter]"});
            this.comboBoxTecla.Location = new System.Drawing.Point(198, 110);
            this.comboBoxTecla.Name = "comboBoxTecla";
            this.comboBoxTecla.Size = new System.Drawing.Size(87, 21);
            this.comboBoxTecla.TabIndex = 69;
            // 
            // numericUpDownOcultamiento
            // 
            this.numericUpDownOcultamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownOcultamiento.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownOcultamiento.Location = new System.Drawing.Point(198, 84);
            this.numericUpDownOcultamiento.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownOcultamiento.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownOcultamiento.Name = "numericUpDownOcultamiento";
            this.numericUpDownOcultamiento.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownOcultamiento.TabIndex = 65;
            this.numericUpDownOcultamiento.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Tecla de reacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Tiempo de ocultamiento (ms):";
            // 
            // numericUpDownVisualizacion
            // 
            this.numericUpDownVisualizacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownVisualizacion.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Location = new System.Drawing.Point(198, 58);
            this.numericUpDownVisualizacion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Name = "numericUpDownVisualizacion";
            this.numericUpDownVisualizacion.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownVisualizacion.TabIndex = 68;
            this.numericUpDownVisualizacion.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Tiempo de visualización (ms):";
            // 
            // numericUpDownEstimulos
            // 
            this.numericUpDownEstimulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEstimulos.Location = new System.Drawing.Point(198, 32);
            this.numericUpDownEstimulos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEstimulos.Name = "numericUpDownEstimulos";
            this.numericUpDownEstimulos.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownEstimulos.TabIndex = 66;
            this.numericUpDownEstimulos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Estímulos por bloque:";
            // 
            // numericUpDownBloques
            // 
            this.numericUpDownBloques.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBloques.Location = new System.Drawing.Point(198, 6);
            this.numericUpDownBloques.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBloques.Name = "numericUpDownBloques";
            this.numericUpDownBloques.Size = new System.Drawing.Size(87, 20);
            this.numericUpDownBloques.TabIndex = 67;
            this.numericUpDownBloques.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Bloques a mostrar:";
            // 
            // pbColor
            // 
            this.pbColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbColor.BackColor = System.Drawing.Color.Black;
            this.pbColor.Location = new System.Drawing.Point(127, 143);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(158, 123);
            this.pbColor.TabIndex = 76;
            this.pbColor.TabStop = false;
            // 
            // ConfASSLetrasColoresUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lIndexImage);
            this.Controls.Add(this.lbColorLetras);
            this.Controls.Add(this.lbColorFondo);
            this.Controls.Add(this.lLetra);
            this.Controls.Add(this.bPredeterminados);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.buttonLeft1);
            this.Controls.Add(this.buttonRigt1);
            this.Controls.Add(this.trackBar1);
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
            this.Controls.Add(this.pbColor);
            this.Name = "ConfASSLetrasColoresUC";
            this.Size = new System.Drawing.Size(293, 427);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOcultamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstimulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBloques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIndexImage;
        private System.Windows.Forms.LinkLabel lbColorLetras;
        private System.Windows.Forms.LinkLabel lbColorFondo;
        private System.Windows.Forms.Label lLetra;
        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button buttonLeft1;
        private System.Windows.Forms.Button buttonRigt1;
        private System.Windows.Forms.TrackBar trackBar1;
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
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
