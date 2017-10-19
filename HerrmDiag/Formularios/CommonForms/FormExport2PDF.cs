using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using PDF_Report;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormExport2PDF : Form
    {
        private readonly Paciente paciente;
        private Resultado resultado;
        private ExportData datos;
        string filename;

        public FormExport2PDF(Paciente paciente, Resultado_AS r)
        {
            InitializeComponent();
            var ToolTipMostrar = new ToolTip();
            ToolTipMostrar.SetToolTip(this.buttonImprimir, "Muestra el reporte en formato pdf y permite imprimirlo desde esa ventana");
            var ToolTipExportar = new ToolTip();
            ToolTipExportar.SetToolTip(this.buttonExportar, "Exporta reporte a formato pdf en la dirección especificada por el usuario");
            this.paciente = paciente;
            this.resultado = r;
            this.datos = new ExportData(this.paciente, resultado);
            this.pdfReportViewerUC1.Datos = datos;
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            this.savePDFFileDialog.ShowDialog(this);
        }

        private void savePDFFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            var pdfReporte = new PDF_Reporte(datos);
            try
            {
                filename = this.savePDFFileDialog.FileName;
                pdfReporte.Save(filename);
            }
            catch (Exception ex)
            {
                var war = new Resp("El documento que se intenta salvar está siendo usado por otro programa",
                                   "Atención!!");
                war.ShowDialog(this);
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var pdfReporte = new PDF_Reporte(datos);
                pdfReporte.Save("reporte.pdf");
                filename = "reporte.pdf";
                FormVisorDeReportePdf f = new FormVisorDeReportePdf(filename);
                f.Show();
            }
            catch (Exception ex)
            {
                var war = new Resp("Usted necesita actualizar su versión de Acrobat Reader",
                                   "Atención!!");
                war.ShowDialog(this);
            }
        }

        private void FormExport2PDF_Load(object sender, EventArgs e)
        {

        }
    }
}
