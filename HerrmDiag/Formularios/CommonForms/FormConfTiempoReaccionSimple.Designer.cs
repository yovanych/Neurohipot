namespace HerrmDiag.Formularios
{
    partial class FormConfTiempoReaccionSimple
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
            this.confTRSimpleUC1 = new HerrmDiag.UserControls.ConfTRSimpleUC();
            this.SuspendLayout();
            // 
            // confTRSimpleUC1
            // 
            this.confTRSimpleUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confTRSimpleUC1.Configuracion = null;
            this.confTRSimpleUC1.Location = new System.Drawing.Point(0, 1);
            this.confTRSimpleUC1.Name = "confTRSimpleUC1";
            this.confTRSimpleUC1.ShowCancelButton = true;
            this.confTRSimpleUC1.Size = new System.Drawing.Size(280, 309);
            this.confTRSimpleUC1.TabIndex = 0;
            this.confTRSimpleUC1.AfterAcept += new HerrmDiag.UserControls.ConfTRSimpleUC.Clic_Delegate(this.bAceptar_Click);
            this.confTRSimpleUC1.AfterPresets += new HerrmDiag.UserControls.ConfTRSimpleUC.Clic_Delegate(this.buttonPredeterminados_Click);
            this.confTRSimpleUC1.AfterCancel += new HerrmDiag.UserControls.ConfTRSimpleUC.Clic_Delegate(this.bCancelar_Click);
            // 
            // FormConfTiempoReaccionSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 310);
            this.Controls.Add(this.confTRSimpleUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfTiempoReaccionSimple";
            this.ShowInTaskbar = false;
            this.Text = "Configuración [Tiempo Reacción 1]";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfTRSimpleUC confTRSimpleUC1;
    }
}