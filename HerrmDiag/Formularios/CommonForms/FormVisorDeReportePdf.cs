using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class FormVisorDeReportePdf : Form
    {
        public FormVisorDeReportePdf(string filename)
        {
            InitializeComponent();
            axAcroPDF2.LoadFile(filename);
        }

        private void FormVisorDeReportePdf_Load(object sender, EventArgs e)
        {

        }

        private void axAcroPDF1_OnError(object sender, EventArgs e)
        {

        }
    }
}
