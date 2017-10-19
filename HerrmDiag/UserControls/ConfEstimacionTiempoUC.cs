using System;
using System.Windows.Forms;
using HerrmDiag.Properties;
using PsicoTests.Alejandro;

namespace HerrmDiag.UserControls
{
    public partial class ConfEstimacionTiempoUC : UserControl
    {
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.nudAltoEstimulo.Value = conf.AltoEstimulo_ET;
                this.nudAnchoEstimulo.Value = conf.AnchoEstimulo_ET;
                this.nudAnchoRespCorrecta.Value = conf.AreaCorrecta_ET;
                this.nudAnchoZonaOpaca.Value = conf.ZonaOpaca_ET;
                this.nudIntervalo.Value = conf.IntervaloSalida_ET;
                this.nudMaxEstimulos.Value = conf.MaxEstimulos_ET;
                this.pColorEstimulo.BackColor = conf.Estimulo_ET;
                this.pColorZonaOp.BackColor = conf.ColorZonaOpaca_ET;
                this.cbTecla.Text = conf.TeclaReaccion_ET == 13 
                    ? Resources.KeyName_Enter 
                    : Resources.KeyName_Space;
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
            conf.AltoEstimulo_ET = (int)this.nudAltoEstimulo.Value;
            conf.AnchoEstimulo_ET = (int)this.nudAnchoEstimulo.Value;
            conf.AreaCorrecta_ET = (int)this.nudAnchoRespCorrecta.Value;
            conf.ZonaOpaca_ET = (int)this.nudAnchoZonaOpaca.Value;
            conf.IntervaloSalida_ET = (int)this.nudIntervalo.Value;
            conf.MaxEstimulos_ET = (int)this.nudMaxEstimulos.Value;
            conf.Estimulo_ET = this.pColorEstimulo.BackColor;
            conf.ColorZonaOpaca_ET = this.pColorZonaOp.BackColor;
            conf.TeclaReaccion_ET = this.cbTecla.Text == Resources.KeyName_Enter ? 13 : 32;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click(object sender, EventArgs e)
        {
            this.nudAltoEstimulo.Value = Estimacion_Tiempo.PaltoEstimulo;
            this.nudAnchoEstimulo.Value = Estimacion_Tiempo.PanchoEstimulo;
            this.nudAnchoRespCorrecta.Value = Estimacion_Tiempo.PareaCorrecta;
            this.nudAnchoZonaOpaca.Value = Estimacion_Tiempo.PzonaOpaca;
            this.nudIntervalo.Value = Estimacion_Tiempo.PintervaloSalida;
            this.nudMaxEstimulos.Value = Estimacion_Tiempo.PmaxEstimulos;
            this.pColorEstimulo.BackColor = Estimacion_Tiempo.Pestimulo;
            this.pColorZonaOp.BackColor = Estimacion_Tiempo.PcolorZonaOpaca;
            this.cbTecla.Text = Estimacion_Tiempo.PteclaReaccion == 13 
                ? Resources.KeyName_Enter 
                : Resources.KeyName_Space;

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
        
        public ConfEstimacionTiempoUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void pColor_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            colorDialog.ShowDialog(this);
            ((Panel)sender).BackColor = colorDialog.Color;
        }
        #endregion
    }
}
