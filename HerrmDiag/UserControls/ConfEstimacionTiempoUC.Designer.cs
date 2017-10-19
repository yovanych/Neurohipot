namespace HerrmDiag.UserControls
{
    partial class ConfEstimacionTiempoUC
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
            this.nudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.nudMaxEstimulos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAnchoEstimulo = new System.Windows.Forms.NumericUpDown();
            this.nudAltoEstimulo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAnchoZonaOpaca = new System.Windows.Forms.NumericUpDown();
            this.nudAnchoRespCorrecta = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pColorEstimulo = new System.Windows.Forms.Panel();
            this.pColorZonaOp = new System.Windows.Forms.Panel();
            this.cbTecla = new System.Windows.Forms.ComboBox();
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEstimulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoEstimulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltoEstimulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoZonaOpaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoRespCorrecta)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntervalo.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudIntervalo.Location = new System.Drawing.Point(177, 30);
            this.nudIntervalo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalo.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudIntervalo.Name = "nudIntervalo";
            this.nudIntervalo.Size = new System.Drawing.Size(68, 20);
            this.nudIntervalo.TabIndex = 18;
            this.nudIntervalo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMaxEstimulos
            // 
            this.nudMaxEstimulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMaxEstimulos.Location = new System.Drawing.Point(177, 4);
            this.nudMaxEstimulos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMaxEstimulos.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMaxEstimulos.Name = "nudMaxEstimulos";
            this.nudMaxEstimulos.Size = new System.Drawing.Size(68, 20);
            this.nudMaxEstimulos.TabIndex = 15;
            this.nudMaxEstimulos.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tiempo de intervalo (ms):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cantidad máxima de estímulos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ancho de estímulo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Alto de estímulo:";
            // 
            // nudAnchoEstimulo
            // 
            this.nudAnchoEstimulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAnchoEstimulo.Location = new System.Drawing.Point(177, 56);
            this.nudAnchoEstimulo.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudAnchoEstimulo.Minimum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudAnchoEstimulo.Name = "nudAnchoEstimulo";
            this.nudAnchoEstimulo.Size = new System.Drawing.Size(68, 20);
            this.nudAnchoEstimulo.TabIndex = 15;
            this.nudAnchoEstimulo.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // nudAltoEstimulo
            // 
            this.nudAltoEstimulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAltoEstimulo.Location = new System.Drawing.Point(177, 82);
            this.nudAltoEstimulo.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAltoEstimulo.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAltoEstimulo.Name = "nudAltoEstimulo";
            this.nudAltoEstimulo.Size = new System.Drawing.Size(68, 20);
            this.nudAltoEstimulo.TabIndex = 18;
            this.nudAltoEstimulo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ancho de zona opaca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ancho de respuesta correcta:";
            // 
            // nudAnchoZonaOpaca
            // 
            this.nudAnchoZonaOpaca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAnchoZonaOpaca.Location = new System.Drawing.Point(177, 108);
            this.nudAnchoZonaOpaca.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nudAnchoZonaOpaca.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudAnchoZonaOpaca.Name = "nudAnchoZonaOpaca";
            this.nudAnchoZonaOpaca.Size = new System.Drawing.Size(68, 20);
            this.nudAnchoZonaOpaca.TabIndex = 15;
            this.nudAnchoZonaOpaca.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudAnchoRespCorrecta
            // 
            this.nudAnchoRespCorrecta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudAnchoRespCorrecta.Location = new System.Drawing.Point(177, 134);
            this.nudAnchoRespCorrecta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudAnchoRespCorrecta.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudAnchoRespCorrecta.Name = "nudAnchoRespCorrecta";
            this.nudAnchoRespCorrecta.Size = new System.Drawing.Size(68, 20);
            this.nudAnchoRespCorrecta.TabIndex = 18;
            this.nudAnchoRespCorrecta.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color del estímulo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Color de la zona opaca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tecla de reacción:";
            // 
            // pColorEstimulo
            // 
            this.pColorEstimulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pColorEstimulo.BackColor = System.Drawing.Color.White;
            this.pColorEstimulo.Location = new System.Drawing.Point(177, 160);
            this.pColorEstimulo.Name = "pColorEstimulo";
            this.pColorEstimulo.Size = new System.Drawing.Size(68, 28);
            this.pColorEstimulo.TabIndex = 19;
            this.pColorEstimulo.Click += new System.EventHandler(this.pColor_Click);
            // 
            // pColorZonaOp
            // 
            this.pColorZonaOp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pColorZonaOp.BackColor = System.Drawing.Color.Red;
            this.pColorZonaOp.Location = new System.Drawing.Point(177, 194);
            this.pColorZonaOp.Name = "pColorZonaOp";
            this.pColorZonaOp.Size = new System.Drawing.Size(68, 28);
            this.pColorZonaOp.TabIndex = 19;
            this.pColorZonaOp.Click += new System.EventHandler(this.pColor_Click);
            // 
            // cbTecla
            // 
            this.cbTecla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTecla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecla.FormattingEnabled = true;
            this.cbTecla.Items.AddRange(new object[] {
            "[Espacio]",
            "[Enter]"});
            this.cbTecla.Location = new System.Drawing.Point(177, 228);
            this.cbTecla.Name = "cbTecla";
            this.cbTecla.Size = new System.Drawing.Size(68, 21);
            this.cbTecla.TabIndex = 37;
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point(139, 265);
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size(106, 23);
            this.bPredeterminados.TabIndex = 40;
            this.bPredeterminados.Text = "Predeterminados";
            this.bPredeterminados.UseVisualStyleBackColor = false;
            this.bPredeterminados.Click += new System.EventHandler(this.Predeterminados_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.DimGray;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point(170, 294);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 39;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.DimGray;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.ForeColor = System.Drawing.Color.White;
            this.bAceptar.Location = new System.Drawing.Point(6, 265);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 38;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // ConfEstimacionTiempoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bPredeterminados);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.cbTecla);
            this.Controls.Add(this.pColorZonaOp);
            this.Controls.Add(this.pColorEstimulo);
            this.Controls.Add(this.nudAnchoRespCorrecta);
            this.Controls.Add(this.nudAltoEstimulo);
            this.Controls.Add(this.nudIntervalo);
            this.Controls.Add(this.nudAnchoZonaOpaca);
            this.Controls.Add(this.nudAnchoEstimulo);
            this.Controls.Add(this.nudMaxEstimulos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfEstimacionTiempoUC";
            this.Size = new System.Drawing.Size(255, 325);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxEstimulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoEstimulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltoEstimulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoZonaOpaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnchoRespCorrecta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIntervalo;
        private System.Windows.Forms.NumericUpDown nudMaxEstimulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAnchoEstimulo;
        private System.Windows.Forms.NumericUpDown nudAltoEstimulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAnchoZonaOpaca;
        private System.Windows.Forms.NumericUpDown nudAnchoRespCorrecta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pColorEstimulo;
        private System.Windows.Forms.Panel pColorZonaOp;
        private System.Windows.Forms.ComboBox cbTecla;
        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
