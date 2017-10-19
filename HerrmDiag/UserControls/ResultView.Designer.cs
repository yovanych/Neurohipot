namespace HerrmDiag.UserControls
{
    partial class ResultView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPaciente = new System.Windows.Forms.Label();
            this.lTipoEstimulo = new System.Windows.Forms.Label();
            this.lTipoPrueba = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.ColumnBloque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAciertos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAciertos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnErrores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOmisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTiempos = new System.Windows.Forms.DataGridView();
            this.tbDesviacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.lable = new System.Windows.Forms.Label();
            this.lcompleto = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add( this.lPaciente );
            this.groupBox1.Controls.Add( this.lTipoEstimulo );
            this.groupBox1.Controls.Add( this.lTipoPrueba );
            this.groupBox1.Location = new System.Drawing.Point( 3, 3 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 293, 76 );
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Prueba ";
            // 
            // lPaciente
            // 
            this.lPaciente.AutoSize = true;
            this.lPaciente.Location = new System.Drawing.Point( 6, 54 );
            this.lPaciente.Name = "lPaciente";
            this.lPaciente.Size = new System.Drawing.Size( 10, 13 );
            this.lPaciente.TabIndex = 2;
            this.lPaciente.Text = "-";
            // 
            // lTipoEstimulo
            // 
            this.lTipoEstimulo.AutoSize = true;
            this.lTipoEstimulo.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.lTipoEstimulo.Location = new System.Drawing.Point( 6, 36 );
            this.lTipoEstimulo.Name = "lTipoEstimulo";
            this.lTipoEstimulo.Size = new System.Drawing.Size( 11, 13 );
            this.lTipoEstimulo.TabIndex = 1;
            this.lTipoEstimulo.Text = "-";
            // 
            // lTipoPrueba
            // 
            this.lTipoPrueba.AutoSize = true;
            this.lTipoPrueba.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.lTipoPrueba.Location = new System.Drawing.Point( 6, 19 );
            this.lTipoPrueba.Name = "lTipoPrueba";
            this.lTipoPrueba.Size = new System.Drawing.Size( 11, 13 );
            this.lTipoPrueba.TabIndex = 0;
            this.lTipoPrueba.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add( this.tabControl1 );
            this.groupBox2.Controls.Add( this.tbDesviacion );
            this.groupBox2.Controls.Add( this.label1 );
            this.groupBox2.Controls.Add( this.tbMedia );
            this.groupBox2.Controls.Add( this.lable );
            this.groupBox2.Controls.Add( this.lcompleto );
            this.groupBox2.Location = new System.Drawing.Point( 3, 85 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 293, 399 );
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Resultados ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add( this.tabPage1 );
            this.tabControl1.Controls.Add( this.tabPage2 );
            this.tabControl1.Location = new System.Drawing.Point( 9, 97 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 278, 296 );
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add( this.dgvResultados );
            this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage1.Size = new System.Drawing.Size( 270, 270 );
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Resultados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBloque,
            this.ColumnAciertos,
            this.ColumnAciertos2,
            this.ColumnErrores,
            this.ColumnOmisiones} );
            this.dgvResultados.Location = new System.Drawing.Point( 6, 6 );
            this.dgvResultados.MultiSelect = false;
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 30;
            this.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvResultados.ShowEditingIcon = false;
            this.dgvResultados.Size = new System.Drawing.Size( 258, 258 );
            this.dgvResultados.TabIndex = 0;
            // 
            // ColumnBloque
            // 
            this.ColumnBloque.HeaderText = "Bloque";
            this.ColumnBloque.Name = "ColumnBloque";
            this.ColumnBloque.ReadOnly = true;
            this.ColumnBloque.Width = 60;
            // 
            // ColumnAciertos
            // 
            this.ColumnAciertos.HeaderText = "Aciertos";
            this.ColumnAciertos.Name = "ColumnAciertos";
            this.ColumnAciertos.ReadOnly = true;
            // 
            // ColumnAciertos2
            // 
            this.ColumnAciertos2.HeaderText = "Aciertos Ext.";
            this.ColumnAciertos2.Name = "ColumnAciertos2";
            this.ColumnAciertos2.ReadOnly = true;
            // 
            // ColumnErrores
            // 
            this.ColumnErrores.HeaderText = "Comisiones";
            this.ColumnErrores.Name = "ColumnErrores";
            this.ColumnErrores.ReadOnly = true;
            // 
            // ColumnOmisiones
            // 
            this.ColumnOmisiones.HeaderText = "Omisiones";
            this.ColumnOmisiones.Name = "ColumnOmisiones";
            this.ColumnOmisiones.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add( this.dgvTiempos );
            this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage2.Size = new System.Drawing.Size( 270, 270 );
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiempos de reacción";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTiempos
            // 
            this.dgvTiempos.AllowUserToAddRows = false;
            this.dgvTiempos.AllowUserToDeleteRows = false;
            this.dgvTiempos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempos.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3} );
            this.dgvTiempos.Location = new System.Drawing.Point( 6, 6 );
            this.dgvTiempos.MultiSelect = false;
            this.dgvTiempos.Name = "dgvTiempos";
            this.dgvTiempos.ReadOnly = true;
            this.dgvTiempos.RowHeadersWidth = 30;
            this.dgvTiempos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTiempos.ShowEditingIcon = false;
            this.dgvTiempos.Size = new System.Drawing.Size( 258, 258 );
            this.dgvTiempos.TabIndex = 1;
            // 
            // tbDesviacion
            // 
            this.tbDesviacion.BackColor = System.Drawing.Color.White;
            this.tbDesviacion.Enabled = false;
            this.tbDesviacion.Location = new System.Drawing.Point( 75, 71 );
            this.tbDesviacion.Name = "tbDesviacion";
            this.tbDesviacion.Size = new System.Drawing.Size( 117, 20 );
            this.tbDesviacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 6, 74 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 63, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Desviación:";
            // 
            // tbMedia
            // 
            this.tbMedia.BackColor = System.Drawing.Color.White;
            this.tbMedia.Enabled = false;
            this.tbMedia.Location = new System.Drawing.Point( 75, 45 );
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size( 117, 20 );
            this.tbMedia.TabIndex = 2;
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point( 6, 48 );
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size( 39, 13 );
            this.lable.TabIndex = 1;
            this.lable.Text = "Media:";
            // 
            // lcompleto
            // 
            this.lcompleto.AutoSize = true;
            this.lcompleto.Location = new System.Drawing.Point( 6, 26 );
            this.lcompleto.Name = "lcompleto";
            this.lcompleto.Size = new System.Drawing.Size( 10, 13 );
            this.lcompleto.TabIndex = 0;
            this.lcompleto.Text = "-";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Bloque";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Media Tiempo de reacción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Desv. Tiempo Reacción";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // panel
            // 
            this.panel.Controls.Add( this.label4 );
            this.panel.Controls.Add( this.label3 );
            this.panel.Controls.Add( this.label2 );
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point( 0, 0 );
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size( 299, 487 );
            this.panel.TabIndex = 2;
            this.panel.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font( "Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label2.Location = new System.Drawing.Point( 23, 101 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 253, 31 );
            this.label2.TabIndex = 0;
            this.label2.Text = "No se han encontrado";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font( "Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label3.Location = new System.Drawing.Point( 21, 128 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 257, 31 );
            this.label3.TabIndex = 0;
            this.label3.Text = "resultados de este tipo";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font( "Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.label4.Location = new System.Drawing.Point( 88, 156 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 122, 31 );
            this.label4.TabIndex = 0;
            this.label4.Text = "de prueba";
            // 
            // ResultView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.panel );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Name = "ResultView";
            this.Size = new System.Drawing.Size( 299, 487 );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout( false );
            this.tabPage1.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.tabPage2.ResumeLayout( false );
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).EndInit();
            this.panel.ResumeLayout( false );
            this.panel.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPaciente;
        private System.Windows.Forms.Label lTipoEstimulo;
        private System.Windows.Forms.Label lTipoPrueba;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDesviacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMedia;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lcompleto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBloque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAciertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAciertos2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnErrores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOmisiones;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTiempos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
