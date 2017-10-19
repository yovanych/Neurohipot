using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using HerrmDiag.Formularios.CommonForms;
using HerrmDiag.Properties;
using HerrmDiag.UserControls;
using PsicoTests.Yovany;
using PsicoTests.Alejandro;

namespace HerrmDiag.BEN
{
    public partial class MainForm : Form
    {
        #region Variables Internas
        
        private readonly Aplicador ap;
        readonly SplashVinci sp;
        private readonly Point configDefaultLocation;
        private readonly int configWidth;
        
        #region Controles

        private ConfMemoriaFigurasUC conf_MF;
        private ConfParesVisualesAsociadosUC conf_PVA;
        private ConfAmplitudMemoriaUC conf_AM;
        private ConfRecuerdoLibreUC conf_RL;
        private ConfTRSimpleUC conf_TRS;
        private ConfTRComplejaUC conf_TRC;
        private ConfEstimacionTiempoUC conf_ET;
        private ConfASSLetrasColoresUC conf_ASS;
        
        private Label labelPrueba;
        private Label labelPaciente;
        
        #endregion
        #endregion

        public MainForm()
        {
            sp = new SplashVinci();
            InitializeComponent();                 
            this.comboBoxPrueba.SelectedIndex = 0;
            this.configDefaultLocation = new Point( 11, 24 );
            this.configWidth = 300;

            timer1.Start();

            try
            {
                ap = new Aplicador();
                Cargar_Pacientes();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        #region Coponentes de Configuracion

        private void Configuracion_Memoria_Figuras()
        {
            groupBoxConf.Controls.Clear();

            if ( this.conf_MF == null )
            {
                conf_MF = new ConfMemoriaFigurasUC
                              {
                                  Location = configDefaultLocation,
                                  ShowCancelButton = false,
                                  Configuracion = ap.Configuracion,
                                  Width = configWidth
                              };
            }
            this.groupBoxConf.Controls.Add( conf_MF );
        }

        private void Configuracion_Pares_Visuales()
        {
            groupBoxConf.Controls.Clear();

            if ( this.conf_PVA == null )
            {
                conf_PVA = new ConfParesVisualesAsociadosUC
                               {
                                   Location = configDefaultLocation,
                                   ShowCancelButton = false,
                                   Configuracion = ap.Configuracion,
                                   Width = configWidth
                               };
            }
            this.groupBoxConf.Controls.Add( conf_PVA );
        }

        private void Configuracion_Amplitud_Memoria()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_AM == null)
            {
                conf_AM = new ConfAmplitudMemoriaUC
                            {
                                Location = configDefaultLocation,
                                ShowCancelButton = false,
                                Configuracion = ap.Configuracion,
                                Width = configWidth
                            };
            }
            this.groupBoxConf.Controls.Add(conf_AM);
        }

        private void Configuracion_Aprendisaje_Palabras()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_RL == null)
            {
                conf_RL = new ConfRecuerdoLibreUC
                            {
                                Location = configDefaultLocation,
                                ShowCancelButton = false,
                                Configuracion = ap.Configuracion,
                                Width = configWidth
                            };
            }
            this.groupBoxConf.Controls.Add(conf_RL);
        }

        private void Configuracion_Atencion_Sostenida_Simple_Colores()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_ASS == null)
            {
                conf_ASS = new ConfASSLetrasColoresUC
                {
                    Location = configDefaultLocation,
                    ShowCancelButton = false,
                    Configuracion = ap.Configuracion,
                    Width = configWidth
                };
            }
            this.groupBoxConf.Controls.Add(conf_ASS);
        }

        private void Configuracion_Tiempo_Reaccion_Compleja()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_TRC == null)
            {
                conf_TRC = new ConfTRComplejaUC
                {
                    Location = configDefaultLocation,
                    ShowCancelButton = false,
                    Configuracion = ap.Configuracion,
                    Width = configWidth
                };
            }
            this.groupBoxConf.Controls.Add(conf_TRC);
        }

        private void Configuracion_Tiempo_Reaccion_Simple()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_TRS == null)
            {
                conf_TRS = new ConfTRSimpleUC
                {
                    Location = configDefaultLocation,
                    ShowCancelButton = false,
                    Configuracion = ap.Configuracion,
                    Width = configWidth
                };
            }
            this.groupBoxConf.Controls.Add(conf_TRS);
        }
        
        private void Configuracion_Estimacion_Tiempo()
        {
            groupBoxConf.Controls.Clear();

            if (this.conf_ET == null)
            {
                conf_ET = new ConfEstimacionTiempoUC
                {
                    Location = configDefaultLocation,
                    ShowCancelButton = false,
                    Configuracion = ap.Configuracion,
                    Width = configWidth
                };
            }
            this.groupBoxConf.Controls.Add(conf_ET);
        }

        #endregion

        #region Manejadores de Eventos
        #region Menu Principal
        private void toolStripCambiarPass_Click(object sender, EventArgs e)
        {
            var c = new CambiarPass(this.ap);
            c.ShowDialog(this);
        }
        #endregion

        #region Sesion
        private void iniciarSesionToolStripMenuItem_Click( object sender, EventArgs e )
        {

            var a = new Autent_User( ap );
            a.ShowDialog( this );

            if ( this.ap.User != null )
            {
                this.tabControl2.Visible = true;
                this.comboBoxPaciente.Enabled = true;
                this.comboBoxPrueba.Enabled = true;
                this.iniciarSesionToolStripMenuItem.Enabled = false;
                this.cerrarSesiónToolStripMenuItem.Enabled = true;
                this.toolStripButtonInicio.Enabled = false;
                this.toolStripButtonCerrar.Enabled = true;
                this.toolStripButtonExportar.Enabled = true;
                this.toolStripCambiarPass.Enabled = true;
                this.adminPacientesUC1.Aplicador = this.ap;
                this.adminUsersUC1.Aplicador = this.ap;
            }

        }
        private void cerrarSesiónToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.tabControl2.Visible = false;
            this.comboBoxPaciente.Enabled = true;
            this.comboBoxPrueba.Enabled = true;
            this.iniciarSesionToolStripMenuItem.Enabled = true;
            this.cerrarSesiónToolStripMenuItem.Enabled = false;
            this.groupBoxConf.Controls.Clear();
            this.comboBoxPaciente.Enabled = false;
            this.comboBoxPrueba.Enabled = false;

            this.toolStripButtonInicio.Enabled = true;
            this.toolStripButtonCerrar.Enabled = false;
            this.toolStripButtonExportar.Enabled = false;
            this.toolStripCambiarPass.Enabled = false;

            ap.Cerrar_Sesion();
        }
        private void MainForm_FormClosing( object sender, FormClosingEventArgs e )
        {
            ap.Cerrar_Vista_Previa();
            ap.Cerrar_Sesion();
        }
        #endregion

        #region Botones
        private void buttonEjecutar_Click( object sender, EventArgs e )
        {
            #region Se debe seleccionar una prueba y un paciente
            if ( comboBoxPrueba.SelectedItem == null )
            {
                var r = new Resp( Resources.MSG_Select_Test );
                r.ShowDialog( this );
                return;
            }
            if ( comboBoxPaciente.SelectedItem == null )
            {
                var r = new Resp( Resources.MSG_Select_Patient );
                r.ShowDialog( this );
                return;
            }
            #endregion

            if ( ap.Paciente != null )
            {
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_MF )
                {
                    var f = new MF_Form(this.ap.Configuracion.Imagenes_MF,
                        ap.Configuracion.Presentacion_MF, 
                        ap.Configuracion.Muestra_MF,
                        ap.Configuracion.Descanso_MF,
                        this.ap.Paciente.Codigo);
                    f.ShowDialog(this);
                    this.ap.Adicionar_Resultado(f.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, f.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_PVA ||
                     this.comboBoxPrueba.Text == Resources.ComboValue_PVA2 )
                {
                    var tipo = this.comboBoxPrueba.Text == Resources.ComboValue_PVA
                                   ? PVA_Type.PVA_1
                                   : PVA_Type.PVA_2;

                    var f = new PVA_Form(tipo, ap.Paciente.Codigo,
                        ap.Configuracion.Presentacion_PVA,
                        ap.Configuracion.Muestra_PVA,
                        ap.Configuracion.Descanso_PVA,
                        ap.Configuracion.Colores_PVA,
                        ap.Configuracion.Imagenes_PVA);
                    f.ShowDialog(this);
                    this.ap.Adicionar_Resultado(f.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, f.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_AM )
                {
                    var n = new NumScreen(ap.Configuracion.Exp_Digito_AM, 
                        ap.Paciente.Codigo,
                        ap.Configuracion.Intervalo_AM,
                        ap.Configuracion.Reaccion_AM);
                    n.ShowDialog(this);
                    this.ap.Adicionar_Resultado(n.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, n.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_ASS_Colores )
                {
                    int tecla_reaccion = this.ap.Configuracion.TeclaTarget_CASS_L == Resources.KeyName_Enter ? 13 : 32;
                    var f2 = new PsicoTests.Yovany.ASS.Colores.FormASSL(this.ap.Paciente.Codigo, 
                        this.ap.Configuracion.Letras_CASS_L[this.ap.Configuracion.Letra_Diana_CASS_L].ToString(),
                        this.ap.Configuracion.Color_LetraDiana_CASS_L, 
                        this.ap.Configuracion.Bloques_CASS_L, 
                        this.ap.Configuracion.EstimulosBloques_CASS_L, 
                        this.ap.Configuracion.TiempoVisualizacion_CASS_L, 
                        this.ap.Configuracion.TiempoOcultamiento_CASS_L,
                        tecla_reaccion);
                    f2.ShowDialog(this);
                    this.ap.Adicionar_Resultado(f2.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, f2.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_TRC )
                {
                    int tecla_reaccion1 = ap.Configuracion.Tecla1_TRC == Resources.KeyName_Enter ? 13 : 32;
                    int tecla_reaccion2 = ap.Configuracion.Tecla2_TRC == Resources.KeyName_Enter ? 13 : 32;
                    var f = new FormTR(this.ap.Paciente.Codigo,
                        ap.Configuracion.Color1_TRC, 
                        ap.Configuracion.Color2_TRC, 
                        ap.Configuracion.MaxEstimulos_TRC, 
                        ap.Configuracion.TiempoVisualizacion_TRC, 
                        ap.Configuracion.TiempoReaccion_TRC, 
                        tecla_reaccion1, 
                        tecla_reaccion2, 
                        ap.Configuracion.Figura_TRC);
                    f.ShowDialog(this);
                    this.ap.Adicionar_Resultado(f.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, f.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_TRS )
                {
                    int tecla_reaccion = ap.Configuracion.Tecla1_TRS == Resources.KeyName_Enter ? 13 : 32;
                    var f = new FormTRS(this.ap.Paciente.Codigo,
                        tecla_reaccion,
                        ap.Configuracion.Color1_TRS,
                        ap.Configuracion.MaxEstimulos_TRS,
                        ap.Configuracion.TiempoVisualizacion_TRS,
                        ap.Configuracion.TiempoReaccion_TRS,
                        ap.Configuracion.Figura_TRS);
                    f.ShowDialog(this);
                    this.ap.Adicionar_Resultado(f.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var r = new Reporte(ap.Paciente, f.Resultado);
                    //    r.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.ComboValue_RL )
                {
                    var r = new Recuerdo(this.ap.Paciente.Codigo,
                        ap.Configuracion.TiempoVisualizacion1_RL, 
                        ap.Configuracion.TiempoOcultamiento1_RL, 
                        ap.Configuracion.TiempoVisualizacion15_RL,
                        ap.Configuracion.TiempoVisualizacion2_RL, 
                        ap.Configuracion.TiempoOcultamiento2_RL);
                    r.ShowDialog(this);
                    this.ap.Adicionar_Resultado(r.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var rep = new Reporte(ap.Paciente, r.Resultado);
                    //    rep.ShowDialog(this);
                    //}
                    return;
                }
                if ( this.comboBoxPrueba.Text == Resources.Combovalue_EM )
                {
                    var t = new TimeEstimation(this.ap.Paciente.Codigo,
                        ap.Configuracion.MaxEstimulos_ET,
                        ap.Configuracion.IntervaloSalida_ET,
                        ap.Configuracion.AnchoEstimulo_ET,
                        ap.Configuracion.AltoEstimulo_ET,
                        ap.Configuracion.ZonaOpaca_ET,
                        ap.Configuracion.AreaCorrecta_ET,
                        ap.Configuracion.Estimulo_ET,
                        ap.Configuracion.ColorZonaOpaca_ET, 
                        ap.Configuracion.TeclaReaccion_ET);
                    t.ShowDialog(this);
                    this.ap.Adicionar_Resultado(t.Resultado);
                    //if (this.checkBoxMostrarResultado.Checked)
                    //{
                    //    var rep = new Reporte(ap.Paciente, t.r);
                    //    rep.ShowDialog(this);
                    //}
                }
            }
        }
        private void buttonEnsayo_Click( object sender, EventArgs e )
        {
            if ( this.comboBoxPrueba.Text == Resources.ComboValue_MF )
            {
                //FullScreenBlack f = new FullScreenBlack("E_MF");
                //f.ShowDialog(this);
                //return;
            }
            if ( this.comboBoxPrueba.Text == Resources.ComboValue_ASS )
            {
                //int bloques = (int)this.numericUpDown1.Value;
                //int estimulos = (int)this.numericUpDown2.Value;
                //int visualizacion = (int)this.numericUpDown3.Value;
                //int ocultamiento = (int)this.numericUpDown4.Value;
                //int tecla_reaccion = 0;
                //if (this.comboBox1.Text == Resources.KeyName_Enter) tecla_reaccion = 13;
                //else tecla_reaccion = 32;
                //Form2 f2 = new Form2(this.textBox1.Text, this.panelColor2.BackColor, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion);
                //f2.ShowDialog(this);
                //return;
            }
            if ( this.comboBoxPrueba.Text == Resources.ComboValue_PVA )
            {
                //FullScreenBlack f = new FullScreenBlack("E_PVA");
                //f.ShowDialog(this);
                //return;
            }
        }
        #endregion

        #region Combos
        private void comboBoxPrueba_SelectedIndexChanged( object sender, EventArgs e )
        {
            this.panelPreView.BackColor = Color.DimGray;
            if ( !this.comboBoxPrueba.Enabled ) return;

            #region Cerrar vista previa
            try
            {
                this.ap.Cerrar_Vista_Previa();
            }
            catch ( Exception )
            {
                MessageBox.Show( Resources.MSG_Error_ClosingPreview );
                return;
            }
            #endregion

            string codigo = string.Empty;

            if ( this.comboBoxPrueba.Text == Resources.ComboValue_MF )
            {
                codigo = string.Empty;// Resources.TESTCODE_MF;
                Configuracion_Memoria_Figuras();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_MF( this.panelPreView, ap.Configuracion.Imagenes_MF );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_PVA 
                || this.comboBoxPrueba.Text == Resources.ComboValue_PVA2 )
            {
                codigo = this.comboBoxPrueba.Text == Resources.ComboValue_PVA
                             ? Resources.TESTCODE_PVA1
                             : Resources.TESTCODE_PVA2;
                Configuracion_Pares_Visuales();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_PVA( this.panelPreView,
                        ap.Configuracion.Colores_PVA,
                        ap.Configuracion.Imagenes_PVA );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_AM )
            {
                codigo = Resources.TESTCODE_AM;
                Configuracion_Amplitud_Memoria();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_AM( this.panelPreView );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_RL )
            {
                codigo = Resources.TESTCODE_RL;
                Configuracion_Aprendisaje_Palabras();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_AP( this.panelPreView );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_ASS_Colores )
            {
                codigo = Resources.TESTCODE_ASS;
                Configuracion_Atencion_Sostenida_Simple_Colores();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_ASS_Letras_Colores( this.panelPreView );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_TRC )
            {
                codigo = Resources.TESTCODE_TRC;
                Configuracion_Tiempo_Reaccion_Compleja();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_TR_Compleja( this.panelPreView );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.ComboValue_TRS )
            {
                codigo = Resources.TESTCODE_TRS;
                Configuracion_Tiempo_Reaccion_Simple();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_TRS( this.panelPreView );
                }
            }
            else if ( this.comboBoxPrueba.Text == Resources.Combovalue_EM )
            {
                codigo = string.Empty;//Resources.TESTCODE_EM;
                Configuracion_Estimacion_Tiempo();
                if ( this.checkBox1.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    ap.Vsita_Previa_ET( this.panelPreView,
                        ap.Configuracion.IntervaloSalida_ET,
                        ap.Configuracion.AnchoEstimulo_ET,
                        ap.Configuracion.AltoEstimulo_ET,
                        ap.Configuracion.ZonaOpaca_ET,
                        ap.Configuracion.AreaCorrecta_ET,
                        ap.Configuracion.Estimulo_ET,
                        ap.Configuracion.ColorZonaOpaca_ET );
                }
            }

            this.testInformationUC1.ToPublish( this.ap, codigo );
        }
        private void comboBoxPaciente_SelectedIndexChanged( object sender, EventArgs e )
        {
            if ( this.comboBoxPaciente.Text != "" )
            {
                ap.Seleccionar_Paciente( this.comboBoxPaciente.Text );
            }
        }
        #endregion

        #region CheckBoxes
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxConf.Visible = this.checkBoxConf.Checked;
        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ap.VistaPrevia != null)
            {
                if (this.checkBox1.Checked)
                {
                    if (this.comboBoxPrueba.Text == Resources.ComboValue_MF)
                    {
                        ap.Vsita_Previa_MF(this.panelPreView, ap.Configuracion.Imagenes_MF);
                        return;
                    }
                    if (this.comboBoxPrueba.Text == Resources.ComboValue_PVA)
                    {
                        ap.Vsita_Previa_PVA(this.panelPreView, ap.Configuracion.Colores_PVA, ap.Configuracion.Imagenes_PVA);
                        return;
                    }
                    if (this.comboBoxPrueba.Text == Resources.ComboValue_AM)
                    {
                        ap.Vsita_Previa_AM(this.panelPreView);
                        return;
                    }
                    if (this.comboBoxPrueba.Text == Resources.ComboValue_RL)
                    {
                        ap.Vsita_Previa_AP(this.panelPreView);
                        return;
                    }
                    if (this.comboBoxPrueba.Text == Resources.ComboValue_ASS)
                    {
                        ap.Vsita_Previa_ASS(this.panelPreView);
                        return;
                    }
                    if (this.comboBoxPrueba.Text == Resources.Combovalue_EM)
                    {
                        this.panelPreView.Controls.Clear();
                        ap.Vsita_Previa_ET(this.panelPreView, 
                            ap.Configuracion.IntervaloSalida_ET, 
                            ap.Configuracion.AnchoEstimulo_ET,
                            ap.Configuracion.AltoEstimulo_ET,
                            ap.Configuracion.ZonaOpaca_ET,
                            ap.Configuracion.AreaCorrecta_ET,
                            ap.Configuracion.Estimulo_ET,
                            ap.Configuracion.ColorZonaOpaca_ET);
                    }
                }
                else
                    ap.Cerrar_Vista_Previa();
            }
        }
        #endregion

        #region Otros
        private void timer1_Tick( object sender, EventArgs e )
        {
            if ( this.sp.Visible )
            {
                sp.Close();
                sp.Dispose();
                this.timer1.Stop();
            }
            else
            {
                sp.Show( this );
                timer1.Interval = 3000;
            }
        }
        #endregion
        #endregion

        private void Cargar_Pacientes()
        {
            this.comboBoxPaciente.Items.Clear();
            List<string> lista = ap.Lista_CodigoPacientes();
            foreach ( string s in lista )
                this.comboBoxPaciente.Items.Add( s );
            this.comboBoxPaciente.Text = "";
        }
        
    }
}