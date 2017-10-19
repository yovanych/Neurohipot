namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfAtencionSostenidaSimple
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
            this.confASSImagenesUC1 = new HerrmDiag.UserControls.ConfASSImagenesUC();
            this.SuspendLayout();
            // 
            // confASSImagenesUC1
            // 
            this.confASSImagenesUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confASSImagenesUC1.Location = new System.Drawing.Point(1, 1);
            this.confASSImagenesUC1.Name = "confASSImagenesUC1";
            this.confASSImagenesUC1.ShowCancelButton = true;
            this.confASSImagenesUC1.Size = new System.Drawing.Size(288, 468);
            this.confASSImagenesUC1.TabIndex = 0;
            this.confASSImagenesUC1.AfterAcept += new HerrmDiag.UserControls.ConfASSImagenesUC.Clic_Delegate(this.bAceptar_Click);
            this.confASSImagenesUC1.AfterPresets += new HerrmDiag.UserControls.ConfASSImagenesUC.Clic_Delegate(this.buttonPredeterminados_Click);
            this.confASSImagenesUC1.AfterCancel += new HerrmDiag.UserControls.ConfASSImagenesUC.Clic_Delegate(this.bCancel_Click_1);
            // 
            // FormConfAtencionSostenidaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 467);
            this.Controls.Add(this.confASSImagenesUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfAtencionSostenidaSimple";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración [Atención Sostenida 1]";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfASSImagenesUC confASSImagenesUC1;

    }
}