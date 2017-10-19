using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public abstract class View
    {
        public DataView Vista_Predeterminada { get; set; }
        public Connection Connection { get; protected set; }

        protected View( )
        {
            this.Connection = new Connection();
        }

        #region Select
        public virtual int loadByPaciente( string cod_paciente, int edad )
        {
            string query = BuildQuery( cod_paciente, edad );
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public virtual int loadAll()
        {
            string query = BuildQuery();
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        #endregion

        protected abstract void FillData( DataRow r );
        protected abstract string BuildQuery( params object[] args );

        #region IEnumerator Members
        private int enumerator_index;
        public int RowCount
        {
            get { return this.Vista_Predeterminada.Table.Rows.Count; }
        }

        public void Rewind()
        {
            enumerator_index = 0;
            if ( this.Vista_Predeterminada.Table.Rows.Count > 0 )
                FillData( this.Vista_Predeterminada.Table.Rows[enumerator_index] );
        }

        public bool MoveNext()
        {
            enumerator_index++;
            if ( enumerator_index < this.Vista_Predeterminada.Table.Rows.Count )
            {
                FillData( this.Vista_Predeterminada.Table.Rows[enumerator_index] );
                return true;
            }
            return false;
        }
        #endregion
    }
}
