using System.Drawing;
using System.Windows.Forms;
using DALayer;

namespace PsicoTests.Alejandro
{
    public partial class TimeEstimation : FormWithResultNUtils
    {
        private Estimacion_Tiempo ET;

        public TimeEstimation(string codigoPaciente)
        {
            InitializeComponent();
            ET = new Estimacion_Tiempo(this, codigoPaciente,  2, 1000, 150, 60, 400, 100, Color.White, Color.Red, 32);            
        }

        public TimeEstimation(string codigoPaciente, int maxEstimulos, int intervaloSalida, int anchoEstimulo, int altoEstimulo,
                              int zonaOpaca, int zonaCorrecta, Color colorEstimulo, Color colorZO, int teclaReaccion)
        {
            InitializeComponent();
            ET = new Estimacion_Tiempo(this, codigoPaciente, maxEstimulos, intervaloSalida, anchoEstimulo, altoEstimulo, zonaOpaca, zonaCorrecta, colorEstimulo, colorZO, teclaReaccion);
        }
    }
}