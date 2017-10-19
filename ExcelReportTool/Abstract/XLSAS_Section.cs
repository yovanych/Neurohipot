using System.Collections.Generic;
using DALayer;

namespace ExcelReportTool.Abstract
{
    public abstract class XLSAS_Section : XLS_Section
    {
        protected XLSAS_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        {
        }

        #region Abstract
        protected abstract _Indicadores GetIndicadoresInstance();
        //protected abstract Table_Res GetResultInstance();
        protected abstract Table_Res GetResultsOfMyType(string codigo_paciente);
        #endregion

        protected override System.Data.DataTable initTable()
        {
            return this.initTable(GetIndicadoresInstance());
        }

        protected System.Data.DataTable initTable(_Indicadores indicadores)
        {
            var table = new System.Data.DataTable("Bolques");
            const string testName = "AS_";
            const string v_correctas = "C_";
            const string v_omisiones = "O_";
            const string v_errores = "E_";
            const string v_tiempoReaccion = "TR_";
            const string v_desviacionTR = "DSTR_";
            const string v_indice = "IA";
            const string bloque = "B";

            var values = new List<object>();
            var resultados = GetResultsOfMyType(this.codigoPaciente);
            
            for (int i = 0; i <= 7; i++)
            {
                indicadores.LoadByID(resultados.Fecha, codigoPaciente, i);

                table.Columns.Add(testName + v_correctas + bloque + (i + 1), typeof(int));
                table.Columns.Add(testName + v_omisiones + bloque + (i + 1), typeof(int));
                table.Columns.Add(testName + v_errores + bloque + (i + 1), typeof(int));
                table.Columns.Add(testName + v_tiempoReaccion + bloque + (i + 1), typeof(int));
                table.Columns.Add(testName + v_desviacionTR + bloque + (i + 1), typeof(double));
                table.Columns.Add(testName + v_indice + bloque + (i + 1), typeof(double));

                values.Add(indicadores.RowCount != 0 ? indicadores.Aciertos + indicadores.Aciertos_Extrannos : 0);
                values.Add(indicadores.RowCount != 0 ? indicadores.Omisiones : 0);
                values.Add(indicadores.RowCount != 0 ? indicadores.Equivocaciones : 0);
                values.Add(indicadores.RowCount != 0 ? indicadores.Media_TiempoReaccion : 0);
                values.Add(indicadores.RowCount != 0 ? indicadores.Desviacion_TiempoReaccion : 0);
                values.Add(indicadores.RowCount != 0 ? indicadores.CoeficienteAtencion : 0);
            }

            table.Rows.Add(values.ToArray());
            return table;
        }
    }
}
