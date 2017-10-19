namespace HerrmDiag.TestAtencion
{
    partial class ActivationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ActivationForm ) );
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbActivacion = new System.Windows.Forms.TextBox();
            this.tbGeneracion = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.buttonExaminar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point( 21, 12 );
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size( 367, 96 );
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString( "richTextBox1.Text" );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 20, 133 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 166, 13 );
            this.label2.TabIndex = 5;
            this.label2.Text = "(localice el Fichero de Activación)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 20, 87 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 116, 13 );
            this.label1.TabIndex = 6;
            this.label1.Text = "Códico de Generación:";
            // 
            // tbActivacion
            // 
            this.tbActivacion.BackColor = System.Drawing.Color.White;
            this.tbActivacion.Enabled = false;
            this.tbActivacion.Location = new System.Drawing.Point( 21, 150 );
            this.tbActivacion.Name = "tbActivacion";
            this.tbActivacion.Size = new System.Drawing.Size( 271, 20 );
            this.tbActivacion.TabIndex = 3;
            this.tbActivacion.TextChanged += new System.EventHandler( this.tbActivación_TextChanged );
            // 
            // tbGeneracion
            // 
            this.tbGeneracion.BackColor = System.Drawing.Color.White;
            this.tbGeneracion.Location = new System.Drawing.Point( 21, 104 );
            this.tbGeneracion.Name = "tbGeneracion";
            this.tbGeneracion.ReadOnly = true;
            this.tbGeneracion.Size = new System.Drawing.Size( 354, 20 );
            this.tbGeneracion.TabIndex = 4;
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Location = new System.Drawing.Point( 21, 181 );
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size( 75, 23 );
            this.button.TabIndex = 7;
            this.button.Text = "Activar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler( this.button_Click );
            // 
            // buttonExaminar
            // 
            this.buttonExaminar.Location = new System.Drawing.Point( 300, 148 );
            this.buttonExaminar.Name = "buttonExaminar";
            this.buttonExaminar.Size = new System.Drawing.Size( 75, 23 );
            this.buttonExaminar.TabIndex = 7;
            this.buttonExaminar.Text = "Examinar...";
            this.buttonExaminar.UseVisualStyleBackColor = true;
            this.buttonExaminar.Click += new System.EventHandler( this.buttonExaminar_Click );
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Ficheros de Activación|*.arlic";
            // 
            // ActivationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 400, 215 );
            this.Controls.Add( this.buttonExaminar );
            this.Controls.Add( this.button );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.tbActivacion );
            this.Controls.Add( this.tbGeneracion );
            this.Controls.Add( this.richTextBox1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActivationForm";
            this.Text = "ActivationForm";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbActivacion;
        private System.Windows.Forms.TextBox tbGeneracion;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonExaminar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}