using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALayer;
using DataAccessTool.DAL;

namespace ExcelReportTool.Abstract
{
    public abstract class XLSAS_Totals : XLS_Section
    {
        protected XLSAS_Totals(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        {
        }

        #region Abstract
        protected abstract _ResAS GetResultsOfMyType(string codigo_paciente);
        #endregion
        
        protected override System.Data.DataTable initTable()
        {
            var table = new System.Data.DataTable("Totales");
            const string testName = "AS_";
            const string v_correctas = "TC_";
            const string v_correctasR = "TCR_";
            const string v_omisiones = "TO_";
            const string v_errores = "TE_";
            const string v_tiempoReaccion = "TTR_";
            const string v_desviacionTR = "TDSTR_";
            const string v_indice = "TIA";

            var values = new List<object>();
            var resultados = GetResultsOfMyType(this.codigoPaciente);
            
            table.Columns.Add(testName + v_correctas, typeof(int));
            table.Columns.Add(testName + v_correctasR, typeof(int));
            table.Columns.Add(testName + v_omisiones, typeof(int));
            table.Columns.Add(testName + v_errores, typeof(int));
            table.Columns.Add(testName + v_tiempoReaccion, typeof(int));
            table.Columns.Add(testName + v_desviacionTR, typeof(double));
            table.Columns.Add(testName + v_indice, typeof(double));

            values.Add(resultados.RowCount != 0 ? resultados.Total_Aciertos : 0);
            values.Add(resultados.RowCount != 0 ? resultados.Total_Aciertos_Ext : 0);
            values.Add(resultados.RowCount != 0 ? resultados.Total_Omisiones : 0);
            values.Add(resultados.RowCount != 0 ? resultados.Total_Equivocaciones : 0);
            values.Add(resultados.RowCount != 0 ? resultados.Media : 0);
            values.Add(resultados.RowCount != 0 ? resultados.Desviacion : 0);
            values.Add(resultados.RowCount != 0 ? resultados.IndiceAtencionTotal : 0);

            table.Rows.Add(values.ToArray());
            return table;
        }
    }
}
