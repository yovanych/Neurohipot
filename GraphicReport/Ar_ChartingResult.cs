using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphicReport
{
    public class Ar_ChartingResult
    {
        public string Label { get; set; }
        public double[] Values { get; set; }
        public Ar_ChartingResult( string label, params double[] result )
        {
            Values = new double[result.Length];
            for ( int i = 0; i < result.Length; i++ )
                Values[i] = Math.Round( result[i], MidpointRounding.ToEven );
            Label = label;
        }
        public DataPoint ToDataPoints(int xValue, int index)
        {
            return new DataPoint( xValue, Values[index] ) { AxisLabel = Label };
        }
    }
}
