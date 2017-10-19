namespace HerrmDiag.Formularios.CommonForms
{
    partial class AddUser
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
            this.groupBoxAdiciona = new System.Windows.Forms.GroupBox();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonAp = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label3_ = new System.Windows.Forms.Label();
            this.label2_ = new System.Windows.Forms.Label();
            this.label1_ = new System.Windows.Forms.Label();
            this.textBoxPass2Add = new System.Windows.Forms.TextBox();
            this.textBoxPass1Add = new System.Windows.Forms.TextBox();
            this.textBoxNombreAdd = new System.Windows.Forms.TextBox();
            this.groupBoxAdiciona.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdiciona
            // 
            this.groupBoxAdiciona.Controls.Add( this.radioButtonAdmin );
            this.groupBoxAdiciona.Controls.Add( this.radioButtonAp );
            this.groupBoxAdiciona.Controls.Add( this.buttonAdd );
            this.groupBoxAdiciona.Controls.Add( this.buttonCerrar );
            this.groupBoxAdiciona.Controls.Add( this.label3_ );
            this.groupBoxAdiciona.Controls.Add( this.label2_ );
            this.groupBoxAdiciona.Controls.Add( this.label1_ );
            this.groupBoxAdiciona.Controls.Add( this.textBoxPass2Add );
            this.groupBoxAdiciona.Controls.Add( this.textBoxPass1Add );
            this.groupBoxAdiciona.Controls.Add( this.textBoxNombreAdd );
            this.groupBoxAdiciona.Location = new System.Drawing.Point( 12, 12 );
            this.groupBoxAdiciona.Name = "groupBoxAdiciona";
            this.groupBoxAdiciona.Size = new System.Drawing.Size( 253, 211 );
            this.groupBoxAdiciona.TabIndex = 4;
            this.groupBoxAdiciona.TabStop = false;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point( 153, 153 );
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size( 88, 17 );
            this.radioButtonAdmin.TabIndex = 4;
            this.radioButtonAdmin.Text = "Administrador";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonAp
            // 
            this.radioButtonAp.AutoSize = true;
            this.radioButtonAp.Checked = true;
            this.radioButtonAp.Location = new System.Drawing.Point( 10, 153 );
            this.radioButtonAp.Name = "radioButtonAp";
            this.radioButtonAp.Size = new System.Drawing.Size( 69, 17 );
            this.radioButtonAp.TabIndex = 4;
            this.radioButtonAp.TabStop = true;
            this.radioButtonAp.Text = "Aplicador";
            this.radioButtonAp.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point( 166, 176 );
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size( 75, 23 );
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler( this.buttonAdicionarUs_Click );
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.DimGray;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.ForeColor = System.Drawing.Color.White;
            this.buttonCerrar.Location = new System.Drawing.Point( 9, 176 );
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size( 75, 23 );
            this.buttonCerrar.TabIndex = 3;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler( this.Cancel_Click );
            // 
            // label3_
            // 
            this.label3_.AutoSize = true;
            this.label3_.Location = new System.Drawing.Point( 7, 101 );
            this.label3_.Name = "label3_";
            this.label3_.Size = new System.Drawing.Size( 108, 13 );
            this.label3_.TabIndex = 1;
            this.label3_.Text = "Repita la contraseña:";
            // 
            // label2_
            // 
            this.label2_.AutoSize = true;
            this.label2_.Location = new System.Drawing.Point( 6, 62 );
            this.label2_.Name = "label2_";
            this.label2_.Size = new System.Drawing.Size( 67, 13 );
            this.label2_.TabIndex = 1;
            this.label2_.Text = "Contraseña: ";
            // 
            // label1_
            // 
            this.label1_.AutoSize = true;
            this.label1_.Location = new System.Drawing.Point( 6, 23 );
            this.label1_.Name = "label1_";
            this.label1_.Size = new System.Drawing.Size( 163, 13 );
            this.label1_.TabIndex = 1;
            this.label1_.Text = "Nombre (de 10 a 12 caracteres): ";
            // 
            // textBoxPass2Add
            // 
            this.textBoxPass2Add.Location = new System.Drawing.Point( 10, 117 );
            this.textBoxPass2Add.Name = "textBoxPass2Add";
            this.textBoxPass2Add.PasswordChar = '®';
            this.textBoxPass2Add.Size = new System.Drawing.Size( 232, 20 );
            this.textBoxPass2Add.TabIndex = 2;
            this.textBoxPass2Add.TextChanged += new System.EventHandler( this.Info_TextChanged );
            // 
            // textBoxPass1Add
            // 
            this.textBoxPass1Add.Location = new System.Drawing.Point( 9, 78 );
            this.textBoxPass1Add.Name = "textBoxPass1Add";
            this.textBoxPass1Add.PasswordChar = '®';
            this.textBoxPass1Add.Size = new System.Drawing.Size( 232, 20 );
            this.textBoxPass1Add.TabIndex = 1;
            this.textBoxPass1Add.TextChanged += new System.EventHandler( this.Info_TextChanged );
            // 
            // textBoxNombreAdd
            // 
            this.textBoxNombreAdd.Location = new System.Drawing.Point( 10, 39 );
            this.textBoxNombreAdd.Name = "textBoxNombreAdd";
            this.textBoxNombreAdd.Size = new System.Drawing.Size( 232, 20 );
            this.textBoxNombreAdd.TabIndex = 0;
            this.textBoxNombreAdd.TextChanged += new System.EventHandler( this.Info_TextChanged );
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 276, 240 );
            this.Controls.Add( this.groupBoxAdiciona );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuario";
            this.groupBoxAdiciona.ResumeLayout( false );
            this.groupBoxAdiciona.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdiciona;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label3_;
        private System.Windows.Forms.Label label2_;
        private System.Windows.Forms.Label label1_;
        private System.Windows.Forms.TextBox textBoxPass2Add;
        private System.Windows.Forms.TextBox textBoxPass1Add;
        private System.Windows.Forms.TextBox textBoxNombreAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonAp;
    }
}