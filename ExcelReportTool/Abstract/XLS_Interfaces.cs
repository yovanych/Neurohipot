using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace ExcelReportTool.Abstract
{
    public interface IXLSPrinteable
    {
        void Print(ref Worksheet wsheet);
    }
}
