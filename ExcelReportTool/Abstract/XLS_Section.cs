using System;
using System.Collections.Generic;
using System.Data;
using DALayer;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace ExcelReportTool.Abstract
{
    public abstract class XLS_Section : IXLSPrinteable
    {
        protected string codigoPaciente;
        protected int fila;
        protected int colInicio, colFinal;

        protected XLS_Section( string codigoPaciente, int fila )
        {
            this.codigoPaciente = codigoPaciente;
            this.fila = fila;
            this.colInicio = GetFirstColumn();
            this.colFinal = GetLastColumn();
        }

        #region Abstract
        protected abstract int GetLastColumn();
        protected abstract int GetFirstColumn();
        protected abstract DataTable initTable();
        #endregion

        #region Implementation of IXLSPrinteable

        public void Print( ref Worksheet wsheet )
        {
            var _rang = wsheet.Cells.Range[wsheet.Cells[fila, colInicio],
                                           wsheet.Cells[fila, colFinal]] as Range;
            if ( _rang == null ) return;
            
            var _t = (object[,])(_rang.Value2);

            var table = initTable();

            DataRow _drow = table.Rows[0];
            for ( int i = 1; i <= colFinal - colInicio + 1; i++ )
                if ( _drow[i-1] != null )
                    _t[1, i] = _drow[i-1];

            _rang.Value2 = _t;
        }

        #endregion

        
    }
}
