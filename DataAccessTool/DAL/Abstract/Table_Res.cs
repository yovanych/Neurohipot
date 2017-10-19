using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public abstract class Table_Res : Table
    {
        #region Propiedades
        public string Codigo_Paciente { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public bool Completo { get; protected set; }
        public static string CodigoPacienteColumnName { get { return "cod_paciente"; } }
        public static string FechaColumnName { get { return "fecha"; } }
        public static string CompletoColumnName { get { return "completo"; } }
        #endregion

        #region Constructores
        protected Table_Res(string table_name)
            : base( table_name )
        { }
        #endregion

        #region Select
        public int LoadByID( string fecha, string codigo_paciente )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = '{4}'", TN, FechaColumnName, fecha, CodigoPacienteColumnName, codigo_paciente );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public int LoadByPaciente( string codigo_paciente )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}' ORDER BY {0}.{3}", TN, CodigoPacienteColumnName, codigo_paciente, FechaColumnName );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        #endregion

        #region Delete
        public virtual bool Delete( string fecha, string codigo_paciente )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "DELETE * FROM {0} WHERE {0}.{1} = {2} AND {0}.{3} = {4}", TN, FechaColumnName, fecha, CodigoPacienteColumnName, codigo_paciente );
            var ds = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public virtual bool Delete( string codigo_paciente )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "DELETE * FROM {0} WHERE {1} = {2}", TN, CodigoPacienteColumnName, codigo_paciente );
            var ds = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        #endregion

        #region Overrides of Table

        protected override void FillData( DataRow r )
        {
            this.Codigo_Paciente = r[CodigoPacienteColumnName].ToString();
            this.Fecha = (DateTime)r[FechaColumnName];
            this.Completo = (bool)r[CompletoColumnName];
        }

        #endregion
    }
}
