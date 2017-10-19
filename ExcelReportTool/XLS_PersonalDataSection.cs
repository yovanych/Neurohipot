using BusinessObjects;
using DALayer;
using ExcelReportTool.Abstract;
using ExcelReportTool.Res;

namespace ExcelReportTool
{
    public class XLS_PersonalDataSection : XLS_Section
    {

        public XLS_PersonalDataSection( string codigoPaciente, int fila )
            : base(codigoPaciente, fila)
        {}

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_PersonalData_First); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_PersonalData_Last); }

        protected override System.Data.DataTable  initTable()
        {
            var p = new Paciente();
            p.LoadByID( codigoPaciente );

            var table = new System.Data.DataTable( "DatosPersonales" );
            table.Columns.Add( "Sujeto", typeof( string ) );
            table.Columns.Add( "Sexo", typeof ( string ) );
            table.Columns.Add( "Edad", typeof( int ) );
            table.Columns.Add( "Aplicador", typeof( string ) );
            table.Columns.Add( "Lugar", typeof( string ) );
            table.Rows.Add( p.Codigo, p.Sexo == Sexo.Masculino ? "M" : "F", p.Edad, p.Aplicador, p.Lugar );
            return table;
        }
    }
}
