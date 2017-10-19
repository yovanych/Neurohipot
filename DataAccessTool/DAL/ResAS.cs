using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;
using DALayer;

namespace DataAccessTool.DAL
{
    public abstract class _ResAS : Table_Res
    {
        #region Propiedades
        public double Desviacion { get; protected set; }
        public double Media { get; protected set; }
        public TypeOf_AS_Test TipoPrueba { get; protected set; }
        public int Total_Aciertos { get; protected set; }
        public int Total_Aciertos_Ext { get; protected set; }
        public int Total_Omisiones { get; protected set; }
        public int Total_Equivocaciones { get; protected set; }
        public float IndiceAtencionTotal
        {
            get
            {
                return FunctionLibrary.AttentionProfit(this.Total_Aciertos, 
                    this.Total_Aciertos_Ext, this.Total_Equivocaciones,this.Total_Omisiones);
            }
        }
        #endregion

        #region Columnas
        public static string DesviacionColumnName { get { return "desviacion"; } }
        public static string MediaColumnName { get { return "media"; } }
        public static string TipoPruebaColumnName { get { return "tipo_prueba"; } }
        public static string TotalAciertosColumnName { get { return "total_aciertos"; } }
        public static string TotalAciertosEXTColumnName { get { return "total_aciertos_ext"; } }
        public static string TotalOmisionesColumnName { get { return "total_omisiones"; } }
        public static string TotalEquivocacionesColumnName { get { return "total_equivocaciones"; } }
        #endregion

        #region Constructores
        protected _ResAS(string table_name)
            : base(table_name)
        { }
        #endregion

        protected override void FillData(DataRow r)
        {
            base.FillData( r );
            this.Desviacion = (double)r[DesviacionColumnName];
            this.Media = (double)r[MediaColumnName];
            this.TipoPrueba = (TypeOf_AS_Test)((byte)r[TipoPruebaColumnName]);
            this.Total_Aciertos = (int) r[TotalAciertosColumnName];
            this.Total_Aciertos_Ext = (int)r[TotalAciertosEXTColumnName];
            this.Total_Omisiones = (int)r[TotalOmisionesColumnName];
            this.Total_Equivocaciones = (int)r[TotalEquivocacionesColumnName];
        }

        #region Select
        public int LoadByTypeOfTest(string codigo_paciente, TypeOf_AS_Test type)
        {
            int code = this.Connection.Connect();
            if (code != 0) return code;
            string query = string.Format("SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = {4} ORDER BY fecha DESC", 
                TN, 
                CodigoPacienteColumnName,
                codigo_paciente, 
                TipoPruebaColumnName,
                (int)type);
            var adapter = new OleDbDataAdapter(query, this.Connection.OleDB_Connection);
            var ds = new DataSet();
            adapter.Fill(ds, TN);
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView(ds.Tables[0]);
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        #endregion

        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, double desviacion, double media, TypeOf_AS_Test tipo_prueba, int total_aciertos, int total_aciertos_ext, int total_omisiones, int total_equivocaciones, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format("INSERT INTO {0} ( {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} ) VALUES ('{11}','{12}',{13},{14},{15},{16},{17},{18},{19},{20})",
                TN, FechaColumnName, CodigoPacienteColumnName, DesviacionColumnName, MediaColumnName, TipoPruebaColumnName, TotalAciertosColumnName, TotalAciertosEXTColumnName, TotalOmisionesColumnName, TotalEquivocacionesColumnName, CompletoColumnName,
                fecha, codigo_paciente, FunctionLibrary.ConvertPointBased(desviacion), FunctionLibrary.ConvertPointBased(media), (int)tipo_prueba, total_aciertos, total_aciertos_ext, total_omisiones, total_equivocaciones, completo);
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert(DateTime fecha, string codigo_paciente, double desviacion, double media, TypeOf_AS_Test tipo_prueba, int total_aciertos, int total_aciertos_ext, int total_omisiones, int total_equivocaciones, bool completo)
        {
            return this.Insert( fecha.ToString(), codigo_paciente, desviacion, media, tipo_prueba, total_aciertos, total_aciertos_ext, total_omisiones, total_equivocaciones, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, double desviacion, double media, TypeOf_AS_Test tipo_prueba, int total_aciertos, int total_aciertos_ext, int total_omisiones, int total_equivocaciones, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format("UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12}, {13} = {14}, {15} = {16} WHERE {17} = '{18}' AND {19} = '{20}'",
                TN, MediaColumnName, media, 
                DesviacionColumnName, desviacion, 
                TipoPruebaColumnName, tipo_prueba, 
                CompletoColumnName, completo,
                TotalAciertosColumnName, total_aciertos,
                TotalAciertosEXTColumnName, total_aciertos_ext,
                TotalOmisionesColumnName, total_omisiones,
                TotalEquivocacionesColumnName, total_equivocaciones,
                CodigoPacienteColumnName, codigo_paciente, FechaColumnName, fecha );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update(DateTime fecha, string codigo_paciente, double desviacion, double media, TypeOf_AS_Test tipo_prueba, int total_aciertos, int total_aciertos_ext, int total_omisiones, int total_equivocaciones, bool completo)
        {
            return this.Update(fecha.ToString(), codigo_paciente, desviacion, media, tipo_prueba, total_aciertos, total_aciertos_ext, total_omisiones, total_equivocaciones, completo);
        }
        #endregion
    }
}
