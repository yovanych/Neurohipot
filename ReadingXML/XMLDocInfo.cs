using System.Xml;

namespace ReadingXML
{
    public enum InfoClass { Fundamentacion, Descripcion, Configuracion, Resultados }
    public enum HelpClass { Intro, Admin, AdminUsuarios, AdminSujetos, AdminTAS, EmisionReporte }

    public class XMLDocInformation
    {
        private readonly NodeList<NodeInfo> elementsInfo;
        private readonly NodeList<NodeHelp> elementsHelp;

        public XMLDocInformation( XmlReader stream )
        {
            elementsInfo = new NodeList<NodeInfo>();
            elementsHelp = new NodeList<NodeHelp>();
            var d = new XmlDocument();  
            d.Load(stream);
            //cargado el documento XML

            var codeTest = new[] { "ASS", "ASC", "ASCL", "TRS", "TRC", "RL", "AM", "PVA", "PVA2" };
            elementsInfo = new NodeList<NodeInfo>();
            foreach (string t in codeTest)
            {
                elementsInfo.Add(GetInfo(t, d));
            }
            elementsHelp.Add( GetHelp("HELP", d) );
        }

        public string GetInfoToPublish(string test, InfoClass tipo)
        {
            return test.Equals( string.Empty )? string.Empty : elementsInfo[test][tipo];
        }
        public string GetHelpToPublish( HelpClass tipo )
        {
            return elementsHelp["HELP"][tipo];
        }

        private static string limpiar(string info)
        {
            int begin = info.IndexOf('{');
            if (begin == -1) return info;
            int end = info.LastIndexOf('}');
            int cont = info.Length - end;
            string result = info.Remove(0, begin);
            end = result.LastIndexOf('}');
            result = result.Remove(end + 1, cont-1);
            return result;
        }

        private static NodeInfo GetInfo(string code, XmlDocument doc)
        {
            XmlNodeList lista = doc.GetElementsByTagName(code);
            XmlNodeList info = lista[0].ChildNodes;
            string descripcion = limpiar(info[0].InnerText);
            string fundamentacion = limpiar(info[1].InnerText);
            string configuracion = limpiar(info[2].InnerText);
            string resultados = limpiar(info[3].InnerText);
            var node = new NodeInfo(code, fundamentacion, descripcion, configuracion, resultados);
            return node;
        }
        private static NodeHelp GetHelp( string code, XmlDocument doc )
        {
            XmlNodeList lista = doc.GetElementsByTagName( code );
            XmlNodeList info = lista[0].ChildNodes;
            string Intro = limpiar( info[0].InnerText );
            string Administracion = limpiar( info[1].InnerText );
            string AdminUsuarios = limpiar( info[2].InnerText );
            string AdminSujetos = limpiar( info[3].InnerText );
            string AdminTas = limpiar( info[4].InnerText );
            string EmitirReporte = limpiar( info[5].InnerText );
            var node = new NodeHelp( code, Intro, Administracion, AdminUsuarios, AdminSujetos, AdminTas, EmitirReporte);
            return node;
        }
    }
}
