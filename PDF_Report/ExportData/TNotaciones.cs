using System.Collections.Generic;
using System.Linq;
using BusinessObjects;
using DALayer;
using GraphicReport;

namespace PDF_Report
{
    public class TNotaciones : InformacionGeneral
    {
        public List<Ar_ChartingResult> ChR_TNotaciones { get; private set; }

        public TNotaciones( Paciente paciente, Resultado_AS resultado ) : base( paciente, resultado )
        {
        }

        #region Overrides of InformacionGeneral

        protected override void Init()
        {
            //var md_bloques = new MD_ByBlock();
            //md_bloques.LoadBlock( FunctionLibrary.GetTopBlocks( paciente.Edad )+1, paciente );

            //double zNotationAciertos = StatFunctionLibrary.ZNotation( resultado.Aciertos.Sum(),
            //                                                          md_bloques.Aciertos.Media,
            //                                                          md_bloques.Aciertos.Desviacion );
            //double zNotationComisiones = StatFunctionLibrary.ZNotation( resultado.Equivocaciones.Sum(),
            //                                                            md_bloques.Comisiones.Media,
            //                                                            md_bloques.Comisiones.Desviacion );
            this.general = new[]
            {
                StatFunctionLibrary.TNotation( ia_total, md_bloques.IA.Media, md_bloques.IA.Desviacion ),
                StatFunctionLibrary.TNotation( zNotationAciertos ),
                StatFunctionLibrary.TNotation( resultado.Omisiones.Sum(), md_bloques.Omisiones.Media, md_bloques.Omisiones.Desviacion ),
                StatFunctionLibrary.TNotation( zNotationComisiones ),
                StatFunctionLibrary.TNotation( resultado.Media, md_bloques.TR.Media, md_bloques.TR.Desviacion ),
                StatFunctionLibrary.TNotation( resultado.Desviacion, md_bloques.DS_TR.Media, md_bloques.DS_TR.Desviacion ),
                0,
                0
            };
            ChR_TNotaciones = new List<Ar_ChartingResult>();
            for ( int i = 0; i < this.Count()-2; i++ )
            {
                var ch_result = new Ar_ChartingResult
                (
                    this.Parametros[i],
                    general[i]
                );
                ChR_TNotaciones.Add( ch_result );
            }
        }

        #endregion
    }
}
