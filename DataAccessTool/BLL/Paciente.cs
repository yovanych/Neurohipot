using System;
using System.Collections.Generic;
using BusinessObjects;

namespace DALayer
{
    public class Paciente :_Paciente
    {
        public List<Resultado> Resultados
        {
            get
            {
                var list = new List<Resultado>();

                #region ASS
                var rass = new _ResASS();
                rass.LoadByPaciente( this.Codigo );
                if ( rass.RowCount > 0 )
                    do
                    {
                        list.Add( new Resultado_ASS( this.Codigo, rass.Fecha, rass.Completo, rass, rass.TipoPrueba ) );
                    } while ( rass.MoveNext() );
                #endregion

                #region ASC
                var rasc = new _ResASC();
                rasc.LoadByPaciente( this.Codigo );
                if ( rasc.RowCount > 0 )
                    do
                    {
                        list.Add( new Resultado_ASC( this.Codigo, rasc.Fecha, rasc.Completo, rasc, rasc.TipoPrueba ) );
                    } while ( rasc.MoveNext() );
                #endregion

                return list;
            }
        }

        #region Constructores

        public Paciente()
        {}
        public Paciente( string nombre, string primer_apellido, string segundo_apellido, Sexo sexo, DateTime fecha_nacimiento, string direccion, string nivel, string aplicador, string lugar, string codigo )
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Apellido1 = primer_apellido;
            this.Apellido2 = segundo_apellido;
            this.sexo = (sexo == Sexo.Masculino)? "M":"F";
            this.Fecha_Nacimiento = fecha_nacimiento;
            this.Direccion = direccion;
            this.Escolaridad = nivel;
            this.Aplicador = aplicador;
            this.Lugar = lugar;
        }
        public Paciente( string nombre, string primer_apellido, string segundo_apellido, Sexo sexo, DateTime fecha_nacimiento, string nivel, string aplicador, string lugar, string codigo )
            :this(nombre, primer_apellido, segundo_apellido, sexo, fecha_nacimiento, "", nivel, aplicador, lugar, codigo)
        {}
        
        #endregion

        #region Metodos
        public void Adiciona_Resultado( Resultado r )
        {
            throw new NotImplementedException();
        }

        public bool Existe_Paciente( string codigo )
        {
            return this.LoadByID( codigo ) > 0;
        }
        public List<Paciente> Lista_Pacientes()
        {
            var list_pac = new List<Paciente>();
            if(this.RowCount > 0)
                do
                {
                    list_pac.Add( (Paciente)this.MemberwiseClone());
                } while ( this.MoveNext() );
            return list_pac;
        }
        public List<string> Lista_Codigos_Pacientes()
        {
            var list = new List<string>();
            this.loadAll();
            if (this.RowCount > 0)
                do
                {
                    list.Add(this.Codigo);
                } while (this.MoveNext());
            return list;
        }
        #endregion
    }
}
