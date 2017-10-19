using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _ResMF : Table_Res
    {
        #region Propiedades
        public int Errores { get; protected set; }
        public int Aciertos { get; protected set; }
        public int Omisiones { get; protected set; }
        #endregion

        #region Columnas
        public static string ErroresColumnName { get { return "errores"; } }
        public static string AciertosColumnName { get { return "aciertos"; } }
        public static string OmisionesColumnName { get { return "omisiones"; } }
        #endregion

        #region Constructores
        public _ResMF()
            : base( "ResMF" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.Errores = (int)r[ErroresColumnName];
            this.Aciertos = (int)r[AciertosColumnName];
            this.Omisiones = (int)r[OmisionesColumnName];
        }

        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, int errores, int aciertos, int omisiones, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4},{5},{6} ) VALUES ('{7}','{8}',{9},{10},{11},{12})",
                TN, CodigoPacienteColumnName, FechaColumnName, ErroresColumnName, AciertosColumnName, OmisionesColumnName, CompletoColumnName, 
                codigo_paciente, fecha, errores, aciertos, omisiones, completo );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente, int errores, int aciertos, int omisiones, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente, errores, aciertos, omisiones, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, int errores, int aciertos, int omisiones, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8} WHERE fecha = '{9}' AND cod_paciente = '{10}'",
                TN, ErroresColumnName, errores, AciertosColumnName, aciertos, OmisionesColumnName, omisiones, CompletoColumnName, completo,
                fecha, codigo_paciente );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente, int errores, int aciertos, int omisiones, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente, errores, aciertos, omisiones, completo );
        }
        #endregion
        
    }
}
