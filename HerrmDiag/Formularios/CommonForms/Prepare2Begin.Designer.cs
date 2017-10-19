namespace HerrmDiag.Formularios.CommonForms
{
    partial class Prepare2Begin
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 9 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 168, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Prepárese para comenzar el test...";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DimGray;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point( 238, 56 );
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size( 75, 23 );
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler( this.buttonClose_Click );
            // 
            // buttonBegin
            // 
            this.buttonBegin.BackColor = System.Drawing.Color.DimGray;
            this.buttonBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBegin.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)) );
            this.buttonBegin.ForeColor = System.Drawing.Color.White;
            this.buttonBegin.Location = new System.Drawing.Point( 12, 56 );
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size( 147, 23 );
            this.buttonBegin.TabIndex = 3;
            this.buttonBegin.Text = "Comenzar ... 10 seg";
            this.buttonBegin.UseVisualStyleBackColor = false;
            this.buttonBegin.Click += new System.EventHandler( this.buttonBegin_Click );
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler( this.timer_Tick );
            // 
            // Prepare2Begin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 325, 91 );
            this.Controls.Add( this.buttonClose );
            this.Controls.Add( this.buttonBegin );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prepare2Begin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "10 seg.";
            this.Load += new System.EventHandler( this.Prepare2Begin_Load );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Timer timer;
    }
}