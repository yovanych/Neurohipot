using System;
using System.Data;
using System.Data.OleDb;

namespace DALayer
{
    public class _ResTRS : Table_Res
    {
        #region Propiedades
        public int EnTiempo { get; protected set; }
        public double MediaEnTiempo { get; protected set; }
        public double DesviacionEnTiempo { get; protected set; }
        public int Omisiones { get; protected set; }
        public int FueraTiempo { get; protected set; }
        public double MediaFueraTiempo { get; protected set; }
        public double DesviacionFueraTiempo { get; protected set; }
        public int Anticipadas { get; protected set; }
        #endregion

        #region Columnas
        public static string EnTiempoColumnName { get { return "en_tiempo"; } }
        public static string MediaEnTiempoColumnName { get { return "media_en_tiempo"; } }
        public static string DesvEnTiempoColumnName { get { return "desv_en_tiempo"; } }
        public static string OmisionesColumnName { get { return "omisiones"; } }
        public static string FueraTiempoColumnName { get { return "fuera_tiempo"; } }
        public static string MediaFueraTiempoColumnName { get { return "media_fuera_tiempo"; } }
        public static string DesvFueraTiempoColumnName { get { return "desv_fuera_tiempo"; } }
        public static string AnticipadasColumnName { get { return "anticipadas"; } }
        #endregion

        #region Constructores
        public _ResTRS()
            : base( "ResTRS" )
        { }
        #endregion

        protected override void FillData( DataRow r )
        {
            base.FillData( r );
            this.EnTiempo = (int)r[EnTiempoColumnName];
            this.MediaEnTiempo = (double)r[MediaEnTiempoColumnName];
            this.DesviacionEnTiempo = (double)r[DesvEnTiempoColumnName];
            this.Omisiones = (int)r[OmisionesColumnName];
            this.FueraTiempo = (int)r[FueraTiempoColumnName];
            this.MediaFueraTiempo = (double)r[MediaFueraTiempoColumnName];
            this.DesviacionEnTiempo = (double)r[DesvFueraTiempoColumnName];
            this.Anticipadas = (int)r[AnticipadasColumnName];
        }

        #region Insert
        protected bool Insert( string fecha, string codigo_paciente,
            int en_tiempo, double media_en_tiempo, double desv_en_tiempo,
            int fuera_tiempo, double media_fuera_tiempo, double desv_fuera_tiempo,
            int omisiones, int anticipadas, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "INSERT INTO {0} ( {1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}) VALUES ('{12}','{13}',{14},{15},{16},{17},{18},{19},{20},{21},{22})",
                TN, CodigoPacienteColumnName, FechaColumnName,
                EnTiempoColumnName,
                MediaEnTiempoColumnName,
                DesvEnTiempoColumnName,
                FueraTiempoColumnName,
                MediaFueraTiempoColumnName,
                DesvFueraTiempoColumnName,
                OmisionesColumnName,
                AnticipadasColumnName,
                CompletoColumnName,
                codigo_paciente, fecha,
                en_tiempo,
                media_en_tiempo,
                desv_en_tiempo,
                fuera_tiempo,
                media_fuera_tiempo,
                desv_fuera_tiempo,
                omisiones,
                anticipadas,
                completo );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert( DateTime fecha, string codigo_paciente,
            int en_tiempo, double media_en_tiempo, double desv_en_tiempo,
            int fuera_tiempo, double media_fuera_tiempo, double desv_fuera_tiempo,
            int omisiones, int anticipadas, bool completo )
        {
            return this.Insert( fecha.ToString(), codigo_paciente,
                en_tiempo, media_en_tiempo, desv_en_tiempo,
                fuera_tiempo, media_fuera_tiempo, desv_fuera_tiempo,
                omisiones, anticipadas, completo );
        }
        #endregion

        #region Update
        protected bool Update( string fecha, string codigo_paciente,
            int en_tiempo, double media_en_tiempo, double desv_en_tiempo,
            int fuera_tiempo, double media_fuera_tiempo, double desv_fuera_tiempo,
            int omisiones, int anticipadas, bool completo )
        {
            int code = this.Connection.Connect();
            if ( code != 0 ) return false;
            string query = string.Format( "UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12}, {13} = {14}, {15} = {16}, {17} = {18} WHERE fecha = '{19}' AND cod_paciente = '{20}'",
                TN, EnTiempoColumnName, en_tiempo,
                MediaEnTiempoColumnName, media_en_tiempo,
                DesvEnTiempoColumnName, desv_en_tiempo,
                FueraTiempoColumnName, fuera_tiempo,
                MediaFueraTiempoColumnName, media_fuera_tiempo,
                DesvFueraTiempoColumnName, desv_fuera_tiempo,
                OmisionesColumnName, omisiones,
                AnticipadasColumnName, anticipadas,
                CompletoColumnName, completo,
                fecha, codigo_paciente );
            var comm = new OleDbCommand( query, this.Connection.OleDB_Connection );
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update( DateTime fecha, string codigo_paciente,
            int en_tiempo, double media_en_tiempo, double desv_en_tiempo,
            int fuera_tiempo, double media_fuera_tiempo, double desv_fuera_tiempo,
            int omisiones, int anticipadas, bool completo )
        {
            return this.Update( fecha.ToString(), codigo_paciente,
            en_tiempo, media_en_tiempo, desv_en_tiempo,
            fuera_tiempo, media_fuera_tiempo, desv_fuera_tiempo,
            omisiones, anticipadas, completo );
        }
        #endregion

    }
}


