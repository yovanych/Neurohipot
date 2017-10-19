﻿using BusinessObjects;
using DALayer;
using DataAccessTool.DAL;
using ExcelReportTool.Abstract;
using ExcelReportTool.Res;

namespace ExcelReportTool
{
    #region ASC

    #region ASC TOTALES Imagenes
    public class XLS_ASC_Imagenes_Totals : XLSAS_Totals
    {
        public XLS_ASC_Imagenes_Totals(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_First_IMG); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_Last_IMG); }

        #endregion

        #region Overrides of XLSAS_Totals

        protected override _ResAS GetResultsOfMyType(string codigo_paciente)
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest(codigo_paciente, TypeOf_AS_Test.H_Imagenes);
            return res;
        }

        #endregion
    }
    #endregion

    #region ASC TOTALES Figuras Abstractas
    public class XLS_ASC_FigAbst_Totals : XLSAS_Totals
    {
        public XLS_ASC_FigAbst_Totals(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_First_FIG); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_Last_FIG); }

        #endregion

        #region Overrides of XLSAS_Totals

        protected override _ResAS GetResultsOfMyType(string codigo_paciente)
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest(codigo_paciente, TypeOf_AS_Test.H_Figuras_Abstractas);
            return res;
        }

        #endregion
    }
    #endregion

    #region ASC TOTALES Figuras Abstractas
    public class XLS_ASC_Letras_Totals : XLSAS_Totals
    {
        public XLS_ASC_Letras_Totals(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_First_LET); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Totals_Last_LET); }

        #endregion

        #region Overrides of XLSAS_Totals

        protected override _ResAS GetResultsOfMyType(string codigo_paciente)
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest(codigo_paciente, TypeOf_AS_Test.H_Letras);
            return res;
        }

        #endregion
    }
    #endregion
    #endregion
}
