﻿namespace PsicoTests.Alejandro
{
    partial class MF_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point( 0, 0 );
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size( 672, 490 );
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler( this.panel_Paint );
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler( this.panel_MouseDown );
            // 
            // MF_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size( 672, 490 );
            this.Controls.Add( this.panel );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MF_Form";
            this.Text = "MF_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.MF_Form_KeyDown );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Panel panel;
    }
}