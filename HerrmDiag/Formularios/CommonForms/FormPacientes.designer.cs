namespace HerrmDiag.Formularios.CommonForms
{
    partial class FormPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormPacientes ) );
            this.MenuStrip = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.seleccionarSujetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.adminPacientesUC1 = new HerrmDiag.UserControls.AdminPacientesUC();
            this.MenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.seleccionarSujetoToolStripMenuItem,
            this.toolStripSeparator3,
            this.eliminarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.toolStripSeparator1,
            this.resultadosToolStripMenuItem,
            this.reporteToolStripMenuItem} );
            this.MenuStrip.Name = "contextMenuStrip1";
            this.MenuStrip.Size = new System.Drawing.Size( 171, 126 );
            // 
            // seleccionarSujetoToolStripMenuItem
            // 
            this.seleccionarSujetoToolStripMenuItem.Name = "seleccionarSujetoToolStripMenuItem";
            this.seleccionarSujetoToolStripMenuItem.Size = new System.Drawing.Size( 170, 22 );
            this.seleccionarSujetoToolStripMenuItem.Text = "&Seleccionar Sujeto";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size( 167, 6 );
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size( 170, 22 );
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size( 170, 22 );
            this.editarToolStripMenuItem.Text = "E&ditar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 167, 6 );
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size( 170, 22 );
            this.resultadosToolStripMenuItem.Text = "&Resultados";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size( 170, 22 );
            this.reporteToolStripMenuItem.Text = "Re&porte";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel} );
            this.statusStrip1.Location = new System.Drawing.Point( 0, 387 );
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size( 776, 22 );
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size( 0, 17 );
            // 
            // adminPacientesUC1
            // 
            this.adminPacientesUC1.ComboBoxPaciente = null;
            this.adminPacientesUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPacientesUC1.Location = new System.Drawing.Point( 0, 0 );
            this.adminPacientesUC1.Name = "adminPacientesUC1";
            this.adminPacientesUC1.Size = new System.Drawing.Size( 776, 387 );
            this.adminPacientesUC1.TabIndex = 49;
            this.adminPacientesUC1.SelectedPatientChanged += new HerrmDiag.UserControls.AdminPacientesUC.SelectedChanged_Delegate( this.listViewPacientes_SelectedIndexChanged );
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 776, 409 );
            this.Controls.Add( this.adminPacientesUC1 );
            this.Controls.Add( this.statusStrip1 );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.MinimumSize = new System.Drawing.Size( 613, 443 );
            this.Name = "FormPacientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Sujetos";
            this.MenuStrip.ResumeLayout( false );
            this.statusStrip1.ResumeLayout( false );
            this.statusStrip1.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarSujetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private UserControls.AdminPacientesUC adminPacientesUC1;
    }
}