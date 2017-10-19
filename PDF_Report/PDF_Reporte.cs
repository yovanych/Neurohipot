using System.Data;
using System.IO;
using BusinessObjects;
using Gios.Pdf;
using System.Drawing;
using GraphicReport;

namespace PDF_Report
{
    public class PDF_Reporte
    {
        private readonly ExportData datos;
        private readonly PdfDocument pdfDocument;
        public PDF_Reporte (ExportData datos)
        {
            this.datos = datos;
            pdfDocument = new PdfDocument( PdfDocumentFormat.A4 );
        }

        private void Reporta()
        {
            #region Primera pagina
            PdfPage initialPdfPage = pdfDocument.NewPage();
            AddLogoTASPortada(180, 115, initialPdfPage);
            AddTitulosDatosPersonales( 80, 275, initialPdfPage );
            AddDatosPersonales( 80, 315, initialPdfPage );
            AddTablaPrincipal( initialPdfPage);
            AddTextoPrincipal( initialPdfPage );
            AddLogoAlFinal( initialPdfPage );
            initialPdfPage.SaveToDocument();
            #endregion

            #region Segunda pagina
            PdfPage segundaPdfPage = pdfDocument.NewPage();
            AddLogoTASPrincipio( segundaPdfPage);
            AddGraficoPercentiles( 90, segundaPdfPage);
            AddTablaResultadosPorBloque( segundaPdfPage, 460 );
            AddLogoAlFinal( segundaPdfPage);
            segundaPdfPage.SaveToDocument();
            #endregion

            #region Terctera pagina
            PdfPage terceraPdfPage = pdfDocument.NewPage();
            AddLogoTASPrincipio( terceraPdfPage );
            AddGraficoErrores( 90, terceraPdfPage );
            AddGraficoTiempos( 400, terceraPdfPage );
            AddLogoAlFinal( terceraPdfPage );
            terceraPdfPage.SaveToDocument();
            #endregion

            #region Cuarta pagina
            PdfPage cuartaPdfPage = pdfDocument.NewPage();
            AddLogoTASPrincipio( cuartaPdfPage );
            AddConclusiones( 90, cuartaPdfPage );
            AddLogoAlFinal( cuartaPdfPage );
            cuartaPdfPage.SaveToDocument();
            #endregion
        }

        public void Save(string file_name)
        {
            Reporta();
            pdfDocument.SaveToFile(file_name);
        }
        public MemoryStream GetPDF()
        {
            Reporta();
            var m = new MemoryStream();
            pdfDocument.SaveToStream( m );
            return m;
        }

        #region private 
        private void AddConclusiones( int y, PdfPage page )
        {
            var text = new PdfTextArea(
                    Function_Library.FontTitulo,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, y, 450, 20 ),
                    ContentAlignment.MiddleLeft,
                    PDF_Resources.Title_Conclusiones );
            page.Add( text );
            var textConlusiones = new PdfTextArea(
                    Function_Library.FontTexto11,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, y + 10, 450, 80 ),
                    ContentAlignment.MiddleLeft,
                    this.datos.Orientaciones.Conclusiones );
            page.Add( textConlusiones );
        }
        private void AddGraficoPercentiles( int y, PdfPage page )
        {
            var text = new PdfTextArea(
                    Function_Library.FontTitulo,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, y, 450, 20 ),
                    ContentAlignment.MiddleCenter,
                    PDF_Resources.Title_GraficosResultadosGenerales );
            page.Add( text );
            
            var chart = new Ar_Chart( ChartReportClass.PERCENTILES, 1000, 650, datos.TNotaciones.ChR_TNotaciones );
            PdfImage grafico = Function_Library.ToPDFImage( chart.ToBinary(), pdfDocument );
            if ( grafico != null )
                page.Add( grafico, 55, y + 25, 170 );
            
            var lArea = new PdfArea( pdfDocument, 55, y + 20, 490, 280 );
            var r = new PdfRectangle( pdfDocument, lArea, Color.LightGray );
            page.Add( r );
        }
        private void AddGraficoTiempos( int y, PdfPage page )
        {
            var text = new PdfTextArea(
                    Function_Library.FontTitulo,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, y, 450, 20 ),
                    ContentAlignment.MiddleCenter,
                    PDF_Resources.Title_GraficoTiempos );
            page.Add( text );
            var chart = new Ar_Chart( ChartReportClass.TIEMPOS, 1000, 600, datos.ChR_Tiempos );
            PdfImage grafico = Function_Library.ToPDFImage( chart.ToBinary(), pdfDocument );
            if ( grafico != null )
                page.Add( grafico, 55, y + 25, 200 );
            AddLeyenda( y + 95, page, PDF_Resources.Leyend_TR, PDF_Resources.Leyend_ErrorTR );

            var lArea = new PdfArea( pdfDocument, 55, y + 20, 490, 250 );
            var r = new PdfRectangle( pdfDocument, lArea, Color.LightGray );
            page.Add( r );
        }
        private void AddGraficoErrores( int y, PdfPage page )
        {
            var text = new PdfTextArea(
                    Function_Library.FontTitulo,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, y, 450, 20 ),
                    ContentAlignment.MiddleCenter,
                    PDF_Resources.Title_GraficoErrores );
            page.Add( text );
            var chart = new Ar_Chart( ChartReportClass.ERRORES, 1000, 600, datos.ChR_Errores );
            PdfImage grafico = Function_Library.ToPDFImage( chart.ToBinary(), pdfDocument );
            if ( grafico != null )
                page.Add( grafico, 55, y + 25, 200 );
            AddLeyenda(y + 95, page, PDF_Resources.Leyend_EComision, PDF_Resources.Leyend_EOmision, PDF_Resources.Leyend_IA);

            var lArea = new PdfArea( pdfDocument, 55, y + 20, 490, 250 );
            var r = new PdfRectangle( pdfDocument, lArea, Color.LightGray );
            page.Add( r );
        }
        private void AddLeyenda( int yPos, PdfPage page, params string[] leyendas )
        {
            var colores = new[]
                {FunctionLibrary.ChartBarColorBlue, FunctionLibrary.ChartBarColorRed, FunctionLibrary.ChartBarColorGreen};
            for ( int i = 0; i < leyendas.Length && i < 3; i++ )
            {
                var lArea = new PdfArea( pdfDocument, 410, yPos + i*15, 5, 5 );
                var r = new PdfRectangle( pdfDocument, lArea, colores[i], 1, colores[i]);
                var text = new PdfTextArea(
                    Function_Library.FontTexto09,
                    Color.Black,
                    new PdfArea( pdfDocument, 425, (yPos-2) + i*15, 100, 20 ),
                    ContentAlignment.TopLeft,
                    leyendas[i] );
                page.Add( r );
                page.Add( text );
            }
        }
        private void AddLogoTASPrincipio(PdfPage page)
        {
            PdfImage image = Function_Library.TAS_Logo(pdfDocument);
            if (image != null)
                page.Add(image, 375, 20, 450);
        }
        private void AddLogoTASPortada(int x, int y, PdfPage page)
        {
            PdfImage LogoImage = Function_Library.TAS_Logo(pdfDocument);
            if (LogoImage != null)
                page.Add(LogoImage, x, y, 220);
        }
        private void AddTextoPrincipal( PdfPage page )
        {
            var text = new PdfTextArea(
                    Function_Library.FontTexto11,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, 650, 450, 80 ),
                    ContentAlignment.MiddleLeft,
                    PDF_Resources.TextoPrincipal );
            page.Add( text );
        }
        private void AddTablaPrincipal( PdfPage page )
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add( PDF_Resources.Header_Parametro );
            dataTable.Columns.Add( PDF_Resources.Header_Puntaje );
            dataTable.Columns.Add( PDF_Resources.Header_Percentil );
            dataTable.Columns.Add( PDF_Resources.Header_Orientacion );

            int rows = datos.TNotaciones.Parametros.Length;
            int columns = dataTable.Columns.Count;

            PdfTable myPdfTable = pdfDocument.NewTable( Function_Library.FontTexto11, rows, columns, 3 );

            var str_orientacion = new[]
                {
                    datos.Orientaciones.O_indice_atencion_total, 
                    //datos.O_Error_estandar_IA,
                    datos.Orientaciones.O_Aciertos, 
                    datos.Orientaciones.O_Omision, 
                    datos.Orientaciones.O_Comision, 
                    datos.Orientaciones.O_TR, 
                    datos.Orientaciones.O_ErrorTR,
                    datos.Orientaciones.O_d,
                    datos.Orientaciones.O_C
                };
            
            for( int i = 0; i < datos.TNotaciones.Parametros.Length; i++ )
            {
                DataRow row = dataTable.NewRow();
                row[PDF_Resources.Header_Parametro] = datos.TNotaciones.Parametros[i];
                row[PDF_Resources.Header_Puntaje] = FunctionLibrary.ShowDouble( datos.Puntuaciones[i] );
                row[PDF_Resources.Header_Percentil] = (i >= 6 && i <= 7) ? string.Empty : FunctionLibrary.ShowDouble( datos.TNotaciones[i] );
                row[PDF_Resources.Header_Orientacion] = str_orientacion[i];
                dataTable.Rows.Add( row );
            }

            myPdfTable.ImportDataTable( dataTable );
            myPdfTable.HeadersRow.SetColors( Color.Black, Color.FromArgb( 229, 229, 229 ) );
            myPdfTable.SetColors( Color.Black, Color.White );
            myPdfTable.SetBorders( Color.Black, 1, BorderType.CompleteGrid );
            myPdfTable.SetColumnsWidth( new[] { 35, 12, 12, 41 } );
            myPdfTable.SetContentAlignment( ContentAlignment.TopLeft );
            myPdfTable.HeadersRow[0].SetContent( string.Empty );
            myPdfTable.Columns[0].SetBackgroundColor(Color.FromArgb( 242, 242, 242 ));
            PdfTablePage newPdfTablePage = myPdfTable.CreateTablePage( new PdfArea( pdfDocument, 80, 480, 450, 420 ) );
            page.Add( newPdfTablePage );
        }
        private void AddTablaResultadosPorBloque(PdfPage page, int  yPos)
        {
            var text = new PdfTextArea(
                    Function_Library.FontTitulo,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, yPos, 450, 20 ),
                    ContentAlignment.MiddleCenter,
                    PDF_Resources.Title_ResultadosXBloque);
            page.Add( text );

            var dataTable = new DataTable();
            dataTable.Columns.Add( PDF_Resources.Header_MEDIDAS );
            for ( int i = 0; i < 7; i++ )
                dataTable.Columns.Add( i.ToString() );

            // Para que se entienda que no se incluyen los ultimos dos parámetros
            int rows = (datos.TNotaciones.Parametros.Length - 2) + 2;
            int columns = dataTable.Columns.Count;

            PdfTable myPdfTable = pdfDocument.NewTable( Function_Library.FontTexto11, rows, columns, 3 );

            DataRow row = dataTable.NewRow();
            row[PDF_Resources.Header_MEDIDAS] = PDF_Resources.Header_MEDIDAS;
            row["0"] = PDF_Resources.Header_BLOQUES;
            dataTable.Rows.Add( row );
            
            row = dataTable.NewRow();
            for ( int i = 0; i < 7; i++ )
                row[i.ToString()] = ( i + 1 ).ToString();
            dataTable.Rows.Add( row );

            for ( int i = 2; i < (datos.TNotaciones.Parametros.Length - 2) + 2; i++ )
            {
                row = dataTable.NewRow();
                row[PDF_Resources.Header_MEDIDAS] = datos.TNotaciones.Parametros[i-2];
                for ( int j = 0; j < 7; j++ )
                    row[j.ToString()] = datos.PercentilesXbloque[j, i-2];
                dataTable.Rows.Add( row );
            }

            myPdfTable.ImportDataTable( dataTable );
            myPdfTable.VisibleHeaders = false;
            myPdfTable.SetColors( Color.Black, Color.White );
            myPdfTable.SetBorders( Color.Black, 1, BorderType.CompleteGrid );
            myPdfTable.SetColumnsWidth( new[] { 37, 9, 9, 9, 9, 9, 9, 9 } );
            myPdfTable.SetContentAlignment( ContentAlignment.MiddleCenter );
            myPdfTable.Columns[0].SetContentAlignment( ContentAlignment.MiddleLeft );
            myPdfTable.Rows[0][0].SetContentAlignment( ContentAlignment.MiddleCenter );
            myPdfTable.Rows[0].SetBackgroundColor( Color.FromArgb( 242, 242, 242 ) );
            myPdfTable.Rows[1].SetBackgroundColor( Color.FromArgb( 242, 242, 242 ) );
            myPdfTable.Rows[0][0].RowSpan = 2;
            myPdfTable.Rows[0][1].ColSpan = 7;
            PdfTablePage newPdfTablePage = myPdfTable.CreateTablePage( new PdfArea( pdfDocument, 75, yPos + 40, 450, 420 ) );
            page.Add( newPdfTablePage );

            var footText = new PdfTextArea(
                    Function_Library.FontTexto10,
                    Color.Black,
                    new PdfArea( pdfDocument, 80, yPos + 180, 450, 80 ),
                    ContentAlignment.MiddleLeft,
                    PDF_Resources.FootNote_Puntuaciones );
            page.Add( footText );
        }
        private void AddLogoAlFinal( PdfPage page )
        {
            PdfImage image = Function_Library.Logo( pdfDocument );
            if ( image != null )
                page.Add( image, 230, 750, 400 );
        }
        private void AddDatosPersonales( int x, int y, PdfPage page )
        {
            const int linespace = 20;
            var tags = new[]
            {
                string.Format(PDF_Resources.DP_NombreFormat, this.datos.Paciente.Nombre, this.datos.Paciente.Apellido1, this.datos.Paciente.Apellido2),
                string.Format(PDF_Resources.DP_FechaNacimientoFormat, this.datos.Paciente.Fecha_Nacimiento.ToShortDateString()), 
                string.Format(PDF_Resources.DP_EdadFormat, this.datos.Paciente.Edad), 
                string.Format(PDF_Resources.DP_SexoFormat, this.datos.Paciente.Sexo),
                string.Format(PDF_Resources.DP_NivelFormat, this.datos.Paciente.Escolaridad),
                string.Format(PDF_Resources.DP_FechaAplicacionFormat, datos.CastResultadoForResultadoAS.Fecha.ToShortDateString())
            };
            for ( int i = 0; i < tags.Length; i++ )
            {
                var text = new PdfTextArea(
                    Function_Library.FontTexto11,
                    Color.Black,
                    new PdfArea( pdfDocument, x, y + i * linespace, 450, 20 ),
                    ContentAlignment.MiddleLeft,
                    tags[i] );
                page.Add( text );
            }
        }
        private void AddTitulosDatosPersonales( int x, int y, PdfPage page )
        {
            var text_tituloDatosPaciente = new PdfTextArea(
                Function_Library.FontTituloDatosPersonales,
                Color.Black,
                new PdfArea( pdfDocument, x, y, 150, 20 ),
                ContentAlignment.MiddleLeft,
                PDF_Resources.Title_DatosPersonales );
            var underline = 
                new PdfLine( pdfDocument, new PointF( x, y + 15 ), new PointF( 225, y + 15 ), Color.Black, 1 );
            page.Add( text_tituloDatosPaciente );
            page.Add( underline );
        }

        #endregion


        
    }
}
