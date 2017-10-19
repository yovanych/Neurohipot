namespace HerrmDiag.Formularios.CommonForms
{
    partial class CambiarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPass));
            this.groupBoxContrasenna = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.label6_ = new System.Windows.Forms.Label();
            this.label7_ = new System.Windows.Forms.Label();
            this.label8_ = new System.Windows.Forms.Label();
            this.textBoxRepPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxPassAnt = new System.Windows.Forms.TextBox();
            this.groupBoxContrasenna.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContrasenna
            // 
            this.groupBoxContrasenna.Controls.Add(this.buttonCancel);
            this.groupBoxContrasenna.Controls.Add(this.buttonCambiar);
            this.groupBoxContrasenna.Controls.Add(this.label6_);
            this.groupBoxContrasenna.Controls.Add(this.label7_);
            this.groupBoxContrasenna.Controls.Add(this.label8_);
            this.groupBoxContrasenna.Controls.Add(this.textBoxRepPass);
            this.groupBoxContrasenna.Controls.Add(this.textBoxNewPass);
            this.groupBoxContrasenna.Controls.Add(this.textBoxPassAnt);
            this.groupBoxContrasenna.Location = new System.Drawing.Point(24, 3);
            this.groupBoxContrasenna.Name = "groupBoxContrasenna";
            this.groupBoxContrasenna.Size = new System.Drawing.Size(217, 183);
            this.groupBoxContrasenna.TabIndex = 4;
            this.groupBoxContrasenna.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.DimGray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(9, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.BackColor = System.Drawing.Color.DimGray;
            this.buttonCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiar.ForeColor = System.Drawing.Color.White;
            this.buttonCambiar.Location = new System.Drawing.Point(101, 143);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(99, 23);
            this.buttonCambiar.TabIndex = 3;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.UseVisualStyleBackColor = false;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // label6_
            // 
            this.label6_.AutoSize = true;
            this.label6_.Location = new System.Drawing.Point(7, 101);
            this.label6_.Name = "label6_";
            this.label6_.Size = new System.Drawing.Size(144, 13);
            this.label6_.TabIndex = 1;
            this.label6_.Text = "Repita la Contraseña Nueva:";
            // 
            // label7_
            // 
            this.label7_.AutoSize = true;
            this.label7_.Location = new System.Drawing.Point(6, 62);
            this.label7_.Name = "label7_";
            this.label7_.Size = new System.Drawing.Size(102, 13);
            this.label7_.TabIndex = 1;
            this.label7_.Text = "Contraseña Nueva: ";
            // 
            // label8_
            // 
            this.label8_.AutoSize = true;
            this.label8_.Location = new System.Drawing.Point(6, 23);
            this.label8_.Name = "label8_";
            this.label8_.Size = new System.Drawing.Size(103, 13);
            this.label8_.TabIndex = 1;
            this.label8_.Text = "Contraseña Antigua:";
            // 
            // textBoxRepPass
            // 
            this.textBoxRepPass.Location = new System.Drawing.Point(10, 117);
            this.textBoxRepPass.Name = "textBoxRepPass";
            this.textBoxRepPass.PasswordChar = '®';
            this.textBoxRepPass.Size = new System.Drawing.Size(190, 20);
            this.textBoxRepPass.TabIndex = 2;
            this.textBoxRepPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxRepPass_KeyDown);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(10, 78);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '®';
            this.textBoxNewPass.Size = new System.Drawing.Size(190, 20);
            this.textBoxNewPass.TabIndex = 1;
            // 
            // textBoxPassAnt
            // 
            this.textBoxPassAnt.Location = new System.Drawing.Point(10, 39);
            this.textBoxPassAnt.Name = "textBoxPassAnt";
            this.textBoxPassAnt.PasswordChar = '®';
            this.textBoxPassAnt.Size = new System.Drawing.Size(190, 20);
            this.textBoxPassAnt.TabIndex = 0;
            // 
            // CambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 194);
            this.Controls.Add(this.groupBoxContrasenna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarPass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar contraseña";
            this.groupBoxContrasenna.ResumeLayout(false);
            this.groupBoxContrasenna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxContrasenna;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Label label6_;
        private System.Windows.Forms.Label label7_;
        private System.Windows.Forms.Label label8_;
        private System.Windows.Forms.TextBox textBoxRepPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxPassAnt;

    }
}