using System;
using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public class _ResRL : Table_Res
    {
        #region Propiedades
        public int Aciertos { get; protected set; }
        public int Equivocaciones { get; protected set; }
        public int Omisiones { get; protected set; }
        public int Recordadas1 { get; protected set; }
        public int Recordadas2 { get; protected set; }
        #endregion

        #region Columnas
        public static string AciertosColumnName { get { return "aciertos"; } }
        public static string EquivocacionesColumnName { get { return "equivocaciones"; } }
        public static string OmisionesColumnName { get { return "omisiones"; } }
        public static string Recordadas1ColumnName { get { return "recordadas1"; } }
        public static string Recordadas2ColumnName { get { return "recordadas2"; } }
        #endregion

        #region Constructores
        public _ResRL()
            : base( "ResRL" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.Aciertos = (int)r[AciertosColumnName];
            this.Equivocaciones = (int)r[EquivocacionesColumnName];
            this.Omisiones = (int)r[OmisionesColumnName];
            this.Recordadas1 = (int)r[Recordadas1ColumnName];
            this.Recordadas2 = (int)r[Recordadas2ColumnName];
        }

        #region Insert
        protected bool Insert( string fecha, string codigo_paciente, int aciertos, int equivocaciones, int omisiones, int recordadas1, int recordadas2, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4},{5},{6},{7},{8}) VALUES ('{9}','{10}',{11},{12},{13},{14},{15},{16})",
                TN, CodigoPacienteColumnName, FechaColumnName, AciertosColumnName, EquivocacionesColumnName, OmisionesColumnName, Recordadas1ColumnName, Recordadas2ColumnName, CompletoColumnName,
                codigo_paciente, fecha, aciertos, equivocaciones, omisiones, recordadas1, recordadas2, completo );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente, int aciertos, int equivocaciones, int omisiones, int recordadas1, int recordadas2, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente, aciertos, equivocaciones, omisiones, recordadas1, recordadas2, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente, int aciertos, int equivocaciones, int omisiones, int recordadas1, int recordadas2, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12} WHERE fecha = '{13}' AND cod_paciente = '{14}'",
                TN, AciertosColumnName, aciertos, EquivocacionesColumnName, equivocaciones, OmisionesColumnName, omisiones, Recordadas1ColumnName, recordadas1, Recordadas2ColumnName, recordadas2, CompletoColumnName, completo,
                fecha, codigo_paciente );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente, int aciertos, int equivocaciones, int omisiones, int recordadas1, int recordadas2, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente, aciertos, equivocaciones, omisiones, recordadas1, recordadas2, completo );
        }
        #endregion

    }
}
