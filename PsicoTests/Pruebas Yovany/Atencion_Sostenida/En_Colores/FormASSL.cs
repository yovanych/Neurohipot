using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;


namespace PsicoTests.Yovany.ASS.Colores
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class FormASSL : FormWithResultNUtils
	{
		private IContainer components;
		
		private Label label_letra;
		private Timer timer_muestra;
		private Timer timer_contador;
        
	    //int demora = 0;
	    readonly Atencion_Sostenida_Simple ass;
	    readonly string letra_target;
	    readonly Color color_target;
	    readonly int bloques;
	    readonly int estimulos;
	    readonly int visualizacion;
	    readonly int ocultamiento;
	    readonly int tecla_reaccion;
        private readonly string codigoPaciente;

        public FormASSL(string codigoPaciente, string letra_target, Color color_target, int a, int b, int c, int d, int tecla_reaccion)
        {
            this.codigoPaciente = codigoPaciente;
            this.tecla_reaccion = tecla_reaccion;
            this.bloques = a;
            this.estimulos = b;
            this.visualizacion = c;
            this.ocultamiento = d;
            this.letra_target = letra_target;
            this.color_target = color_target;
			
			InitializeComponent();
			//Dimensiones de la pantalla
			Rectangle r = Screen.PrimaryScreen.Bounds;

			//Poniendo las dimensiones de la ventana
			//del tamaño de la pantalla
			this.Height = r.Height;
			this.Width = r.Width;
			int w = (this.Width - this.label_letra.Width)/2;
			int h = (this.Height - this.label_letra.Height)/2;
			
			//Posición del label.
			this.label_letra.Top = h;
			this.label_letra.Left = w;
			this.label_letra.Font = new Font("Arial",300);
            ass = new Atencion_Sostenida_Simple(null, this.letra_target, this.color_target, this.bloques, this.estimulos);
            timer_muestra.Interval = 1000;
            timer_muestra.Start();
			
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
            this.label_letra = new System.Windows.Forms.Label();
            this.timer_muestra = new System.Windows.Forms.Timer( this.components );
            this.timer_contador = new System.Windows.Forms.Timer( this.components );
            this.SuspendLayout();
            // 
            // label_letra
            // 
            this.label_letra.BackColor = System.Drawing.Color.Black;
            this.label_letra.Location = new System.Drawing.Point( 88, 56 );
            this.label_letra.Name = "label_letra";
            this.label_letra.Size = new System.Drawing.Size( 504, 432 );
            this.label_letra.TabIndex = 0;
            this.label_letra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_muestra
            // 
            this.timer_muestra.Enabled = true;
            this.timer_muestra.Interval = 500;
            this.timer_muestra.Tick += new System.EventHandler( this.timer_muestra_Tick );
            // 
            // timer_contador
            // 
            this.timer_contador.Interval = 1;
            this.timer_contador.Tick += new System.EventHandler( this.timer_contador_Tick );
            // 
            // FormASSL
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size( 712, 512 );
            this.Controls.Add( this.label_letra );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormASSL";
            this.Text = "Form2";
            this.Load += new System.EventHandler( this.Form2_Load );
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.Form2_KeyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.FormASSL_KeyUp );
            this.ResumeLayout( false );

		}
		#endregion

        #region Eventos
        private void Form2_Load(object sender, EventArgs e)
		{
																																																
		}

		private void timer_muestra_Tick(object sender, EventArgs e)
		{
            if (ass.count == this.bloques * 100 && ass.hide)
            {
                if (ass.miliseg != 0) ass.omisiones[(ass.count - 1) / 100]++;

                int dim = ass.omisiones.Length;
                var aciertos_extrannos = new int[dim]; // no se está usando en esta versión
                var tiempos_reaccion = new double[dim]; // no se está usando en esta versión
                var desviaciones = new double[dim]; // no se está usando en esta versión
                this.Resultado = new Resultado_ASC(this.codigoPaciente,
                    ass.omisiones,
                    ass.equivocaciones,
                    ass.aciertos,
                    aciertos_extrannos,
                    tiempos_reaccion,
                    desviaciones,
                    ass.tiempos,
                    DateTime.Now,
                    true,
                    TypeOf_AS_Test.C_Letras);
                this.Dispose();
            }
			
    
            else
            {
                if (ass.hide == false)
                {
                    label_letra.Text = "";
                    ass.hide = true;
                    timer_muestra.Interval = ocultamiento;
                }
                else
                {
                    if (ass.miliseg > 0)
                    {
                        ass.omisiones[(ass.count - 1) / 100]++;
                        ass.miliseg = 0;
                    }


                    //this.panel.BackgroundImage = imagen[ass.secuencia_imagen[ass.count]];
                    label_letra.ForeColor = ass.secuencia_color[ass.count];
                    label_letra.Text = ass.secuencia_letra[ass.count];

                    ass.count++;
                    ass.hide = false;
                    ass.activo = true;
                    if (ass.secuencia[ass.count - 1]) ass.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer_muestra.Interval = visualizacion;
                }
            }
		}

		private void timer_contador_Tick(object sender, EventArgs e)
		{
			ass.milisec ++;
		}

		private void Form2_KeyDown(object sender, KeyEventArgs e)
		{
            
            if (e.KeyValue == this.tecla_reaccion)
            {
                KeyHasBeenPressed();
                if (ass.miliseg > 0)
                {
                    int x = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    ass.click(x, 0);
                }
                else if (ass.activo)
                {
                    ass.click(0, 0);
                }
            }

            if (e.KeyValue == 27 && ass.count > 0)
            {
                int dim = ass.omisiones.Length;
                var aciertos_extrannos = new int[dim]; // no se está usando en esta versión
                var tiempos_reaccion = new double[dim]; // no se está usando en esta versión
                var desviaciones = new double[dim]; // no se está usando en esta versión
                this.Resultado = new Resultado_ASC(this.codigoPaciente,
                    ass.omisiones,
                    ass.equivocaciones,
                    ass.aciertos,
                    aciertos_extrannos,
                    tiempos_reaccion,
                    desviaciones,
                    ass.tiempos,
                    DateTime.Now,
                    false,
                    TypeOf_AS_Test.C_Letras);
                this.Dispose();
            }


		}

        private void FormASSL_KeyUp( object sender, KeyEventArgs e )
        {
            if (e.KeyValue == this.tecla_reaccion)
                KeyHasBeenRelease();
        }
        #endregion
    }
}
