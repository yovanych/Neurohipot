using System;
using System.Drawing;
using System.Windows.Forms;
using PsicoTests.Yovany;

namespace HerrmDiag.UserControls
{
    public partial class ConfTRComplejaUC : UserControl
    {
        private Color color;
        private Color color_aux1;
        private Color color_aux2;
        private TiempoReaccion.Figura fig_aux;

        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.fig_aux = conf.Figura_TRC;
                this.color_aux1 = conf.Color1_TRC;
                this.color = color_aux1;
                this.color_aux2 = conf.Color2_TRC;
                this.numericUpDownCantEstimulos.Value = new decimal(conf.MaxEstimulos_TRC);
                this.numericUpDownVisualizacion.Value = new decimal(conf.TiempoVisualizacion_TRC);
                this.numericUpDownReaccion.Value = new decimal(conf.TiempoReaccion_TRC);
                this.comboBoxTecla1.Text = conf.Tecla1_TRC;
                this.comboBoxTecla2.Text = conf.Tecla2_TRC;

                this.panel1.BackColor = color_aux1;
                this.panel2.BackColor = color_aux2;
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
            conf.Figura_TRC = this.fig_aux;
            conf.Color1_TRC = this.color_aux1;
            conf.Color2_TRC = this.color_aux2;
            conf.MaxEstimulos_TRC = (int)this.numericUpDownCantEstimulos.Value;
            conf.TiempoVisualizacion_TRC = (int)this.numericUpDownVisualizacion.Value;
            conf.TiempoReaccion_TRC = (int)this.numericUpDownReaccion.Value;
            conf.Tecla1_TRC = this.comboBoxTecla1.Text;
            conf.Tecla2_TRC = this.comboBoxTecla2.Text;

            if (AfterAcept != null)
                AfterAcept(sender, e);
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click(object sender, EventArgs e)
        {
            this.fig_aux = TiempoReaccion.PFigura;
            this.color_aux1 = TiempoReaccion.PColor1;
            this.color = color_aux1;
            this.color_aux2 = TiempoReaccion.PColor2;
            this.numericUpDownCantEstimulos.Value = new decimal(TiempoReaccion.PMaxEstimulos);
            this.numericUpDownVisualizacion.Value = new decimal(TiempoReaccion.PTiempoVisualizacion);
            this.numericUpDownReaccion.Value = new decimal(TiempoReaccion.PTiempoReaccion);
            this.comboBoxTecla1.Text = TiempoReaccion.PTecla1;
            this.comboBoxTecla2.Text = TiempoReaccion.PTecla2;

            this.panel1.BackColor = color_aux1;
            this.panel2.BackColor = color_aux2;

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

        public ConfTRComplejaUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void panelColor_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            colorDialog.ShowDialog(this);
            ((Panel)sender).BackColor = colorDialog.Color;
            color_aux1 = ((Panel)sender).BackColor;
            color = color_aux1;
            this.pictureBox1.Refresh();
        }

        private void panelColor2_Click(object sender, EventArgs e)
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            colorDialog.ShowDialog(this);
            ((Panel)sender).BackColor = colorDialog.Color;
            color_aux2 = ((Panel)sender).BackColor;
            color = color_aux2;
            this.pictureBox1.Refresh();
        }

        private void comboBoxFigura_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxFigura1.Text)
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

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int dim = (this.pictureBox1.Height / 5) * 3;
            int x = (this.pictureBox1.Width - dim) / 2;
            int y = dim / 3;
            Graphics g = e.Graphics;
            Brush b = new SolidBrush(this.color);

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
