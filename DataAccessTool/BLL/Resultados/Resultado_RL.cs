using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_RL : Resultado
    {
        #region Propiedades
        public int Omisiones { get; set; }
        public int Equivocaciones { get; set; }
        public int Aciertos { get; set; }
        public int Recordadas1 { get; set; }
        public int Recordadas2 { get; set; }
        #endregion

        #region Cast
        protected new _ResRL TableResult
        {
            get { return base.TableResult as _ResRL; }
        }
        #endregion

        #region Constructores
        public Resultado_RL( string codigo_paciente, int equivocaciones, int omisiones, int aciertos, int recordadas1, int recordadas2, DateTime fecha, bool completo )
            : base( new _ResRL(), codigo_paciente, fecha, completo )
        {
            init( equivocaciones, aciertos, omisiones, recordadas1, recordadas2 );
        }

        private void init( int equivocaciones, int aciertos, int omisiones, int recordadas1, int recordadas2 )
        {
            this.Aciertos = aciertos;
            this.Equivocaciones = equivocaciones;
            this.Omisiones = omisiones;
            this.Recordadas1 = recordadas1;
            this.Recordadas2 = recordadas2;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_RL )
            {
                var r = (Resultado_RL)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return "Aprendizaje de Palabras";
        }
        protected override void initType()
        {
            this.Tipo = ResultType.RL;
        }

        public override bool Save()
        {
            return
                this.TableResult.Insert( this.Fecha,
                    this.CodigoPaciente,
                    Aciertos, Equivocaciones, Omisiones, Recordadas1, Recordadas2,
                    this.Completo );
        }

        #endregion
    }
}



