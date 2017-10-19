using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using GraphicReport;
using PDF_Report;

namespace HerrmDiag.UserControls
{
    public partial class PdfReportViewerUC : UserControl
    {
        public PdfReportViewerUC()
        {
            InitializeComponent();
            this.panelColoEComision.BackColor = this.panelColorTR.BackColor = FunctionLibrary.ChartBarColorBlue;
            this.panelColorEOmision.BackColor = this.panelColorDSTR.BackColor = FunctionLibrary.ChartBarColorRed;
            this.panelColorIndiceAt.BackColor = FunctionLibrary.ChartBarColorGreen;
        }

        private Image GraficoPercentilesGenereales, GraficoErrores, GraficoTiemposReaccion;

        public ExportData Datos
        {
            set
            {
                ExportData datos = value;

                #region datos personales
                this.labelNombre.Text = 
                    string.Format("{0} {1} {2}", datos.Paciente.Nombre, datos.Paciente.Apellido1, datos.Paciente.Apellido2);
                this.labelFechaNac.Text = datos.Paciente.Fecha_Nacimiento.ToShortDateString();
                this.labelEdad.Text = datos.Paciente.Edad.ToString();
                this.labelSexo.Text = datos.Paciente.Sexo.ToString();
                this.labelNivel.Text = datos.Paciente.Escolaridad;
                this.labelFecha.Text = datos.Resultado.Fecha.ToShortDateString();
                #endregion

                #region tabla de valores generales
                var orientaciones = new[]
                    {
                        datos.Orientaciones.O_indice_atencion_total,
                        datos.Orientaciones.O_Aciertos,
                        datos.Orientaciones.O_Omision,
                        datos.Orientaciones.O_Comision,
                        datos.Orientaciones.O_TR,
                        datos.Orientaciones.O_ErrorTR,
                        datos.Orientaciones.O_d,
                        datos.Orientaciones.O_C
                    };
                for ( int i = 0; i < datos.TNotaciones.Count(); i++ )
                {
                    dgvGenerales.Rows.Add(  datos.TNotaciones.Parametros[i], 
                                            FunctionLibrary.ShowDouble( datos.Puntuaciones[i]),
                                            (i >= 6 && i <= 7) ? string.Empty : FunctionLibrary.ShowDouble( datos.TNotaciones[i] ), 
                                            orientaciones[i] );
                }
                #endregion

                #region gráfico de valores generales
                var chartGen = new Ar_Chart(ChartReportClass.PERCENTILES, 1000, 650, datos.TNotaciones.ChR_TNotaciones);
                this.GraficoPercentilesGenereales = chartGen.ToImage();
                this.pictureBoxGraficoGeneral.Refresh();
                #endregion

                #region tabla de valores por bloque
                for ( int i = 0; i < datos.PercentilesXbloque.GetLength(1); i++ )
                {
                    dgvPorBloques.Rows.Add( datos.TNotaciones.Parametros[i], 
                        datos.PercentilesXbloque[0, i],
                        datos.PercentilesXbloque[1, i],
                        datos.PercentilesXbloque[2, i], 
                        datos.PercentilesXbloque[3, i],
                        datos.PercentilesXbloque[4, i],
                        datos.PercentilesXbloque[5, i],
                        datos.PercentilesXbloque[6, i]
                    );
                }
                #endregion

                #region gráfico de errores
                var chartErr = new Ar_Chart( ChartReportClass.ERRORES, 1000, 650, datos.ChR_Errores );
                this.GraficoErrores = chartErr.ToImage();
                this.pictureBoxErrores.Refresh();
                #endregion

                #region gráfico de tiempos de reaccion
                var chartTR = new Ar_Chart( ChartReportClass.TIEMPOS, 1000, 650, datos.ChR_Tiempos );
                this.GraficoTiemposReaccion = chartTR.ToImage();
                this.pictureBoxTiemposReaccion.Refresh();
                #endregion

                #region gráfico de tiempos de reaccion

                this.richTextBoxConclusiones.Text = datos.Orientaciones.Conclusiones;

                #endregion
            }
        }

        private void pictureBoxGraficoGeneral_Paint(object sender, PaintEventArgs e)
        {
            if(this.GraficoPercentilesGenereales != null)
                e.Graphics.DrawImage(GraficoPercentilesGenereales, 0, 0, 
                    this.pictureBoxGraficoGeneral.Width, this.pictureBoxGraficoGeneral.Height);
        }
        private void pictureBoxErrores_Paint( object sender, PaintEventArgs e )
        {
            if ( this.GraficoErrores != null )
                e.Graphics.DrawImage( GraficoErrores, 0, 0,
                    this.pictureBoxErrores.Width, this.pictureBoxErrores.Height );
        }
        private void pictureBoxTiemposReaccion_Paint( object sender, PaintEventArgs e )
        {
            if ( this.GraficoTiemposReaccion != null )
                e.Graphics.DrawImage( GraficoTiemposReaccion, 0, 0,
                    this.pictureBoxTiemposReaccion.Width, this.pictureBoxTiemposReaccion.Height );
        }
    }
}
