using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_AM : Resultado
    {
        #region Propiedades
        public int Maximo_Hacia_Alante { get; set; }
        public int Maximo_Hacia_Atras { get; set; }
        public int Puntos_Hacia_Alante { get; set; }
        public int Puntos_Hacia_Atras { get; set; }
        #endregion

        #region Cast
        protected new _ResAM TableResult
        {
            get { return base.TableResult as _ResAM; }
        }
        #endregion

        #region Constructores
        public Resultado_AM( string codigo_paciente, int hacia_alante, int ptos_hacia_alante, int hacia_atras, int ptos_hacia_atras, DateTime fecha, bool completo )
            : base(new _ResAM(), codigo_paciente, fecha, completo)
        {
            init(hacia_alante, ptos_hacia_alante, hacia_atras, ptos_hacia_atras);
        }

        private void init(int hacia_alante, int ptos_hacia_alante, int hacia_atras, int ptos_hacia_atras)
        {
            this.Maximo_Hacia_Alante = hacia_alante;
            this.Maximo_Hacia_Atras = hacia_atras;
            this.Puntos_Hacia_Alante = ptos_hacia_alante;
            this.Puntos_Hacia_Atras = ptos_hacia_atras;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_AM )
            {
                var r = (Resultado_AM)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return "Amplitud de Memoria";
        }
        protected override void initType()
        {
            this.Tipo = ResultType.AM;
        }

        public override bool Save()
        {
            return 
                this.TableResult.Insert(this.Fecha, 
                    this.CodigoPaciente, 
                    Maximo_Hacia_Alante, 
                    Puntos_Hacia_Alante, 
                    Maximo_Hacia_Atras, 
                    Puntos_Hacia_Atras, 
                    this.Completo);
        }

        #endregion
    }
}
