namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormUsuarios ) );
            this.imageListLarge = new System.Windows.Forms.ImageList( this.components );
            this.imageListSmall = new System.Windows.Forms.ImageList( this.components );
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.adminUsersUC1 = new HerrmDiag.UserControls.AdminUsersUC();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageListLarge.ImageStream" )));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName( 0, "U32.png" );
            this.imageListLarge.Images.SetKeyName( 1, "Ufo.ico" );
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageListSmall.ImageStream" )));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName( 0, "u24.png" );
            this.imageListSmall.Images.SetKeyName( 1, "Goofy.ico" );
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel} );
            this.statusStrip2.Location = new System.Drawing.Point( 0, 284 );
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size( 685, 22 );
            this.statusStrip2.TabIndex = 5;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size( 0, 17 );
            // 
            // adminUsersUC1
            // 
            this.adminUsersUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminUsersUC1.Location = new System.Drawing.Point( 0, 0 );
            this.adminUsersUC1.Name = "adminUsersUC1";
            this.adminUsersUC1.Size = new System.Drawing.Size( 685, 284 );
            this.adminUsersUC1.TabIndex = 6;
            this.adminUsersUC1.SelectedUserChanged += new HerrmDiag.UserControls.AdminUsersUC.SelectedChanged_Delegate( this.listViewUser_SelectedIndexChanged );
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 685, 306 );
            this.Controls.Add( this.adminUsersUC1 );
            this.Controls.Add( this.statusStrip2 );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.Name = "FormUsuarios";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramienta de Administrador de Usuarios";
            this.statusStrip2.ResumeLayout( false );
            this.statusStrip2.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private UserControls.AdminUsersUC adminUsersUC1;
    }
}