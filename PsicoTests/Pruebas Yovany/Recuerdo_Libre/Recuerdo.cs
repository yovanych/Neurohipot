using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using DALayer;

namespace PsicoTests.Yovany
{
	/// <summary>
	/// Summary description for Recuerdo.
	/// </summary>
	public class Recuerdo : FormWithResultNUtils
	{
	    public Recuerdo_Libre rl;
		private Label Palabra;
		public Timer Timer;
		private IContainer components;
		private Timer Timer1;
		//private Formulario f;
		public Graphics g;
		public Font fon;
		private Label label1;
		public Brush b;
        //private Form princ;
        private readonly int vis1;
	    private readonly int oc1;
	    private readonly int vis15;
	    private readonly int vis2;
	    private readonly int oc2;
	    private int /*teclacorrecta, teclaincorrecta,*/ vez;
	    private Button button1;
        private Label label2;
        private RichTextBox richTextBox1;
	    private readonly string codigoPaciente;

		public Recuerdo(string codigoPaciente, int vis1, int oc1, int vis15, int vis2, int oc2)
		{
			InitializeComponent();
            //this.princ = principal;
		    this.codigoPaciente = codigoPaciente;
            this.vis1 = vis1;
            this.vis15 = vis15;
            this.vis2 = vis2;
            this.oc1 = oc1;
            this.oc2 = oc2;
            //this.teclacorrecta = teclacorrecta;
            //this.teclaincorrecta = teclaincorrecta;
			
			//Dimensiones de la pantalla
			Rectangle r = Screen.PrimaryScreen.Bounds;

			//Poniendo las dimensiones de la ventana
			//del tamaño de la pantalla
			this.Height = r.Height;
			this.Width = r.Width;
			
//			Posición de label1.
			this.label1.Text= @"Presione [Enter] para pasar a la nueva fase";
			this.label1.Width = this.Width;
			this.label1.Height = this.Height/10;
			this.label1.Font = new Font("Arial",20);
			this.label1.Top = this.Height-this.label1.Height;
			this.label1.Left = 60;
			this.label1.Hide();		

//			Posición del label.
            this.Palabra.Width = 500;
            this.Palabra.Height = 100;
			this.Palabra.Top = (this.Height - this.Palabra.Height)/2;
			this.Palabra.Left = (this.Width - this.Palabra.Width)/2;
			this.Palabra.Font = new Font("Arial",60);
			g = this.CreateGraphics();
			this.Palabra.Visible = false;
			fon = new Font(FontFamily.GenericSansSerif, 40);
			b = new SolidBrush(Color.Red);
			this.Palabra.Visible = true;
            this.Timer.Interval = this.oc1;
            this.Timer1.Interval = this.oc2;
			rl = new Recuerdo_Libre(Timer);
            rl.Start();
            
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
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Palabra = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Palabra
            // 
            this.Palabra.Location = new System.Drawing.Point(355, 188);
            this.Palabra.Name = "Palabra";
            this.Palabra.Size = new System.Drawing.Size(307, 44);
            this.Palabra.TabIndex = 0;
            this.Palabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Palabra.Visible = false;
            this.Palabra.Click += new System.EventHandler(this.Palabra_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 299);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ESCRIBA TODAS LAS PALABRAS QUE RECUERDE";
            this.label2.Visible = false;
            // 
            // Recuerdo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(706, 426);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Palabra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recuerdo";
            this.Text = "Recuerdo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recuerdo_KeyDown);
            this.Load += new System.EventHandler(this.Recuerdo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Recuerdo_Load(object sender, EventArgs e)
		{
		
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if(rl.count1 == -3)
			{
				this.rl.fase = 2;
				this.Visible = true;				
				this.Palabra.Visible = true;
                this.label1.Show();
				this.Timer.Stop();
                this.Focus();
				
			}
			else
			if(rl.count1 == -2)
			{
				rl.count1 --;
				this.Timer.Stop();
				this.Timer.Interval = 1;
				g.FillRectangle(new SolidBrush(this.BackColor),0,0,this.Width,this.Height);
				this.rl.fase=2;
                //f.ShowDialog(this);
                //f.StartPosition = FormStartPosition.CenterScreen;
                //this.Palabra.Visible = true;
                this.richTextBox1.Clear();
                this.label2.Visible = true;
                this.richTextBox1.Visible = true;
                this.button1.Visible = true;
			}
			else
			if(rl.count1 == -1)
			{
				rl.count1 --;
				this.Palabra.Visible = false;
				this.Timer.Interval = this.vis15;
				int w = this.Width;
				int h = this.Height;
                g = this.CreateGraphics();

                //this.Controls.Clear();

				for(int i =0; i < 5; i++)
				{
					g.DrawString(this.rl.memorizar[i],fon,b, w/16, h/10 + i*h/7);
				}
				for(int i =0; i < 5; i++)
				{
					g.DrawString(this.rl.memorizar[5 + i],fon,b,w/16 + w/3, h/10 + i*h/7 );				}
				for(int i =0; i < 5; i++)
				{
					g.DrawString(this.rl.memorizar[10 + i],fon,b,w/6 + w/2, h/10 + i*h/7);
				}
			}
			else
			if(rl.count1==15)
			{
				this.Palabra.Text = "";
				rl.count1 = -1;
				Timer.Stop();
                //f = new Formulario(this);
                //f.ShowDialog(this);
                //f.StartPosition = FormStartPosition.CenterScreen;  
               
                this.richTextBox1.Visible = true;
                this.button1.Visible = true;
                this.label2.Visible = true;
			}
			else
			if(this.Timer.Interval == this.oc1)
			{
				this.Palabra.Text = rl.memorizar[rl.count1];
				this.Timer.Interval = vis1;
				rl.count1++;
			}
			else
			{
				this.Palabra.Text = "";
				this.Timer.Interval = oc1;
			}
		}

		private void Palabra_Click(object sender, EventArgs e)
		{
		
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{			
			if(rl.count2==30)
			{
                if (this.rl.flag == false) this.rl.omisiones++;
                Resultado = new Resultado_RL(this.codigoPaciente, this.rl.errores, this.rl.omisiones,
									 this.rl.aciertos,this.rl.recordadas1,
                                     this.rl.recordadas2, DateTime.Now, true );
                this.Timer.Dispose();
				this.Close();
				
			}
			else
				if(this.Timer1.Interval == this.oc2)
			    {
				
                    
                    if(this.rl.flag == false&&this.rl.count2>0)
                        this.rl.omisiones++;
				    else this.rl.flag = false;
				    this.Palabra.Text = rl.distractoras[rl.count2];
				    this.Timer1.Interval = this.vis2;
				    rl.count2++;
			    }
			else
			{
				this.Palabra.Text = "";
				this.Timer1.Interval = this.oc2;
			}
		}

		private void Recuerdo_KeyDown(object sender, KeyEventArgs e)
		{
            if (e.KeyValue == 27)
            {
                Resultado = new Resultado_RL(this.codigoPaciente, this.rl.errores, this.rl.omisiones, 
                this.rl.aciertos, this.rl.recordadas1,
                this.rl.recordadas2, DateTime.Now, false );
                this.Timer.Dispose();
                this.Close();
                return;
            }
			if(e.KeyValue == 13 && rl.fase == 2 && rl.count2 == 0)
			{
				rl.fase = 3;
                this.Timer1.Start();
				this.label1.Visible = false;
                this.Palabra.Visible = true;               
			}
					
			if(this.rl.flag == false && this.rl.count2>0)
			{
				if(e.KeyValue == 13 && rl.fase == 3)
				{
				
					if(this.rl.pertenece(this.rl.count2-1))
						this.rl.errores++;
					else
						this.rl.aciertos++;
				}
				if(e.KeyValue == 32 && rl.fase==3)
				{
					if(this.rl.pertenece(this.rl.count2-1))
						this.rl.aciertos++;
					else
						this.rl.errores++;
				}
				this.rl.flag = true;
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {

            string text = this.richTextBox1.Text;
            string[] palabras = text.Split(' ', '\n');

            if (vez == 0)
            {
                vez = 1;
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < palabras.Length; j++)
                        if (palabras[j] == rl.memorizar[i])
                        {
                            rl.recordadas1++;
                            break;
                        }
                }
            }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j < palabras.Length; j++)
                        if (palabras[j] == rl.memorizar[i])
                        {
                            rl.recordadas2++;
                            break;
                        }
                }
                this.button1.Enabled = false;
                
            }
            this.richTextBox1.Visible = false;
            this.label2.Visible = false;
            this.button1.Visible = false;           
            this.Timer.Start(); 
        }
	}
    
}
