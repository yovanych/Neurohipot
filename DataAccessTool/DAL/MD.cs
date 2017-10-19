using System;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _MD : Table
    {
        #region Propiedades
        protected string sexo;
        public Sexo Sexo
        {
            get { return ( sexo.Equals( "M" ) ) ? Sexo.Masculino : Sexo.Femenino; }
            set
            {
                switch ( value )
                {
                    case Sexo.Masculino:
                        sexo = "M";
                        break;
                    case Sexo.Femenino:
                        sexo = "F";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException( "value" );
                }
            }
        }
        public int Edad { get; protected set; }
        public string Param { get; protected set; }
        public int Bloque { get; protected set; }
        public double Media { get; protected set; }
        public double Desviacion { get; protected set; }
        #endregion

        #region Columnas
        public static string SexoColumnName { get { return "Sexo"; } }
        public static string EdadColumnName { get { return "Edad"; } }
        public static string ParamColumnName { get { return "Param"; } }
        public static string BlockColumnName { get { return "Bloque"; } }
        public static string MediaColumnName { get { return "media"; } }
        public static string DesvEstColumnName { get { return "desv_est"; } }
        #endregion

        #region Constructores
        public _MD()
            : base( "MD" )
        { }
        #endregion

        #region Select
        public int LoadByID( Sexo sex, int edad, string param, int block )
        {
            string sexo = ( sex == Sexo.Masculino ) ? "M" : "F";
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = {4} AND {0}.{5} = '{6}' AND {0}.{7} = {8}", 
                TN, SexoColumnName, sexo, EdadColumnName, edad, ParamColumnName, param, BlockColumnName, block );
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
            string query = string.Format( "SELECT * FROM {0} ORDER BY {1}", TN, SexoColumnName);
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public int LoadByParameter( Sexo sex, int edad, string param )
        {
            string sexo = (sex == Sexo.Masculino) ? "M" : "F";
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = {4} AND {0}.{5} = '{6}' ORDER BY {7}",
                TN, SexoColumnName, sexo, EdadColumnName, edad, ParamColumnName, param, BlockColumnName);
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public int LoadByBlock( Sexo sex, int edad, int block )
        {
            string sexo = (sex == Sexo.Masculino) ? "M" : "F";
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = {4} AND {0}.{5} = {6} ORDER BY {7}",
                TN, SexoColumnName, sexo, EdadColumnName, edad, BlockColumnName, block, ParamColumnName );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        #endregion
        
        #region Metodos privados
        protected override void FillData( DataRow r )
        {
            this.sexo = r[SexoColumnName].ToString();
            this.Edad = (int)r[EdadColumnName];
            this.Param = r[ParamColumnName].ToString();
            this.Bloque = (int) r[BlockColumnName];
            this.Media = (double) r[MediaColumnName];
            this.Desviacion = (double) r[DesvEstColumnName];
        }
        #endregion

    }
}
