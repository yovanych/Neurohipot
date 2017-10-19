using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace PsicoTests
{
	/// <summary>
	/// Summary description for Formulario.
	/// </summary>
	public class Formulario : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Aceptar;
		public Recuerdo f;
		public int vez;
		private System.Windows.Forms.RichTextBox Recordadas;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Formulario(Form f)
		{
            this.f = (Recuerdo)f;
            //f.Hide();
			this.vez = 1;
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.label1 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.Recordadas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Escriba todas las palabras que recuerde";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Aceptar.Location = new System.Drawing.Point(240, 328);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(72, 32);
            this.Aceptar.TabIndex = 16;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recordadas
            // 
            this.Recordadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordadas.Location = new System.Drawing.Point(8, 40);
            this.Recordadas.Name = "Recordadas";
            this.Recordadas.Size = new System.Drawing.Size(304, 280);
            this.Recordadas.TabIndex = 17;
            this.Recordadas.Text = "";
            this.Recordadas.TextChanged += new System.EventHandler(this.Recordadas_TextChanged);
            // 
            // Formulario
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(322, 366);
            this.Controls.Add(this.Recordadas);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{	
			string text = this.Recordadas.Text;
			string[] palabras = text.Split(' ', '\n');
			
			if(vez == 1)
			{
				vez = 2;
				for(int i = 0; i<15; i++)
				{
					for(int j = 0; j < palabras.Length; j++)
						if(palabras[j] == f.rl.memorizar[i])
						{
							f.rl.recordadas1++;
							break;
						}
				}
				this.Recordadas.Clear();
				this.Hide();
				
			}
			else
			{
				for(int i = 0; i<15; i++)
				{
					for(int j = 0; j < palabras.Length; j++)
						if(palabras[j] == f.rl.memorizar[i])
						{
							f.rl.recordadas2++;
							break;
						}
				}
				this.Dispose();
				
			}
            f.Show();
            f.rl.Start(); 
		}

		private void Formulario_Load(object sender, System.EventArgs e)
		{		
		}

		private void label1_Click(object sender, System.EventArgs e)
		{		
		}

        private void Recordadas_TextChanged(object sender, EventArgs e)
        {

        }
	}
}
