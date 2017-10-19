using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
    public class StatFunctionLibrary
    {
        public static double media( ICollection<int> tiempos )
        {
            if ( tiempos.Count == 0 ) return 0;
            double s = 0;
            s += tiempos.Sum();
            return s / tiempos.Count;
        }
        public static double media( ICollection<double> values )
        {
            if ( values.Count == 0 ) return 0;
            double s = 0;
            s += values.Sum();
            return s / values.Count;
        }
        public static double desv_est( ICollection<int> tiempos, double media )
        {
            if ( tiempos.Count == 0 ) return 0;
            double f = tiempos.Sum( t => Math.Pow( t - media, 2 ) );
            return Math.Sqrt( f / tiempos.Count );
        }
        public static double desv_est( ICollection<double> tiempos, double media )
        {
            if ( tiempos.Count == 0 ) return 0;
            double f = tiempos.Sum( t => Math.Pow( t - media, 2 ) );
            return Math.Sqrt( f / tiempos.Count );
        }
        public static double ZNotation(double puntuación, double media, double desv_est)
        {
            if ( desv_est == 0 ) return 0;
            return ( puntuación - media ) / desv_est;
        }
        public static double TNotation(double puntuación, double media, double desv_est)
        {
            double z = ZNotation( puntuación, media, desv_est );
            return 10 * z + 50;
        }
        public static double TNotation( double zNotation )
        {
            return 10 * zNotation + 50;
        }
    }
}
