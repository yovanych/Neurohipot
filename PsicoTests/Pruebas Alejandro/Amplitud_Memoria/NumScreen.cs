using System.Windows.Forms;
using DALayer;

namespace PsicoTests.Alejandro
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class NumScreen : FormWithResultNUtils
	{
        private readonly Amplitud_Memoria am;

	    /// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
       
        #region Constructores
        public NumScreen(string codigoPaciente)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
			am = new Amplitud_Memoria(this, codigoPaciente);
        }
        
        public NumScreen(int digito, string codigoPaciente,  int intervalo, int reaccion)
        {
            InitializeComponent();
            am = new Amplitud_Memoria(this, codigoPaciente, digito, intervalo, reaccion);
        }
        #endregion

        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumScreen));
            this.SuspendLayout();
            // 
            // NumScreen
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NumScreen";
            this.Text = "NeuroSoftware";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NumScreen_FormClosing);
            this.ResumeLayout(false);

		}
		#endregion

        private void NumScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Resultado = am.Resultado;
        }
        
	}
}
