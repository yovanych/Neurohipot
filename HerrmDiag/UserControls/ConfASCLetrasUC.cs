using System;
using System.Windows.Forms;
using PsicoTests.Yovany;
using PsicoTests.Yovany.ASC.Homogeneas;

namespace HerrmDiag.UserControls
{
    public partial class ConfASCLetrasUC : UserControl
    {
        #region Campos
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDownBloques.Value = new decimal(conf.Bloques_ASC_L);
                this.numericUpDownEstimulos.Value = new decimal(conf.EstimulosBloques_ASC_L);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_ASC_L);
                this.numericUpDownOcultamiento.Value = new decimal(conf.TiempoOcultamiento_ASC_L);
                this.comboBoxTecla.Text = conf.TeclaTarget_ASC_L;
                this.trackBar1.Value = conf.Index_Diana1_ASC_L;
                this.trackBar2.Value = conf.Index_Diana2_ASC_L;
                this.pbFondo1.BackColor = this.pbFondo2.BackColor = conf.Color_Fondo_ASC_L;
                this.lLetra1.BackColor = this.lLetra2.BackColor = conf.Color_Fondo_ASC_L;
                this.lLetra1.ForeColor = this.lLetra2.ForeColor = conf.Color_Letras_ASC_L;
                this.trackBar1.Maximum = conf.Letras_ASC_L.Length - 1;
                this.trackBar2.Maximum = conf.Letras_ASC_L.Length - 1;
                this.lLetra1.Text = conf.Letras_ASC_L[conf.Index_Diana1_ASC_L].ToString();
                this.lLetra2.Text = conf.Letras_ASC_L[conf.Index_Diana2_ASC_L].ToString();
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

        public ConfASCLetrasUC()
        {
            InitializeComponent();
        }

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
            this.numericUpDownBloques.Value = Atencion_Sostenida_Compleja_Letras.PBloques;
            this.numericUpDownEstimulos.Value = Atencion_Sostenida_Compleja_Letras.PEstimulosBloque;
            this.numericUpDownVisualizacion.Value = Atencion_Sostenida_Compleja_Letras.PTiempoVisualizacion;
            this.numericUpDownOcultamiento.Value = Atencion_Sostenida_Compleja_Letras.PTiempoOcultamiento;
            this.comboBoxTecla.Text = Atencion_Sostenida_Compleja_Letras.PTeclaTarget;
            this.pbFondo1.BackColor = this.pbFondo2.BackColor = Atencion_Sostenida_Compleja_Letras.PColorFondo;
            this.lLetra1.BackColor = this.lLetra2.BackColor = Atencion_Sostenida_Compleja_Letras.PColorFondo;
            this.lLetra1.ForeColor = this.lLetra2.ForeColor = Atencion_Sostenida_Compleja_Letras.PColorLetras;
            this.lLetra1.Text = conf.Letras_ASC_L[Atencion_Sostenida_Compleja_Letras.PIndexDiana1] + "";
            this.lLetra2.Text = conf.Letras_ASC_L[Atencion_Sostenida_Compleja_Letras.PIndexDiana2] + "";
            this.trackBar1.Value = Atencion_Sostenida_Compleja_Letras.PIndexDiana1;
            this.trackBar2.Value = Atencion_Sostenida_Compleja_Letras.PIndexDiana2;
            Aceptar();

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

        #region Eventos
        private void derecha1_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value < conf.Letras_ASC_L.Length - 1)
                this.trackBar1.Value++;
        }
        private void izquierda1_Click(object sender, EventArgs e)
        {
            if (this.trackBar1.Value > 0)
                this.trackBar1.Value--;
        }
        private void izquierda2_Click(object sender, EventArgs e)
        {
            if (this.trackBar2.Value > 0)
                this.trackBar2.Value--;
        }
        private void derecha2_Click(object sender, EventArgs e)
        {
            if (this.trackBar2.Value < conf.Letras_ASC_L.Length - 1)
                this.trackBar2.Value++;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.lLetra1.Text = conf.Letras_ASC_L[trackBar1.Value].ToString();
            SetIndexImgage(this.lIndexImage1, this.trackBar1);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.lLetra2.Text = conf.Letras_ASC_L[trackBar2.Value].ToString();
            SetIndexImgage(this.lIndexImage2, this.trackBar2);
        }

        private void lbcolorFondo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.pbFondo1.BackColor = this.pbFondo2.BackColor = this.colorDialog.Color;
            this.lLetra1.BackColor = this.lLetra2.BackColor = this.colorDialog.Color;
            this.pbFondo1.Refresh();
            this.pbFondo2.Refresh();
        }
        private void lbcolorLetra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.colorDialog.ShowDialog(this);
            this.lLetra1.ForeColor = this.lLetra2.ForeColor = this.colorDialog.Color;
            this.lLetra1.Refresh();
            this.lLetra2.Refresh();
        }
        #endregion
        
        #region Métodos privados
        private void Aceptar()
        {
            conf.Bloques_ASC_L = (int)this.numericUpDownBloques.Value;
            conf.EstimulosBloques_ASC_L = (int)this.numericUpDownEstimulos.Value;
            conf.TiempoVisualizacion_ASC_L = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoOcultamiento_ASC_L = (int)this.numericUpDownOcultamiento.Value;
            conf.TeclaTarget_ASC_L = this.comboBoxTecla.Text;
            conf.Index_Diana1_ASC_L = this.trackBar1.Value;
            conf.Index_Diana2_ASC_L = this.trackBar2.Value;
            conf.Color_Fondo_ASC_L = this.pbFondo1.BackColor;
            conf.Color_Letras_ASC_L = this.lLetra1.ForeColor;
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
