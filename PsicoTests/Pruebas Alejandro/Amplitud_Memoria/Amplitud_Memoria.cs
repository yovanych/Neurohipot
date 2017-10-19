using System;
using System.Windows.Forms;
using DALayer;


namespace PsicoTests.Alejandro
{
	
    public enum Estado_AM { Exponer_Digito, Ocultar_Digito, Reaccion, Descanso, Nulo };
    
    public class Amplitud_Memoria : Prueba_Psicológica
    {
        #region Parametros
            #region Predeterminados
            public static int PExp_digito = 700;
            public static int PIntervalo = 300;
            public static int PReaccion = 5000;
            public static int PDesasiertos = 2;        
            #endregion
        private readonly int exp_digito;
        private readonly int intervalo;
        private readonly int reaccion;
        //private int desasiertos;
        #endregion

        private readonly Test_AM test;
		public Label label, sennal;
		public TextBox box;               
		public Timer t1, t2;		
		private int ronda, char_;
        private bool adelante, en_Curso;
        private Estado_AM estado;
        private int fallos;
        private readonly string codigoPaciente;

        #region Costructores
        public Amplitud_Memoria(Control c, string codigoPaciente, int exp_digito, int intervalo, int reaccion)//, int desasiertos)
            :base(null)
        {
            this.codigoPaciente = codigoPaciente;
            estado = Estado_AM.Nulo;
			t1 = new Timer {Interval = 300};
            t2 = new Timer {Interval = 1};
            t1.Tick += t1_tick;
			t2.Tick += t2_tick;			
			test = new Test_AM();			
			this.char_ = 0;
			ronda = 0;
			adelante = true;
			en_Curso = true;
			Resultado = null;
            this.fallos = 0;
            int y = (Screen.PrimaryScreen.Bounds.Height- 200) / 2;
            
            this.label = new Label();
            this.sennal = new Label();
            this.box = new TextBox();

            #region LABEL
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(385, 65);
            int xL = (Screen.PrimaryScreen.Bounds.Width - label.Width) / 2;
            this.label.Location = new System.Drawing.Point(xL, y);
            this.label.TabIndex = 0;
            this.label.Text = "";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            c.Controls.Add(this.label);
            #endregion

            #region SEÑAL
            this.sennal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.sennal.Location = new System.Drawing.Point(40, 30);
            this.sennal.Name = "sennal";
            this.sennal.Size = new System.Drawing.Size(700, 40);
            this.sennal.TabIndex = 2;
            this.sennal.Text = @"Teclee [Enter] cuando esté listo (Hacia adelante)";
            this.sennal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            c.Controls.Add(this.sennal);
            #endregion

            #region BOX
            this.box.BackColor = System.Drawing.SystemColors.Control;
            this.box.BorderStyle = BorderStyle.FixedSingle;
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.box.Size = new System.Drawing.Size(385, 83);
            int xB = (Screen.PrimaryScreen.Bounds.Width - box.Width) / 2;
            this.box.Location = new System.Drawing.Point(xB, y);
            this.box.Name = "box";
            
            this.box.TabIndex = 1;
            this.box.Text = "";
            this.box.TextAlign = HorizontalAlignment.Center;
            this.box.Visible = false;
            this.box.KeyDown += this.control_KeyDown;
            this.box.KeyPress += textBox1_KeyPress;
            c.Controls.Add(this.box);
            c.KeyDown += this.control_KeyDown;
            #endregion

            this.exp_digito = exp_digito;
            this.intervalo = intervalo;
            this.reaccion = reaccion;
            //this.desasiertos = desasiertos;
		}
        public Amplitud_Memoria(Control c, string codigoPaciente )
            : this(c, codigoPaciente, PExp_digito, PIntervalo, PReaccion)//, PDesasiertos)
        { }
        #endregion

        private void t2_tick(object sender, EventArgs e)
		{
			if(estado == Estado_AM.Ocultar_Digito)//t2.Interval == 1)
			{
				this.box.Text = "";
				this.box.Visible = true;
				this.box.Focus();
				t2.Interval = reaccion;
                estado = Estado_AM.Reaccion;
			}
			else
				if(estado == Estado_AM.Reaccion)//t2.Interval == reaccion)
			{
				this.box.Visible = false;
				this.t2.Interval = 1;
                estado = Estado_AM.Descanso;
				this.t2.Stop();
				this.label.Parent.Focus();
				this.sennal.Visible = true;
			    if (box.Text != "")
                {
                    long n = long.Parse(box.Text);
                    fallos += this.test.diana(n, this.adelante, ronda);
                }
                else
                    fallos++;
                    
                if (fallos >= 2)
                {
                    if (adelante)
                    {
                        ronda = test.hacia_delante.Length;
                        fallos = 0;
                    }
                    else
                    {
                        adelante = true;
                        ronda = 0;
                        en_Curso = false;
                        estado = Estado_AM.Nulo;
                        this.box.Visible = false;
                        this.label.Visible = false;
                        this.Resultado = new Resultado_AM(codigoPaciente, test.maximo_delante, test.ptos_delante, test.maximo_detras, test.ptos_detras, DateTime.Now, true);
                        this.sennal.Text = @"La prueba ha sido interrumpida";
                    }
                }
				ronda ++;
				if(adelante)
				{
					if(ronda >= test.hacia_delante.Length)
					{
						adelante = false;
						this.sennal.Text = @"Teclee [Enter] cuando esté listo (Hacia atrás)";
						ronda = 0;
					}
				}
				else
					if(ronda == test.hacia_detras.Length)
				{
					adelante = true;
					ronda = 0;
					en_Curso = false;
                    estado = Estado_AM.Nulo;
                    this.Resultado = new Resultado_AM(codigoPaciente, test.maximo_delante, test.ptos_delante, test.maximo_detras, test.ptos_detras, DateTime.Now, true);
                    this.sennal.Text = @"La prueba ha terminado";
				}
				this.sennal.Visible = true;
			}
		}

		private void t1_tick(object sender, EventArgs e)
		{	
			this.sennal.Visible = false;
		    string s = adelante ? (test.hacia_delante[ronda].ToString()) : (test.hacia_detras[ronda].ToString());
			
			if(estado == Estado_AM.Descanso || estado == Estado_AM.Ocultar_Digito)//this.t1.Interval == intervalo)
			{
                estado = Estado_AM.Exponer_Digito;
				this.t1.Interval = exp_digito;
				this.label.Visible = true;
				this.label.Text = ""+s[char_++];
			}
			else
                if (estado == Estado_AM.Exponer_Digito)//this.t1.Interval == exp_digito)
				{
					this.label.Visible = false;
					this.t1.Interval = intervalo;
                    estado = Estado_AM.Ocultar_Digito;
					if(char_ == s.Length)
					{
						t1.Stop();
						t2.Start();
						char_ = 0;
					}
				}
		}


		public override void Stop()
		{
			this.t1.Stop();
			this.t2.Stop();
			en_Curso = true;
			this.ronda = 0;
			this.adelante = true;
		}

		public override void Start()
		{
			if(en_Curso)
			{				
				this.box.Visible = false;
				this.label.Text = "";
                this.char_ = 0;
                estado = Estado_AM.Descanso;
				t1.Start();			
			}
			
		}

        public override void click(int x, int y)
        {
            throw new NotImplementedException();
        }
		
		public bool En_Curso
		{
			get
			{
				return en_Curso;
			}
		}

        public void control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && !(sender is TextBox))
            {
                if (En_Curso)
                    Start();
                return;
            }
            if (e.KeyValue == 27)
            {
                t1.Stop();
                t2.Stop();
                ((Control)sender).Dispose();
                if (En_Curso)
                    this.Resultado = new Resultado_AM(codigoPaciente, test.maximo_delante, test.ptos_delante, test.maximo_detras, test.ptos_detras, DateTime.Now, false);
                return;
            }            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' &&
                e.KeyChar != '2' && e.KeyChar != '3' &&
                e.KeyChar != '4' && e.KeyChar != '5' &&
                e.KeyChar != '6' && e.KeyChar != '7' &&
                e.KeyChar != '8' && e.KeyChar != '9')
            {
                e.Handled = true;
            }
        }
    }
    
}
