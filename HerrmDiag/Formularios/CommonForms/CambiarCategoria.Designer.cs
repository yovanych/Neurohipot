namespace HerrmDiag.Formularios.CommonForms
{
    partial class CambiarCategoria
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
            this.groupBoxCategoria = new System.Windows.Forms.GroupBox();
            this.radioButtonApp = new System.Windows.Forms.RadioButton();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.buttonCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCategoria
            // 
            this.groupBoxCategoria.Controls.Add(this.radioButtonApp);
            this.groupBoxCategoria.Controls.Add(this.radioButtonAdmin);
            this.groupBoxCategoria.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCategoria.Name = "groupBoxCategoria";
            this.groupBoxCategoria.Size = new System.Drawing.Size(268, 60);
            this.groupBoxCategoria.TabIndex = 6;
            this.groupBoxCategoria.TabStop = false;
            // 
            // radioButtonApp
            // 
            this.radioButtonApp.AutoSize = true;
            this.radioButtonApp.Location = new System.Drawing.Point(6, 35);
            this.radioButtonApp.Name = "radioButtonApp";
            this.radioButtonApp.Size = new System.Drawing.Size(69, 17);
            this.radioButtonApp.TabIndex = 0;
            this.radioButtonApp.TabStop = true;
            this.radioButtonApp.Text = "Aplicador";
            this.radioButtonApp.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(6, 12);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(88, 17);
            this.radioButtonAdmin.TabIndex = 0;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administrador";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonCat
            // 
            this.buttonCat.BackColor = System.Drawing.Color.DimGray;
            this.buttonCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCat.ForeColor = System.Drawing.Color.White;
            this.buttonCat.Location = new System.Drawing.Point(205, 91);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(75, 23);
            this.buttonCat.TabIndex = 3;
            this.buttonCat.Text = "Cambiar";
            this.buttonCat.UseVisualStyleBackColor = false;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 124);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.groupBoxCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Categoria";
            this.groupBoxCategoria.ResumeLayout(false);
            this.groupBoxCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategoria;
        private System.Windows.Forms.RadioButton radioButtonApp;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button button1;
    }
}