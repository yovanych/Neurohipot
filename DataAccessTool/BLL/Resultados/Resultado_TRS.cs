using System;
using BusinessObjects;

namespace DALayer
{
    public class Resultado_TRS : Resultado
    {
        #region Propiedades
        public int Omisiones { get; set; }
        public double MedFueraDeTiempo { get; set; }
        public double DesvFueraDeTiempo { get; set; }
        public int FueraDeTiempo { get; set; }
        public double MedEnTiempo { get; set; }
        public double DesvEnTiempo { get; set; }
        public int EnTiempo { get; set; }
        public int Anticipadas { get; set; }
        #endregion

        #region Cast
        protected new _ResTRS TableResult
        {
            get { return base.TableResult as _ResTRS; }
        }
        #endregion

        #region Constructores
        public Resultado_TRS( string codigo_paciente,
            int en_tiempo, 
            double media_en_tiempo, 
            double desv_en_tiempo,
            int fuera_tiempo, 
            double media_fuera_tiempo, 
            double desv_fuera_tiempo,
            int omisiones, 
            int anticipadas, 
            DateTime fecha, 
            bool completo ) : base( new _ResTRS(), codigo_paciente, fecha, completo )
        {
            init( en_tiempo, media_en_tiempo, desv_en_tiempo, fuera_tiempo, media_fuera_tiempo, desv_fuera_tiempo,
                omisiones, anticipadas );
        }

        private void init( int en_tiempo, double media_en_tiempo, double desv_en_tiempo, int fuera_tiempo, double media_fuera_tiempo, double desv_fuera_tiempo, int omisiones, int anticipadas )
        {
            this.EnTiempo = en_tiempo;
            this.MedEnTiempo = media_en_tiempo;
            this.DesvEnTiempo = desv_en_tiempo;
            this.FueraDeTiempo = fuera_tiempo;
            this.MedFueraDeTiempo = media_fuera_tiempo;
            this.DesvFueraDeTiempo = desv_fuera_tiempo;
            this.Omisiones = omisiones;
            this.Anticipadas = anticipadas;
        }
        #endregion

        #region Metodos
        #endregion

        #region Override
        public override bool Equals( object obj )
        {
            if ( obj is Resultado_TRS )
            {
                var r = (Resultado_TRS)obj;
                return (r.Fecha.Equals( this.Fecha ));
            }
            return false;
        }
        public override string ToString()
        {
            return "Tiempo se Reacción Simple";
        }
        protected override void initType()
        {
            this.Tipo = ResultType.TRS;
        }

        public override bool Save()
        {
            return
                this.TableResult.Insert( this.Fecha,
                    this.CodigoPaciente,
                    EnTiempo, MedEnTiempo, DesvEnTiempo, FueraDeTiempo, MedFueraDeTiempo, DesvFueraDeTiempo,
                    Omisiones, Anticipadas, 
                    this.Completo );
        }

        #endregion
    }
}




