using System;
using System.Windows.Forms;
using PsicoTests.Yovany;
using PsicoTests.Yovany.ASS.Homogeneas;

namespace HerrmDiag.UserControls
{
    public partial class ConfASSImagenesUC : UserControl
    {
        #region Campos
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDownBloques.Value = new decimal(conf.Bloques_ASS);
                this.numericUpDownEstimulos.Value = new decimal(conf.EstimulosBloques_ASS);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_ASS);
                this.numericUpDownOcultamiento.Value = new decimal(conf.TiempoOcultamiento_ASS);
                this.comboBoxTecla.Text = conf.TeclaTarget_ASS;
                this.comboBoxEstimulo.SelectedIndex = conf.Estimulo_ASS;
                int index = conf.Estimulo_ASS;
                this.pbColor.BackColor = conf.Color_Fondo_ASS;
                switch (index)
                {
                    case 0:
                        this.trackBar1.Maximum = conf.Imagenes_ASS_IMG.Count - 1;
                        this.pbEstimulo.Image = conf.Imagenes_ASS_IMG[trackBar1.Value];
                        break;
                    case 1:
                        this.trackBar1.Maximum = conf.Imagenes_ASS_FIG.Count - 1;
                        this.pbEstimulo.Image = conf.Imagenes_ASS_FIG[trackBar1.Value];
                        break;
                }
                this.trackBar1.Value = conf.ImageIndex_ASS;
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
            conf.Bloques_ASS = (int)this.numericUpDownBloques.Value;
            conf.EstimulosBloques_ASS = (int)this.numericUpDownEstimulos.Value;
            conf.TiempoVisualizacion_ASS = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoOcultamiento_ASS = (int)this.numericUpDownOcultamiento.Value;
            conf.TeclaTarget_ASS = this.comboBoxTecla.Text;
            conf.ImageIndex_ASS = this.trackBar1.Value;
            conf.Estimulo_ASS = this.comboBoxEstimulo.SelectedIndex;
            conf.Color_Fondo_ASS = this.pbColor.BackColor;
            conf.Estimulo_ASS = comboBoxEstimulo.SelectedIndex;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
            conf.Bloques_ASS = Atencion_Sostenida_Simple.PBloques;
            conf.EstimulosBloques_ASS = Atencion_Sostenida_Simple.PEstimulosBloque;
            conf.TiempoVisualizacion_ASS = Atencion_Sostenida_Simple.PTiempoVisualizacion;
            conf.TiempoOcultamiento_ASS = Atencion_Sostenida_Simple.PTiempoOcultamiento;
            conf.TeclaTarget_ASS = Atencion_Sostenida_Simple.PTeclaTarget;
            conf.ImageIndex_ASS = Atencion_Sostenida_Simple.PIndexDiana;
            conf.Color_Fondo_ASS = Atencion_Sostenida_Simple.PColorFondo;
            this.numericUpDownBloques.Value = conf.Bloques_ASS;
            this.numericUpDownEstimulos.Value = conf.EstimulosBloques_ASS;
            this.numericUpDownVisualizacion.Value = conf.TiempoVisualizacion_ASS;
            this.numericUpDownOcultamiento.Value = conf.TiempoOcultamiento_ASS;
            this.comboBoxTecla.Text = conf.TeclaTarget_ASS;
            this.trackBar1.Value = conf.ImageIndex_ASS;

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

        public ConfASSImagenesUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void comboBoxEstimulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.conf.Estimulo_ASS = this.comboBoxEstimulo.SelectedIndex;
            int index = this.comboBoxEstimulo.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.trackBar1.Maximum = conf.Imagenes_ASS_IMG.Count - 1;
                    break;
                case 1:
                    this.trackBar1.Maximum = conf.Imagenes_ASS_FIG.Count - 1;
                    break;
            }
            trackBar1.Value = 0;
            trackBar1_ValueChanged(null, null);
        }

        private void lbColorFondo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.pbColor.BackColor = this.colorDialog.Color;
            this.pbColor.Refresh();
        }
        private void buttonRigth_Click(object sender, EventArgs e)
        {
            int index = this.comboBoxEstimulo.SelectedIndex;
            int maxIndex = 0;
            switch (index)
            {
                case 0:
                    maxIndex = conf.Imagenes_ASS_IMG.Count - 1;
                    break;
                case 1:
                    maxIndex = conf.Imagenes_ASS_FIG.Count - 1;
                    break;
            }
            if (this.trackBar1.Value < maxIndex)
                this.trackBar1.Value++;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value > 0)
                this.trackBar1.Value--;
        }


        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxEstimulo.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.pbEstimulo.Image = conf.Imagenes_ASS_IMG[trackBar1.Value];
                    break;
                case 1:
                    this.pbEstimulo.Image = conf.Imagenes_ASS_FIG[trackBar1.Value];
                    break;
            }
            SetIndexImgage(this.lIndexImage, this.trackBar1);
        }

        #endregion

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
    }
}
