namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormconfAmplitudMemoria
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
            this.confAmplitudMemoriaUC1 = new HerrmDiag.UserControls.ConfAmplitudMemoriaUC();
            this.SuspendLayout();
            // 
            // confAmplitudMemoriaUC1
            // 
            this.confAmplitudMemoriaUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.confAmplitudMemoriaUC1.Configuracion = null;
            this.confAmplitudMemoriaUC1.Location = new System.Drawing.Point(1, 2);
            this.confAmplitudMemoriaUC1.Name = "confAmplitudMemoriaUC1";
            this.confAmplitudMemoriaUC1.ShowCancelButton = true;
            this.confAmplitudMemoriaUC1.Size = new System.Drawing.Size(317, 181);
            this.confAmplitudMemoriaUC1.TabIndex = 0;
            this.confAmplitudMemoriaUC1.AfterAcept += new HerrmDiag.UserControls.ConfAmplitudMemoriaUC.Clic_Delegate(this.confAmplitudMemoriaUC1_AfterAcept);
            this.confAmplitudMemoriaUC1.AfterCancel += new HerrmDiag.UserControls.ConfAmplitudMemoriaUC.Clic_Delegate(this.confAmplitudMemoriaUC1_AfterCancel);
            // 
            // FormconfAmplitudMemoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 179);
            this.Controls.Add(this.confAmplitudMemoriaUC1);
            this.Name = "FormconfAmplitudMemoria";
            this.Text = "FormconfAmplitudMemoria";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ConfAmplitudMemoriaUC confAmplitudMemoriaUC1;
    }
}