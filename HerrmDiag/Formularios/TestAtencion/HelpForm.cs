using System.Windows.Forms;
using ReadingXML;

namespace HerrmDiag.Formularios.TestAtencion
{
    public partial class HelpForm : Form
    {
        private readonly Aplicador aplicador;
        public HelpForm(Aplicador ap)
        {
            InitializeComponent();
            this.aplicador = ap;
        }

        private void treeView1_AfterSelect( object sender, TreeViewEventArgs e )
        {
            var codeNode = (string)this.tvTopics.SelectedNode.Tag;
            switch ( codeNode )
            {
                case "INT":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.Intro );
                    break;
                case "ADM":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.Admin );
                    break;
                case "ADU":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.AdminUsuarios );
                    break;
                case "ADS":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.AdminSujetos );
                    break;
                case "ADT":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.AdminTAS );
                    break;
                case "EMI":
                    this.rtbInfo.Rtf = aplicador.XmlInfo.GetHelpToPublish( HelpClass.EmisionReporte );
                    break;
            }
            this.rtbInfo.Refresh();
        }

    }
}
