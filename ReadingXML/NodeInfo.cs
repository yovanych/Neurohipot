namespace ReadingXML
{
    internal class NodeInfo
    {
        #region Indexer
        public string this[InfoClass cat]
        {
            get
            {
                switch (cat)
                {
                    case InfoClass.Fundamentacion:
                        return this.Fundamentacion;
                    case InfoClass.Descripcion:
                        return this.Descripcion;
                    case InfoClass.Configuracion:
                        return this.Configuracion;
                    case InfoClass.Resultados:
                        return this.Resultados;
                    default:
                        return "";
                }
            }
        }
        #endregion

        #region Propiedades

        public string Nombre { get; set; }
        public string Resultados { get; set; }
        public string Configuracion { get; set; }
        public string Descripcion { get; set; }
        public string Fundamentacion { get; set; }

        #endregion

        public NodeInfo(string nombre, string fundamentacion, string descripcion, string configuracion, string resultados)
        {
            this.Nombre = nombre;
            this.Fundamentacion = fundamentacion;
            this.Descripcion = descripcion;
            this.Configuracion = configuracion;
            this.Resultados = resultados;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
