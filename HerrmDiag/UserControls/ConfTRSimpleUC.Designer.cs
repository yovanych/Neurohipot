namespace HerrmDiag.UserControls
{
    partial class ConfTRSimpleUC
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
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFigura = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxTecla1 = new System.Windows.Forms.ComboBox();
            this.numericUpDownReaccion = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownVisualizacion = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownCantEstimulos = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantEstimulos)).BeginInit();
            this.SuspendLayout();
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point(168, 248);
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size(106, 23);
            this.bPredeterminados.TabIndex = 31;
            this.bPredeterminados.Text = "Predeterminados";
            this.bPredeterminados.UseVisualStyleBackColor = false;
            this.bPredeterminados.Click += new System.EventHandler(this.Predeterminados_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.DimGray;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(199, 277);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 30;
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
            this.bAceptar.Location = new System.Drawing.Point(6, 248);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 29;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.White;
            this.panelColor.Location = new System.Drawing.Point(149, 184);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(125, 21);
            this.panelColor.TabIndex = 28;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Color estímulo";
            // 
            // comboBoxFigura
            // 
            this.comboBoxFigura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFigura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFigura.FormattingEnabled = true;
            this.comboBoxFigura.Items.AddRange(new object[] {
            "Círculo",
            "Cuadrado",
            "Triángulo"});
            this.comboBoxFigura.Location = new System.Drawing.Point(6, 151);
            this.comboBoxFigura.Name = "comboBoxFigura";
            this.comboBoxFigura.Size = new System.Drawing.Size(131, 21);
            this.comboBoxFigura.TabIndex = 26;
            this.comboBoxFigura.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigura_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(149, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 88);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // comboBoxTecla1
            // 
            this.comboBoxTecla1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTecla1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTecla1.FormattingEnabled = true;
            this.comboBoxTecla1.Items.AddRange(new object[] {
            "[Espacio]",
            "[Enter]"});
            this.comboBoxTecla1.Location = new System.Drawing.Point(191, 213);
            this.comboBoxTecla1.Name = "comboBoxTecla1";
            this.comboBoxTecla1.Size = new System.Drawing.Size(83, 21);
            this.comboBoxTecla1.TabIndex = 24;
            // 
            // numericUpDownReaccion
            // 
            this.numericUpDownReaccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownReaccion.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownReaccion.Location = new System.Drawing.Point(191, 58);
            this.numericUpDownReaccion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownReaccion.Name = "numericUpDownReaccion";
            this.numericUpDownReaccion.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownReaccion.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estímulo:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tecla de reacción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tiempo de reacción (ms):";
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
            this.numericUpDownVisualizacion.Location = new System.Drawing.Point(191, 32);
            this.numericUpDownVisualizacion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVisualizacion.Name = "numericUpDownVisualizacion";
            this.numericUpDownVisualizacion.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownVisualizacion.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tiempo de visualización (ms):";
            // 
            // numericUpDownCantEstimulos
            // 
            this.numericUpDownCantEstimulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownCantEstimulos.Location = new System.Drawing.Point(191, 4);
            this.numericUpDownCantEstimulos.Name = "numericUpDownCantEstimulos";
            this.numericUpDownCantEstimulos.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownCantEstimulos.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cantidad máxima de estímulos:";
            // 
            // ConfTRSimpleUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bPredeterminados);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFigura);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxTecla1);
            this.Controls.Add(this.numericUpDownReaccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownVisualizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownCantEstimulos);
            this.Controls.Add(this.label1);
            this.Name = "ConfTRSimpleUC";
            this.Size = new System.Drawing.Size(280, 309);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownReaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVisualizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantEstimulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFigura;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTecla1;
        private System.Windows.Forms.NumericUpDown numericUpDownReaccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownVisualizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownCantEstimulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
