using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _ResPVA : Table_Res
    {
        #region Propiedades
        public int Aciertos { get; protected set; }
        #endregion

        #region Columnas
        public static string AciertosColumnName { get { return "aciertos"; } }
        #endregion

        #region Constructores
        public _ResPVA(PVA_Type type)
            : base( type == PVA_Type.PVA_1 ? "ResPVA" : "ResPVA2" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.Aciertos = (int)r[AciertosColumnName];
        }

        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, int aciertos, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4}) VALUES ('{5}','{6}',{7},{8})",
                TN, CodigoPacienteColumnName, FechaColumnName, AciertosColumnName, CompletoColumnName,
                codigo_paciente, fecha, aciertos, completo );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente, int aciertos, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente, aciertos, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, int aciertos, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4} WHERE fecha = '{5}' AND cod_paciente = '{6}'",
                TN, AciertosColumnName, aciertos, CompletoColumnName, completo,
                fecha, codigo_paciente );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente, int aciertos, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente, aciertos, completo );
        }
        #endregion

        
    }
}
