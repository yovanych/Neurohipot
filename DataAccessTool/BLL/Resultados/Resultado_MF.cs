using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_MF : Resultado
    {
        #region Propiedades
        public int Errores { get;  set; }
        public int Omisiones { get;  set; }
        public int Aciertos { get;  set; }
        #endregion

        #region Cast
        protected new _ResMF TableResult
        {
            get { return base.TableResult as _ResMF; }
        }
        #endregion

        #region Constructores
        public Resultado_MF( string codigo_paciente, int errores, int omisiones, int aciertos, DateTime fecha, bool completo )
            : base( new _ResMF(), codigo_paciente, fecha, completo )
        {
            init( errores, aciertos, omisiones);
        }

        private void init( int errores, int aciertos, int omisiones)
        {
            this.Aciertos = aciertos;
            this.Errores = errores;
            this.Omisiones = omisiones;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_MF )
            {
                var r = (Resultado_MF)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return "Memoria de Figuras";
        }
        protected override void initType()
        {
            this.Tipo = ResultType.MF;
        }

        public override bool Save()
        {
            return
                this.TableResult.Insert( this.Fecha,
                    this.CodigoPaciente,
                    Errores, Aciertos, Omisiones,
                    this.Completo );
        }

        #endregion
    }
}


