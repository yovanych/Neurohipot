namespace PsicoTests.Yovany.ASC.Homogeneas
{
    partial class FormASCL
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
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer( this.components );
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font( "Microsoft Sans Serif", 180F );
            this.label.Location = new System.Drawing.Point( 327, 77 );
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size( 0, 272 );
            this.label.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler( this.timer_Tick );
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.BackColor = System.Drawing.Color.White;
            this.Feedback.Location = new System.Drawing.Point( 322, 355 );
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size( 55, 13 );
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "Feedback";
            // 
            // FormASCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 690, 400 );
            this.Controls.Add( this.Feedback );
            this.Controls.Add( this.label );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormASCL";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.FormASCL_KeyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.FormASCL_KeyUp );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Feedback;
    }
}