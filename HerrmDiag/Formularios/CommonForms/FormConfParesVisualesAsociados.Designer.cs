namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormConfParesVisualesAsociados
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
            this.confParesVisualesAsociadosUC1 = new HerrmDiag.UserControls.ConfParesVisualesAsociadosUC();
            this.SuspendLayout();
            // 
            // confParesVisualesAsociadosUC1
            // 
            this.confParesVisualesAsociadosUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confParesVisualesAsociadosUC1.Location = new System.Drawing.Point( 0, 2 );
            this.confParesVisualesAsociadosUC1.Name = "confParesVisualesAsociadosUC1";
            this.confParesVisualesAsociadosUC1.ShowCancelButton = true;
            this.confParesVisualesAsociadosUC1.Size = new System.Drawing.Size( 298, 234 );
            this.confParesVisualesAsociadosUC1.TabIndex = 0;
            this.confParesVisualesAsociadosUC1.AfterAcept += new HerrmDiag.UserControls.ConfParesVisualesAsociadosUC.Clic_Delegate( this.bAceptar_Click );
            this.confParesVisualesAsociadosUC1.AfterPresets += new HerrmDiag.UserControls.ConfParesVisualesAsociadosUC.Clic_Delegate( this.buttonPredeterminados_Click );
            this.confParesVisualesAsociadosUC1.AfterCancel += new HerrmDiag.UserControls.ConfParesVisualesAsociadosUC.Clic_Delegate( this.bCancelar_Click );
            // 
            // FormConfParesVisualesAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 296, 236 );
            this.Controls.Add( this.confParesVisualesAsociadosUC1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfParesVisualesAsociados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Configuración [Pares Visuales Asociados]";
            this.ResumeLayout( false );

        }

        #endregion

        private UserControls.ConfParesVisualesAsociadosUC confParesVisualesAsociadosUC1;
    }
}