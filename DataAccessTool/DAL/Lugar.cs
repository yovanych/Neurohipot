using System;
using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public class _Lugar : Table
    {
        #region Propiedades
        public int Id_Lugar { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; protected set; }
        #endregion

        #region Columnas
        public static string IdLugarColumnName { get { return "id_lugar"; } }
        public static string LugarColumnName { get { return "lugar"; } }
        public static string DescripcionColumnName { get { return "descripcion"; } }
        #endregion

        #region Constructores
        public _Lugar()
            : base( "Lugar" )
        { }
        #endregion

        #region Select
       public int LoadByID( int id_lugar )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = {2}", TN, IdLugarColumnName, id_lugar );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public int LoadByName( string lugar )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}'", TN, LugarColumnName, lugar );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }

        public override int loadAll()
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0} ORDER BY {1}", TN, LugarColumnName );
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
        #endregion

        #region Update
        #endregion

        #region Insert
        public bool Insert( string lugar, string descripcion)
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1}, {2} ) VALUES ('{3}','{4}')",
                TN, LugarColumnName, DescripcionColumnName, lugar, descripcion );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( !(obj is _Lugar) ) return false;
            var us = (_Lugar)obj;
            return (us.Id_Lugar == this.Id_Lugar);
        }
        #endregion

        #region Metodos privados
        protected override void FillData( DataRow r )
        {
            this.Lugar = r[LugarColumnName].ToString();
            this.Id_Lugar = (int)r[IdLugarColumnName];
            this.Descripcion = r[DescripcionColumnName].ToString();
        }
        #endregion
    }
}
