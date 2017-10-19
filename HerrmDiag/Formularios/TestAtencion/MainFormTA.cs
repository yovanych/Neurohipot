using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BusinessObjects;
using DALayer;
using ExcelReportTool;
using HerrmDiag.Formularios.CommonForms;
using HerrmDiag.Formularios.TestAtencion;
using HerrmDiag.Properties;
using PsicoTests.Yovany.ASC.Homogeneas;
using PsicoTests.Yovany.ASS.Homogeneas;

namespace HerrmDiag.TestAtencion
{
    public partial class MainFormTA : Form
    {
        #region Variables Locales
        FormPacientes f_pacientes;
        readonly FormUsuarios f_usuarios;
        private readonly Aplicador ap;
        #endregion
        
        public MainFormTA(Aplicador ap)
        {
            InitializeComponent();
            this.ap = ap;
            f_usuarios = new FormUsuarios(this.ap);
            if (ap.User.Categoria == Categoria_Usuario.Aplicador)
                this.administradorDeUsuariosToolStripMenuItem.Enabled = false;
            Cargar_Pacientes();            
        }

        #region Metodos Privados
        //TEST POR EDADES
        private bool CorrectTestForAge()
        {
            int edad = this.ap.Paciente.Edad;
            if (edad == FunctionLibrary.AgeFirstLevel)
                return this.ap.Configuracion.Estimulo_ASC == 0 && this.comboBoxTest.Text == Resources.ComboValue_ASC;
            if (FunctionLibrary.InRange(edad, FunctionLibrary.AgeMinSecondLevel, FunctionLibrary.AgeMaxSecondLevel))
                return this.comboBoxTest.Text == Resources.ComboValue_ASC_L;
            return false;
        }

        private void Cargar_Pacientes()
        {
            this.comboBoxPaciente.Items.Clear();
            List<string> lista = ap.Lista_CodigoPacientes();
            foreach (string s in lista)
                this.comboBoxPaciente.Items.Add(s);
            this.comboBoxPaciente.Text = "";
        }

        private void publicar(string p)
        {
            this.testInformationUC1.ToPublish(this.ap, p);
        }
        private static string InitialDirectory()
        {
            CultureInfo cult = Application.CurrentCulture;
            switch (cult.Name)
            {
                case "en-US":
                    return "Desktop";
                case "es-ES":
                    return "Escritorio";
                default:
                    return string.Empty;
            }
        }
        #endregion

        #region Eventos
        #region Otros
        private void administradorDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_pacientes = new FormPacientes(this.ap, this.comboBoxPaciente);
            f_pacientes.ShowDialog(this);            
        }
        private void administradorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_usuarios.ShowDialog(this);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerrarSesiónToolStripMenuItem_Click();
        }
        private void checkBoxVistaPrevia_CheckedChanged(object sender, EventArgs e)
        {
            if (ap.VistaPrevia != null)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    comboBoxTest_SelectedIndexChanged(null, null);
                }
                else
                    ap.Cerrar_Vista_Previa();
            }
        }
        //private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (this.ap.Paciente == null)
        //    {
        //        var r = new Resp(Resources.MSG_Select_Patient);
        //        r.ShowDialog(this);
        //        return;
        //    }
        //    var rep = new Reporte(ap.Paciente);
        //    rep.ShowDialog(this);
        //}
        #endregion

        #region Botones
        private void buttonConf_Click(object sender, EventArgs e)
        {            
            //if(this.comboBoxTest.Text == "Memoria de Figuras")
            //{
            //    FormConfMemoriaDeFiguras fc_MF = new FormConfMemoriaDeFiguras(this.ap.Configuracion);
            //    fc_MF.ShowDialog(this);
            //}else if(this.comboBoxTest.Text == "Pares Visuales Asociados" || this.comboBoxTest.Text == "Pares Visuales Asociados (2)")
            //{
            //    FormConfParesVisualesAsociados fc_PVA = new FormConfParesVisualesAsociados(this.ap.Configuracion);
            //    fc_PVA.ShowDialog(this);
            //} else
            if (this.comboBoxTest.Text == Resources.ComboValue_ASS)
            {
                var fc_ASS = new FormConfAtencionSostenidaSimple(this.ap.Configuracion);
                fc_ASS.ShowDialog(this);
                //this.ap.Configuracion.SeCuentaConNormas( this.ap.Paciente.Edad, ResultType.ASS );
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_ASC)
            {
                var fc_ASC = new FormConfAtencionSostenidaCompleja(this.ap.Configuracion);
                fc_ASC.ShowDialog(this);
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_ASS_L)
            {
                var fc_ASSL = new FormConfAtencionSostenidaSimpleLetras(this.ap.Configuracion);
                fc_ASSL.ShowDialog(this);
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_ASC_L)
            {
                var fc_ASCL = new FormConfAtencionSostenidaComplejaLetras(this.ap.Configuracion);
                fc_ASCL.ShowDialog(this);
            }
            //else if (this.comboBoxTest.Text == "Tiempo de Reacción 1")
            //{
            //    Formularios.FormConfTiempoReaccionSimple fc_TRS = new Formularios.FormConfTiempoReaccionSimple(this.ap.Configuracion);
            //    fc_TRS.ShowDialog(this);
            //}
            //else if (this.comboBoxTest.Text == "Tiempo de Reacción 2")
            //{
            //    Formularios.FormConfTiempoReaccionCompleja fc_TRC = new Formularios.FormConfTiempoReaccionCompleja(this.ap.Configuracion);
            //    fc_TRC.ShowDialog(this);
            //}
            //else if (this.comboBoxTest.Text == "Aprendizaje de Palabras")
            //{
            //    Formularios.FormConfRecuerdoLibre fc_RL = new Formularios.FormConfRecuerdoLibre(this.ap.Configuracion);
            //    fc_RL.ShowDialog(this);
            //}
            comboBoxTest_SelectedIndexChanged(null, null);
        }
        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            if ( comboBoxPaciente.SelectedItem == null )
            {
                var r = new Resp( Resources.MSG_Select_Patient );
                r.ShowDialog( this );
                return;
            }
            if (comboBoxTest.SelectedItem == null)
            {
                var r = new Resp(Resources.MSG_Select_Test);
                r.ShowDialog(this);
                return;
            }
            if (ap.Paciente != null)
            {
                #region OTHERS tests
                //if (this.comboBoxTest.Text == Resources.ComboValue_MF)
                //{
                //    int presentacion = (int)this.numericUpDown1.Value;
                //    int muestra = (int)this.numericUpDown2.Value;
                //    FullScreenBlack f = new FullScreenBlack(presentacion, muestra);
                //    f.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(f.Resultado);
                //    if (this.checkBoxMostrarResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, f.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_PVA)
                //{
                //    //FullScreenBlack f = new FullScreenBlack(p, "PVA");
                //    int presentacion = this.ap.Configuracion.Presentacion_PVA;
                //    int muestra = this.ap.Configuracion.Muestra_PVA;
                //    int descanso = this.ap.Configuracion.Descanso_PVA;
                //    Color[] colores = new Color[]{this.ap.Configuracion.Colores_PVA[0],
                //                                  this.ap.Configuracion.Colores_PVA[1],
                //                                  this.ap.Configuracion.Colores_PVA[2],
                //                                  this.ap.Configuracion.Colores_PVA[3],
                //                                  this.ap.Configuracion.Colores_PVA[4],
                //                                  this.ap.Configuracion.Colores_PVA[5]};
                //    FullScreenBlack f = new FullScreenBlack(presentacion, muestra, descanso, colores, false, this.ap.Configuracion.Imagenes_PVA);
                //    f.ShowDialog(this);
                //    if (f.Resultado == null) return;
                //    this.ap.Adicionar_Resultado(f.Resultado);
                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, f.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_PVA2)
                //{
                //    //FullScreenBlack f = new FullScreenBlack(p, "PVA");
                //    int presentacion = this.ap.Configuracion.Presentacion_PVA;
                //    int muestra = this.ap.Configuracion.Muestra_PVA;
                //    int descanso = this.ap.Configuracion.Descanso_PVA;
                //    Color[] colores = new Color[]{this.ap.Configuracion.Colores_PVA[0],
                //                                  this.ap.Configuracion.Colores_PVA[1],
                //                                  this.ap.Configuracion.Colores_PVA[2],
                //                                  this.ap.Configuracion.Colores_PVA[3],
                //                                  this.ap.Configuracion.Colores_PVA[4],
                //                                  this.ap.Configuracion.Colores_PVA[5]};
                //    FullScreenBlack f = new FullScreenBlack(presentacion, muestra, descanso, colores, true, this.ap.Configuracion.Imagenes_PVA);
                //    f.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(f.Resultado);
                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, f.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_AM)
                //{                    
                //    int digito = ap.Configuracion.Exp_Digito_AM;
                //    int intervalo = ap.Configuracion.Intervalo_AM;
                //    int reaccion = ap.Configuracion.Reaccion_AM;
                //    int desasiertos = ap.Configuracion.Desasiertos_AM;
                //    NumScreen n = new NumScreen(digito, intervalo, reaccion, desasiertos);
                //    n.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(n.Resultado);
                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, n.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_TRC)
                //{
                //    Complementos.Figura figura = this.ap.Configuracion.Figura_TRC;
                //    int estimulos = this.ap.Configuracion.MaxEstimulos_TRC;
                //    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_TRC;
                //    int reaccion = this.ap.Configuracion.TiempoReaccion_TRC;
                //    int tecla_reaccion = (this.ap.Configuracion.Tecla1_TRC == "[Enter]") ? 13 : 32;
                //    int tecla_reaccion1 = (this.ap.Configuracion.Tecla1_TRC == "[Enter]") ? 13 : 32;
                //    Color color = this.ap.Configuracion.Color1_TRC;
                //    Color color1 = this.ap.Configuracion.Color2_TRC;

                //    FormTR f = new FormTR(color, color1, estimulos, visualizacion, reaccion, tecla_reaccion, tecla_reaccion1, figura);
                //    f.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(f.Resultado);
                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, f.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_TRS)
                //{
                //    Complementos.Figura figura = this.ap.Configuracion.Figura_TRS;
                //    int estimulos = this.ap.Configuracion.MaxEstimulos_TRS;
                //    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_TRS;
                //    int reaccion = this.ap.Configuracion.TiempoReaccion_TRS;
                //    int tecla_reaccion = (this.ap.Configuracion.Tecla1_TRS == "[Enter]") ? 13 : 32;
                //    Color color = this.ap.Configuracion.Color1_TRS;
                //    FormTRS f = new FormTRS(tecla_reaccion, color, estimulos, visualizacion, reaccion, figura);
                //    f.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(f.Resultado);
                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte r = new Reporte(ap.Paciente, f.Resultado);
                //        r.ShowDialog(this);
                //    }
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.ComboValue_RL)
                //{
                //    int vis1 = this.ap.Configuracion.TiempoVisualizacion1_RL;
                //    int oc1 = this.ap.Configuracion.TiempoOcultamiento1_RL;
                //    int vis15 = this.ap.Configuracion.TiempoVisualizacion15_RL;
                //    int vis2 = this.ap.Configuracion.TiempoVisualizacion2_RL;
                //    int oc2 = this.ap.Configuracion.TiempoOcultamiento2_RL;
                //    int teclacorrecta = (this.ap.Configuracion.Tecla1_TRS == "[Enter]") ? 13 : 32;
                //    int teclaincorrecta = (this.ap.Configuracion.Tecla1_TRS == "[Enter]") ? 13 : 32;
                //    Recuerdo r = new Recuerdo(this, vis1, oc1, vis15, vis2, oc2, teclacorrecta, teclaincorrecta);
                //    r.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(r.Resultado);

                //    if (this.checkBoxResultado.Checked)
                //    {
                //        Reporte rep = new Reporte(ap.Paciente, r.Resultado);
                //        rep.ShowDialog(this);
                //    }
                //    r = null;
                //    return;
                //}
                //if (this.comboBoxTest.Text == Resources.Combovalue_EM)
                //{
                //    int maxEst = (int)this.numericUpDown1.Value;
                //    int interv = (int)this.numericUpDown2.Value;
                //    int anchEst = (int)this.numericUpDown3.Value;
                //    int altoEst = (int)this.numericUpDown4.Value;
                //    int anchoZO = (int)this.numericUpDown5.Value;
                //    int areaCorrecta = (int)this.numericUpDown6.Value;
                //    Color colorEst = this.panelColor1.BackColor;
                //    Color colorZO = this.panelColor2.BackColor;
                //    int teclaReaccion = (this.comboBox1.Text == "[Espacio]") ? 32 : 13;

                //    TimeEstimation t = new TimeEstimation(maxEst, interv, anchEst, altoEst, anchoZO, areaCorrecta, colorEst, colorZO, teclaReaccion);
                //    t.ShowDialog(this);
                //    this.ap.Adicionar_Resultado(t.r);

                //    if (this.checkBoxMostrarResultado.Checked)
                //    {
                //        Reporte rep = new Reporte(ap.Paciente, t.r);
                //        rep.ShowDialog(this);
                //    }
                //}
                #endregion

                // PARCHE PARA TEST POR EDADES
                //if (!CorrectTestForAge())
                //{
                //    var r = new Resp(string.Format(Resources.MSG_Select_Test, ap.Paciente.Edad));
                //    r.ShowDialog(this);
                //    return;
                //}

                if (this.comboBoxTest.Text == Resources.ComboValue_ASS)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASS;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASS;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASS;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASS;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.ImageIndex_ASS;
                    FormASS f2 = this.ap.Configuracion.Estimulo_ASS == 0 ?
                        new FormASS(false, this.ap.Paciente.Codigo, this.ap.Configuracion.Imagenes_ASS_IMG, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASS) :
                        new FormASS(false, this.ap.Paciente.Codigo, this.ap.Configuracion.Imagenes_ASS_FIG, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASS);
                    this.ap.ManageRunTest( this, f2, 10, true );
                    if (this.checkBoxResultado.Checked)
                    {
                        Resultado_AS res = ap.ExtractResultFromPaciente();
                        if ( res == null )
                        {
                            var resp = new Resp( "Este paciente no ha realizado ninguna prueba", "Paciente sin consultarse" );
                            resp.ShowDialog( this );
                            return;
                        }
                        var r = new FormExport2PDF( ap.Paciente, res);
                        r.ShowDialog(this);
                    }
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASS_L)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASS_L;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASS_L;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASS_L;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASS_L;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS_L == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.Letra_Diana_ASS_L;
                    Color color = this.ap.Configuracion.Color_Letras_ASS_L;
                    var f2 = new FormASSL(false, this.ap.Paciente.Codigo, this.ap.Configuracion.Letras_ASS_L, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS_L, color);
                    this.ap.ManageRunTest( this, f2, 10, true );
                    if (this.checkBoxResultado.Checked)
                    {
                        Resultado_AS res = ap.ExtractResultFromPaciente();
                        if ( res == null )
                        {
                            var resp = new Resp( "Este paciente no ha realizado ninguna prueba", "Paciente sin consultarse" );
                            resp.ShowDialog( this );
                            return;
                        }
                        var r = new FormExport2PDF( ap.Paciente, res );
                        r.ShowDialog(this);
                    }
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASC)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASC;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASC;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASC;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASC;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.ImageIndex1_ASC;
                    int index1 = this.ap.Configuracion.ImageIndex2_ASC;

                    FormASC f2 = this.ap.Configuracion.Estimulo_ASC == 0 ?
                        new FormASC(false, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Imagenes_ASC_IMG, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASC) :
                        new FormASC(false, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Imagenes_ASC_FIG, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASC);
                    this.ap.ManageRunTest( this, f2, 10, true );
                    if (this.checkBoxResultado.Checked)
                    {
                        Resultado_AS res = ap.ExtractResultFromPaciente();
                        if ( res == null )
                        {
                            var resp = new Resp( "Este paciente no ha realizado ninguna prueba", "Paciente sin consultarse" );
                            resp.ShowDialog( this );
                            return;
                        }
                        var r = new FormExport2PDF( ap.Paciente, res );
                        r.ShowDialog(this);
                    }
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASC_L)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASC_L;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASC_L;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASC_L;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASC_L;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASC_L == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.Index_Diana1_ASC_L;
                    int index1 = this.ap.Configuracion.Index_Diana2_ASC_L;
                    //string secuencia_letras = this.ap.Configuracion.Letras_ASC_L;
                    var f2 = new FormASCL(false, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Letras_ASC_L, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, this.ap.Configuracion.Color_Letras_ASC_L);
                    this.ap.ManageRunTest( this, f2, 10, true );
                    if (this.checkBoxResultado.Checked)
                    {
                        Resultado_AS res = ap.ExtractResultFromPaciente();
                        if ( res == null )
                        {
                            var resp = new Resp( "Este paciente no ha realizado ninguna prueba", "Paciente sin consultarse" );
                            resp.ShowDialog( this );
                            return;
                        }
                        var r = new FormExport2PDF( ap.Paciente, res );
                        r.ShowDialog(this);
                    }
                    return;
                }
            }
        }

        private void buttonEnsayo_Click(object sender, EventArgs e)
        {
            if (comboBoxTest.SelectedItem == null)
            {
                var r = new Resp(Resources.MSG_Select_Test);
                r.ShowDialog(this);
                return;
            }
            if (comboBoxPaciente.SelectedItem == null)
            {
                var r = new Resp(Resources.MSG_Select_Patient);
                r.ShowDialog(this);
                return;
            }

            if (ap.Paciente != null)
            {
                if (this.comboBoxTest.Text == Resources.ComboValue_MF)
                {
                    //FullScreenBlack f = new FullScreenBlack("E_MF");
                    //f.ShowDialog(this);
                    //return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASS)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASS;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASS;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASS;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASS;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.ImageIndex_ASS;
                    FormASS f2 = this.ap.Configuracion.Estimulo_ASS == 0 ?
                        new FormASS(true, this.ap.Paciente.Codigo, this.ap.Configuracion.Imagenes_ASS_IMG, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASS) :
                        new FormASS(true, this.ap.Paciente.Codigo, this.ap.Configuracion.Imagenes_ASS_FIG, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASS);

                    f2.ShowDialog(this);
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASC)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASC;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASC;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASC;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASC;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.ImageIndex1_ASC;
                    int index1 = this.ap.Configuracion.ImageIndex2_ASC;

                    FormASC f2 = this.ap.Configuracion.Estimulo_ASC == 0 ?
                        new FormASC(true, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Imagenes_ASC_IMG, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASC) :
                        new FormASC(true, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Imagenes_ASC_FIG, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, (TypeOf_AS_Test)this.ap.Configuracion.Estimulo_ASC);

                    f2.ShowDialog(this);

                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASC_L)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASC_L;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASC_L;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASC_L;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASC_L;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASC_L == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.Index_Diana1_ASC_L;
                    int index1 = this.ap.Configuracion.Index_Diana2_ASC_L;
                    //string secuencia_letras = this.ap.Configuracion.Letras_ASC_L;
                    var f2 = new FormASCL(true, this.ap.Paciente.Codigo, index, index1, this.ap.Configuracion.Letras_ASC_L, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASC, this.ap.Configuracion.Color_Letras_ASC_L);
                    f2.ShowDialog(this);
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_ASS_L)
                {
                    int bloques = this.ap.Configuracion.Bloques_ASS_L;
                    int estimulos = this.ap.Configuracion.EstimulosBloques_ASS_L;
                    int visualizacion = this.ap.Configuracion.TiempoVisualizacion_ASS_L;
                    int ocultamiento = this.ap.Configuracion.TiempoOcultamiento_ASS_L;
                    int tecla_reaccion = (this.ap.Configuracion.TeclaTarget_ASS_L == "[Enter]") ? 13 : 32;
                    int index = this.ap.Configuracion.Letra_Diana_ASS_L;
                    Color color = this.ap.Configuracion.Color_Letras_ASS_L;
                    var f2 = new FormASSL(true, this.ap.Paciente.Codigo, this.ap.Configuracion.Letras_ASS_L, index, bloques, estimulos, visualizacion, ocultamiento, tecla_reaccion, this.ap.Configuracion.Color_Fondo_ASS_L, color);
                    f2.ShowDialog(this);
                    return;
                }
                if (this.comboBoxTest.Text == Resources.ComboValue_PVA)
                {
                    //FullScreenBlack f = new FullScreenBlack("E_PVA", this.ap.Configuracion.Imagenes_Ej);
                    //f.ShowDialog(this);
                    //return;
                }
            }
        }
        #endregion 

        #region Menu
        private void cerrarSesiónToolStripMenuItem_Click()
        {
            if ( ap != null ) ap.Cerrar_Sesion();
            Application.Exit();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ap.Cerrar_Sesion();
            this.Dispose();
            Application.Exit();
        }
        private void cambiarContraseñaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var cp = new CambiarPass(this.ap);
            cp.ShowDialog(this);
        }
        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sfdExcelFile.ShowDialog(this);
        }
        private void contenidoToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var hf = new HelpForm( this.ap );
            hf.Show(this);
        }
        private void acercaDeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            var ace = new Acerca();
            ace.ShowDialog( this );
        }
        #endregion

        #region Combos
        private void comboBoxPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( this.comboBoxPaciente.Text != "" )
            {
                ap.Seleccionar_Paciente( this.comboBoxPaciente.Text );
                //int edad = ap.Paciente.Edad;
                //if ( edad == FunctionLibrary.AgeFirstLevel )
                //    this.comboBoxTest.SelectedIndex = 2;
                //else if ( FunctionLibrary.InRange( edad, FunctionLibrary.AgeMinSecondLevel,
                //                                   FunctionLibrary.AgeMaxSecondLevel ) )
                //    this.comboBoxTest.SelectedIndex = 3;
            }
        }
        private void comboBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ap != null)
                    this.ap.Cerrar_Vista_Previa();
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.MSG_ClosePreViewError);
                return;
            }
            if (this.comboBoxTest.Text == Resources.ComboValue_PVA || this.comboBoxTest.Text == Resources.ComboValue_PVA2)
            {
                //string path = InfoPath() + "Fundamentacion_PVA.htm";
                //this.webBrowserInfo.Url = new Uri(path);
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    var colores = new[]{ap.Configuracion.Colores_PVA[0], ap.Configuracion.Colores_PVA[1],
											 ap.Configuracion.Colores_PVA[2], ap.Configuracion.Colores_PVA[3],
											 ap.Configuracion.Colores_PVA[4], ap.Configuracion.Colores_PVA[5]};
                    ap.Vsita_Previa_PVA(this.panelPreView, colores, this.ap.Configuracion.Imagenes_PVA);
                }
                string code = (this.comboBoxTest.Text == Resources.ComboValue_PVA) ? "PVA" : "PVA2";
                publicar(code);              
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_ASS) 
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_ASS(this.panelPreView);
                }
                publicar("ASS");
            }
            else if ( this.comboBoxTest.Text == Resources.ComboValue_ASS_L )
            {
                if ( this.checkBoxVistaPrevia.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    if ( ap != null ) ap.Vsita_Previa_ASS_L( this.panelPreView );
                }
                publicar( "ASS" );
            }
            else if ( this.comboBoxTest.Text == Resources.ComboValue_ASC_L )
            {
                if ( this.checkBoxVistaPrevia.Checked )
                {
                    this.panelPreView.Controls.Clear();
                    if ( ap != null ) ap.Vsita_Previa_ASC_L( this.panelPreView );
                }
                publicar( "ASCL" );
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_ASC)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_ASC(this.panelPreView);
                }
                publicar("ASC");
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_TRS)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_TRS(this.panelPreView);
                }
                publicar("TRS");
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_TRC)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_TR_Compleja(this.panelPreView);
                }
                publicar("TRC");
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_RL)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_AP(this.panelPreView);
                }
                publicar("RL");
            }
            else if (this.comboBoxTest.Text == Resources.ComboValue_AM)
            {
                if (this.checkBoxVistaPrevia.Checked)
                {
                    this.panelPreView.Controls.Clear();
                    if (ap != null) ap.Vsita_Previa_AM(this.panelPreView);
                }
                publicar("AM");
            }
        }
        #endregion

        private void sfdExcelFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string path = this.sfdExcelFile.FileName;
            this.sfdExcelFile.InitialDirectory = InitialDirectory();
            var report = new XLS_Report(3);
            try
            {
                this.lsbEstado.Text = Resources.MSG_MainFormStatus_Exporting2Excel;
                report.Export(path);
                this.lsbEstado.Text = Resources.MSG_MainFormStatus_OperationComplete;
                var r = new Resp(Resources.MSG_Excel_ExportOK);
                r.ShowDialog(this);
                this.lsbEstado.Text = string.Empty;
            }
            catch ( InvalidOperationException ex)
            {
                var r = new Resp( ex.Message );
                r.ShowDialog( this );
            }
            catch (Exception ex2)
            {
                var r = new Resp(Resources.MSG_Excel_ExportError);
                r.ShowDialog(this);
            }
        }
        #endregion
    }
}