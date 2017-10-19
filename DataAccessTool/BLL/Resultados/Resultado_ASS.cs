using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_ASS : Resultado_AS
    {
        #region Cast
        protected new _ResASS TableResult
        {
            get { return base.TableResult as _ResASS; }
        }
        #endregion

        public Resultado_ASS( string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, List<int> tiempos, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba )
            : base(TypeAS.Simple, codigo_paciente, omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, tiempos, fecha, completo, tipo_prueba)
        {
        }

        public Resultado_ASS( string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, double media, double desviacion, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba )
            : base(TypeAS.Simple, codigo_paciente, omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, media, desviacion, fecha, completo, tipo_prueba)
        {
        }

        public Resultado_ASS( string codigo_paciente, DateTime fecha, bool completo, _ResASS rass, TypeOf_AS_Test tipo_prueba )
            : base(TypeAS.Simple, codigo_paciente, fecha, completo, rass, tipo_prueba)
        {
        }
        public override bool Save()
        {
            if (!this.TableResult.Insert(this.Fecha, this.CodigoPaciente, (int)this.Desviacion, (int)this.Media, this.TipoPrueba, this.Aciertos.Sum(), this.Aciertos_Extrannos.Sum(), this.Omisiones.Sum(), this.Equivocaciones.Sum(), this.Completo))
                return false;
            var indicadores = new IndicadoresASS();
            for (int i = 0; i < this.Aciertos.Length; i++)
            {
                if (!indicadores.Insert(this.Fecha, this.CodigoPaciente, i, Equivocaciones[i], Aciertos[i], Aciertos_Extrannos[i], Omisiones[i], MediasTR[i], DesiacionesTR[i]))
                    return false;
            }
            return true;
        }
    }
}
