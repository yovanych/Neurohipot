using BusinessObjects;
using DALayer;

namespace PDF_Report
{
    public class Orientaciones
    {
        #region Orientaciones

        private string o_ia;
        public string O_indice_atencion_total
        {
            get { return this.o_ia ?? string.Empty; }
        }
        private string o_aciertos;
        public string O_Aciertos
        {
            get { return o_aciertos ?? string.Empty; }
        }

        private string o_omisiones;
        public string O_Omision
        {
            get { return o_omisiones ?? string.Empty; }
        }

        private string o_comisiones;
        public string O_Comision
        {
            get { return o_comisiones ?? string.Empty; }
        }

        private string o_tr;
        public string O_TR
        {
            get { return o_tr ?? string.Empty; }
        }

        private string o_error_tr;
        public string O_ErrorTR
        {
            get { return o_error_tr ?? string.Empty; }
        }

        private string o_conclusiones;
        public string Conclusiones
        {
            get { return o_conclusiones ?? string.Empty; }
        }

        public string O_d
        {
            get { return "Ver Manual"; }
        }
        public string O_C
        {
            get { return "Ver Manual"; }
        }
        #endregion

        public void Init( Resultado_AS result_SA, double[] ia_bloques, TNotaciones TNotaciones, int edad )
        {
            var perc = new[] { int.MinValue, 0, 30, 40, 61, 66 };
            var ori_IA_A = new[]
                {
                    "Puntaje probablemente inválido",
                    "Altamente Atípico", 
                    "Moderadamente Atípico", 
                    "Promedio", 
                    "Buen desempeño", 
                    "Muy buen desempeño"
                };
            var ori_O_C_DE = new[]
                {
                    "Puntaje probablemente inválido",
                    "Muy Buen desempeño", 
                    "Buen desempeño", 
                    "Promedio", 
                    "Moderadamente Atípico", 
                    "Altamente Atípico"
                };
            var ori_TR = new[]
                {
                    "Puntaje probablemente inválido",
                    "Atípicamente rápidos", 
                    "Moderadamente rápidos", 
                    "Promedio", 
                    "Moderadamente lentos", 
                    "Muy lento"
                };
            int countPerc = perc.Length;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.IndiceAtencion >= perc[i] )
                    this.o_ia = ori_IA_A[i];
                else break;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.Aciertos >= perc[i] )
                    this.o_aciertos = ori_IA_A[i];
                else break;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.Omisiones >= perc[i] )
                    this.o_omisiones = ori_O_C_DE[i];
                else break;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.Comisiones >= perc[i] )
                    this.o_comisiones = ori_O_C_DE[i];
                else break;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.DesviacionTiempoReaccion >= perc[i] )
                    this.o_error_tr = ori_O_C_DE[i];
                else break;
            for ( int i = 0; i < countPerc; i++ )
                if ( TNotaciones.TiempoReaccion >= perc[i] )
                    this.o_tr = ori_TR[i];
                else break;

            #region Conclusiones de los percentiles
            //// a)
            //if ( PercentilesGenerales[IA_index] <= 25 && PercentilesGenerales[Omisiones_index] >= 75 )
            //    this.o_conclusiones +=
            //        "Los resultados en el Índice de Atención y el número elevado de errores por omisión, sugieren la presencia de dificultades atencionales.\n";
            //// b)
            //if ( PercentilesGenerales[IA_index] <= 25 && PercentilesGenerales[Omisiones_index] <= 75 && PercentilesGenerales[Comisiones_index] >= 75 )
            //    this.o_conclusiones +=
            //        "Los resultados en el Índice de Atención y el número elevado de errores por acción, sugieren la presencia de dificultades en el control de los impulsos que pueden perturbar el rendimiento atencional, esta conclusión será tan válida como válido se considere el protocolo.\n";
            //// c)
            //if ( PercentilesGenerales[Error_TR_index] <= 75 )
            //    this.o_conclusiones +=
            //        "Los resultados en la desviación estándar de los TR sugieren variabilidad en la calidad de la  atención.\n";
            //// f)
            //if ( result_SA.Aciertos_Extrannos.Sum() >= 3 )
            //    this.o_conclusiones +=
            //        "Dado el número de Aciertos Extemporáneos establezca una correlación entre éstos, los tiempos de reacción y el IA antes de conjeturar posibles dificultades de control inhibitorio.\n";
            //// g)
            //if ( string.IsNullOrEmpty( o_conclusiones ) )
            //    this.o_conclusiones =
            //        "Protocolo que no indica altas probabilidades de ser compatible con dificultades atencionales.\n";
            //// protocolo válido por omisiones de un bloque
            //if ( !ProtocoloVálido1( result_SA ) )
            //    this.o_conclusiones +=
            //        "Hubo una larga serie de omisiones, el administrador debe decidir si este protocolo es válido.\n";
            //// protocolo válido por atencion deficiente
            //if ( !ProtocoloVálidoMAS( result_SA ) )
            //    this.o_conclusiones +=
            //        "Hubo bloques de la prueba en que el sujeto parece no haber respondido, o respondido al azar. El administrador debe decidir si este protocolo es válido.\n";
            #endregion

            if ( !ProtocoloValidoA( result_SA, FunctionLibrary.GetTopBlocks( edad ) ) )
                this.o_conclusiones +=
                    "Hubo una larga serie de omisiones, el administrador debe decidir si este protocolo es válido\n";
            if ( !ProtocoloValidoB( result_SA, ia_bloques, FunctionLibrary.GetTopBlocks( edad ) ) )
                this.o_conclusiones +=
                    "Hubo bloques de la prueba en que el sujeto parece no haber respondido, o respondido al azar. El administrador debe decidir si este protocolo es válido.\n";
            if ( string.IsNullOrEmpty( o_conclusiones ) )
                this.o_conclusiones =
                    "El análisis de los parámetros de esta administración sugieren que el protocolo es válido";
        }

        /// <summary>
        /// b)	Si se dan en dos o más bloques IA de valor negativo (pero al menos ha habido 1 acierto en cada bloque). 
        /// </summary>
        private bool ProtocoloValidoB( Resultado_AS result_SA, double[] ia_bloques, int TOP )
        {
            int ia_Count = 0;
            int aciertosBloques = 0;
            for ( int bloque = 0; bloque < TOP; bloque++ )
            {
                if ( ia_bloques[bloque] < 0 ) ia_Count++;
                if ( result_SA.Aciertos[bloque] > 0 ) aciertosBloques++;
            }
            return !(ia_Count >= 2 && aciertosBloques == TOP);
        }

        /// <summary>
        /// a)	Si no hay aciertos durante todo un bloque
        /// </summary>
        private bool ProtocoloValidoA( Resultado_AS result_SA, int TOP )
        {
            for ( int bloque = 0; bloque < TOP; bloque++ )
                if ( result_SA.Aciertos[bloque] == 0 )
                    return false;
            return true;
        }
    }
}
