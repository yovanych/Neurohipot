using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_PVA : Resultado
    {
        #region Propiedades
        public int Aciertos { get; set; }
        public PVA_Type PVA_Tipo { get; set; }
        #endregion

        #region Cast
        protected new _ResPVA TableResult
        {
            get { return base.TableResult as _ResPVA; }
        }
        #endregion

        #region Constructores
        public Resultado_PVA( PVA_Type type, string codigo_paciente, int aciertos, DateTime fecha, bool completo )
            : base( new _ResPVA( type ), codigo_paciente, fecha, completo )
        {
            init(aciertos, type);
        }

        private void init(int aciertos,PVA_Type type)
        {
 	        this.Aciertos = aciertos;
            this.PVA_Tipo = type;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_PVA )
            {
                var r = (Resultado_PVA)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return this.PVA_Tipo == PVA_Type.PVA_1 ?
                "Pares Visuales Asociados":
                "Pares Visuales Asociados 2";
        }
        protected override void initType()
        {
            this.Tipo = (PVA_Tipo == PVA_Type.PVA_1)?
                ResultType.PVA :
                ResultType.PVA2;
        }

        public override bool Save()
        {
            return
                this.TableResult.Insert( this.Fecha,
                    this.CodigoPaciente,
                    Aciertos,
                    this.Completo );
        }

        #endregion
    }
}



