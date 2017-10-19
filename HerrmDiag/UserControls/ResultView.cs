using System;
using System.Linq;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using HerrmDiag.Properties;

namespace HerrmDiag.UserControls
{
    public partial class ResultView : UserControl
    {
        public ResultView()
        {
            InitializeComponent();
        }

        public Resultado Result 
        {
            set
            {
                if ( value == null )
                    this.panel.Visible = true;
                else
                {
                    this.panel.Visible = false;
                    Init( value );
                }
            }
        }

        private void Init( Resultado r )
        {
            var result = (Resultado_AS) r;
            switch ( result.TipoPrueba )
            {
                case TypeOf_AS_Test.H_Imagenes:
                    this.lTipoEstimulo.Text = Resources.AS_ResultView_Homogénea_Imágenes;
                    break;
                case TypeOf_AS_Test.H_Figuras_Abstractas:
                    this.lTipoEstimulo.Text = Resources.AS_ResultView_Homogenea_Figuras;
                    break;
                case TypeOf_AS_Test.H_Letras:
                    this.lTipoEstimulo.Text = Resources.AS_ResultView_Homognea_Letras;
                    break;
                case TypeOf_AS_Test.C_Imagenes:
                    this.lTipoEstimulo.Text = Resources.AS_ResultView_Colores_Imagenes;
                    break;
                case TypeOf_AS_Test.C_Letras:
                    this.lTipoEstimulo.Text = Resources.AS_ResultView_Colores_Letras;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            this.lTipoPrueba.Text = result.ToString();
            this.lcompleto.Text = string.Format("{0} ({1})", r.Fecha.ToShortDateString(), (r.Completo)?"Completo":"Incompleto");
            this.tbMedia.Text = result.Media.ToString();
            this.tbDesviacion.Text = result.Desviacion.ToString();
            var p = new Paciente();
            p.LoadByID( r.CodigoPaciente );
            this.lPaciente.Text = string.Format( "{0} {1} ({2})", p.Nombre, p.Apellido1, p.Edad );
            this.dgvResultados.Rows.Clear();
            for ( int i = 0; i < result.Aciertos.Count(); i++ )
            {
                this.dgvResultados.Rows.Add( i + 1, 
                                             result.Aciertos[i], 
                                             result.Aciertos_Extrannos[i],
                                             result.Equivocaciones[i], 
                                             result.Omisiones[i] );
                this.dgvTiempos.Rows.Add( i + 1, result.MediasTR[i], result.DesiacionesTR[i] );
            }
        }
    }
}
