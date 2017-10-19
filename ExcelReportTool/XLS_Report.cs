using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using ExcelReportTool.Res;
using Microsoft.Office.Interop.Excel;

namespace ExcelReportTool
{
    public class XLS_Report
    {
        private readonly int firstLine;

        public XLS_Report(int firstLine)
        {
            this.firstLine = firstLine;
        }

        public void Export(string path)
        {
            CheckExcellProcesses();
            var excelApp = new Microsoft.Office.Interop.Excel.Application
                               {
                                   DisplayAlerts = true,
                                   ScreenUpdating = false,
                                   Interactive = false//,
                                   //AlertBeforeOverwriting = true
                               };
            Workbook wbook = cargarDocumento(InfoPath() + Resource.ExcelSourceName, excelApp);
            Worksheet wsheet = crearHoja(wbook);

            var xls_rows = new XLS_ListRows(firstLine);
            xls_rows.Print(ref wsheet);

            salvar2(path, wbook);
            excelApp.Quit();
            KillExcel();

        }

        #region Metodos privados
        #region IO
        #endregion

        private static void CheckExcellProcesses()
        {
            Process[] AllProcesses = Process.GetProcessesByName( "excel" );
            if(AllProcesses.Length > 0) throw new InvalidOperationException(Resource.MSG_CloseExcel);
        }
        private static void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName( "excel" );
            foreach ( Process ExcelProcess in AllProcesses) 
                ExcelProcess.Kill();
        }
        private Workbook crearDocumento(string name, Application excelApp)
        {
            Workbook wbook;
            if (!File.Exists(name))
            {
                wbook = excelApp.Workbooks.Add(Type.Missing);
            }
            else
                wbook = excelApp.Workbooks.Open(name,
                                                Type.Missing, Type.Missing, Type.Missing,
                                                Type.Missing, Type.Missing,
                                                Type.Missing, Type.Missing, Type.Missing,
                                                Type.Missing, Type.Missing,
                                                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            return wbook;
        }
        private static Workbook cargarDocumento(string name, Application excelApp)
        {
            Workbook wbook = excelApp.Workbooks.Open(name,
                                                      Type.Missing, Type.Missing, Type.Missing,
                                                      Type.Missing, Type.Missing,
                                                      Type.Missing, Type.Missing, Type.Missing,
                                                      Type.Missing, Type.Missing,
                                                      Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            return wbook;
        }
        private static Worksheet crearHoja(Workbook wbook)
        {
            Sheets excelSheets = wbook.Worksheets;
            var excelWorksheet = (Worksheet)excelSheets.Item[Resource.ExcelWorksheetName];
            return excelWorksheet;
        }
        private static void salvar1(string m_excelFileName, Workbook wbook)
        {
            wbook.SaveAs(m_excelFileName + "\\reporte.xlsx", Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing,
                              XlSaveAsAccessMode.xlNoChange,
                              Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
            wbook.Close(true, Type.Missing, Type.Missing);
        }
        private static void salvar2(string m_excelFileName, Workbook wbook)
        {
            wbook.SaveAs(m_excelFileName, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing, Type.Missing,
                              XlSaveAsAccessMode.xlNoChange,
                              Type.Missing, Type.Missing, Type.Missing,
                              Type.Missing, Type.Missing);
            wbook.Close(true, Type.Missing, Type.Missing);
        }
        private static string InfoPath()
        {
            string path = System.Windows.Forms.Application.ExecutablePath;
            int ult = path.LastIndexOfAny(new[] { '\\' });
            string folder = path.Substring(0, ult + 1);
            string[] words = folder.Split('\\');
            return words.Aggregate("", (current, s) => current + (s + "\\"));
        }
        #endregion
    }
}
