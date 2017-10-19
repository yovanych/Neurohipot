using System;
using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public enum Categoria_Usuario {Administrador, Aplicador}

    public class _Usuario : Table
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Password { get; protected set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Escolaridad { get; set; }
        private string categoria;
        public Categoria_Usuario Categoria
        {
            get
            {
                return ( categoria.Equals( "Administrador" ) )
                           ? Categoria_Usuario.Administrador
                           : Categoria_Usuario.Aplicador;
            }
            set
            {
                switch ( value )
                {
                    case Categoria_Usuario.Administrador:
                        this.categoria = "Administrador";
                        break;
                    case Categoria_Usuario.Aplicador:
                        this.categoria = "Aplicador";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException( "value" );
                }
            }
        }
        #endregion

        #region Constructores
        public _Usuario()
            : base( "Usuario" )
        { }
        #endregion

        #region Select
        public int LoadByID( string nombre )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.nombre = '{1}'", TN, nombre );
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
            string query = string.Format( "SELECT * FROM {0} ORDER BY nombre", TN);
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }

        #endregion

        #region Metodos
        public bool Autenticate( string nombre, string password )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "SELECT * FROM {0} WHERE {0}.nombre = '{1}' AND {0}.passwd = '{2}'", TN, nombre, password );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count > 0;
        }
        
        #endregion

        #region Delete
        public bool Delete( string nombre )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "DELETE * FROM {0} WHERE {0}.nombre = '{1}'", TN, nombre);
            var ds = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        #endregion

        #region Update
        public bool Update( string nombre, string password, string categoria )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET nombre = '{1}', passwd = '{2}', categoria = '{3}' WHERE nombre = '{4}'",
                TN, nombre, password, categoria, nombre );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( string nombre, string password, Categoria_Usuario categoria )
        {
            switch (categoria)
            {
                case Categoria_Usuario.Administrador:
                    return this.Update(nombre, password, "Administrador");
                case Categoria_Usuario.Aplicador:
                    return this.Update(nombre, password, "Aplicador");
                default:
                    throw new ArgumentOutOfRangeException("categoria");
            }
        }

        #endregion

        #region Insert
        public bool Insert( string nombre, string password, Categoria_Usuario categoriaUsuario  )
        {
            string cat = (categoriaUsuario == Categoria_Usuario.Administrador) ? "Administrador" : "Aplicador";

            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( nombre, passwd, categoria ) VALUES ('{1}','{2}','{3}')",
                TN, nombre, password, cat);
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
            if ( !(obj is _Usuario) ) return false;
            var us = (_Usuario)obj;
            return (us.Nombre.Equals(this.Nombre) && us.Password.Equals(this.Password));
        }
        #endregion

        #region Metodos privados
        protected override void FillData( DataRow r )
        {
            this.Nombre = r["nombre"].ToString();
            this.Password = r["passwd"].ToString();
            this.categoria = r["categoria"].ToString();
        }
        protected void Save()
        {
            Update( this.Nombre, this.Password, this.categoria );
        }
        #endregion
    }
}
