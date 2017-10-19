using System;
using System.Windows.Forms;
using PsicoTests.Alejandro;

namespace HerrmDiag.UserControls
{
    public partial class ConfAmplitudMemoriaUC : UserControl
    {
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.nudExposicion.Value = conf.Exp_Digito_AM;
                this.nudIntervalo.Value = conf.Intervalo_AM;
                this.nudTiempoReaccion.Value = conf.Reaccion_AM;
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
            conf.Exp_Digito_AM = (int) this.nudExposicion.Value;
            conf.Intervalo_AM = (int)this.nudIntervalo.Value;
            conf.Reaccion_AM = (int)this.nudTiempoReaccion.Value;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click(object sender, EventArgs e)
        {
            this.nudExposicion.Value = Amplitud_Memoria.PExp_digito;
            this.nudIntervalo.Value = Amplitud_Memoria.PIntervalo;
            this.nudTiempoReaccion.Value = Amplitud_Memoria.PReaccion;

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

        public ConfAmplitudMemoriaUC()
        {
            InitializeComponent();
        }

    }
}
