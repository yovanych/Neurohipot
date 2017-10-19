using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    #region [UTILeS]
    
    public struct Busqueda
    {
        public Criterios_Busqueda campo;
        public string valor;
    }
    #endregion

    public class _Paciente : Table, IEnumerable<_Paciente>, IEnumerator<_Paciente>
    {
        public static string TableName = "Paciente";

        #region Propiedades
        public string Codigo { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre { get; set; }
        public string Aplicador { get; set; }
        public string Lugar { get; set; }
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
        public int Edad
        {
            get
            {
                var hoy = DateTime.Now;
                if (Fecha_Nacimiento < hoy)
                    return FunctionLibrary.GetAge(Fecha_Nacimiento);
                throw new Exception("Error: Fecha de entrada anterior");
            } 
        }
        public string Direccion { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }
        public string Escolaridad { get; set; }
        #endregion

        #region Columnas
        public static string CodigoPacienteColumnName { get { return "codigo"; } }
        public static string Apellido1ColumnName { get { return "apellido1"; } }
        public static string Apellido2ColumnName { get { return "apellido2"; } }
        public static string NombreColumnName { get { return "nombre"; } }
        public static string SexoColumnName { get { return "sexo"; } }
        public static string DireccionColumnName { get { return "direccion"; } }
        public static string Fecha_NacimientoColumnName { get { return "fecha_nac"; } }
        public static string EscolaridadColumnName { get { return "escolaridad"; } }
        public static string AplicadorColumnName { get { return "aplicador"; } }
        public static string LugarColumnName { get { return "lugar"; } }
        #endregion

        public _Paciente()
            : base( TableName )
        {}

        protected override void FillData( DataRow r )
        {
            this.Codigo = r[CodigoPacienteColumnName].ToString();
            this.Nombre = r[NombreColumnName].ToString();
            this.Apellido1 = r[Apellido1ColumnName].ToString();
            this.Apellido2 = r[Apellido2ColumnName].ToString();
            this.Direccion = r[DireccionColumnName].ToString();
            this.Fecha_Nacimiento = (DateTime)r[Fecha_NacimientoColumnName];
            this.sexo = r[SexoColumnName].ToString();
            this.Escolaridad = r[EscolaridadColumnName].ToString();
            this.Aplicador = r[AplicadorColumnName].ToString();
            this.Lugar = r[LugarColumnName].ToString();
        }

        #region Select
        public override int loadAll()
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0} ORDER BY {0}.{1}", TN, CodigoPacienteColumnName );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return this.Vista_Predeterminada.Table.Rows.Count;
        }
        public int LoadByID( string id )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0}  WHERE {1}.{2} = '{3}'", TN, TN, CodigoPacienteColumnName, id );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }

        public int LoadByName( string nombre )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            string query = string.Format( "SELECT * FROM {0} WHERE {0}.{1} = '{2}'", TN, NombreColumnName, nombre );
            var adapter = new OleDbDataAdapter( query, this.Connection.OleDB_Connection );
            var ds = new DataSet();
            adapter.Fill( ds, TN );
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView( ds.Tables[0] );
            Rewind();
            return ds.Tables[0].Rows.Count;
        }

        public int LoadByCriteria( List<Busqueda> criterios )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return code;
            var criterios_busqueda = new[] {CodigoPacienteColumnName, NombreColumnName, Apellido1ColumnName, Apellido2ColumnName, SexoColumnName};
            string cad = "(";
            for ( int i = 0; i < criterios.Count; i++ )
            {
                var criterio = criterios[i];
                cad += " "+ TN +"." + criterios_busqueda[(int)criterio.campo] + " = '" + criterio.valor + "'";
                if ( i != criterios.Count - 1 ) cad += " AND ";
                else cad += ")";
            }
            string query = string.Format("SELECT * FROM {0} WHERE {1}", TN, cad);
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
        public bool Delete( string id )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "DELETE * FROM {0} WHERE {0}.{1} = '{2}'", TN, CodigoPacienteColumnName, id );
            var ds = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        #endregion

        #region Update 
        public bool Update( string codigo, string nombre, string apellido1, string apellido2, string direccion, DateTime fecha_nacimiento, string sexo, string escolaridad, string aplicador, string lugar )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = '{2}', {3} = '{4}', {5} = '{6}', {7} = '{8}', {9} = {10}, {11} = '{12}', {13} = '{14}' , {15} = '{16}' , {17} = '{18}' WHERE {19} = '{20}'",
                TN, 
                NombreColumnName,
                nombre, 
                Apellido1ColumnName,
                apellido1, 
                Apellido2ColumnName,
                apellido2, 
                DireccionColumnName,
                direccion, 
                Fecha_NacimientoColumnName,
                FunctionLibrary.GetQueryStringForDateTime(fecha_nacimiento), 
                SexoColumnName,
                sexo, 
                EscolaridadColumnName,
                escolaridad, 
                AplicadorColumnName,
                aplicador, 
                LugarColumnName,
                lugar, 
                CodigoPacienteColumnName,
                codigo);
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( string codigo, string nombre, string apellido1, string apellido2, string direccion, DateTime fecha_nacimiento, Sexo sexo, string escolaridad, string aplicador, string lugar )
        {
            this.Sexo = sexo;
            return this.Update(codigo, nombre, apellido1, apellido2, direccion, fecha_nacimiento, this.sexo, escolaridad, aplicador, lugar);
        }

        #endregion

        #region Insert 
        public bool Insert( string codigo, string nombre, string apellido1, string apellido2, string direccion, DateTime fecha_nacimiento, string sexo, string escolaridad, string aplicador, string lugar )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} ) VALUES ('{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}')",
                TN, CodigoPacienteColumnName, NombreColumnName, Apellido1ColumnName, Apellido2ColumnName, DireccionColumnName, Fecha_NacimientoColumnName, SexoColumnName, EscolaridadColumnName, AplicadorColumnName, LugarColumnName,
                codigo, nombre, apellido1, apellido2, direccion, fecha_nacimiento, sexo, escolaridad, aplicador, lugar );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( string codigo, string nombre, string apellido1, string apellido2, string direccion, DateTime fecha_nacimiento, Sexo sexo, string escolaridad, string aplicador, string lugar )
        {
            this.Sexo = sexo;
            return this.Insert(codigo, nombre, apellido1, apellido2, direccion, fecha_nacimiento, this.sexo, escolaridad, aplicador, lugar);
        }

        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<_Paciente> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IEnumerator

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public _Paciente Current
        {
            get { return this; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        #endregion
    }
}
