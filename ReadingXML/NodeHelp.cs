namespace ReadingXML
{
    internal class NodeHelp
    {
        #region Indexer
        public string this[HelpClass cat]
        {
            get
            {
                switch ( cat )
                {
                    case HelpClass.Intro:
                        return this.Introduccion;
                    case HelpClass.Admin:
                        return this.Adminsitracion;
                    case HelpClass.AdminUsuarios:
                        return this.Admin_Usuarios;
                    case HelpClass.AdminSujetos:
                        return this.Admin_Sujetos;
                    case HelpClass.AdminTAS:
                        return this.Admin_TAS;
                    case HelpClass.EmisionReporte:
                        return this.Emitir_Reporte;
                    default:
                        return "";
                }
            }
        }
        #endregion

        #region Propiedades

        public string Nombre { get; set; }
        public string Introduccion { get; set; }
        public string Adminsitracion { get; set; }
        public string Admin_Usuarios { get; set; }
        public string Admin_Sujetos { get; set; }
        public string Admin_TAS { get; set; }
        public string Emitir_Reporte { get; set; }

        #endregion

        public NodeHelp( string nombre, string Intro, string admin, string admin_user, string admin_suj, string admin_tas, string emitir )
        {
            this.Nombre = nombre;
            this.Introduccion = Intro;
            this.Adminsitracion = admin;
            this.Admin_Usuarios = admin_user;
            this.Admin_Sujetos = admin_suj;
            this.Admin_TAS = admin_tas;
            this.Emitir_Reporte = emitir;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
