using System;
using System.Collections.Generic;
using BusinessObjects;

namespace DALayer
{
    public abstract class Resultado_AS : Resultado
    {
        #region Propiedades
        public int[] Omisiones { get; set; }
        public int[] Equivocaciones { get; set; }
        public int[] Aciertos { get; set; }
        public int[] Aciertos_Extrannos { get; set; }
        public double[] MediasTR { get; set; }
        public double[] DesiacionesTR { get; set; }
        public double Media { get; set; }
        public double Desviacion { get; set; }
        public TypeAS TipoAtencion { get; private set; }
        public TypeOf_AS_Test TipoPrueba { get; set; }
        #endregion
        
        #region Constructores

        protected Resultado_AS(TypeAS tipo_atencion, string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, List<int> tiempos, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba)
            : base(tipo_atencion == TypeAS.Simple ? (Table) new _ResASS() : new _ResASC(), codigo_paciente, fecha, completo)
        {
            double m = StatFunctionLibrary.media(tiempos);
            this.TipoAtencion = tipo_atencion;
            init( omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, m, StatFunctionLibrary.desv_est( tiempos, m ), tipo_prueba );
        }

        protected Resultado_AS( TypeAS tipo_atencion, string codigo_paciente, int[] omisiones, int[] equivocaciones, int[] aciertos, int[] aciertos_ext, double[] medias_tr, double[] desviaciones_tr, double media, double desviacion, DateTime fecha, bool completo, TypeOf_AS_Test tipo_prueba )
            : base(tipo_atencion == TypeAS.Simple ? new _ResASS() : new _ResASC() as Table, codigo_paciente, fecha, completo)
        {
            this.TipoAtencion = tipo_atencion;
            init(omisiones, equivocaciones, aciertos, aciertos_ext, medias_tr, desviaciones_tr, media, desviacion, tipo_prueba);
        }

        protected Resultado_AS(TypeAS tipo_atencion, string codigo_paciente, DateTime fecha, bool completo, Table_Res ras, TypeOf_AS_Test tipo_prueba)
            : base(ras, codigo_paciente, fecha, completo)
        {
            _Indicadores indicadores = tipo_atencion == TypeAS.Simple ? (_Indicadores)new IndicadoresASS() : new IndicadoresASC();
            indicadores.LoadByPacienteAndFecha(codigo_paciente, fecha);
            var _omisiones      = new int[indicadores.RowCount];
            var _equivocaciones = new int[indicadores.RowCount];
            var _aciertos       = new int[indicadores.RowCount];
            var _aciertos_ext = new int[indicadores.RowCount];
            var _medias_tr = new double[indicadores.RowCount];
            var _desv_tr = new double[indicadores.RowCount];
            var i = 0;
            if (indicadores.RowCount > 0)
                do
                {
                    _omisiones[i] = indicadores.Omisiones;
                    _equivocaciones[i] = indicadores.Equivocaciones;
                    _aciertos[i] = indicadores.Aciertos;
                    _aciertos_ext[i] = indicadores.Aciertos_Extrannos;
                    _medias_tr[i] = indicadores.Media_TiempoReaccion;
                    _desv_tr[i++] = indicadores.Desviacion_TiempoReaccion;
                } while (indicadores.MoveNext());
            double _desv = tipo_atencion == TypeAS.Simple ? ((_ResASS)ras).Desviacion : ((_ResASC)ras).Desviacion;
            double _media = tipo_atencion == TypeAS.Simple ? ((_ResASS) ras).Media : ((_ResASC)ras).Media;
            this.TipoAtencion = tipo_atencion;
            init(_omisiones, _equivocaciones, _aciertos, _aciertos_ext, _medias_tr, _desv_tr, _media, _desv, tipo_prueba);
        }
        private void init(  int[] omisiones, 
                            int[] equivocaciones, 
                            int[] aciertos, 
                            int[] aciertos_ext, 
                            double[] medias_tr, 
                            double[] desviaciones_tr, 
                            double media, 
                            double desviacion,
                            TypeOf_AS_Test tipo_prueba)
        {
            this.Omisiones = omisiones;
            this.Equivocaciones = equivocaciones;
            this.Aciertos = aciertos;
            this.Aciertos_Extrannos = aciertos_ext;
            this.MediasTR = medias_tr;
            this.DesiacionesTR = desviaciones_tr;
            this.Media = media;
            this.Desviacion = desviacion;
            this.TipoPrueba = tipo_prueba;
        }
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_AS )
            {
                var r = (Resultado_AS)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }

        public override string ToString()
        {
            return (this.TipoAtencion == TypeAS.Simple)
                ? "Atención Sostenida Simple" 
                : "Atención Sostenida Compleja";
        }
        protected override void initType()
        {
            this.Tipo = (this.TableResult is _ResASS)//this.Tipo = (this.TipoAtencion == TypeAS.Simple) 
                ? ResultType.ASS
                : ResultType.ASC;
        }

        #endregion
    }
}
