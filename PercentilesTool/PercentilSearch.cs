using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BusinessObjects;

//namespace PercentilesTool
//{
//    public class PercentilSearch
//    {
//        static PercentilData pd;
//        public static PercentilData Deserialize()
//        {
//            pd = null;

//            try
//            {
//                Stream stream = File.Open("DataInfo.osl", FileMode.Open);
//                var bformatter = new BinaryFormatter();
//                pd = (PercentilData)bformatter.Deserialize(stream);
//                stream.Close();
//                return pd;
//            }
//            catch (Exception ex)
//            {
//                try
//                {
//                    ASPercentiles.BuildAgain(); // aqui se crean las tablas nuevamente
//                }
//                catch(Exception exception)
//                {
//                    return null;
//                }
//                return null;
//            }
//        }
//        public static int Percentil(TypeAS type, TypeOf_AS_Test test, AS_TestParameter testparameter, int bloque, int edad, double valor, Sexo sexo)
//        {
//            string s = prefijo(type, test, testparameter);
//            s += "b" + bloque;
//            s += sexo == Sexo.Masculino ? "m" : "f";
//            return Percentil(s, edad, valor);
//        }
//        public static int Percentil(TypeAS type, TypeOf_AS_Test test, AS_TestParameter testparameter, int edad, double valor, Sexo sexo)
//        {
//            string s = prefijo(type, test, testparameter);
//            s += "t";
//            s += sexo == Sexo.Masculino ? "m" : "f";
//            return Percentil(s, edad, valor);
//        }

//        #region private
//        private static string prefijo(TypeAS type, TypeOf_AS_Test test, AS_TestParameter testparameter)
//        {
//            string s = "as";
//            switch (type)
//            {
//                case TypeAS.Simple:
//                    s += "s";
//                    break;
//                case TypeAS.Compleja:
//                    s += "c";
//                    break;
//                default:
//                    throw new ArgumentOutOfRangeException("type");
//            }
//            switch (test)
//            {
//                case TypeOf_AS_Test.H_Imagenes:
//                    s += "i";
//                    break;
//                case TypeOf_AS_Test.H_Figuras_Abstractas:
//                    s += "fa";
//                    break;
//                case TypeOf_AS_Test.H_Letras:
//                    s += "l";
//                    break;
//                case TypeOf_AS_Test.C_Imagenes:
//                    s += "colori";
//                    break;
//                case TypeOf_AS_Test.C_Letras:
//                    s += "colorl";
//                    break;
//                default:
//                    throw new ArgumentOutOfRangeException("test");
//            }
//            switch (testparameter)
//            {
//                case AS_TestParameter.IA:
//                    s += "i";
//                    break;
//                case AS_TestParameter.Aciertos:
//                    s += "a";
//                    break;
//                case AS_TestParameter.Omisiones:
//                    s += "o";
//                    break;
//                case AS_TestParameter.Comisiones:
//                    s += "c";
//                    break;
//                case AS_TestParameter.TR:
//                    s += "tr";
//                    break;
//                case AS_TestParameter.DS_TR:
//                    s += "dstr";
//                    break;
//            }
//            return s;
//        }

//        private static int Percentil(string test, int age, double value)
//        {
//            if (!pd.dataHash.ContainsKey(test))
//                return 0;
//            double[,] agePerc = pd.dataHash[test];
//            int ageindex = age - pd.initage;
//            if (ageindex < 0) ageindex = 0;
//            if (ageindex > pd.agerange - 1) ageindex = pd.agerange - 1;

//            double min = Math.Abs(value - agePerc[ageindex, 0]);
//            int index = 0;
//            int i = 1;
//            while (i < pd.percentil.Length - 1)
//            {
//                double aux = Math.Abs(value - agePerc[ageindex, i]);
//                if (aux < min) index = i;
//                if (aux == 0) break;
//                i++;
//            }
//            return pd.percentil[index];
//        }
//        #endregion
//    }
//}
