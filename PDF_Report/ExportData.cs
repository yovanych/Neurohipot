using System.Collections.Generic;
using BusinessObjects;
using DALayer;
using GraphicReport;


namespace PDF_Report
{
    public class ExportData
    {
        //#region Orientaciones

        //private string o_ia;
        //public string O_indice_atencion_total
        //{
        //    get { return this.o_ia ?? string.Empty; }
        //}
        //private string o_aciertos;
        //public string O_Aciertos
        //{
        //    get { return o_aciertos ?? string.Empty; }
        //}

        //private string o_omisiones;
        //public string O_Omision
        //{
        //    get { return o_omisiones ?? string.Empty; }
        //}

        //private string o_comisiones;
        //public string O_Comision
        //{
        //    get { return o_comisiones ?? string.Empty; }
        //}

        //private string o_tr;
        //public string O_TR
        //{
        //    get { return o_tr ?? string.Empty; }
        //}

        //private string o_error_tr;
        //public string O_ErrorTR
        //{
        //    get { return o_error_tr ?? string.Empty; }
        //}

        //private string o_conclusiones;
        //public string Conclusiones
        //{
        //    get { return o_conclusiones ?? string.Empty; }
        //}
        
        //public string O_d
        //{
        //    get { return "Ver Manual"; }
        //}
        //public string O_C
        //{
        //    get { return "Ver Manual"; }
        //}
        //#endregion
        
        private const int TOP_SHOW = 7;
        private readonly int TOP; 

        public ExportData (Paciente paciente, Resultado resultado)
        {
            this.Paciente = paciente;
            this.TOP = (Paciente.Edad == 6) ? 4 : 7;
            this.Resultado = resultado;
        }

        public Paciente Paciente { get; private set; }
        private Resultado _resultado;
        public Resultado Resultado
        {
            get { return _resultado; }
            private set
            {
                _resultado = value;
                if ( this.Paciente == null || _resultado == null) return;
                var resultado = (Resultado_AS)_resultado;
                ChR_Errores = new List<Ar_ChartingResult>();
                ChR_Tiempos = new List<Ar_ChartingResult>();
                
                //bloque, parámetro
                PercentilesXbloque = new string[7, 6];
                var ia_bloques = new double[TOP_SHOW];
                
                for ( int i = 0; i < TOP_SHOW; i++ )
                    ia_bloques[i] = (i < TOP)? IA_Bloque( i, resultado ) : 0;

                //var md_bloques = new MD();
                var md_bloques = new MD_ByBlock();

                for ( int bloque = 0; bloque < TOP_SHOW; bloque++ )
                {
                    md_bloques.LoadBlock( bloque+1, Paciente );
                    PercentilesXbloque[bloque, 1] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( resultado.Aciertos[bloque], md_bloques.Aciertos.Media, md_bloques.Aciertos.Desviacion ) );
                    PercentilesXbloque[bloque, 3] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( resultado.Equivocaciones[bloque], md_bloques.Comisiones.Media, md_bloques.Comisiones.Desviacion ) );
                    PercentilesXbloque[bloque, 5] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( resultado.DesiacionesTR[bloque], md_bloques.DS_TR.Media, md_bloques.DS_TR.Desviacion ) );
                    PercentilesXbloque[bloque, 0] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( ia_bloques[bloque], md_bloques.IA.Media, md_bloques.IA.Desviacion ) );
                    PercentilesXbloque[bloque, 2] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( resultado.Omisiones[bloque], md_bloques.Omisiones.Media, md_bloques.Omisiones.Desviacion ) );
                    PercentilesXbloque[bloque, 4] = (bloque>=TOP)?"-": 
                        FunctionLibrary.ShowDouble( StatFunctionLibrary.TNotation( resultado.MediasTR[bloque], md_bloques.TR.Media, md_bloques.TR.Desviacion ) );
                    
                    var ch_result1 = new Ar_ChartingResult
                    (
                        string.Format( PDF_Resources.BloqueGraphicAxisLabelFormat, bloque+1 ),
                        (resultado.Equivocaciones.Length <= bloque)? 0 : StatFunctionLibrary.TNotation( resultado.Equivocaciones[bloque], md_bloques.Comisiones.Media, md_bloques.Comisiones.Desviacion ),
                        (resultado.Omisiones.Length <= bloque)? 0 : StatFunctionLibrary.TNotation( resultado.Omisiones[bloque], md_bloques.Omisiones.Media, md_bloques.Omisiones.Desviacion ),
                        (resultado.Omisiones.Length <= bloque)? 0 : StatFunctionLibrary.TNotation( ia_bloques[bloque], md_bloques.IA.Media, md_bloques.IA.Desviacion )
                    );
                    var ch_result2 = new Ar_ChartingResult
                    (
                        string.Format( PDF_Resources.BloqueGraphicAxisLabelFormat, bloque+1 ),
                        (resultado.MediasTR.Length <= bloque)? 0 : StatFunctionLibrary.TNotation( resultado.MediasTR[bloque], md_bloques.TR.Media, md_bloques.TR.Desviacion ),
                        (resultado.DesiacionesTR.Length <= bloque)? 0 : StatFunctionLibrary.TNotation( resultado.DesiacionesTR[bloque], md_bloques.DS_TR.Media, md_bloques.DS_TR.Desviacion )
                    );
                    ChR_Errores.Add( ch_result1 );
                    ChR_Tiempos.Add( ch_result2 );
                }
                //Parametros = new[]
                //{
                //    PDF_Resources.EP_IA_Total,
                //    PDF_Resources.EP_Aciertos, 
                //    PDF_Resources.EP_Omisiones,
                //    PDF_Resources.EP_Comisiones, 
                //    PDF_Resources.EP_TR, 
                //    PDF_Resources.EP_Error_TR,
                //    PDF_Resources.EP_Sensibilidad,
                //    PDF_Resources.EP_Criterio
                //};

                this.Puntuaciones = new Puntuaciones( this.Paciente, resultado );
                this.TNotaciones = new TNotaciones( this.Paciente, resultado );

                this.Orientaciones = new Orientaciones();
                this.Orientaciones.Init( resultado, ia_bloques, this.TNotaciones, this.Paciente.Edad );
            }
        }
        /* Resultado utilizando percentiles
        public Resultado Resultado
        {
            get { return _resultado; }
            private set
            {
                _resultado = value;
                PercentilSearch.Deserialize();
                if ( this.Paciente == null ) return;
                var resultado = (Resultado_AS)_resultado;
                var result_SA = (Resultado_AS)_resultado;
                ChR_Errores = new List<Ar_ChartingResult>();
                ChR_Tiempos = new List<Ar_ChartingResult>();
                // filas - los parámetros, columnas - los bloques
                PercentilesXbloque = new string[7, 6];
                for ( int i = 0; i < resultado.Aciertos.Length; i++ )
                {
                    double iaBloque = FunctionLibrary.AttentionProfit(
                                resultado.Aciertos[i],
                                resultado.Aciertos_Extrannos[i],
                                resultado.Equivocaciones[i],
                                resultado.Omisiones[i] );
                    PercentilesXbloque[i, 0] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.IA, i + 1, Paciente.Edad, iaBloque, Paciente.Sexo)); 
                    PercentilesXbloque[i, 1] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Aciertos, i + 1, Paciente.Edad, resultado.Aciertos[i], Paciente.Sexo));
                    PercentilesXbloque[i, 2] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Omisiones, i + 1, Paciente.Edad, resultado.Omisiones[i], Paciente.Sexo));
                    PercentilesXbloque[i, 3] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Comisiones, i + 1, Paciente.Edad, resultado.Equivocaciones[i], Paciente.Sexo));
                    PercentilesXbloque[i, 4] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.TR, i + 1, Paciente.Edad, resultado.MediasTR[i], Paciente.Sexo));
                    PercentilesXbloque[i, 5] = Function_Library.ShowDouble(PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.DS_TR, i + 1, Paciente.Edad, resultado.DesiacionesTR[i], Paciente.Sexo)); 
                }

                float ia_total = FunctionLibrary.AttentionProfit(result_SA.Aciertos.Sum(),
                                                         result_SA.Aciertos_Extrannos.Sum(),
                                                         result_SA.Equivocaciones.Sum(),
                                                         result_SA.Omisiones.Sum() );
                ChR_Percentiles = new List<Ar_ChartingResult>();
                Parametros = new[]
                {
                    PDF_Resources.EP_IA_Total,
                    PDF_Resources.EP_Aciertos, 
                    PDF_Resources.EP_Omisiones,
                    PDF_Resources.EP_Comisiones, 
                    PDF_Resources.EP_TR, 
                    PDF_Resources.EP_Error_TR
                };

                var indices = new double[resultado.Aciertos.Length];
                for ( int bloque = 0; bloque < resultado.Aciertos.Length; bloque++ )
                {
                    float ia = FunctionLibrary.AttentionProfit(resultado.Aciertos[bloque],
                                                             resultado.Aciertos_Extrannos[bloque],
                                                             resultado.Equivocaciones[bloque],
                                                             resultado.Omisiones[bloque] );
                    var ch_result1 = new Ar_ChartingResult
                    (
                        string.Format( PDF_Resources.BloqueGraphicAxisLabelFormat, bloque+1 ),
                        PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Comisiones, bloque + 1, Paciente.Edad, resultado.Equivocaciones[bloque], Paciente.Sexo),
                        PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Omisiones, bloque + 1, Paciente.Edad, resultado.Omisiones[bloque], Paciente.Sexo),
                        PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.IA, bloque + 1, Paciente.Edad, ia, Paciente.Sexo)
                    );
                    var ch_result2 = new Ar_ChartingResult
                    (
                        string.Format( PDF_Resources.BloqueGraphicAxisLabelFormat, bloque+1 ),
                        PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.TR, bloque + 1, Paciente.Edad, resultado.MediasTR[bloque], Paciente.Sexo),
                        PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.DS_TR, bloque + 1, Paciente.Edad, resultado.DesiacionesTR[bloque], Paciente.Sexo)
                    );
                    indices[bloque] = ia;
                    ChR_Errores.Add( ch_result1 );
                    ChR_Tiempos.Add( ch_result2 );
                }
                this.ValoresGenerales = new[]
                {
                    Function_Library.ShowDouble( ia_total ),
                    result_SA.Aciertos.Sum().ToString(),
                    result_SA.Omisiones.Sum().ToString(),
                    result_SA.Equivocaciones.Sum().ToString(),
                    Function_Library.ShowDouble(result_SA.Media), 
                    Function_Library.ShowDouble(Math.Sqrt(result_SA.Desviacion))
                };
                this.PercentilesGenerales = new[]
                {
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.IA, Paciente.Edad, ia_total, Paciente.Sexo),
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Aciertos, Paciente.Edad, result_SA.Aciertos.Sum(), Paciente.Sexo),
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Omisiones, Paciente.Edad, result_SA.Omisiones.Sum(), Paciente.Sexo),
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.Comisiones, Paciente.Edad, result_SA.Equivocaciones.Sum(), Paciente.Sexo),
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.TR, Paciente.Edad, result_SA.Media, Paciente.Sexo),
                    PercentilSearch.Percentil(result_SA.TipoAtencion, result_SA.TipoPrueba, AS_TestParameter.DS_TR, Paciente.Edad, result_SA.Desviacion, Paciente.Sexo)
                };
                STR_PercentilesGenerales = new string[PercentilesGenerales.Length];
                for ( int i = 0; i < PercentilesGenerales.Length; i++ )
                {
                    var ch_result = new Ar_ChartingResult
                    (
                        this.Parametros[i],
                        PercentilesGenerales[i]
                    );
                    ChR_Percentiles.Add( ch_result );
                    STR_PercentilesGenerales[i] = Function_Library.ShowDouble( PercentilesGenerales[i] );
                }

                SetOrientaciones(result_SA);
            }
        }
         */
        
        private double IA_Bloque( int bloque, Resultado_AS resultado )
        {
            return FunctionLibrary.AttentionProfit( resultado.Aciertos[bloque],
                                                    resultado.Aciertos_Extrannos[bloque],
                                                    resultado.Equivocaciones[bloque],
                                                    resultado.Omisiones[bloque] );
        }

        //private void SetOrientaciones( Resultado_AS result_SA, double[] ia_bloques )
        //{
        //    var perc = new[] {int.MinValue, 0, 30, 40, 61, 66 };
        //    var ori_IA_A = new[]
        //        {
        //            "Puntaje probablemente inválido",
        //            "Altamente Atípico", 
        //            "Moderadamente Atípico", 
        //            "Promedio", 
        //            "Buen desempeño", 
        //            "Muy buen desempeño"
        //        };
        //    var ori_O_C_DE = new[]
        //        {
        //            "Puntaje probablemente inválido",
        //            "Muy Buen desempeño", 
        //            "Buen desempeño", 
        //            "Promedio", 
        //            "Moderadamente Atípico", 
        //            "Altamente Atípico"
        //        };
        //    var ori_TR = new[]
        //        {
        //            "Puntaje probablemente inválido",
        //            "Atípicamente rápidos", 
        //            "Moderadamente rápidos", 
        //            "Promedio", 
        //            "Moderadamente lentos", 
        //            "Muy lento"
        //        };
        //    int countPerc = perc.Length;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[IA_index] >= perc[i] )
        //            this.o_ia = ori_IA_A[i];
        //        else break;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[Aciertos_index] >= perc[i] )
        //            this.o_aciertos = ori_IA_A[i];
        //        else break;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[Omisiones_index] >= perc[i] )
        //            this.o_omisiones = ori_O_C_DE[i];
        //        else break;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[Comisiones_index] >= perc[i] )
        //            this.o_comisiones = ori_O_C_DE[i];
        //        else break;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[Error_TR_index] >= perc[i] )
        //            this.o_error_tr = ori_O_C_DE[i];
        //        else break;
        //    for ( int i = 0; i < countPerc; i++ )
        //        if ( this.PercentilesGenerales[TR_index] >= perc[i] )
        //            this.o_tr = ori_TR[i];
        //        else break;

        //    #region Conclusiones de los percentiles
        //    //// a)
        //    //if ( PercentilesGenerales[IA_index] <= 25 && PercentilesGenerales[Omisiones_index] >= 75 )
        //    //    this.o_conclusiones +=
        //    //        "Los resultados en el Índice de Atención y el número elevado de errores por omisión, sugieren la presencia de dificultades atencionales.\n";
        //    //// b)
        //    //if ( PercentilesGenerales[IA_index] <= 25 && PercentilesGenerales[Omisiones_index] <= 75 && PercentilesGenerales[Comisiones_index] >= 75 )
        //    //    this.o_conclusiones +=
        //    //        "Los resultados en el Índice de Atención y el número elevado de errores por acción, sugieren la presencia de dificultades en el control de los impulsos que pueden perturbar el rendimiento atencional, esta conclusión será tan válida como válido se considere el protocolo.\n";
        //    //// c)
        //    //if ( PercentilesGenerales[Error_TR_index] <= 75 )
        //    //    this.o_conclusiones +=
        //    //        "Los resultados en la desviación estándar de los TR sugieren variabilidad en la calidad de la  atención.\n";
        //    //// f)
        //    //if ( result_SA.Aciertos_Extrannos.Sum() >= 3 )
        //    //    this.o_conclusiones +=
        //    //        "Dado el número de Aciertos Extemporáneos establezca una correlación entre éstos, los tiempos de reacción y el IA antes de conjeturar posibles dificultades de control inhibitorio.\n";
        //    //// g)
        //    //if ( string.IsNullOrEmpty( o_conclusiones ) )
        //    //    this.o_conclusiones =
        //    //        "Protocolo que no indica altas probabilidades de ser compatible con dificultades atencionales.\n";
        //    //// protocolo válido por omisiones de un bloque
        //    //if ( !ProtocoloVálido1( result_SA ) )
        //    //    this.o_conclusiones +=
        //    //        "Hubo una larga serie de omisiones, el administrador debe decidir si este protocolo es válido.\n";
        //    //// protocolo válido por atencion deficiente
        //    //if ( !ProtocoloVálidoMAS( result_SA ) )
        //    //    this.o_conclusiones +=
        //    //        "Hubo bloques de la prueba en que el sujeto parece no haber respondido, o respondido al azar. El administrador debe decidir si este protocolo es válido.\n";
        //    #endregion

        //    if ( !ProtocoloValidoA( result_SA ) )
        //        this.o_conclusiones +=
        //            "Hubo una larga serie de omisiones, el administrador debe decidir si este protocolo es válido\n";
        //    if ( !ProtocoloValidoB( result_SA, ia_bloques ) )
        //        this.o_conclusiones +=
        //            "Hubo bloques de la prueba en que el sujeto parece no haber respondido, o respondido al azar. El administrador debe decidir si este protocolo es válido.\n";
        //    if ( string.IsNullOrEmpty( o_conclusiones ) )
        //        this.o_conclusiones =
        //            "El análisis de los parámetros de esta administración sugieren que el protocolo es válido";
        //}

        /// <summary>
        /// b)	Si se dan en dos o más bloques IA de valor negativo (pero al menos ha habido 1 acierto en cada bloque). 
        /// </summary>
        //private bool ProtocoloValidoB( Resultado_AS result_SA, double[] ia_bloques )
        //{
        //    int ia_Count = 0;
        //    int aciertosBloques = 0;
        //    for ( int bloque = 0; bloque < TOP; bloque++ )
        //    {
        //        if ( ia_bloques[bloque] < 0 ) ia_Count++;
        //        if ( result_SA.Aciertos[bloque] > 0 ) aciertosBloques++;
        //    }
        //    return !(ia_Count >= 2 && aciertosBloques == TOP);
        //}

        /// <summary>
        /// a)	Si no hay aciertos durante todo un bloque
        /// </summary>
        //private bool ProtocoloValidoA( Resultado_AS result_SA )
        //{
        //    for ( int bloque = 0; bloque < TOP; bloque++ )
        //        if ( result_SA.Aciertos[bloque] == 0 )
        //            return false;
        //    return true;
        //}

        public Resultado_AS CastResultadoForResultadoAS{ get { return (Resultado_AS) this.Resultado; } }
        //public string[] Parametros { get; private set; }
        public string[,] PercentilesXbloque { get; private set; }
        //public string[] ValoresGenerales { get; private set; }
        //public double[] PercentilesGenerales { get; private set; }
        //public string[] STR_PercentilesGenerales { get; private set; }
        //public string Sensibilidad { get; private set; }
        //public string Criterio { get; private set; }
        //public List<Ar_ChartingResult> ChR_Percentiles { get; private set; }
        public List<Ar_ChartingResult> ChR_Errores { get; private set; }
        public List<Ar_ChartingResult> ChR_Tiempos { get; private set; }
        public string ParamSensibilidad { get { return PDF_Resources.EP_Sensibilidad; } }
        public string ParamCriterio { get { return PDF_Resources.EP_Criterio; } }


        public TNotaciones TNotaciones { get; private set; }
        public Puntuaciones Puntuaciones { get; private set; }
        public Orientaciones Orientaciones { get; private set; }
    }
}
