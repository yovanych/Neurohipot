using System;
using BusinessObjects;

namespace DALayer
{
    //public class ASSReport : ASReport
    //{
    //    public ASSReport()
    //        : base( "ResASS", "IndicadoresASS" )
    //    { }
        
    //    #region Overrides of ASReport

    //    protected override int CompleteColumn( TypeOf_AS_Test image_type )
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn( "F" );
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn("G");
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn("H");
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    protected override int TotalsFirstColumn(TypeOf_AS_Test image_type)
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn("BB");
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn("EV");
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn("IP");
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    protected override int BlocksFirstColumn( TypeOf_AS_Test image_type )
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn("L");
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn("DF");
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn("GZ");
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    #endregion
    //}
}
