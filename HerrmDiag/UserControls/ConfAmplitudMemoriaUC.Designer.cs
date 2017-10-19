namespace HerrmDiag.UserControls
{
    partial class ConfAmplitudMemoriaUC
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
            this.nudExposicion = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTiempoReaccion = new System.Windows.Forms.NumericUpDown();
            this.nudErrores = new System.Windows.Forms.NumericUpDown();
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoReaccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // nudIntervalo
            // 
            this.nudIntervalo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudIntervalo.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIntervalo.Location = new System.Drawing.Point(224, 29);
            this.nudIntervalo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudIntervalo.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudIntervalo.Name = "nudIntervalo";
            this.nudIntervalo.Size = new System.Drawing.Size(77, 20);
            this.nudIntervalo.TabIndex = 18;
            this.nudIntervalo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudExposicion
            // 
            this.nudExposicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudExposicion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudExposicion.Location = new System.Drawing.Point(224, 3);
            this.nudExposicion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudExposicion.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudExposicion.Name = "nudExposicion";
            this.nudExposicion.Size = new System.Drawing.Size(77, 20);
            this.nudExposicion.TabIndex = 15;
            this.nudExposicion.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tiempo de intervalo (mseg):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tiempo exposición del dígito (mseg):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tiempo de reacción (mseg):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad de errores posibles:";
            // 
            // nudTiempoReaccion
            // 
            this.nudTiempoReaccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTiempoReaccion.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTiempoReaccion.Location = new System.Drawing.Point(224, 55);
            this.nudTiempoReaccion.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTiempoReaccion.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTiempoReaccion.Name = "nudTiempoReaccion";
            this.nudTiempoReaccion.Size = new System.Drawing.Size(77, 20);
            this.nudTiempoReaccion.TabIndex = 15;
            this.nudTiempoReaccion.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudErrores
            // 
            this.nudErrores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nudErrores.Enabled = false;
            this.nudErrores.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudErrores.Location = new System.Drawing.Point(224, 81);
            this.nudErrores.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudErrores.Name = "nudErrores";
            this.nudErrores.Size = new System.Drawing.Size(77, 20);
            this.nudErrores.TabIndex = 18;
            this.nudErrores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point(195, 116);
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size(106, 23);
            this.bPredeterminados.TabIndex = 21;
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
            this.bCancelar.Location = new System.Drawing.Point(226, 145);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 20;
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
            this.bAceptar.Location = new System.Drawing.Point(3, 116);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 19;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // ConfAmplitudMemoriaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bPredeterminados);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.nudErrores);
            this.Controls.Add(this.nudIntervalo);
            this.Controls.Add(this.nudTiempoReaccion);
            this.Controls.Add(this.nudExposicion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConfAmplitudMemoriaUC";
            this.Size = new System.Drawing.Size(310, 178);
            ((System.ComponentModel.ISupportInitialize)(this.nudIntervalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempoReaccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudIntervalo;
        private System.Windows.Forms.NumericUpDown nudExposicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTiempoReaccion;
        private System.Windows.Forms.NumericUpDown nudErrores;
        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
    }
}
