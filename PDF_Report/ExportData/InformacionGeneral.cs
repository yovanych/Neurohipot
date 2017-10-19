using System.Linq;
using BusinessObjects;
using DALayer;

namespace PDF_Report
{
    public abstract class InformacionGeneral
    {
        protected double[] general;
        protected readonly Paciente paciente;
        protected readonly Resultado_AS resultado;
        protected readonly float ia_total;
        public string[] Parametros { get; private set; }
        protected double zNotationAciertos, zNotationComisiones;
        protected MD_ByBlock md_bloques;

        protected InformacionGeneral( Paciente paciente, Resultado_AS resultado )
        {
            this.resultado = resultado;
            this.paciente = paciente;
            this.ia_total = FunctionLibrary.AttentionProfit( resultado.Aciertos.Sum(),
                                                         resultado.Aciertos_Extrannos.Sum(),
                                                         resultado.Equivocaciones.Sum(),
                                                         resultado.Omisiones.Sum() );
            this.md_bloques = new MD_ByBlock();
            md_bloques.LoadBlock( FunctionLibrary.GetTopBlocks( paciente.Edad )+1, paciente );

            this.zNotationAciertos = StatFunctionLibrary.ZNotation( resultado.Aciertos.Sum(),
                                                                      md_bloques.Aciertos.Media,
                                                                      md_bloques.Aciertos.Desviacion );
            this.zNotationComisiones = StatFunctionLibrary.ZNotation( resultado.Equivocaciones.Sum(),
                                                                        md_bloques.Comisiones.Media,
                                                                        md_bloques.Comisiones.Desviacion );
            Parametros = new[]
                {
                    PDF_Resources.EP_IA_Total,
                    PDF_Resources.EP_Aciertos, 
                    PDF_Resources.EP_Omisiones,
                    PDF_Resources.EP_Comisiones, 
                    PDF_Resources.EP_TR, 
                    PDF_Resources.EP_Error_TR,
                    PDF_Resources.EP_Sensibilidad,
                    PDF_Resources.EP_Criterio
                };
            this.Init();
        }

        #region Propiedades
        public double IndiceAtencion { get { return general[Function_Library.IA_index]; } }
        public double Aciertos { get { return general[Function_Library.Aciertos_index]; } }
        public double Omisiones { get { return general[Function_Library.Omisiones_index]; } }
        public double Comisiones { get { return general[Function_Library.Comisiones_index]; } }
        public double TiempoReaccion { get { return general[Function_Library.TR_index]; } }
        public double DesviacionTiempoReaccion { get { return general[Function_Library.DSTR_index]; } }
        public double Sensibilidad { get { return general[Function_Library.Sensibilidad_index]; } }
        public double Criterio { get { return general[Function_Library.Criterio_index]; } }

        public string STR_IndiceAtencion { get { return FunctionLibrary.ShowDouble( general[Function_Library.IA_index] ); } }
        public string STR_Aciertos { get { return FunctionLibrary.ShowDouble( general[Function_Library.Aciertos_index] ); } }
        public string STR_Omisiones { get { return FunctionLibrary.ShowDouble( general[Function_Library.Omisiones_index] ); } }
        public string STR_Comisiones { get { return FunctionLibrary.ShowDouble( general[Function_Library.Comisiones_index] ); } }
        public string STR_TiempoReaccion { get { return FunctionLibrary.ShowDouble( general[Function_Library.TR_index] ); } }
        public string STR_DesviacionTiempoReaccion { get { return FunctionLibrary.ShowDouble( general[Function_Library.DSTR_index] ); } }
        public string STR_Sensibilidad { get { return FunctionLibrary.ShowDouble( general[Function_Library.Sensibilidad_index] ); } }
        public string STR_Criterio { get { return FunctionLibrary.ShowDouble( general[Function_Library.Criterio_index] ); } }

        public double this[int index]
        {
            get { return general[index]; }
        }

        #endregion

        protected abstract void Init();

        public int Count()
        {
            return general.Length;
        }
    }
}
