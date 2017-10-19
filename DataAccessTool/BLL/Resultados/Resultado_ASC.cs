using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_ASC : Resultado_AS
    {
        #region Cast
        protected new _ResASC TableResult
        {
            get { return base.TableResult as _ResASC; }
        }
        #endregion

        public Resultado_ASC(string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, List<int> tiempos, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba)
            : base(TypeAS.Compleja, codigo_paciente, omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, tiempos, fecha, completo, tipo_prueba)
        {
        }

        public Resultado_ASC( string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, double media, double desviacion, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba )
            : base(TypeAS.Compleja, codigo_paciente, omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, media, desviacion, fecha, completo, tipo_prueba)
        {
        }

        public Resultado_ASC(string codigo_paciente, DateTime fecha, bool completo, _ResASC rasc, TypeOf_AS_Test tipo_prueba)
            : base(TypeAS.Compleja, codigo_paciente, fecha, completo, rasc, tipo_prueba)
        {
        }

        public override bool Save()
        {
            if (!this.TableResult.Insert(this.Fecha, this.CodigoPaciente, (int)this.Desviacion, (int)this.Media, this.TipoPrueba, this.Aciertos.Sum(), this.Aciertos_Extrannos.Sum(), this.Omisiones.Sum(), this.Equivocaciones.Sum(), this.Completo))
                return false;
            var indicadores = new IndicadoresASC();
            for (int i = 0; i < this.Aciertos.Length; i++)
            {
                if (!indicadores.Insert(this.Fecha, this.CodigoPaciente, i, Equivocaciones[i], Aciertos[i], Aciertos_Extrannos[i], Omisiones[i], MediasTR[i], DesiacionesTR[i]))
                    return false;
            }
            return true;
        }
    }
}
