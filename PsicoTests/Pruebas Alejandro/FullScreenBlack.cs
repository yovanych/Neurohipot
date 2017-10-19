using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Complementos;
using ImgSet;

namespace PsicoTests
{
	/// <summary>
	/// Summary description for FullScreenBlack.
	/// </summary>
	public class FullScreenBlack :  System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel;
		
		#region Mis variables

		public IPrueba p;
		//private bool ejemplo;
		private bool EnCurso;
        private Resultado r;

        public Resultado Resultado
        {
            get { return r; }
            set { r = value; }
        }

		
		#endregion

		private System.ComponentModel.Container components = null;

        #region Constructores
        public FullScreenBlack(string id, ImgSet.ImageSet listaIMG)
		{			
			InitializeComponent();
			//ejemplo = false;
            //switch (id)
            //{
            //    case "MF":
            //        this.p = new Memoria_Figuras(this.panel, listaIMG);
            //        //ejemplo = false;
            //        break;
            //    case "PVA":
            //        this.p = new Pares_Visuales_Asociados(this.panel, listaIMG);
            //        //ejemplo = false;
            //        break;
            //    case "PVA2":
            //        this.p = new Pares_Visuales_Asociados_2(this.panel, listaIMG);
            //        //ejemplo = false;
            //        break;

            //    case "E_MF":
            //        this.p = new Ensayo_Memoria_Figuras(this.panel, listaIMG);
            //        //ejemplo = true;
            //        break;
            //    case "E_PVA":
            //        this.p = new Ensayo_Pares_Visuales_Asociados(this.panel, listaIMG);
            //        //ejemplo = false;
            //        break;
            //    default:
            //        throw new Exception();
            //}
        }
        public FullScreenBlack(int presentacion, int muestra, ImgSet.ImageSet listaMF)
        {
            //InitializeComponent();
            //this.p = new Memoria_Figuras(this.panel, presentacion, muestra, Memoria_Figuras.Pdescanso, listaMF);
            ////ejemplo = false;
        }
        public FullScreenBlack(int presentacion, int muestra, int descanso, Color[] colores, bool segunda_etapa, ImgSet.ImageSet listaIMG)
        {
        //    InitializeComponent();
        //    if(!segunda_etapa)
        //        this.p = new Pares_Visuales_Asociados(this.panel, presentacion, muestra, Pares_Visuales_Asociados.Pdescanso, colores, listaIMG);
        //else this.p = new Pares_Visuales_Asociados_2(this.panel, presentacion, Pares_Visuales_Asociados.Pdescanso, colores, listaIMG);
        //    //ejemplo = false;
        }
        #endregion
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullScreenBlack));
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DimGray;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(688, 528);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // FullScreenBlack
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(688, 528);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullScreenBlack";
            this.Text = "NeuroSoftware";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FullScreenBlack_KeyDown);
            this.ResumeLayout(false);

		}
		#endregion

		private void panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.p.click(e.X,  e.Y);			
		}

		private void FullScreenBlack_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
            //if(e.KeyValue == 13)
            //{
            //    if (!EnCurso)
            //    {
            //        EnCurso = true;
            //        p.Start();
            //        return;
            //    }
            //}
            //if (e.KeyValue == 27)
            //{                
            //    EnCurso = false;
            //    p.Stop();
            //    if (p is Prueba_Psicológica)
            //        r = ((Prueba_Psicológica)p).Resultado;
            //    this.Dispose();                
            //}
			
		}

		private void panel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
            //Graphics g = this.panel.CreateGraphics();
            //if(p is Pares_Visuales_Asociados)
            //{
            //    int W = this.panel.Width;
            //    int H = this.panel.Height;
            //    int a_f = W/4;
            //    int a_c = 3*W/16;
            //    int b_f = H/5;					
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[0]),W/2,H/10,a_c,H/5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[1]), 3 * W / 4, H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[2]), W / 2, 4 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[3]), 3 * W / 4, 4 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[4]), W / 2, 7 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados)p).Colores[5]), 3 * W / 4, 7 * H / 10, a_c, H / 5);
            //}
            //if (p is Pares_Visuales_Asociados_2)
            //{
            //    int W = this.panel.Width;
            //    int H = this.panel.Height;
            //    int a_f = W / 4;
            //    int a_c = 3 * W / 16;
            //    int b_f = H / 5;
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[0]), W / 2, H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[1]), 3 * W / 4, H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[2]), W / 2, 4 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[3]), 3 * W / 4, 4 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[4]), W / 2, 7 * H / 10, a_c, H / 5);
            //    g.FillRectangle(new SolidBrush(((Pares_Visuales_Asociados_2)p).Colores[5]), 3 * W / 4, 7 * H / 10, a_c, H / 5);
            //}
            //Font f = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold);
            //Brush brush = new SolidBrush(Color.LightYellow);            
            //g.DrawString("Oprima [Enter] para comenzar", f, brush,10 , this.panel.Height - 30);
		}
	}
}
