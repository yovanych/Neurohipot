namespace HerrmDiag.Formularios.CommonForms
{
    partial class Reporte
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode( "Node0" );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Reporte ) );
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.treeViewResult = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDir = new System.Windows.Forms.RichTextBox();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.textBoxSexo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxReporte = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList( this.components );
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.groupBox3 );
            this.groupBox1.Controls.Add( this.groupBox2 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Margin = new System.Windows.Forms.Padding( 5 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 301, 479 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Datos del Sujeto ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.treeViewResult );
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point( 3, 265 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 295, 211 );
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // treeViewResult
            // 
            this.treeViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewResult.Location = new System.Drawing.Point( 3, 16 );
            this.treeViewResult.Name = "treeViewResult";
            treeNode1.Name = "NodeRoot";
            treeNode1.Text = "Node0";
            this.treeViewResult.Nodes.AddRange( new System.Windows.Forms.TreeNode[] {
            treeNode1} );
            this.treeViewResult.Size = new System.Drawing.Size( 289, 192 );
            this.treeViewResult.TabIndex = 0;
            this.treeViewResult.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.treeViewResult_AfterSelect );
            this.treeViewResult.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler( this.treeViewResult_NodeMouseClick );
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.richTextBoxDir );
            this.groupBox2.Controls.Add( this.textBoxNivel );
            this.groupBox2.Controls.Add( this.textBoxSexo );
            this.groupBox2.Controls.Add( this.label6 );
            this.groupBox2.Controls.Add( this.label5 );
            this.groupBox2.Controls.Add( this.textBoxEdad );
            this.groupBox2.Controls.Add( this.label4 );
            this.groupBox2.Controls.Add( this.textBoxCodigo );
            this.groupBox2.Controls.Add( this.label3 );
            this.groupBox2.Controls.Add( this.textBoxNombre );
            this.groupBox2.Controls.Add( this.label2 );
            this.groupBox2.Controls.Add( this.label1 );
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point( 3, 16 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 295, 249 );
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // richTextBoxDir
            // 
            this.richTextBoxDir.BackColor = System.Drawing.Color.White;
            this.richTextBoxDir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDir.Location = new System.Drawing.Point( 9, 180 );
            this.richTextBoxDir.Name = "richTextBoxDir";
            this.richTextBoxDir.ReadOnly = true;
            this.richTextBoxDir.Size = new System.Drawing.Size( 280, 60 );
            this.richTextBoxDir.TabIndex = 2;
            this.richTextBoxDir.Text = "";
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.BackColor = System.Drawing.Color.White;
            this.textBoxNivel.Location = new System.Drawing.Point( 126, 136 );
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.ReadOnly = true;
            this.textBoxNivel.Size = new System.Drawing.Size( 163, 20 );
            this.textBoxNivel.TabIndex = 1;
            this.textBoxNivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSexo
            // 
            this.textBoxSexo.BackColor = System.Drawing.Color.White;
            this.textBoxSexo.Location = new System.Drawing.Point( 126, 110 );
            this.textBoxSexo.Name = "textBoxSexo";
            this.textBoxSexo.ReadOnly = true;
            this.textBoxSexo.Size = new System.Drawing.Size( 163, 20 );
            this.textBoxSexo.TabIndex = 1;
            this.textBoxSexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 6, 164 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 102, 13 );
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección Particular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 50, 139 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 72, 13 );
            this.label5.TabIndex = 0;
            this.label5.Text = "Nivel Escolar:";
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.BackColor = System.Drawing.Color.White;
            this.textBoxEdad.Location = new System.Drawing.Point( 126, 84 );
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.ReadOnly = true;
            this.textBoxEdad.Size = new System.Drawing.Size( 163, 20 );
            this.textBoxEdad.TabIndex = 1;
            this.textBoxEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 50, 113 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 34, 13 );
            this.label4.TabIndex = 0;
            this.label4.Text = "Sexo:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.BackColor = System.Drawing.Color.White;
            this.textBoxCodigo.Location = new System.Drawing.Point( 126, 58 );
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size( 163, 20 );
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 50, 87 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 35, 13 );
            this.label3.TabIndex = 0;
            this.label3.Text = "Edad:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point( 26, 32 );
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size( 263, 20 );
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 50, 61 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 43, 13 );
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 6, 16 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 120, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y dos Apellidos:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add( this.richTextBoxReporte );
            this.groupBox4.Controls.Add( this.groupBox5 );
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point( 301, 0 );
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size( 368, 479 );
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = " Reporte ";
            // 
            // richTextBoxReporte
            // 
            this.richTextBoxReporte.BackColor = System.Drawing.Color.White;
            this.richTextBoxReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxReporte.HideSelection = false;
            this.richTextBoxReporte.Location = new System.Drawing.Point( 3, 16 );
            this.richTextBoxReporte.Name = "richTextBoxReporte";
            this.richTextBoxReporte.ReadOnly = true;
            this.richTextBoxReporte.ShowSelectionMargin = true;
            this.richTextBoxReporte.Size = new System.Drawing.Size( 362, 413 );
            this.richTextBoxReporte.TabIndex = 2;
            this.richTextBoxReporte.Text = "";
            this.richTextBoxReporte.WordWrap = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add( this.buttonSave );
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point( 3, 429 );
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size( 362, 47 );
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DimGray;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point( 247, 16 );
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size( 112, 28 );
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler( this.buttonSave_Click );
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject( "imageList1.ImageStream" )));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName( 0, "contents.gif" );
            this.imageList1.Images.SetKeyName( 1, "smblu05.gif" );
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Formato RTF|*.rtf";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler( this.saveFileDialog_FileOk );
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 669, 479 );
            this.Controls.Add( this.groupBox4 );
            this.Controls.Add( this.groupBox1 );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.groupBox1.ResumeLayout( false );
            this.groupBox3.ResumeLayout( false );
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout( false );
            this.groupBox5.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSexo;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxDir;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView treeViewResult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxReporte;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

