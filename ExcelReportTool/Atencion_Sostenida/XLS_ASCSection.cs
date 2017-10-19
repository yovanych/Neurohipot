using BusinessObjects;
using DALayer;
using ExcelReportTool.Abstract;
using ExcelReportTool.Res;

namespace ExcelReportTool
{
    #region ASC
    public abstract class XLS_ASC_Section : XLSAS_Section
    {
        protected XLS_ASC_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section
        protected override _Indicadores GetIndicadoresInstance() { return new IndicadoresASC(); }
        #endregion
    }

    #region ASC Imagenes
    public class XLS_ASC_Imagenes_Section : XLS_ASC_Section
    {
        public XLS_ASC_Imagenes_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn( Resource.ExcelColumn_ASC_First_IMG ); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Last_IMG); }

        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType(string codigo_paciente)
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Imagenes );
            return res;
        }

        #endregion
    }
    #endregion

    #region ASC Figuras Abstractas
    public class XLS_ASC_FigAbst_Section : XLS_ASC_Section
    {
        public XLS_ASC_FigAbst_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_First_FIG); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Last_FIG); }

        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType( string codigo_paciente )
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Figuras_Abstractas );
            return res;
        }

        #endregion
    }
    #endregion

    #region ASC Letras
    public class XLS_ASC_Letras_Section : XLS_ASC_Section
    {
        public XLS_ASC_Letras_Section(string codigoPaciente, int fila)
            : base(codigoPaciente, fila)
        { }

        #region Overrides of XLS_Section

        protected override int GetFirstColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_First_LET); }
        protected override int GetLastColumn() { return FunctionLibrary.GetExcelColumn(Resource.ExcelColumn_ASC_Last_LET); }

        #endregion

        #region Overrides of XLSAS_Section

        protected override Table_Res GetResultsOfMyType( string codigo_paciente )
        {
            var res = new _ResASC();
            res.LoadByTypeOfTest( codigo_paciente, TypeOf_AS_Test.H_Letras );
            return res;
        }

        #endregion
    }
    #endregion
    #endregion
}
