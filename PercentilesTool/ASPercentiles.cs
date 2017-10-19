using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using BusinessObjects;

//namespace PercentilesTool
//{
//    public class ASPercentiles
//    {
//        public static Dictionary<int, int> percHash = new Dictionary<int, int>(10);
//        private static int initage;
//        private static int agerange;
//        public static Dictionary<string, double[,]> dataHash = new Dictionary<string, double[,]>(120);
//        public static int[] percentil;

//        public static int BuildAgain()//(string path)
//        {
//            BuildHashtable();
//            PercentilSearch.Deserialize(); // aqui no debe lanzar excepci'on
//            int result = PercentilSearch.Percentil(TypeAS.Compleja, TypeOf_AS_Test.H_Letras, AS_TestParameter.Aciertos, 6, 8, 5, Sexo.Masculino);
//            return result;
//        }
//        public static void BuildHashtable(string path)
//        {
//            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-EN");
//            var pd = new PercentilData();
//            InitPercentilTables();
//            TablePercCreate(path + "\\Normas Finales");
//            pd.percentil = percentil;
//            pd.percHash = percHash;
//            pd.initage = initage;
//            pd.agerange = agerange;
//            pd.dataHash = dataHash;
//            Stream stream = File.Open("DataInfo.osl", FileMode.Create);
//            var bformatter = new BinaryFormatter();
//            bformatter.Serialize(stream, pd);
//            stream.Close();
//        }
//        public static void BuildHashtable()
//        {
//            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-EN");
//            var pd = new PercentilData();
//            InitPercentilTables();
//            TablePercCreate(Directory.GetCurrentDirectory() + "\\Normas Finales");
//            pd.percentil = percentil;
//            pd.percHash = percHash;
//            pd.initage = initage;
//            pd.agerange = agerange;
//            pd.dataHash = dataHash;
//            Stream stream = File.Open("DataInfo.osl", FileMode.Create);
//            var bformatter = new BinaryFormatter();
//            bformatter.Serialize(stream, pd);
//            stream.Close();
//        }

//        public static void BuildHashtable(int inage, int endage, int[] perc)
//        {
//            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-EN");
//            var pd = new PercentilData();
//            InitPercentilTables(inage, endage, perc);
//            TablePercCreate(Directory.GetCurrentDirectory() + "\\Normas Finales");
//            pd.percentil = percentil;
//            pd.percHash = percHash;
//            pd.initage = initage;
//            pd.agerange = agerange;
//            pd.dataHash = dataHash;
//            Stream stream = File.Open("DataInfo.osl", FileMode.Create);
//            var bformatter = new BinaryFormatter();
//            //Console.WriteLine("Writing Data Information");
//            bformatter.Serialize(stream, pd);
//            stream.Close();
//        }

//        private static void InitPercentilTables(int inage, int endage, int[] perc)
//        {
//            initage = inage;
//            percentil = perc;
//            agerange = endage - initage + 1;
//            for (int i = 0; i < percentil.Length; i++)
//            {
//                percHash.Add(percentil[i], i);
//            }
//        }

//        private static void InitPercentilTables() { InitPercentilTables(6, 12, new[] { 5, 10, 25, 50, 75, 90, 95 }); }

//        private static void TablePercCreate(string path)
//        {
//            string[] sa = Directory.GetFiles(path, "*.txt");
//            foreach (string s in sa)
//            {
//                CreatePercEntry(s, path.Length + 1);
//            }
//            sa = Directory.GetDirectories(path);
//            foreach (string s in sa)
//            {
//                TablePercCreate(s);
//            }
//        }

//        private static void CreatePercEntry(string path, int init)
//        {
//            var xxx = new double[agerange, percentil.Length];
//            var str = new StreamReader(path);
//            string s;
//            string[] a;
//            int i = 0;
//            while (!str.EndOfStream)
//            {
//                s = str.ReadLine();
//                if (s != string.Empty)
//                {
//                    a = s.Split(new[] { " ", "  ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
//                    for (int j = 0; j < a.Length; j++)
//                        xxx[i, j] = double.Parse(a[j]);
//                    i++;
//                }
//            }
//            path = path.Substring(init, path.Length - init - 4);
//            dataHash.Add(path, xxx);
//            str.Close();
//        }
//    }
//}
