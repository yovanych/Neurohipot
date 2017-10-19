using System.Collections.Generic;
using BusinessObjects;
using DALayer;
using DataAccessTool.DAL;
using ExcelReportTool.Abstract;

namespace ExcelReportTool
{
    public class XLS_CompleteSection: XLS_Section
    {
        public XLS_CompleteSection( string codigoPaciente, int fila )
            : base(codigoPaciente, fila)
        {
        }


        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn("F"); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn("K"); }

        protected override System.Data.DataTable initTable()
        {
            var table = new System.Data.DataTable("completas");
            
            var values = new List<object>();
            //var resultados = GetResultsOfMyType(this.codigoPaciente);
            
            table.Columns.Add( "SI", typeof(string));
            table.Columns.Add( "SF", typeof( string ) );
            table.Columns.Add( "SL", typeof( string ) );
            table.Columns.Add( "CI", typeof( string ) );
            table.Columns.Add( "CF", typeof( string ) );
            table.Columns.Add( "CL", typeof( string ) );

            // Simple
            _ResAS resultados = new _ResASS();
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Imagenes );
            values.Add(resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty);
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Figuras_Abstractas );
            values.Add( resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty );
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Letras );
            values.Add( resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty );
            // Compleja
            resultados = new _ResASC();
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Imagenes );
            values.Add( resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty );
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Figuras_Abstractas );
            values.Add( resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty );
            resultados.LoadByTypeOfTest( this.codigoPaciente, TypeOf_AS_Test.H_Letras );
            values.Add( resultados.RowCount != 0 && resultados.Completo ? "X" : string.Empty );

            table.Rows.Add(values.ToArray());
            return table;
        }
    }
}
