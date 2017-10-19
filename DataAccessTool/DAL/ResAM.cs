using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _ResAM : Table_Res
    {
        #region Propiedades
        public int Max_Adelante { get; protected set; }
        public int Max_Atras { get; protected set; }
        public int Ptos_Adelante { get; protected set; }
        public int Ptos_Atras { get; protected set; }
        #endregion

        #region Columnas
        public static string MaxAdelanteColumnName { get { return "max_adelante"; } }
        public static string MaxAtrasColumnName { get { return "max_atras"; } }
        public static string PtosAlanteColumnName { get { return "ptos_alante"; } }
        public static string PtosAtrasColumnName { get { return "ptos_atras"; } }
        #endregion

        #region Constructores
        public _ResAM()
            : base( "ResAM" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.Max_Adelante = (int)r[MaxAdelanteColumnName];
            this.Max_Atras = (int)r[MaxAtrasColumnName];
            this.Ptos_Adelante = (int) r[PtosAlanteColumnName];
            this.Ptos_Atras = (int)r[PtosAtrasColumnName];
        }


        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, int max_alante, int ptos_alante, int max_atras, int ptos_atras, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4},{5},{6},{7} ) VALUES ('{8}','{9}',{10},{11},{12},{13},{14})",
                TN, CodigoPacienteColumnName, FechaColumnName, MaxAdelanteColumnName, PtosAlanteColumnName, MaxAtrasColumnName, PtosAtrasColumnName, CompletoColumnName,
                codigo_paciente, fecha, max_alante, ptos_alante, max_atras, ptos_atras, completo);
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente, int max_alante, int ptos_alante, int max_atras, int ptos_atras, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente, max_alante, ptos_alante, max_atras, ptos_atras, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, int max_alante, int ptos_alante, int max_atras, int ptos_atras, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8} WHERE fecha = '{9}' AND cod_paciente = '{10}'",
                TN, MaxAdelanteColumnName, max_alante, PtosAlanteColumnName, ptos_alante, 
                MaxAtrasColumnName, max_atras, PtosAtrasColumnName, ptos_atras, 
                fecha, codigo_paciente);
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente, int max_alante, int ptos_alante, int max_atras, int ptos_atras, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente, max_alante, ptos_alante, max_atras, ptos_atras, completo);
        }
        #endregion
        
    }
}
