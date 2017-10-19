using System.Collections.Generic;
using System.Windows.Forms;
using BusinessObjects;

namespace GraphicReport
{
    public partial class FormPreview : Form
    {
        public FormPreview()
        {
            InitializeComponent();
            var l = new List<Ar_ChartingResult>
                        {
                            new Ar_ChartingResult( "Bloque 1", 4.555677866, 2, 10),
                            new Ar_ChartingResult( "Bloque 2", 4.555677866, 2, 10),
                            new Ar_ChartingResult( "Bloque 3", 10.555677866, 3 , 15),
                            new Ar_ChartingResult( "Bloque 4", 4.555677866, 2, 12),
                            new Ar_ChartingResult( "Bloque 5", 4.555677866, 2, 15),
                            new Ar_ChartingResult( "Bloque 6", 12.555677866, 2 , 13),
                        };
            
            var chart = new Ar_Chart( ChartReportClass.ERRORES, 600, 400, l );
            this.pictureBox1.Image = chart.ToImage();
        }
    }

}
