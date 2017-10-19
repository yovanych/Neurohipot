using System;
using BusinessObjects;

namespace DALayer
{
    public abstract class Resultado
    {
        #region Propiedades
        public ResultType Tipo { get; protected set; }
        public Table TableResult { get; protected set; }
        public string CodigoPaciente { get; set; }
        public DateTime Fecha { get; protected set; }
        public bool Completo { get; protected set; }
        #endregion

        protected Resultado(Table tableResult, string codigo_paciente, DateTime fecha, bool completo)
        {
            this.TableResult = tableResult;
            this.CodigoPaciente = codigo_paciente;
            this.Fecha = fecha;
            this.Completo = completo;
            initType();
        }
        protected abstract void initType();
        public abstract bool Save();
    }
}
