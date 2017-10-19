using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using BusinessObjects;

namespace DALayer
{
    public class _Indicadores : Table, IEnumerable<_Indicadores>, IEnumerator<_Indicadores>
    {   
        #region Propiedades
        public string Codigo_Paciente { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public int Bloque { get; protected set; }
        public int Aciertos { get; protected set; }
        public int Aciertos_Extrannos { get; protected set; }
        public int Equivocaciones { get; protected set; }
        public int Omisiones { get; protected set; }
        public double Media_TiempoReaccion { get; protected set; }
        public double Desviacion_TiempoReaccion { get; protected set; }
        public float CoeficienteAtencion { get; protected set; }
        #endregion

        #region Columnas
        public static string CodigoPacienteColumnName { get { return "cod_paciente"; } }
        public static string FechaColumnName { get { return "fecha"; } }
        public static string BloqueColumnName { get { return "bloque"; } }
        public static string AciertosColumnName { get { return "aciertos"; } }
        public static string AciertosEXTColumnName { get { return "aciertos_ext"; } }
        public static string EquivocacionesColumnName { get { return "equivocaciones"; } }
        public static string OmisionesColumnName { get { return "omisiones"; } }
        public static string MediaTRColumnName { get { return "media_tr"; } }
        public static string DesviacionTRColumnName { get { return "desv_tr";  } }
        #endregion

        #region Constructores
        protected _Indicadores(string tableName)
            : base(tableName)
        { }
        #endregion

        protected override void FillData(DataRow r)
        {
            this.Codigo_Paciente = r[CodigoPacienteColumnName].ToString();
            this.Fecha = (DateTime)r[FechaColumnName];
            this.Bloque = (int)r[BloqueColumnName];
            this.Aciertos = (int)r[AciertosColumnName];
            this.Aciertos_Extrannos = (int) r[AciertosEXTColumnName];
            this.Equivocaciones = (int)r[EquivocacionesColumnName];
            this.Omisiones = (int) r[OmisionesColumnName];
            this.Media_TiempoReaccion = (double) r[MediaTRColumnName];
            this.Desviacion_TiempoReaccion = (double) r[DesviacionTRColumnName];
            this.CoeficienteAtencion = FunctionLibrary.AttentionProfit(this.Aciertos, this.Aciertos_Extrannos, this.Equivocaciones, this.Omisiones);
        }
        
        #region Select
        public int LoadByID(DateTime fecha, string codigo_paciente, int bloque)
        {
            int code = this.Connection.Connect();
            if (code != 0) return code;
            string query = string.Format("SELECT * FROM {0}  WHERE {0}.{1} = {2} AND {0}.{3} = '{4}' AND {0}.{5} = {6}",
                TN, 
                FechaColumnName, 
                FunctionLibrary.GetQueryStringForDateTime(fecha), 
                CodigoPacienteColumnName,
                codigo_paciente, 
                BloqueColumnName,
                bloque);
            var adapter = new OleDbDataAdapter(query, this.Connection.OleDB_Connection);
            var ds = new DataSet();
            adapter.Fill(ds, TN);
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView(ds.Tables[0]);
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        public int LoadByPacienteAndFecha(string codigo_paciente, DateTime fecha)
        {
            int code = this.Connection.Connect();
            if (code != 0) return code;
            string query = string.Format("SELECT * FROM {0}  WHERE {0}.{1} = '{2}' AND {0}.{3} = {4}",
                TN, CodigoPacienteColumnName, codigo_paciente, FechaColumnName, FunctionLibrary.GetQueryStringForDateTime(fecha));
            var adapter = new OleDbDataAdapter(query, this.Connection.OleDB_Connection);
            var ds = new DataSet();
            adapter.Fill(ds, TN);
            this.Connection.Disconnect();
            this.Vista_Predeterminada = new DataView(ds.Tables[0]);
            Rewind();
            return ds.Tables[0].Rows.Count;
        }
        #endregion

        #region Insert
        public bool Insert(string fecha, string codigo_paciente, int bloque, int equivocaciones, int aciertos, int aciertos_ext, int omisiones, double media_tr, double desv_tr)
        {
            int code = this.Connection.Connect();
            if (code != 0) return false;
            string query = string.Format("INSERT INTO {0} ( {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9} ) VALUES ('{10}','{11}',{12},{13},{14},{15},{16},{17},{18})",
                TN, FechaColumnName, CodigoPacienteColumnName, BloqueColumnName, EquivocacionesColumnName, AciertosColumnName, AciertosEXTColumnName, OmisionesColumnName, MediaTRColumnName, DesviacionTRColumnName,
                fecha, codigo_paciente, bloque, equivocaciones, aciertos, aciertos_ext, omisiones, FunctionLibrary.ConvertPointBased(media_tr), FunctionLibrary.ConvertPointBased(desv_tr));
            var comm = new OleDbCommand(query, this.Connection.OleDB_Connection);
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Insert(DateTime fecha, string codigo_paciente, int bloque, int equivocaciones, int aciertos, int aciertos_ext, int omisiones, double media_tr, double desv_tr)
        {
            return this.Insert(fecha.ToString(), codigo_paciente, bloque, equivocaciones, aciertos, aciertos_ext, omisiones, media_tr, desv_tr);
        }
        #endregion

        #region Update
        public bool Update(string fecha, string codigo_paciente, int bloque, int equivocaciones, int aciertos, int aciertos_ext, int omisiones, double media_tr, double desv_tr)
        {
            int code = this.Connection.Connect();
            if (code != 0) return false;
            string query = string.Format("UPDATE {0} SET {1} = {2}, {3} = {4}, {5} = {6}, {7} = {8}, {9} = {10}, {11} = {12} WHERE {13} = '{14}' AND {15} = '{16}' AND {17} = {18}",
                TN, EquivocacionesColumnName, equivocaciones, AciertosColumnName, aciertos, AciertosEXTColumnName, aciertos_ext, OmisionesColumnName, omisiones, MediaTRColumnName, media_tr, DesviacionTRColumnName, desv_tr,
                FechaColumnName, fecha, CodigoPacienteColumnName, codigo_paciente, BloqueColumnName, bloque);
            var comm = new OleDbCommand(query, this.Connection.OleDB_Connection);
            this.Connection.Open();
            comm.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Update(DateTime fecha, string codigo_paciente, int bloque, int equivocaciones, int aciertos, int aciertos_ext, int omisiones, double media_tr, double desv_tr)
        {
            return this.Update(fecha.ToString(), codigo_paciente, bloque, equivocaciones, aciertos, aciertos_ext, omisiones, media_tr, desv_tr);
        }
        #endregion

        #region Delete
        public bool Delete(string fecha, string codigo_paciente)
        {
            int code = this.Connection.Connect();
            if (code != 0) return false;
            string query = string.Format("DELETE * FROM {0} WHERE {1} = '{2}' AND {3} = '{4}'",
                TN, FechaColumnName, fecha, CodigoPacienteColumnName, codigo_paciente);
            var ds = new OleDbCommand(query, this.Connection.OleDB_Connection);
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        public bool Delete(string codigo_paciente)
        {
            int code = this.Connection.Connect();
            if (code != 0) return false;
            string query = string.Format("DELETE * FROM {0} WHERE {1} = '{2}'",
                TN, CodigoPacienteColumnName, codigo_paciente);
            var ds = new OleDbCommand(query, this.Connection.OleDB_Connection);
            this.Connection.Open();
            ds.ExecuteNonQuery();
            this.Connection.Disconnect();
            return true;
        }
        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<_Indicadores> GetEnumerator()
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

        public _Indicadores Current
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
