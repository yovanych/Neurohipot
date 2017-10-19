using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;


namespace PsicoTests.Yovany.ASS.Homogeneas
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class FormASS : FormWithResultNUtils
    {
        #region Campos
        private IContainer components;
		private Timer timer_muestra;
		private Timer timer_contador;
	    private readonly string codigo_paciente;
	    private TypeOf_AS_Test tipo_estimulo;
        bool ensayo;

	    //int demora = 0;
	    readonly Atencion_Sostenida_Simple ass;

	    readonly int bloques;
	    readonly int estimulos;
	    readonly int visualizacion;
	    readonly int ocultamiento;
	    private Panel panel;
	    readonly int tecla_reaccion;
        private Label Feedback;
	    readonly ImgSet.ImageSet imagen;
        #endregion

        #region Constructor
        public FormASS(
            bool ensayo,
            string codigoPaciente, 
            ImgSet.ImageSet imagen, 
            int index,
            int bloques, 
            int estimulos, 
            int visualizacion, 
            int ocultamiento, 
            int tecla_reaccion,
            Color fondo, TypeOf_AS_Test tipo_estimulo )
		{
            this.ensayo = ensayo;
		    this.codigo_paciente = codigoPaciente;
            this.imagen = imagen;
            this.tecla_reaccion = tecla_reaccion;
            this.bloques = bloques;
            this.estimulos = estimulos;
            this.visualizacion = visualizacion;
            this.ocultamiento = ocultamiento;
            this.tipo_estimulo = tipo_estimulo;
            
            InitializeComponent();
            this.BackColor = fondo;
			//Dimensiones de la pantalla
			Rectangle r = Screen.PrimaryScreen.Bounds;

			//Poniendo las dimensiones de la ventana
			//del tamaño de la pantalla
			this.Height = r.Height;
			this.Width = r.Width;
			int w = (this.Width - this.panel.Width)/2;
			int h = (this.Height - this.panel.Height)/2;
			
			//Posición del panel.
			this.panel.Top = h;
			this.panel.Left = w;
            //Posicion del label
            Feedback.Top = this.Height - 100;
            Feedback.Left = 100;
            Feedback.Font = new Font(FontFamily.GenericSansSerif, 30);
            Feedback.Hide();
            ass = new Atencion_Sostenida_Simple( null, index, this.bloques, this.estimulos, imagen.Count );
            timer_muestra.Interval = 1000;
            timer_muestra.Start();
			
		}
        #endregion

        #region Override
        public override sealed Color BackColor
	    {
	        get { return base.BackColor; }
	        set { base.BackColor = value; }
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.timer_muestra = new System.Windows.Forms.Timer( this.components );
            this.timer_contador = new System.Windows.Forms.Timer( this.components );
            this.panel = new System.Windows.Forms.Panel();
            this.Feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point( 189, 171 );
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size( 332, 219 );
            this.panel.TabIndex = 0;
            // 
            // Feedback
            // 
            this.Feedback.AutoSize = true;
            this.Feedback.BackColor = System.Drawing.Color.White;
            this.Feedback.Location = new System.Drawing.Point( 310, 456 );
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size( 55, 13 );
            this.Feedback.TabIndex = 1;
            this.Feedback.Text = "Feedback";
            // 
            // FormASS
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size( 712, 512 );
            this.Controls.Add( this.Feedback );
            this.Controls.Add( this.panel );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormASS";
            this.Text = "Form2";
            this.Load += new System.EventHandler( this.Form2_Load );
            this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.Form2_KeyDown );
            this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.FormASS_KeyUp );
            this.ResumeLayout( false );
            this.PerformLayout();

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
                if (!ensayo)
                {
                    ass.Calcula_estadistica();
                    Resultado = new Resultado_ASS(this.codigo_paciente, ass.omisiones, ass.equivocaciones, ass.aciertos, ass.aciertos_ext, ass.medias_tr, ass.desviaciones_tr,
                        ass.tiempos, DateTime.Now, true, this.tipo_estimulo);
                }
                this.Dispose();
            }
            else
            {
                if (ass.hide == false)
                {
                    panel.BackgroundImage = null;
                    ass.hide = true;
                    timer_muestra.Interval = ocultamiento;
                }
                else
                {
                    bool omision = false;
                    if (ass.miliseg > 0)
                    {
                        omision = true;
                        ass.omisiones[(ass.count - 1) / 100]++;
                        ass.miliseg = 0;
                        if (ensayo)
                        {
                            Feedback.Show();
                            Feedback.Text = "Estimulo no reconocido";
                        }
                    }


                    this.panel.BackgroundImage = imagen[ass.secuencia_imagen[ass.count]];
                    ass.count++;
                    ass.hide = false;
                    ass.activo = true;
                    if (ass.secuencia[ass.count - 1]) ass.miliseg = DateTime.Now.Millisecond + DateTime.Now.Second * 1000 + DateTime.Now.Minute * 60000 + DateTime.Now.Hour * 3600000;
                    timer_muestra.Interval = visualizacion;
                    if (ensayo && !omision) Feedback.Hide();
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
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = "Acierto";
                    }
                }
                else if (ass.activo)
                {
                    ass.click(0, 0);
                    if (ensayo)
                    {
                        Feedback.Show();
                        Feedback.Text = "Error";
                    }
                }
            }

            if (e.KeyValue == 27 && ass.count > 0)
            {
                if (!ensayo)
                {
                    ass.Calcula_estadistica();
                    Resultado = new Resultado_ASS(this.codigo_paciente, ass.omisiones, ass.equivocaciones, ass.aciertos, ass.aciertos_ext, ass.medias_tr, ass.desviaciones_tr,
                        ass.tiempos, DateTime.Now, false, this.tipo_estimulo);
                }
                this.Dispose();
            }

        }

        private void FormASS_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyValue == this.tecla_reaccion )
                KeyHasBeenRelease();
        }
        #endregion
        
    }
}
