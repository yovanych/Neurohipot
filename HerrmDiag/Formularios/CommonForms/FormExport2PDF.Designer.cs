namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormExport2PDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormExport2PDF ) );
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonImprimir = new System.Windows.Forms.Button();
            this.savePDFFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdfReportViewerUC1 = new HerrmDiag.UserControls.PdfReportViewerUC();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExportar
            // 
            this.buttonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportar.BackColor = System.Drawing.Color.DimGray;
            this.buttonExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportar.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonExportar.ForeColor = System.Drawing.Color.White;
            this.buttonExportar.Location = new System.Drawing.Point( 479, 481 );
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size( 133, 38 );
            this.buttonExportar.TabIndex = 9;
            this.buttonExportar.Text = "EXPORTAR a PDF";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler( this.buttonExportar_Click );
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImprimir.BackColor = System.Drawing.Color.DimGray;
            this.buttonImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImprimir.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Location = new System.Drawing.Point( 632, 492 );
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.Size = new System.Drawing.Size( 109, 27 );
            this.buttonImprimir.TabIndex = 10;
            this.buttonImprimir.Text = "Mostrar PDF";
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler( this.buttonImprimir_Click );
            // 
            // savePDFFileDialog
            // 
            this.savePDFFileDialog.FileName = "reporte";
            this.savePDFFileDialog.Filter = "Archivos PDF|*.pdf";
            this.savePDFFileDialog.InitialDirectory = "Desktop";
            this.savePDFFileDialog.Title = "Salvar reporte";
            this.savePDFFileDialog.FileOk += new System.ComponentModel.CancelEventHandler( this.savePDFFileDialog_FileOk );
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add( this.pdfReportViewerUC1 );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point( 3, 16 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 723, 454 );
            this.panel1.TabIndex = 0;
            // 
            // pdfReportViewerUC1
            // 
            this.pdfReportViewerUC1.BackColor = System.Drawing.Color.White;
            this.pdfReportViewerUC1.Location = new System.Drawing.Point( 3, 3 );
            this.pdfReportViewerUC1.Name = "pdfReportViewerUC1";
            this.pdfReportViewerUC1.Size = new System.Drawing.Size( 700, 3000 );
            this.pdfReportViewerUC1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add( this.panel1 );
            this.groupBox2.Location = new System.Drawing.Point( 12, 2 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 729, 473 );
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // printDialog
            // 
            this.printDialog.AllowPrintToFile = false;
            this.printDialog.UseEXDialog = true;
            // 
            // FormExport2PDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size( 753, 526 );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.buttonImprimir );
            this.Controls.Add( this.buttonExportar );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.MaximizeBox = false;
            this.Name = "FormExport2PDF";
            this.Text = "Reporte";
            this.Load += new System.EventHandler( this.FormExport2PDF_Load );
            this.panel1.ResumeLayout( false );
            this.groupBox2.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonImprimir;
        private System.Windows.Forms.SaveFileDialog savePDFFileDialog;
        private System.Windows.Forms.Panel panel1;
        private UserControls.PdfReportViewerUC pdfReportViewerUC1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}