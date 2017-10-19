namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfAtencionSostenidaSimpleLetras
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
            this.confASSLetrasUC1 = new HerrmDiag.UserControls.ConfASSLetrasUC();
            this.SuspendLayout();
            // 
            // confASSLetrasUC1
            // 
            this.confASSLetrasUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confASSLetrasUC1.Location = new System.Drawing.Point(1, 1);
            this.confASSLetrasUC1.Name = "confASSLetrasUC1";
            this.confASSLetrasUC1.ShowCancelButton = true;
            this.confASSLetrasUC1.Size = new System.Drawing.Size(293, 427);
            this.confASSLetrasUC1.TabIndex = 0;
            this.confASSLetrasUC1.AfterAcept += new HerrmDiag.UserControls.ConfASSLetrasUC.Clic_Delegate(this.bAceptar_Click_1);
            this.confASSLetrasUC1.AfterPresets += new HerrmDiag.UserControls.ConfASSLetrasUC.Clic_Delegate(this.bPredeterminados_Click);
            this.confASSLetrasUC1.AfterCancel += new HerrmDiag.UserControls.ConfASSLetrasUC.Clic_Delegate(this.bCancelar_Click_1);
            // 
            // FormConfAtencionSostenidaSimpleLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 426);
            this.Controls.Add(this.confASSLetrasUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfAtencionSostenidaSimpleLetras";
            this.Text = "Configuración [Atención Sostenida Simple]";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfASSLetrasUC confASSLetrasUC1;

    }
}