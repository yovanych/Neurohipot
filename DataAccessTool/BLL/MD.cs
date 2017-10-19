using BusinessObjects;
using DALayer;
using DataAccessTool;

namespace DALayer
{
    public class MD : _MD
    {

    }

    public class MD_ByBlock
    {
        public MD_Node Aciertos { get; private set; }
        public MD_Node Comisiones { get; private set; }
        public MD_Node Omisiones { get; private set; }
        public MD_Node TR { get; private set; }
        public MD_Node DS_TR { get; private set; }
        public MD_Node IA { get; private set; }

        private readonly MD md_bloques;

        public MD_ByBlock()
        {
            this.md_bloques = new MD();
        }

        public void LoadBlock(int block, Paciente p)
        {
            md_bloques.LoadByBlock( p.Sexo, p.Edad, block );
            if(md_bloques.RowCount > 0)
                do
                {
                    switch ( md_bloques.Param )
                    {
                        case "Aciertos":
                            this.Aciertos = new MD_Node {Media = md_bloques.Media, Desviacion = md_bloques.Desviacion};
                            break;
                        case "Omisiones":
                            this.Omisiones = new MD_Node { Media = md_bloques.Media, Desviacion = md_bloques.Desviacion };
                            break;
                        case "Comisiones":
                            this.Comisiones = new MD_Node { Media = md_bloques.Media, Desviacion = md_bloques.Desviacion };
                            break;
                        case "IA":
                            this.IA = new MD_Node { Media = md_bloques.Media, Desviacion = md_bloques.Desviacion };
                            break;
                        case "TR":
                            this.TR = new MD_Node { Media = md_bloques.Media, Desviacion = md_bloques.Desviacion };
                            break;
                        case "DS_TR":
                            this.DS_TR = new MD_Node { Media = md_bloques.Media, Desviacion = md_bloques.Desviacion };
                            break;
                        default:
                            break;
                    }
                } while ( md_bloques.MoveNext() );
        }
    }

    public struct MD_Node
    {
        public double Media { get; set; }
        public double Desviacion { get; set; }
    }
}
