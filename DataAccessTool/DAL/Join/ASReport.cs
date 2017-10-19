using System;
using System.Data;
using BusinessObjects;

namespace DALayer
{
    public class ASReport : View
    {
        private const string generalQuery =
            "SELECT * FROM Paciente INNER JOIN ( ResASC INNER JOIN ( IndicadoresASC AS IndicadoresASC_1 INNER JOIN ( IndicadoresASC AS IndicadoresASC_2 INNER JOIN ( IndicadoresASC AS IndicadoresASC_3 INNER JOIN ( IndicadoresASC AS IndicadoresASC_4 INNER JOIN ( IndicadoresASC AS IndicadoresASC_5 INNER JOIN ( IndicadoresASC AS IndicadoresASC_6 INNER JOIN ( IndicadoresASC AS IndicadoresASC_7 ) ON IndicadoresASC_6.cod_paciente = IndicadoresASC_7.cod_paciente AND IndicadoresASC_6.fecha = IndicadoresASC_7.fecha  ) ON IndicadoresASC_5.cod_paciente = IndicadoresASC_6.cod_paciente AND IndicadoresASC_5.fecha = IndicadoresASC_6.fecha  ) ON IndicadoresASC_4.cod_paciente = IndicadoresASC_5.cod_paciente AND IndicadoresASC_4.fecha = IndicadoresASC_5.fecha  ) ON IndicadoresASC_3.cod_paciente = IndicadoresASC_4.cod_paciente AND IndicadoresASC_3.fecha = IndicadoresASC_4.fecha  ) ON IndicadoresASC_2.cod_paciente = IndicadoresASC_3.cod_paciente AND IndicadoresASC_2.fecha = IndicadoresASC_3.fecha  ) ON IndicadoresASC_1.cod_paciente = IndicadoresASC_2.cod_paciente AND IndicadoresASC_1.fecha = IndicadoresASC_2.fecha  ) ON ResASC.cod_paciente = IndicadoresASC_1.cod_paciente AND ResASC.fecha = IndicadoresASC_1.fecha  ) ON Paciente.codigo = ResASC.cod_paciente  WHERE IndicadoresASC_1.bloque = 0 AND IndicadoresASC_2.bloque = 1 AND IndicadoresASC_3.bloque = 2 AND IndicadoresASC_4.bloque = 3 AND IndicadoresASC_5.bloque = 4 AND IndicadoresASC_6.bloque = 5 AND IndicadoresASC_7.bloque = 6  ORDER BY Paciente.codigo ASC, ResASC.fecha DESC";

        #region Propiedades
        #region Paciente

        public DateTime FechaNacimiento { get; protected set; }
        public string Sexo { get; protected set; }
        public string Aplicador { get; protected set; }
        public string Lugar { get; protected set; }
        public int Edad
        {
            get
            {
                var hoy = DateTime.Now;
                if ( FechaNacimiento < hoy )
                {
                    int edad = hoy.Year - FechaNacimiento.Year;
                    if ( hoy.Month < FechaNacimiento.Month )
                        edad--;
                    else if ( hoy.Month == FechaNacimiento.Month && hoy.Day < FechaNacimiento.Day )
                        edad--;
                    return edad;
                }
                throw new Exception( "Error: Fecha de entrada anterior" );
            }
        }
        #endregion

        #region Res
        public string Codigo_Paciente { get; protected set; }
        public DateTime Fecha { get; protected set; }
        public bool Completo { get; protected set; }
        public double Desviacion { get; protected set; }
        public double Media { get; protected set; }
        public TypeOf_AS_Test TipoPrueba { get; protected set; }
        public int Total_Aciertos { get; protected set; }
        public int Total_Aciertos_Ext { get; protected set; }
        public int Total_Omisiones { get; protected set; }
        public int Total_Equivocaciones { get; protected set; }
        public float IndiceAtencionTotal
        {
            get
            {
                return FunctionLibrary.AttentionProfit( this.Total_Aciertos,
                    this.Total_Aciertos_Ext, this.Total_Equivocaciones, this.Total_Omisiones );
            }
        }
        #endregion

        #region Indicadores
        public int[] Aciertos { get; protected set; }
        public int[] Aciertos_Extrannos { get; protected set; }
        public int[] Equivocaciones { get; protected set; }
        public int[] Omisiones { get; protected set; }
        public double[] Media_TiempoReaccion { get; protected set; }
        public double[] Desviacion_TiempoReaccion { get; protected set; }
        public float[] CoeficienteAtencion { get; protected set; }
        #endregion
        #endregion

        #region Overrides of View
        /// <summary>
        /// Build a query with joints
        /// </summary>
        /// <param name="args">args[0] = cod_paciente</param>
        /// <returns></returns>
        protected override string BuildQuery(params object[] args )
        {
            if ( args == null || args.Length == 0 )
                return  BuildBasicQuery();
            return BuildQuery4APatient( (string)args[0], (int)args[1] );
        }

        protected override void FillData( DataRow r )
        {
            this.Codigo_Paciente = r[Paciente.CodigoPacienteColumnName].ToString();
            this.Sexo = r[Paciente.SexoColumnName].ToString();
            this.FechaNacimiento = (DateTime) r[Paciente.Fecha_NacimientoColumnName];
            this.Aplicador = r[Paciente.AplicadorColumnName].ToString();
            this.Lugar = r[Paciente.LugarColumnName].ToString();
            this.Fecha = (DateTime)r[string.Format( "{0}.{1}", _ResASC.TableName, _ResASC.FechaColumnName )];
            this.Desviacion = (double) r[_ResASC.DesviacionColumnName];
            this.Media = (double)r[_ResASC.MediaColumnName];
            this.TipoPrueba = (TypeOf_AS_Test)((byte)r[_ResASC.TipoPruebaColumnName]);
            this.Total_Aciertos = (int)r[_ResASC.TotalAciertosColumnName];
            this.Total_Aciertos_Ext = (int)r[_ResASC.TotalAciertosEXTColumnName];
            this.Total_Omisiones = (int)r[_ResASC.TotalOmisionesColumnName];
            this.Total_Equivocaciones = (int)r[_ResASC.TotalEquivocacionesColumnName];
            this.Completo = (bool)r[_ResASC.CompletoColumnName];

            int TOP = FunctionLibrary.GetTopBlocks( this.Edad );

            Aciertos = new int[7];
            Aciertos_Extrannos = new int[7];
            Equivocaciones = new int[7];
            Omisiones  = new int[7];
            Media_TiempoReaccion  = new double[7];
            Desviacion_TiempoReaccion  = new double[7];
            CoeficienteAtencion  = new float[7];

            for ( int i = 0; i < 7; i++ )
            {
                Aciertos[i] = (i<TOP)? (int)r[string.Format( "{0}_{1}.{2}",IndicadoresASC.TableName, i+1, IndicadoresASC.AciertosColumnName )] : 0;
                Aciertos_Extrannos[i] = (i<TOP)?  (int)r[string.Format( "{0}_{1}.{2}", IndicadoresASC.TableName, i+1, IndicadoresASC.AciertosEXTColumnName )] : 0;
                Equivocaciones[i] = (i<TOP)?  (int)r[string.Format( "{0}_{1}.{2}", IndicadoresASC.TableName, i+1, IndicadoresASC.EquivocacionesColumnName )] : 0;
                Omisiones[i] = (i<TOP)?  (int)r[string.Format( "{0}_{1}.{2}", IndicadoresASC.TableName, i+1, IndicadoresASC.OmisionesColumnName )] : 0;
                Media_TiempoReaccion[i] = (i<TOP)?  (double)r[string.Format( "{0}_{1}.{2}", IndicadoresASC.TableName, i+1, IndicadoresASC.MediaTRColumnName )] : 0;
                Desviacion_TiempoReaccion[i] = (i<TOP)?  (double)r[string.Format( "{0}_{1}.{2}", IndicadoresASC.TableName, i+1, IndicadoresASC.DesviacionTRColumnName )] : 0;
                CoeficienteAtencion[i] = (i<TOP)?  FunctionLibrary.AttentionProfit( Aciertos[i], 
                                                                          Aciertos_Extrannos[i], 
                                                                          Equivocaciones[i],
                                                                          Omisiones[i] ) : 0;
            }
        }

        #endregion

        #region Private
        private string BuildQuery4APatient( string cod_paciente, int edad )
        {
            int TOP = FunctionLibrary.GetTopBlocks( edad );
            var tablas = new string[TOP+2];
            tablas[0] = Paciente.TableName;
            tablas[1] = _ResASC.TableName;
            for ( int i = 0; i < TOP; i++ )
            {
                tablas[i+2] = string.Format( "{0}_{1}", IndicadoresASC.TableName, i + 1 );
            }
            return string.Format( "SELECT * FROM {0} WHERE {1} ORDER BY {2}.fecha DESC", BuildQuery( tablas, 0 ), BuildWhere( tablas, cod_paciente ), _ResASC.TableName );
        }

        private string BuildBasicQuery()
        {
            var tablas = new string[9];
            tablas[0] = Paciente.TableName;
            tablas[1] = _ResASC.TableName;
            for ( int i = 0; i < 7; i++ )
            {
                tablas[i+2] = string.Format( "{0}_{1}", IndicadoresASC.TableName, i + 1 );
            }
            return string.Format( "SELECT * FROM {0} WHERE {1} ORDER BY {3}.codigo ASC, {2}.fecha DESC", BuildQuery( tablas, 0 ), BuildWhere( tablas, null ), _ResASC.TableName, Paciente.TableName );
        }

        private string BuildWhere( string[] tablas, string cod_paciente )
        {
            string q = string.Format( "{0}.bloque = 0 ", tablas[2] );
            for ( int pos = 3; pos < tablas.Length; pos++ )
                q += string.Format( "AND {0}.bloque = {1} ", tablas[pos], pos - 2 );
            if (!string.IsNullOrEmpty( cod_paciente )) 
                q += string.Format( "AND {0}.codigo = '{1}'", Paciente.TableName, cod_paciente );
            return q;
        }

        private string BuildQuery( string[] tablas, int pos )
        {
            if ( pos == tablas.Length-1 ) return string.Format( "{0} AS {1}", IndicadoresASC.TableName, tablas[pos] );
            string join = (pos <= 1)
                            ? tablas[pos]
                            : string.Format( "{0} AS {1}", IndicadoresASC.TableName, tablas[pos] );
            string q = string.Format( "{0} INNER JOIN ( {1} ) ON ", join, BuildQuery( tablas, pos + 1 ) );
            if ( pos == 0 )
                q += string.Format( "{0}.codigo = {1}.cod_paciente ", tablas[pos], tablas[pos+1] );
            else
                q += string.Format( "{0}.cod_paciente = {1}.cod_paciente AND {0}.fecha = {1}.fecha ", tablas[pos], tablas[pos+1] );
            return q;
        }

        #endregion
    }
}
