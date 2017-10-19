using ExcelReportTool.Abstract;
using Microsoft.Office.Interop.Excel;
using DALayer;

namespace ExcelReportTool
{
    public class XLS_ListRows : IXLSPrinteable
    {
        protected int FilaInicio { get; set; }

        public XLS_ListRows(int filaInicio)
        {
            this.FilaInicio = filaInicio;
        }

        public void Print(ref Worksheet wsheet)
        {
            var pacientes = new Paciente();
            pacientes.loadAll();
            var row = new XLS_Row();
            int fila = FilaInicio;
            if(pacientes.RowCount > 0)
            {
                pacientes.Rewind();
                do
                {
                    row.CodigoPaciente = pacientes.Codigo;
                    row.Fila = fila++;
                    row.Print(ref wsheet);
                } while ( pacientes.MoveNext() );
            }
        }
    }
}
