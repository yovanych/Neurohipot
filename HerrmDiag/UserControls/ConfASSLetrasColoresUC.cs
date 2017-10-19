using System;
using System.Windows.Forms;
using PsicoTests.Yovany;
using PsicoTests.Yovany.ASS.Colores;

namespace HerrmDiag.UserControls
{
    public partial class ConfASSLetrasColoresUC : UserControl
    {
       #region Campos
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDownBloques.Value = new decimal(conf.Bloques_CASS_L);
                this.numericUpDownEstimulos.Value = new decimal(conf.EstimulosBloques_CASS_L);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_CASS_L);
                this.numericUpDownOcultamiento.Value = new decimal(conf.TiempoOcultamiento_CASS_L);
                this.comboBoxTecla.Text = conf.TeclaTarget_CASS_L;
                this.trackBar1.Value = conf.Letra_Diana_CASS_L;
                this.pbColor.BackColor = conf.Color_Fondo_CASS_L;
                this.lLetra.BackColor = conf.Color_Fondo_CASS_L;
                this.lLetra.ForeColor = conf.Color_LetraDiana_CASS_L;
                this.trackBar1.Maximum = conf.Letras_CASS_L.Length - 1;
                this.lLetra.Text = conf.Letras_ASS_L[conf.Letra_Diana_CASS_L].ToString();
            }
        }
        #endregion

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
            Aceptar();
            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
            conf.Bloques_CASS_L = Atencion_Sostenida_Simple.PBloques;
            conf.EstimulosBloques_CASS_L = Atencion_Sostenida_Simple.PEstimulosBloque;
            conf.TiempoVisualizacion_CASS_L = Atencion_Sostenida_Simple.PTiempoVisualizacion;
            conf.TiempoOcultamiento_CASS_L = Atencion_Sostenida_Simple.PTiempoOcultamiento;
            conf.TeclaTarget_CASS_L = Atencion_Sostenida_Simple.PTeclaTarget;
            conf.Letra_Diana_CASS_L = Atencion_Sostenida_Simple.PLetraDiana;
            conf.Color_Fondo_CASS_L = Atencion_Sostenida_Simple.PColorFondo;
            conf.Color_LetraDiana_CASS_L = Atencion_Sostenida_Simple.PColorDiana;
            this.numericUpDownBloques.Value = conf.Bloques_CASS_L;
            this.numericUpDownEstimulos.Value = conf.EstimulosBloques_CASS_L;
            this.numericUpDownVisualizacion.Value = conf.TiempoVisualizacion_CASS_L;
            this.numericUpDownOcultamiento.Value = conf.TiempoOcultamiento_CASS_L;
            this.comboBoxTecla.Text = conf.TeclaTarget_CASS_L;
            this.pbColor.BackColor = conf.Color_Fondo_CASS_L;
            this.lLetra.BackColor = conf.Color_Fondo_CASS_L;
            this.lLetra.ForeColor = conf.Color_LetraDiana_CASS_L;
            this.trackBar1.Value = conf.Letra_Diana_CASS_L;

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

        public ConfASSLetrasColoresUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void derecha_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value < conf.Letras_ASS_L.Length - 1)
                this.trackBar1.Value++;
        }

        private void izquierda_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value > 0)
                this.trackBar1.Value--;
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.lLetra.Text = conf.Letras_ASS_L[trackBar1.Value].ToString();
            SetIndexImgage(this.lIndexImage, trackBar1);
        }
        private void lbColorFondo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.pbColor.BackColor = this.colorDialog.Color;
            this.lLetra.BackColor = this.colorDialog.Color;
            this.pbColor.Refresh();
        }
        private void lbColorLetras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.lLetra.ForeColor = this.colorDialog.Color;
            this.lLetra.Refresh();
        }
        #endregion

        #region Metodos privados
        private void Aceptar()
        {
            conf.Bloques_CASS_L = (int)this.numericUpDownBloques.Value;
            conf.EstimulosBloques_CASS_L = (int)this.numericUpDownEstimulos.Value;
            conf.TiempoVisualizacion_CASS_L = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoOcultamiento_CASS_L = (int)this.numericUpDownOcultamiento.Value;
            conf.TeclaTarget_CASS_L = this.comboBoxTecla.Text;
            conf.Letra_Diana_CASS_L = conf.Letras_ASS_L.IndexOf(this.lLetra.Text);
            conf.Color_Fondo_CASS_L = this.pbColor.BackColor;
            conf.Color_LetraDiana_CASS_L = this.lLetra.ForeColor;
        }
        private void SetIndexImgage(Label label, TrackBar trackBar)
        {
            int index = trackBar.Value;
            int total = trackBar1.Maximum;
            string text = string.Format("{0}{1} de {2}{3}",
                                        index > 9 ? string.Empty : "0",
                                        index,
                                        total > 9 ? string.Empty : "0",
                                        total);
            label.Text = text;
        }
        #endregion

    }
}
