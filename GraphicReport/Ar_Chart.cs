using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using BusinessObjects;

namespace GraphicReport
{
    public class Ar_Chart : Chart
    {
        public Ar_Chart( ChartReportClass report_class, int width, int height, List<Ar_ChartingResult> members )
        {
            switch ( report_class )
            {
                case ChartReportClass.PERCENTILES:
                    InitialicePERCENTILES( width, height, members );
                    break;
                case ChartReportClass.ERRORES:
                    InitialiceERRORES( width, height, members );
                    break;
                case ChartReportClass.TIEMPOS:
                    InitialiceTIEMPOS( width, height, members );
                    break;
                default:
                    throw new ArgumentOutOfRangeException( "report_class" );
            }
        }

        public byte[] ToBinary()
        {
            var m = new MemoryStream();
            SaveImage( m, ChartImageFormat.Jpeg );
            return m.GetBuffer();
        }

        public Image ToImage()
        {
            var m = new MemoryStream();
            SaveImage( m, ChartImageFormat.Jpeg );
            return Image.FromStream( m );
        }

        #region Private
        private void InitialicePERCENTILES(
            int width,
            int height,
            List<Ar_ChartingResult> members )
        {
            Series[] series = BuildSeries( 1 );

            for ( int i = 0; i < members.Count; i++ )
                series[0].Points.Add( members[i].ToDataPoints( i, 0 ) );
            
            var t = new Title( "PUNTUACIONES T" )
            {
                Font = new Font( "Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0 )
            };

            Series.Add( series[0] );
            Titles.Add( t );

            BorderColor = Color.LightGray;
            BorderWidth = 1;
            ChartAreas.Add( BuildChartArea(true) );
            Width = width; // new Unit( width, UnitType.Pixel );
            Height = height; // new Unit( height, UnitType.Pixel );
        }

        private void InitialiceERRORES(
            int width,
            int height,
            List<Ar_ChartingResult> members )
        {
            Series[] series = BuildSeries( 3 );

            for ( int i = 0; i < members.Count; i++ )
            {
                series[0].Points.Add( members[i].ToDataPoints( i, 0 ) );
                series[1].Points.Add( members[i].ToDataPoints( i, 1 ) );
                series[2].Points.Add( members[i].ToDataPoints( i, 2 ) );
            }

            Series.Add( series[0] );
            Series.Add( series[1] );
            Series.Add( series[2] );
            BorderColor = Color.LightGray;
            BorderWidth = 1;
            ChartAreas.Add( BuildChartArea(false) );
            Width = width;
            Height = height;
        }
        private void InitialiceTIEMPOS(
            int width,
            int height,
            List<Ar_ChartingResult> members )
        {
            Series[] series = BuildSeries( 2 );

            for ( int i = 0; i < members.Count; i++ )
            {
                series[0].Points.Add( members[i].ToDataPoints( i, 0 ) );
                series[1].Points.Add( members[i].ToDataPoints( i, 1 ) );
            }

            Series.Add( series[0] );
            Series.Add( series[1] );
            BorderColor = Color.LightGray;
            BorderWidth = 1;
            ChartAreas.Add( BuildChartArea( false ) );
            Width = width;
            Height = height;
        }
        private Series[] BuildSeries(int cantidad)
        {
            var colores = new[]
                {
                    FunctionLibrary.ChartBarColorBlue,
                    FunctionLibrary.ChartBarColorRed, 
                    FunctionLibrary.ChartBarColorGreen
                };
            var series = new Series[cantidad];
            for ( int i = 0; i < cantidad; i++ )
            {
                var s = new Series( string.Format( "S{0}", i + 1 ) )
                    {
                        ChartType = SeriesChartType.Column,
                        Color = colores[i],
                        IsXValueIndexed = true,
                        XValueType = ChartValueType.String,
                        
                    };
                series[i] = s;
            }
            return series;
        }
        private ChartArea BuildChartArea(bool angle)
        {
            var cha = new ChartArea( "ChA1" );
            cha.AxisX.MinorGrid.LineDashStyle = 
                cha.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.NotSet;
            cha.AxisY.MinorGrid.LineColor = 
                cha.AxisY.MajorGrid.LineColor = Color.LightGray;
            cha.AxisX.IsLabelAutoFit = cha.AxisY.IsLabelAutoFit = false;
            if ( angle )
                cha.AxisX.LabelStyle.Angle = -45;
            cha.AxisX.LabelStyle.Font = new Font( "Microsoft Sans Serif", 14F );
            cha.AxisY.LabelStyle.Font = new Font( "Microsoft Sans Serif", 14F );
            cha.AxisY.Maximum = 100;
            return cha;
        }
        #endregion
    }
}
