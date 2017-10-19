using System;
using System.Windows.Forms;
using PsicoTests.Yovany.ASC.Homogeneas;

namespace HerrmDiag.UserControls
{
    public partial class ConfASCImagenesUC : UserControl
    {
        #region Campos
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDownBloques.Value = new decimal(conf.Bloques_ASC);
                this.numericUpDownEstimulos.Value = new decimal(conf.EstimulosBloques_ASC);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_ASC);
                this.numericUpDownOcultamiento.Value = new decimal(conf.TiempoOcultamiento_ASC);
                this.comboBoxTecla.Text = conf.TeclaTarget_ASC;
                this.comboBoxEstimulo.SelectedIndex = conf.Estimulo_ASC;
                this.trackBar1.Value = conf.ImageIndex1_ASC;
                this.trackBar2.Value = conf.ImageIndex2_ASC;
                this.pbColor1.BackColor = this.pbColor2.BackColor = conf.Color_Fondo_ASC;

                int index = conf.Estimulo_ASC;
                switch (index)
                {
                    case 0:
                        this.trackBar1.Maximum = conf.Imagenes_ASC_IMG.Count - 1;
                        this.trackBar2.Maximum = conf.Imagenes_ASC_IMG.Count - 1;
                        this.pictureBox1.Image = conf.Imagenes_ASC_IMG[trackBar1.Value];
                        this.pictureBox2.Image = conf.Imagenes_ASC_IMG[trackBar2.Value];
                        break;
                    case 1:
                        this.trackBar1.Maximum = conf.Imagenes_ASC_FIG.Count - 1;
                        this.trackBar2.Maximum = conf.Imagenes_ASC_FIG.Count - 1;
                        this.pictureBox1.Image = conf.Imagenes_ASC_FIG[trackBar1.Value];
                        this.pictureBox2.Image = conf.Imagenes_ASC_FIG[trackBar2.Value];
                        break;
                }
            }
        }
        #endregion

        #region Propiedades
        public bool ShowCancelButton
        {
            set { this.bCancel.Visible = value; }
            get { return this.bCancel.Visible; }
        }
        #endregion

        #region Eventos publicos
        public delegate void Clic_Delegate(object sender, EventArgs e);
        public event Clic_Delegate AfterAcept;
        private void Aceptar_Click(object sender, EventArgs e)
        {
            conf.Bloques_ASC = (int)this.numericUpDownBloques.Value;
            conf.EstimulosBloques_ASC = (int)this.numericUpDownEstimulos.Value;
            conf.TiempoVisualizacion_ASC = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoOcultamiento_ASC = (int)this.numericUpDownOcultamiento.Value;
            conf.TeclaTarget_ASC = this.comboBoxTecla.Text;
            conf.ImageIndex1_ASC = this.trackBar1.Value;
            conf.ImageIndex2_ASC = this.trackBar2.Value;
            conf.Color_Fondo_ASC = this.pbColor1.BackColor;
            conf.Estimulo_ASC = this.comboBoxEstimulo.SelectedIndex;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void buttonPredeterminados_Click(object sender, EventArgs e)
        {
            this.numericUpDownBloques.Value = Atencion_Sostenida_Compleja.PBloques;
            this.numericUpDownEstimulos.Value = Atencion_Sostenida_Compleja.PEstimulosBloque;
            this.numericUpDownVisualizacion.Value = Atencion_Sostenida_Compleja.PTiempoVisualizacion;
            this.numericUpDownOcultamiento.Value = Atencion_Sostenida_Compleja.PTiempoOcultamiento;
            this.comboBoxTecla.Text = Atencion_Sostenida_Compleja.PTeclaTarget;
            this.trackBar1.Value = Atencion_Sostenida_Compleja.PIndexDiana1;
            this.trackBar2.Value = Atencion_Sostenida_Compleja.PIndexDiana2;
            this.pbColor1.BackColor = this.pbColor2.BackColor = Atencion_Sostenida_Compleja.PColorFondo;

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

        public ConfASCImagenesUC()
        {
            InitializeComponent();
        }

        #region Eventos

        #region Image Navigation
        private void buttonRigt1_Click(object sender, EventArgs e)
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

        private void buttonLeft1_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value > 0)
                this.trackBar1.Value--;
        }

        private void buttonLeft2_Click(object sender, EventArgs e)
        {
            if (this.trackBar2.Value > 0)
                this.trackBar2.Value--;
        }

        private void buttonRigt2_Click(object sender, EventArgs e)
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
            if (this.trackBar2.Value < maxIndex)
                this.trackBar2.Value++;
        }
        
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxEstimulo.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.pictureBox1.Image = conf.Imagenes_ASC_IMG[trackBar1.Value];
                    break;
                case 1:
                    this.pictureBox1.Image = conf.Imagenes_ASC_FIG[trackBar1.Value];
                    break;
            }
            SetIndexImgage(this.lIndexImage1, this.trackBar1);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            int index = this.comboBoxEstimulo.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.pictureBox2.Image = conf.Imagenes_ASC_IMG[trackBar2.Value];
                    break;
                case 1:
                    this.pictureBox2.Image = conf.Imagenes_ASC_FIG[trackBar2.Value];
                    break;
            }
            SetIndexImgage(this.lIndexImage2, this.trackBar2);
        }

        #endregion

        private void comboBoxEstimulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.conf.Estimulo_ASC = this.comboBoxEstimulo.SelectedIndex;
            int index = this.comboBoxEstimulo.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.trackBar1.Maximum = conf.Imagenes_ASC_IMG.Count - 1;
                    this.trackBar2.Maximum = conf.Imagenes_ASC_IMG.Count - 1;
                    break;
                case 1:
                    this.trackBar1.Maximum = conf.Imagenes_ASC_FIG.Count - 1;
                    this.trackBar2.Maximum = conf.Imagenes_ASC_FIG.Count - 1;
                    break;
            }
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar1_ValueChanged(null, null);
            trackBar2_ValueChanged(null, null);
        }

        private void lbcolorFondo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.pbColor1.BackColor = this.pbColor2.BackColor = this.colorDialog.Color;
        }

        #endregion

        #region Métodos privados
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
