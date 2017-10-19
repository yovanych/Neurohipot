namespace PsicoTests.Yovany.ASS.Homogeneas
{
    partial class FormASSL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary

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
            this.components = new System.ComponentModel.Container();
            this.timer_muestra = new System.Windows.Forms.Timer( this.components );
            this.timer_contador = new System.Windows.Forms.Timer( this.components );
            this.label = new System.Windows.Forms.Label();
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_muestra
            // 
            this.timer_muestra.Enabled = true;
            this.timer_muestra.Interval = 500;
            this.timer_muestra.Tick += new System.EventHandler( this.timer_muestra_Tick_1 );
            // 
            // timer_contador
            // 
            this.timer_contador.Interval = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font( "Microsoft Sans Serif", 180F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label.Location = new System.Drawing.Point( 274, 215 );
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size( 0, 272 );
            this.label.TabIndex = 0;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.BackColor = System.Drawing.Color.White;
            this.Feedback.Location = new System.Drawing.Point( 58, 425 );
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size( 55, 13 );
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "Feedback";
            // 
            // FormASSL
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size( 696, 474 );
            this.Controls.Add( this.Feedback );
            this.Controls.Add( this.label );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormASSL";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.FormASSL_KeyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.FormASSL_KeyUp );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_muestra;
        private System.Windows.Forms.Timer timer_contador;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label Feedback;
    }
}