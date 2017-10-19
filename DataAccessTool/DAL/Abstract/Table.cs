using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public abstract class Table
    {
        protected string TN;
        public DataView Vista_Predeterminada { get; set; }
        public Connection Connection { get; protected set; }
        
        protected Table( string table_name )
        {
            this.Connection = new Connection( );
            this.TN = table_name;
        }

        #region Select
        public virtual int loadAll()
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}", TN );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return this.Vista_Predeterminada.Table.Rows.Count;
        }
        #endregion

        protected abstract void FillData( DataRow r );

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
