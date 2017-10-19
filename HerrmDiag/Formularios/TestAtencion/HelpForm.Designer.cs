namespace HerrmDiag.Formularios.TestAtencion
{
    partial class HelpForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Introducción" );
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode( "Administración de Usuarios y contraseñas" );
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode( "Administración  de sujetos" );
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode( "Administración del TAS" );
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode( "Administración", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4} );
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode( "Emisión del reporte" );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( HelpForm ) );
            this.tvTopics = new System.Windows.Forms.TreeView();
            this.imageListIcons = new System.Windows.Forms.ImageList( this.components );
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvTopics
            // 
            this.tvTopics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvTopics.ImageIndex = 0;
            this.tvTopics.ImageList = this.imageListIcons;
            this.tvTopics.Location = new System.Drawing.Point( 12, 130 );
            this.tvTopics.Name = "tvTopics";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "NodeInt";
            treeNode1.Tag = "INT";
            treeNode1.Text = "Introducción";
            treeNode2.Name = "NodeAdu";
            treeNode2.Tag = "ADU";
            treeNode2.Text = "Administración de Usuarios y contraseñas";
            treeNode3.Name = "NodeAds";
            treeNode3.Tag = "ADS";
            treeNode3.Text = "Administración  de sujetos";
            treeNode4.Name = "NodeAdt";
            treeNode4.Tag = "ADT";
            treeNode4.Text = "Administración del TAS";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "NodeAdm";
            treeNode5.Tag = "ADM";
            treeNode5.Text = "Administración";
            treeNode6.Name = "NodeEmi";
            treeNode6.Tag = "EMI";
            treeNode6.Text = "Emisión del reporte";
            this.tvTopics.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode6} );
            this.tvTopics.SelectedImageIndex = 0;
            this.tvTopics.Size = new System.Drawing.Size( 264, 301 );
            this.tvTopics.TabIndex = 0;
            this.tvTopics.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.treeView1_AfterSelect );
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageListIcons.ImageStream" )));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName( 0, "doc" );
            this.imageListIcons.Images.SetKeyName( 1, "folder" );
            // 
            // rtbInfo
            // 
            this.rtbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInfo.BackColor = System.Drawing.Color.White;
            this.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfo.Location = new System.Drawing.Point( 15, 15 );
            this.rtbInfo.Margin = new System.Windows.Forms.Padding( 15 );
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size( 361, 376 );
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HerrmDiag.Properties.Resources.TAS;
            this.pictureBox1.Location = new System.Drawing.Point( 12, 12 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 264, 112 );
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 279, 12 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 58, 13 );
            this.label1.TabIndex = 3;
            this.label1.Text = "Contenido:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add( this.rtbInfo );
            this.panel1.Location = new System.Drawing.Point( 282, 28 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 391, 403 );
            this.panel1.TabIndex = 4;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 685, 443 );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.tvTopics );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda TAS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvTopics;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageListIcons;
    }
}