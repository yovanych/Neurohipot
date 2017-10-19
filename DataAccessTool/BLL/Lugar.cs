using System.Collections.Generic;

namespace DALayer
{
    public class Lugar : _Lugar
    {
        #region Constructores

        public Lugar()
        { }
        public Lugar( int id_lugar, string lugar, string descripcion )
        {
            this.Id_Lugar = id_lugar;
            this.Lugar = lugar;
            this.Descripcion = descripcion;
        }

        #endregion

        #region Metodos

        public bool Existe_Aplicador( string nombre )
        {
            return this.LoadByName( nombre ) > 0;
        }
        public List<Lugar> Lista_Lugares()
        {
            var list_ap = new List<Lugar>();
            this.loadAll();
            if ( this.RowCount > 0 )
                do
                {
                    list_ap.Add( (Lugar)this.MemberwiseClone() );
                } while ( this.MoveNext() );
            return list_ap;
        }
        #endregion
    }
}
