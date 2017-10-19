using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using Gios.Pdf;

namespace PDF_Report
{
    internal class Function_Library
    {
        #region Constantes
        internal const int IA_index = 0;
        internal const int Aciertos_index = 1;
        internal const int Omisiones_index = 2;
        internal const int Comisiones_index = 3;
        internal const int TR_index = 4;
        internal const int DSTR_index = 5;
        internal const int Sensibilidad_index = 6;
        internal const int Criterio_index = 7;
        
        #endregion

        internal static PdfImage TAS_Logo(PdfDocument pdfDocument)
        {
            #region Buena práctica pero aun sin decifrar el problema (tiene que ver con GiosPDF)
            //UnmanagedMemoryStream img_stream = PDF_Resources.ResourceManager.GetStream( PDF_Resources.TAS_name );
            //if ( img_stream == null ) return null;
            //var buffer = new byte[img_stream.Length];
            //img_stream.Read( buffer, 0, buffer.Length );
            //return pdfDocument.NewImage( buffer );
            #endregion
            var img_stream = new MemoryStream();
            PDF_Resources.TAS.Save( img_stream, ImageFormat.Jpeg );
            return pdfDocument.NewImage( img_stream.GetBuffer() );
        }

        internal static PdfImage Logo( PdfDocument pdfDocument )
        {
            var img_stream = new MemoryStream();
            PDF_Resources.Logo.Save( img_stream, ImageFormat.Jpeg );
            return pdfDocument.NewImage( img_stream.GetBuffer() );
        }

        internal static Font FontTituloDatosPersonales
        {
            get { return new Font( "Arial", 10, FontStyle.Bold | FontStyle.Underline ); }
        }
        internal static Font FontTexto11
        {
            get { return new Font( "Arial", 11, FontStyle.Regular ); }
        }
        internal static Font FontTexto10
        {
            get { return new Font( "Arial", 10, FontStyle.Regular ); }
        }
        internal static Font FontTitulo
        {
            get { return new Font( "Arial", 12, FontStyle.Bold ); }
        }
        public static Font FontTexto09
        {
            get { return new Font( "Arial", 9, FontStyle.Regular ); }
        }
        internal static PdfImage ToPDFImage( byte[] image, PdfDocument pdfDocument )
        {
            return pdfDocument.NewImage( image );
        }
        
    }
}
