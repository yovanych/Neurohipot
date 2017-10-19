using System;
using System.Drawing;
using System.Windows.Forms;
using PsicoTests.Yovany;

namespace HerrmDiag.UserControls
{
    public partial class ConfTRSimpleUC : UserControl
    {
        private Color color_aux;
        private TiempoReaccion.Figura fig_aux;

        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.fig_aux = conf.Figura_TRS;
                this.color_aux = conf.Color1_TRS;
                this.numericUpDownCantEstimulos.Value = new decimal(conf.MaxEstimulos_TRS);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_TRS);
                this.numericUpDownReaccion.Value = new decimal(conf.TiempoReaccion_TRS);
                this.comboBoxTecla1.Text = conf.Tecla1_TRS;

                this.panelColor.BackColor = color_aux;
                this.pictureBox1.Refresh();
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
            conf.Figura_TRS = this.fig_aux;
            conf.Color1_TRS = this.color_aux;
            conf.MaxEstimulos_TRS = (int)this.numericUpDownCantEstimulos.Value;
            conf.TiempoVisualizacion_TRS = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoReaccion_TRS = (int)this.numericUpDownReaccion.Value;
            conf.Tecla1_TRS = this.comboBoxTecla1.Text;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click(object sender, EventArgs e)
        {
            this.fig_aux = TiempoReaccionSimple.PFigura;
            this.color_aux = TiempoReaccionSimple.PColor1;
            this.numericUpDownCantEstimulos.Value = new decimal(TiempoReaccionSimple.PMaxEstimulos);
            this.numericUpDownVisualizacion.Value = new decimal(TiempoReaccionSimple.PTiempoVisualizacion);
            this.numericUpDownReaccion.Value = new decimal(TiempoReaccionSimple.PTiempoReaccion);
            this.comboBoxTecla1.Text = TiempoReaccionSimple.PTecla1;

            this.panelColor.BackColor = color_aux;

            this.pictureBox1.Refresh();

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

        public ConfTRSimpleUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void panelColor_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            colorDialog.ShowDialog(this);
            ((Panel)sender).BackColor = colorDialog.Color;
            color_aux = colorDialog.Color;
            this.pictureBox1.Refresh();
        }

        private void comboBoxFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxFigura.Text)
            {
                case "Círculo":
                    fig_aux = TiempoReaccion.Figura.Circulo;
                    break;
                case "Cuadrado":
                    fig_aux = TiempoReaccion.Figura.Cuadrado;
                    break;
                case "Triángulo":
                    fig_aux = TiempoReaccion.Figura.Triangulo;
                    break;
                default:
                    break;
            }
            this.pictureBox1.Refresh();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            int dim = (this.pictureBox1.Height / 5) * 3;
            int x = (this.pictureBox1.Width - dim) / 2;
            int y = dim / 3;
            Graphics g = e.Graphics;
            Brush b = new SolidBrush(this.color_aux);

            switch (this.fig_aux)
            {
                case TiempoReaccion.Figura.Circulo:
                    g.FillEllipse(b, x, y, dim, dim);
                    break;
                case TiempoReaccion.Figura.Cuadrado:
                    g.FillRectangle(b, x, y, dim, dim);
                    break;
                case TiempoReaccion.Figura.Triangulo:
                    var p = new[]{new Point(this.pictureBox1.Width/2, y), 
                                          new Point(x - 5, y + dim),
                                          new Point(this.pictureBox1.Width - x + 5, y + dim)};
                    g.FillPolygon(b, p);
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
