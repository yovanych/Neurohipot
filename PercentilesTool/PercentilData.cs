using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

//namespace PercentilesTool
//{
//    [Serializable]
//    public class PercentilData : ISerializable
//    {
//        public Dictionary<int, int> percHash = new Dictionary<int, int>(10);
//        public int initage;
//        public int agerange;
//        public Dictionary<string, double[,]> dataHash = new Dictionary<string, double[,]>(120);
//        public int[] percentil;
        

//        public PercentilData(SerializationInfo info, StreamingContext ctxt)
//        {
//            //Get the values from info and assign them to the appropriate properties
//            percHash = (Dictionary<int, int>)info.GetValue("percentilHash", typeof(Dictionary<int, int>));
//            initage = (int)info.GetValue("initage", typeof(int));
//            agerange = (int)info.GetValue("agerange", typeof(int));
//            dataHash = (Dictionary<string, double[,]>)info.GetValue("dataHash", typeof(Dictionary<string, double[,]>));
//            percentil = (int[])info.GetValue("percentil", typeof(int[]));
//        }
//        public PercentilData() { }
//        //Serialization function.
//        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
//        {
//            //You can use any custom name for your name-value pair. But make sure you
//            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
//            // then you should read the same with "EmployeeId"
//            info.AddValue("percentilHash", percHash);
//            info.AddValue("initage", initage);
//            info.AddValue("agerange", agerange);
//            info.AddValue("dataHash", dataHash);
//            info.AddValue("percentil", percentil);
//        }
//    }
//}
