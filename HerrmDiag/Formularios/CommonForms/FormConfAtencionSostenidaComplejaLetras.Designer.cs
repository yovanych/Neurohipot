namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfAtencionSostenidaComplejaLetras
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
            this.confASCLetrasUC1 = new HerrmDiag.UserControls.ConfASCLetrasUC();
            this.SuspendLayout();
            // 
            // confASCLetrasUC1
            // 
            this.confASCLetrasUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confASCLetrasUC1.Location = new System.Drawing.Point(0, 2);
            this.confASCLetrasUC1.Name = "confASCLetrasUC1";
            this.confASCLetrasUC1.ShowCancelButton = true;
            this.confASCLetrasUC1.Size = new System.Drawing.Size(283, 489);
            this.confASCLetrasUC1.TabIndex = 0;
            this.confASCLetrasUC1.AfterAcept += new HerrmDiag.UserControls.ConfASCLetrasUC.Clic_Delegate(this.bAceptar_Click);
            this.confASCLetrasUC1.AfterPresets += new HerrmDiag.UserControls.ConfASCLetrasUC.Clic_Delegate(this.buttonPredeterminados_Click);
            this.confASCLetrasUC1.AfterCancel += new HerrmDiag.UserControls.ConfASCLetrasUC.Clic_Delegate(this.bCancelar_Click_1);
            // 
            // FormConfAtencionSostenidaComplejaLetras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 488);
            this.Controls.Add(this.confASCLetrasUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfAtencionSostenidaComplejaLetras";
            this.ShowInTaskbar = false;
            this.Text = "Configuración [Atención Sostenida 2] (Letras)";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfASCLetrasUC confASCLetrasUC1;
    }
}