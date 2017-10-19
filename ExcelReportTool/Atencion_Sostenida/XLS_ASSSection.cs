using BusinessObjects;
using ExcelReportTool.Abstract;
using DALayer;
using ExcelReportTool.Res;

namespace ExcelReportTool
{
    #region ASS
    public abstract class XLS_ASS_Section : XLSAS_Section
    {
        protected XLS_ASS_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section
        protected override _Indicadores GetIndicadoresInstance() { return new IndicadoresASS(); }
        #endregion
    }

    #region ASS Imagenes
    public class XLS_ASS_Imagenes_Section : XLS_ASS_Section
    {
        public XLS_ASS_Imagenes_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        {}

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_First_IMG); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_Last_IMG); }

        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType( string codigo_paciente )
        {
            var res = new _ResASS();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Imagenes );
            return res;
        }

        #endregion
    }
    #endregion

    #region ASS Figuras Abstractas
    public class XLS_ASS_FigAbst_Section : XLS_ASS_Section
    {
        public XLS_ASS_FigAbst_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_First_FIG); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_Last_FIG); }
        
        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType( string codigo_paciente )
        {
            var res = new _ResASS();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Figuras_Abstractas );
            return res;
        }

        #endregion
    }
    #endregion

    #region ASS Letras
    public class XLS_ASS_Letras_Section : XLS_ASS_Section
    {
        public XLS_ASS_Letras_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_First_LET); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASS_Last_LET); }
        
        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType( string codigo_paciente )
        {
            var res = new _ResASS();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Letras );
            return res;
        }

        #endregion
    }
    #endregion
    #endregion
}
