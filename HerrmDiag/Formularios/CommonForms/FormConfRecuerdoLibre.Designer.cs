namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfRecuerdoLibre
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
            this.confRecuerdoLibreUC1 = new HerrmDiag.UserControls.ConfRecuerdoLibreUC();
            this.SuspendLayout();
            // 
            // confRecuerdoLibreUC1
            // 
            this.confRecuerdoLibreUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confRecuerdoLibreUC1.Configuracion = null;
            this.confRecuerdoLibreUC1.Location = new System.Drawing.Point(0, -2);
            this.confRecuerdoLibreUC1.Name = "confRecuerdoLibreUC1";
            this.confRecuerdoLibreUC1.ShowCancelButton = true;
            this.confRecuerdoLibreUC1.Size = new System.Drawing.Size(356, 341);
            this.confRecuerdoLibreUC1.TabIndex = 0;
            this.confRecuerdoLibreUC1.AfterAcept += new HerrmDiag.UserControls.ConfRecuerdoLibreUC.Clic_Delegate(this.bAceptar_Click);
            this.confRecuerdoLibreUC1.AfterPresets += new HerrmDiag.UserControls.ConfRecuerdoLibreUC.Clic_Delegate(this.buttonPredeterminados_Click);
            this.confRecuerdoLibreUC1.AfterCancel += new HerrmDiag.UserControls.ConfRecuerdoLibreUC.Clic_Delegate(this.bCancel_Click);
            // 
            // FormConfRecuerdoLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 339);
            this.Controls.Add(this.confRecuerdoLibreUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfRecuerdoLibre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración [Aprendizaje de Palabras]";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfRecuerdoLibreUC confRecuerdoLibreUC1;

    }
}