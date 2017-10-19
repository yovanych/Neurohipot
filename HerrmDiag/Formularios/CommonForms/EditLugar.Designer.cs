namespace HerrmDiag.Formularios.CommonForms
{
    partial class EditLugar
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.buttonAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 21 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 90, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del lugar:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point( 112, 18 );
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size( 242, 20 );
            this.tbNombre.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12, 47 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 66, 13 );
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point( 112, 44 );
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDescripcion.Size = new System.Drawing.Size( 242, 109 );
            this.tbDescripcion.TabIndex = 1;
            // 
            // buttonAction
            // 
            this.buttonAction.BackColor = System.Drawing.Color.DimGray;
            this.buttonAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction.ForeColor = System.Drawing.Color.White;
            this.buttonAction.Location = new System.Drawing.Point( 15, 172 );
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size( 75, 23 );
            this.buttonAction.TabIndex = 2;
            this.buttonAction.Text = "Agregar";
            this.buttonAction.UseVisualStyleBackColor = false;
            this.buttonAction.Click += new System.EventHandler( this.buttonAction_Click );
            // 
            // EditLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 377, 204 );
            this.Controls.Add( this.buttonAction );
            this.Controls.Add( this.tbDescripcion );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.tbNombre );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditLugar";
            this.Text = "EditLugar";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Button buttonAction;
    }
}