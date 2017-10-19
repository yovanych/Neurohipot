using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public abstract class Join
    {
        protected string TN1, TN2;
        protected string tPaciente = "Paciente";
        protected string Query;
        protected string SelectFields;
        public DataView Vista_Predeterminada { get; set; }
        public Connection Connection { get; protected set; }

        protected Join( string table1_name, string table2_name )
        {
            this.Connection = new Connection();
            this.TN1 = table1_name;
            this.TN2 = table2_name;
            this.Query = init_Query();
            this.SelectFields = init_SelectedFields();
        }

        #region Select
        public virtual int loadAll()
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT {0} FROM {1}", SelectFields, this.Query );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return this.Vista_Predeterminada.Table.Rows.Count;
        }
        #endregion

        #region Abstract
        protected abstract string init_Query();
        protected abstract string init_SelectedFields();
        protected abstract void FillData( DataRow r );
        #endregion

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
