namespace PsicoTests.Yovany.ASC.Colores
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
            this.panel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point( 242, 155 );
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size( 332, 219 );
            this.panel.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler( this.timer_Tick );
            // 
            // FormASCL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size( 704, 482 );
            this.Controls.Add( this.panel );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormASCL";
            this.Text = "FormASC";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.FormASC_KeyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.FormASCL_KeyUp );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timer;
    }
}