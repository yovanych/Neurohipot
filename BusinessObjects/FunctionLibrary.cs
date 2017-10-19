using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace BusinessObjects
{
    public class FunctionLibrary
    {
        public static Color ChartBarColorBlue { get { return Color.FromArgb( 84, 193, 224 ); } }//79, 129, 189); } }
        public static Color ChartBarColorRed { get { return Color.FromArgb( 198, 29, 40 ); } }//192, 88, 77); } }
        public static Color ChartBarColorGreen { get { return Color.FromArgb( 22, 161, 33 ); } }//155, 187, 89); } }

        public static int AgeFirstLevel { get { return 6; } }
        public static int AgeMinSecondLevel { get { return 7; } }
        public static int AgeMaxSecondLevel { get { return 12; } }

        public static string GetQueryStringForDateTime(DateTime fecha)
        {
            string f = fecha.ToShortDateString();
            string d = fecha.Day.ToString();
            if (d.Length == 1) d = "0" + d;
            string m = fecha.Month.ToString();
            if (m.Length == 1) m = "0" + m;
            string a = fecha.Year.ToString();

            string hou = fecha.Hour.ToString();
            if (hou.Length == 1) hou = "0" + hou;
            string min = fecha.Minute.ToString();
            if (min.Length == 1) min = "0" + min;
            string sec = fecha.Second.ToString();
            if (sec.Length == 1) sec = "0" + sec;
            //return string.Format("#{0} {1}:{2}:{3}#", f, hou, min, sec);
            //return string.Format( "#{0}#", fecha );
            return string.Format("#{0}/{1}/{2} {3}:{4}:{5}#", m, d, a, hou, min, sec);
        }
        public static float AttentionProfit(int aciertos, int aciertosExtrannos, int equivocaciones, int omisiones)
        {
            float t = aciertos + aciertosExtrannos + equivocaciones + omisiones;
            return t == 0 ? 0 : (aciertos + aciertosExtrannos - equivocaciones - omisiones) / t;
        }

        public static string ConvertPointBased(double numero)
        {
            string[] strs = numero.ToString().Split(',', '.');
            return (strs.Length > 1) ? string.Format("{0}.{1}", strs[0], strs[1]) : strs[0];
        }
        public static string GetExcelColumn(int code)
        {
            code = code - 65;
            int decCode = (code) / 26;
            int unitCode = (code) % 26;
            string delante = (decCode == 0) ? string.Empty : ((char)(decCode + 64)).ToString();
            string detras = ((char)(unitCode + 65)).ToString();
            return delante + detras;
        }
        public static int GetExcelColumn(string code)
        {
            IEnumerable<Char> flipCode = code.Reverse();
            int intCode = 0;
            for (int i = 0; i < flipCode.Count(); i++)
                intCode += (int)(Math.Pow(26, i) * (flipCode.ElementAt(i) - 64));
            return intCode;
        }
        public static string GetTableName(ResultType resultType)
        {
            return "Res" + resultType;
        }

        public static int GetAge(DateTime birthday)
        {
            var today = DateTime.Now;
            int edad = today.Year - birthday.Year;
            if (today.Month < birthday.Month)
                edad--;
            else if (today.Month == birthday.Month && today.Day < birthday.Day)
                edad--;
            return edad;
        }
        public static bool InRange(int edad, int min, int max)
        {
            return edad >= min && edad <= max;
        }
        public static string ShowDouble( double d )
        {
            double result = Math.Round( d, 2, MidpointRounding.ToEven );
            double int_result = Math.Floor( result );
            return ( result == int_result ) ? ( (int) int_result ).ToString() : result.ToString();
        }
        public static int GetTopBlocks(int edad)
        {
            return (edad == 6) ? 4 : 7;
        }
    }
}
