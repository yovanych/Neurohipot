namespace HerrmDiag.Formularios
{
    partial class FormConfTiempoReaccionCompleja
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.confTRComplejaUC1 = new HerrmDiag.UserControls.ConfTRComplejaUC();
            this.SuspendLayout();
            // 
            // confTRComplejaUC1
            // 
            this.confTRComplejaUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confTRComplejaUC1.Configuracion = null;
            this.confTRComplejaUC1.Location = new System.Drawing.Point(0, 0);
            this.confTRComplejaUC1.Name = "confTRComplejaUC1";
            this.confTRComplejaUC1.ShowCancelButton = true;
            this.confTRComplejaUC1.Size = new System.Drawing.Size(275, 370);
            this.confTRComplejaUC1.TabIndex = 0;
            this.confTRComplejaUC1.AfterAcept += new HerrmDiag.UserControls.ConfTRComplejaUC.Clic_Delegate(this.bAceptar_Click);
            this.confTRComplejaUC1.AfterPresets += new HerrmDiag.UserControls.ConfTRComplejaUC.Clic_Delegate(this.buttonPredeterminados_Click);
            this.confTRComplejaUC1.AfterCancel += new HerrmDiag.UserControls.ConfTRComplejaUC.Clic_Delegate(this.bCancel_Click);
            // 
            // FormConfTiempoReaccionCompleja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 367);
            this.Controls.Add(this.confTRComplejaUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfTiempoReaccionCompleja";
            this.ShowInTaskbar = false;
            this.Text = "Configuración [Tiempo Reacción 2]";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private UserControls.ConfTRComplejaUC confTRComplejaUC1;
    }
}