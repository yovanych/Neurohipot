namespace HerrmDiag.UserControls
{
    partial class TestInformationUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDesc = new System.Windows.Forms.TabPage();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.tabPageConf = new System.Windows.Forms.TabPage();
            this.richTextBoxConf = new System.Windows.Forms.RichTextBox();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.tabControl.SuspendLayout();
            this.tabPageDesc.SuspendLayout();
            this.tabPageConf.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add( this.tabPageDesc );
            this.tabControl.Controls.Add( this.tabPageConf );
            this.tabControl.Controls.Add( this.tabPageResult );
            this.tabControl.Location = new System.Drawing.Point( 3, 3 );
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size( 470, 383 );
            this.tabControl.TabIndex = 2;
            // 
            // tabPageDesc
            // 
            this.tabPageDesc.Controls.Add( this.richTextBoxDesc );
            this.tabPageDesc.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageDesc.Name = "tabPageDesc";
            this.tabPageDesc.Padding = new System.Windows.Forms.Padding( 15 );
            this.tabPageDesc.Size = new System.Drawing.Size( 462, 357 );
            this.tabPageDesc.TabIndex = 1;
            this.tabPageDesc.Text = "Descripción";
            this.tabPageDesc.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.BackColor = System.Drawing.Color.White;
            this.richTextBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDesc.Location = new System.Drawing.Point( 15, 15 );
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.ReadOnly = true;
            this.richTextBoxDesc.Size = new System.Drawing.Size( 432, 327 );
            this.richTextBoxDesc.TabIndex = 2;
            this.richTextBoxDesc.Text = "";
            // 
            // tabPageConf
            // 
            this.tabPageConf.Controls.Add( this.richTextBoxConf );
            this.tabPageConf.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageConf.Name = "tabPageConf";
            this.tabPageConf.Padding = new System.Windows.Forms.Padding( 15 );
            this.tabPageConf.Size = new System.Drawing.Size( 462, 357 );
            this.tabPageConf.TabIndex = 2;
            this.tabPageConf.Text = "Configuración";
            this.tabPageConf.UseVisualStyleBackColor = true;
            // 
            // richTextBoxConf
            // 
            this.richTextBoxConf.BackColor = System.Drawing.Color.White;
            this.richTextBoxConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxConf.Location = new System.Drawing.Point( 15, 15 );
            this.richTextBoxConf.Name = "richTextBoxConf";
            this.richTextBoxConf.ReadOnly = true;
            this.richTextBoxConf.Size = new System.Drawing.Size( 432, 327 );
            this.richTextBoxConf.TabIndex = 1;
            this.richTextBoxConf.Text = "";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add( this.richTextBoxResult );
            this.tabPageResult.Location = new System.Drawing.Point( 4, 22 );
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding( 15 );
            this.tabPageResult.Size = new System.Drawing.Size( 462, 357 );
            this.tabPageResult.TabIndex = 3;
            this.tabPageResult.Text = "Resultados";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.White;
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResult.Location = new System.Drawing.Point( 15, 15 );
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size( 432, 327 );
            this.richTextBoxResult.TabIndex = 2;
            this.richTextBoxResult.Text = "";
            // 
            // TestInformationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.tabControl );
            this.Name = "TestInformationUC";
            this.Size = new System.Drawing.Size( 476, 389 );
            this.tabControl.ResumeLayout( false );
            this.tabPageDesc.ResumeLayout( false );
            this.tabPageConf.ResumeLayout( false );
            this.tabPageResult.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDesc;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.TabPage tabPageConf;
        private System.Windows.Forms.RichTextBox richTextBoxConf;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}
