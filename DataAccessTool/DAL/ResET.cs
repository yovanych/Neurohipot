using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _ResET : Table_Res
    {
        #region Propiedades
        public int Correctos { get; protected set; }
        public int Antes { get; protected set; }
        public int Dentro { get; protected set; }
        public int Omisiones { get; protected set; }
        public int Retardados { get; protected set; }
        #endregion

        #region Columnas
        public static string CorrectosColumnName { get { return "correctos"; } }
        public static string OmisionesColumnName { get { return "omisiones"; } }
        public static string DentroColumnName { get { return "dentro"; } }
        public static string AntesColumnName { get { return "antes"; } }
        public static string RetardadosColumnName { get { return "retardados"; } }
        #endregion

        #region Constructores
        public _ResET()
            : base( "ResET" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.Correctos = (int)r[CorrectosColumnName];
            this.Antes = (int)r[AntesColumnName];
            this.Omisiones = (int)r[OmisionesColumnName];
            this.Retardados = (int) r[RetardadosColumnName];
            this.Dentro = (int) r[DentroColumnName];
        }


        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, int correctos, int antes, int omisiones, int retardados, int dentro, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4},{5},{6},{7},{8}) VALUES ('{9}','{10}',{11},{12},{13},{14},{15},{16})",
                TN, CodigoPacienteColumnName, FechaColumnName, CorrectosColumnName, AntesColumnName, OmisionesColumnName, RetardadosColumnName, DentroColumnName, CompletoColumnName,
                codigo_paciente, fecha, correctos, antes, omisiones, retardados, dentro, completo );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente, int correctos, int antes, int omisiones, int retardados, int dentro, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente, correctos, antes, omisiones, retardados, dentro, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, int correctos, int antes, int omisiones, int retardados, int dentro, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12} WHERE fecha = '{13}' AND cod_paciente = '{14}'",
                TN, CorrectosColumnName, correctos, AntesColumnName, antes, OmisionesColumnName, omisiones, RetardadosColumnName, retardados, DentroColumnName, dentro, CompletoColumnName, completo,
                fecha, codigo_paciente );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente, int correctos, int antes, int omisiones, int retardados, int dentro, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente, correctos, antes, omisiones, retardados, dentro, completo );
        }
        #endregion
        
    }
}
