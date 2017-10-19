namespace ActiveCodeGenerator
{
    partial class ActiveMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ActiveMainForm ) );
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbGeneracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject( "pictureBox1.BackgroundImage" )));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point( 7, 7 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 205, 176 );
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbGeneracion
            // 
            this.tbGeneracion.Location = new System.Drawing.Point( 229, 32 );
            this.tbGeneracion.Name = "tbGeneracion";
            this.tbGeneracion.Size = new System.Drawing.Size( 302, 20 );
            this.tbGeneracion.TabIndex = 1;
            this.tbGeneracion.TextChanged += new System.EventHandler( this.tbGeneracion_TextChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 228, 15 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 116, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Códico de Generación:";
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Location = new System.Drawing.Point( 232, 58 );
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size( 98, 33 );
            this.button.TabIndex = 3;
            this.button.Text = "Generar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler( this.button_Click );
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font( "Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.labelMensaje.ForeColor = System.Drawing.Color.Red;
            this.labelMensaje.Location = new System.Drawing.Point( 228, 136 );
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size( 0, 16 );
            this.labelMensaje.TabIndex = 4;
            // 
            // TestButton
            // 
            this.TestButton.Enabled = false;
            this.TestButton.Location = new System.Drawing.Point( 456, 68 );
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size( 75, 23 );
            this.TestButton.TabIndex = 5;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler( this.TestButton_Click );
            // 
            // ActiveMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 545, 190 );
            this.Controls.Add( this.TestButton );
            this.Controls.Add( this.labelMensaje );
            this.Controls.Add( this.button );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.tbGeneracion );
            this.Controls.Add( this.pictureBox1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActiveMainForm";
            this.Text = "Generador de código de activación";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbGeneracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button TestButton;
    }
}

