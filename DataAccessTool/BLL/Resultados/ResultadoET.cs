using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_ET : Resultado
    {
        #region Propiedades
        public int Correcto { get;  set; }
        public int Dentro { get;  set; }
        public int Anticipados { get;  set; }
        public int Omisiones { get;  set; }
        public int Retardados { get;  set; }
        #endregion

        #region Cast
        protected new _ResET TableResult
        {
            get { return base.TableResult as _ResET; }
        }
        #endregion

        #region Constructores
        public Resultado_ET( string codigo_paciente, int correcto, int dentro, int anticipadas, int omisiones, int retardados, DateTime fecha, bool completo )
            : base( new _ResET(), codigo_paciente, fecha, completo )
        {
            init( correcto, dentro, anticipadas, omisiones, retardados );
        }

        private void init( int correcto, int dentro, int anticipadas, int omisiones, int retardados )
        {
            this.Correcto = correcto;
            this.Dentro = dentro;
            this.Anticipados = anticipadas;
            this.Omisiones = omisiones;
            this.Retardados = retardados;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_ET )
            {
                var r = (Resultado_ET)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return "Estimación de Tiempo";
        }
        protected override void initType()
        {
            this.Tipo = ResultType.ET;
        }

        public override bool Save()
        {
            return
                this.TableResult.Insert( this.Fecha,
                    this.CodigoPaciente,
                    Correcto,Anticipados, Omisiones, Retardados, Dentro,
                    this.Completo );
        }

        #endregion
    }
}

