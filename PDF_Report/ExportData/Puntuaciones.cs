using System.Linq;
using BusinessObjects;
using DALayer;

namespace PDF_Report
{
    public class Puntuaciones : InformacionGeneral
    {
        public Puntuaciones( Paciente paciente, Resultado_AS resultado ) : base( paciente, resultado )
        {
        }

        #region Overrides of InformacionGeneral

        protected override void Init()
        {
            this.general = new[]
                {
                    ia_total,
                    resultado.Aciertos.Sum(),
                    resultado.Omisiones.Sum(),
                    resultado.Equivocaciones.Sum(),
                    resultado.Media, 
                    resultado.Desviacion,
                    zNotationAciertos - zNotationComisiones,
                    -0.5 * ( zNotationAciertos + zNotationComisiones )
                };
        }

        #endregion
    }
}
