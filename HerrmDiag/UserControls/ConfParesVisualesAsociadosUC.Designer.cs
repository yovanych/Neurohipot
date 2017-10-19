namespace HerrmDiag.UserControls
{
    partial class ConfParesVisualesAsociadosUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.panelColor6 = new System.Windows.Forms.Panel();
            this.panelColor5 = new System.Windows.Forms.Panel();
            this.panelColor4 = new System.Windows.Forms.Panel();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bPredeterminados = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Increment = new decimal( new int[] {
            100,
            0,
            0,
            0} );
            this.numericUpDown2.Location = new System.Drawing.Point( 206, 26 );
            this.numericUpDown2.Maximum = new decimal( new int[] {
            2147483647,
            0,
            0,
            0} );
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size( 84, 20 );
            this.numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Increment = new decimal( new int[] {
            100,
            0,
            0,
            0} );
            this.numericUpDown1.Location = new System.Drawing.Point( 206, 4 );
            this.numericUpDown1.Maximum = new decimal( new int[] {
            2147483647,
            0,
            0,
            0} );
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size( 84, 20 );
            this.numericUpDown1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 3, 28 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 190, 13 );
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiempo exposición de la muestra (seg):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 3, 6 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 159, 13 );
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiempo exposición del par (seg):";
            // 
            // panelColor2
            // 
            this.panelColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor2.BackColor = System.Drawing.Color.Blue;
            this.panelColor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor2.Location = new System.Drawing.Point( 229, 57 );
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor2.TabIndex = 13;
            this.panelColor2.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // panelColor1
            // 
            this.panelColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor1.BackColor = System.Drawing.Color.Red;
            this.panelColor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor1.Location = new System.Drawing.Point( 150, 57 );
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor1.TabIndex = 12;
            this.panelColor1.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // panelColor6
            // 
            this.panelColor6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor6.BackColor = System.Drawing.Color.Cyan;
            this.panelColor6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor6.Location = new System.Drawing.Point( 229, 127 );
            this.panelColor6.Name = "panelColor6";
            this.panelColor6.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor6.TabIndex = 14;
            this.panelColor6.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // panelColor5
            // 
            this.panelColor5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor5.BackColor = System.Drawing.Color.Magenta;
            this.panelColor5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor5.Location = new System.Drawing.Point( 150, 127 );
            this.panelColor5.Name = "panelColor5";
            this.panelColor5.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor5.TabIndex = 15;
            this.panelColor5.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // panelColor4
            // 
            this.panelColor4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor4.BackColor = System.Drawing.Color.Green;
            this.panelColor4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor4.Location = new System.Drawing.Point( 229, 92 );
            this.panelColor4.Name = "panelColor4";
            this.panelColor4.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor4.TabIndex = 10;
            this.panelColor4.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // panelColor3
            // 
            this.panelColor3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor3.BackColor = System.Drawing.Color.Yellow;
            this.panelColor3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelColor3.Location = new System.Drawing.Point( 150, 92 );
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size( 61, 29 );
            this.panelColor3.TabIndex = 11;
            this.panelColor3.Click += new System.EventHandler( this.panelColor_Click );
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 72, 99 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 45, 13 );
            this.label3.TabIndex = 9;
            this.label3.Text = "Colores:";
            // 
            // bPredeterminados
            // 
            this.bPredeterminados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPredeterminados.BackColor = System.Drawing.Color.DimGray;
            this.bPredeterminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPredeterminados.ForeColor = System.Drawing.Color.White;
            this.bPredeterminados.Location = new System.Drawing.Point( 184, 172 );
            this.bPredeterminados.Name = "bPredeterminados";
            this.bPredeterminados.Size = new System.Drawing.Size( 106, 23 );
            this.bPredeterminados.TabIndex = 18;
            this.bPredeterminados.Text = "Predeterminados";
            this.bPredeterminados.UseVisualStyleBackColor = false;
            this.bPredeterminados.Click += new System.EventHandler( this.Predeterminados_Click );
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.BackColor = System.Drawing.Color.DimGray;
            this.bCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelar.ForeColor = System.Drawing.Color.White;
            this.bCancelar.Location = new System.Drawing.Point( 215, 201 );
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size( 75, 23 );
            this.bCancelar.TabIndex = 17;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = false;
            this.bCancelar.Click += new System.EventHandler( this.Cancel_Click );
            // 
            // bAceptar
            // 
            this.bAceptar.BackColor = System.Drawing.Color.DimGray;
            this.bAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAceptar.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.bAceptar.ForeColor = System.Drawing.Color.White;
            this.bAceptar.Location = new System.Drawing.Point( 6, 172 );
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size( 75, 23 );
            this.bAceptar.TabIndex = 16;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = false;
            this.bAceptar.Click += new System.EventHandler( this.Aceptar_Click );
            // 
            // ConfParesVisualesAsociadosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.bPredeterminados );
            this.Controls.Add( this.bCancelar );
            this.Controls.Add( this.bAceptar );
            this.Controls.Add( this.numericUpDown2 );
            this.Controls.Add( this.numericUpDown1 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.panelColor2 );
            this.Controls.Add( this.panelColor1 );
            this.Controls.Add( this.panelColor6 );
            this.Controls.Add( this.panelColor5 );
            this.Controls.Add( this.panelColor4 );
            this.Controls.Add( this.panelColor3 );
            this.Controls.Add( this.label3 );
            this.Name = "ConfParesVisualesAsociadosUC";
            this.Size = new System.Drawing.Size( 298, 234 );
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor6;
        private System.Windows.Forms.Panel panelColor5;
        private System.Windows.Forms.Panel panelColor4;
        private System.Windows.Forms.Panel panelColor3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bPredeterminados;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}
