using System.Windows.Forms;
using ReadingXML;

namespace HerrmDiag.UserControls
{
    public partial class TestInformationUC : UserControl
    {
        public TestInformationUC()
        {
            InitializeComponent();
        }

        public void ToPublish(Aplicador ap, string TestCode)
        {
            this.richTextBoxConf.Rtf = ap.XmlInfo.GetInfoToPublish(TestCode, InfoClass.Configuracion);
            this.richTextBoxDesc.Rtf = ap.XmlInfo.GetInfoToPublish( TestCode, InfoClass.Descripcion );
            this.richTextBoxResult.Rtf = ap.XmlInfo.GetInfoToPublish( TestCode, InfoClass.Resultados );
        }
    }
}
