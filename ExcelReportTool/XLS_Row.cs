using ExcelReportTool.Abstract;
using Microsoft.Office.Interop.Excel;

namespace ExcelReportTool
{
    public class XLS_Row : IXLSPrinteable
    {
        public string CodigoPaciente { get; set; }
        public int Fila { get; set; }

        public XLS_Row(string codigo_paciente, int fila)
        {
            this.CodigoPaciente = codigo_paciente;
            this.Fila = fila;
        }
        public XLS_Row() : this(null, 2)
        {}

        public void Print(ref Worksheet wsheet)
        {
            var datos_personales = new XLS_PersonalDataSection(CodigoPaciente, this.Fila);
            datos_personales.Print(ref wsheet);
            var completas = new XLS_CompleteSection( CodigoPaciente, this.Fila );
            completas.Print( ref wsheet );

            var assIMG = new XLS_ASS_Imagenes_Section(CodigoPaciente, this.Fila);
            assIMG.Print( ref wsheet );
            var assTotIMG = new XLS_ASS_Imagenes_Totals( CodigoPaciente, this.Fila );
            assTotIMG.Print( ref wsheet );
            var assFIG = new XLS_ASS_FigAbst_Section( CodigoPaciente, this.Fila );
            assFIG.Print( ref wsheet );
            var assTotFIG = new XLS_ASS_FigAbst_Totals( CodigoPaciente, this.Fila );
            assTotFIG.Print( ref wsheet );
            var assLET = new XLS_ASS_Letras_Section( CodigoPaciente, this.Fila );
            assLET.Print( ref wsheet );
            var assTotLET = new XLS_ASS_Letras_Totals( CodigoPaciente, this.Fila );
            assTotLET.Print( ref wsheet );

            var ascIMG = new XLS_ASC_Imagenes_Section(CodigoPaciente, this.Fila);
            ascIMG.Print(ref wsheet);
            var ascTotIMG = new XLS_ASC_Imagenes_Totals(CodigoPaciente, this.Fila);
            ascTotIMG.Print(ref wsheet);
            var ascFIG = new XLS_ASC_FigAbst_Section( CodigoPaciente, this.Fila );
            ascFIG.Print( ref wsheet );
            var ascTotFIG = new XLS_ASC_FigAbst_Totals( CodigoPaciente, this.Fila );
            ascTotFIG.Print( ref wsheet );
            var ascLET = new XLS_ASC_Letras_Section(CodigoPaciente, this.Fila);
            ascLET.Print(ref wsheet);
            var ascTotLET = new XLS_ASC_Letras_Totals(CodigoPaciente, this.Fila);
            ascTotLET.Print(ref wsheet);
        }
    }
}
