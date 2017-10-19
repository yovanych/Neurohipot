using System;
using BusinessObjects;

namespace DALayer
{
    //public class ASCReport : ASReport
    //{
    //    public ASCReport()
    //        : base( "ResASC", "IndicadoresASC" )
    //    { }

    //    #region Overrides of ASReport

    //    protected override int CompleteColumn( TypeOf_AS_Test image_type )
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn( "I" );
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn( "J" );
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn( "K" );
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    protected override int TotalsFirstColumn( TypeOf_AS_Test image_type )
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn( "CY" );
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn( "GS" );
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn( "KM" );
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    protected override int BlocksFirstColumn( TypeOf_AS_Test image_type )
    //    {
    //        switch ( image_type )
    //        {
    //            case TypeOf_AS_Test.H_Imagenes:
    //                return FunctionLibrary.GetExcelColumn( "BI" );
    //            case TypeOf_AS_Test.H_Figuras_Abstractas:
    //                return FunctionLibrary.GetExcelColumn( "FC" );
    //            case TypeOf_AS_Test.H_Letras:
    //                return FunctionLibrary.GetExcelColumn( "IW" );
    //            default:
    //                throw new ArgumentOutOfRangeException( "image_type" );
    //        }
    //    }

    //    #endregion
    //}
}
