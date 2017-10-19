namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfMemoriaDeFiguras
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
            this.confMemoriaFigurasUC1 = new HerrmDiag.UserControls.ConfMemoriaFigurasUC();
            this.SuspendLayout();
            // 
            // confMemoriaFigurasUC1
            // 
            this.confMemoriaFigurasUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confMemoriaFigurasUC1.Location = new System.Drawing.Point( 1, 2 );
            this.confMemoriaFigurasUC1.Name = "confMemoriaFigurasUC1";
            this.confMemoriaFigurasUC1.ShowCancelButton = true;
            this.confMemoriaFigurasUC1.Size = new System.Drawing.Size( 309, 122 );
            this.confMemoriaFigurasUC1.TabIndex = 0;
            this.confMemoriaFigurasUC1.AfterAcept += new HerrmDiag.UserControls.ConfMemoriaFigurasUC.Clic_Delegate( this.bAceptar_Click );
            this.confMemoriaFigurasUC1.AfterPresets += new HerrmDiag.UserControls.ConfMemoriaFigurasUC.Clic_Delegate( this.bPredeterminados_Click );
            this.confMemoriaFigurasUC1.AfterCancel += new HerrmDiag.UserControls.ConfMemoriaFigurasUC.Clic_Delegate( this.bCancelar_Click );
            // 
            // FormConfMemoriaDeFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 312, 122 );
            this.Controls.Add( this.confMemoriaFigurasUC1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfMemoriaDeFiguras";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuración [Memoria de Figuras]";
            this.ResumeLayout( false );

        }

        #endregion

        private UserControls.ConfMemoriaFigurasUC confMemoriaFigurasUC1;

    }
}