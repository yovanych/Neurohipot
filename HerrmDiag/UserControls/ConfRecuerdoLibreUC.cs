using System;
using System.Windows.Forms;
using PsicoTests.Yovany;

namespace HerrmDiag.UserControls
{
    public partial class ConfRecuerdoLibreUC : UserControl
    {

        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion1_RL);
                this.numericUpDownVisualizacion2.Value = new decimal(conf.TiempoVisualizacion2_RL);
                this.numericUpDownOcultamiento.Value = new decimal(conf.TiempoOcultamiento1_RL);
                this.numericUpDownOcultamiento2.Value = new decimal(conf.TiempoOcultamiento2_RL);
                this.numericUpDownVisualizacion15.Value = new decimal(conf.TiempoVisualizacion15_RL);
                this.comboBoxTeclaSi.Text = conf.Correcta_RL;
                this.comboBoxTeclaNo.Text = conf.Incorrecta_RL;
            }
            get { return conf; }
        }

        #region Propiedades
        public bool ShowCancelButton
        {
            set { this.bCancelar.Visible = value; }
            get { return this.bCancelar.Visible; }
        }
        #endregion

        #region Eventos publicos
        public delegate void Clic_Delegate(object sender, EventArgs e);
        public event Clic_Delegate AfterAcept;
        private void Aceptar_Click(object sender, EventArgs e)
        {
            conf.TiempoVisualizacion1_RL = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoVisualizacion2_RL = (int)this.numericUpDownVisualizacion2.Value;
            conf.TiempoOcultamiento1_RL = (int)this.numericUpDownOcultamiento.Value;
            conf.TiempoOcultamiento2_RL = (int)this.numericUpDownOcultamiento2.Value;
            conf.TiempoVisualizacion15_RL = (int)this.numericUpDownVisualizacion15.Value;
            conf.Correcta_RL = this.comboBoxTeclaSi.Text;
            conf.Incorrecta_RL = this.comboBoxTeclaNo.Text;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click(object sender, EventArgs e)
        {
            this.numericUpDownVisualizacion.Value = Recuerdo_Libre.PTiempoVisualizacion1;
            this.numericUpDownVisualizacion2.Value = Recuerdo_Libre.PTiempoVisualizacion2;
            this.numericUpDownOcultamiento.Value = Recuerdo_Libre.PTiempoOcultamiento1;
            this.numericUpDownOcultamiento2.Value = Recuerdo_Libre.PTiempoOcultamiento1;
            this.numericUpDownVisualizacion15.Value = Recuerdo_Libre.PTiempoVisualizacion1;
            this.comboBoxTeclaSi.Text = Recuerdo_Libre.PCorrecta;
            this.comboBoxTeclaNo.Text = Recuerdo_Libre.PIncorrecta;

            if (AfterPresets != null)
                AfterPresets(sender, e);
        }
        public event Clic_Delegate AfterCancel;
        private void Cancel_Click(object sender, EventArgs e)
        {
            if (AfterCancel != null)
                AfterCancel(sender, e);
        }
        #endregion

        public ConfRecuerdoLibreUC()
        {
            InitializeComponent();
        }
    }
}
