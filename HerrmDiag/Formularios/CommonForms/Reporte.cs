using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using BusinessObjects;
using DALayer;
using HerrmDiag.Properties;
using Resultado = DALayer.Resultado;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class Reporte : Form
    {
        #region variables
        private readonly Paciente p;
        private readonly string AM;
        private readonly int c_AM;
        private readonly string PVA;
        private readonly int c_PVA;
        private readonly string MF;
        private readonly int c_MF;
        private readonly string RL;
        private readonly int c_RL;
        private readonly string ASS;
        private readonly int c_ASS;
        private readonly string ET;
        private readonly int c_ET;
        private readonly string TRS;
        private readonly int c_TRS;
        private readonly string TRC;
        private readonly int c_TRC;
        #endregion

        #region constructores
        public Reporte(Paciente p)
        {
            // \b Alejandro Reyes:\b0  Alejandro\par
            InitializeComponent();
            this.p = p;            
            this.richTextBoxReporte.Rtf = Inicia_Documento() + Datos_Generales()+Finaliza_Documento();
            TreeNode n = this.treeViewResult.Nodes["NodeRoot"];
            n.Text = Resources.TITLE_Results;
            foreach (Resultado r in p.Resultados)
            {
                if (!n.Nodes.ContainsKey(r.ToString()))
                {
                    var n1 = new TreeNode(r.ToString()) {Name = r.ToString()};
                    n.Nodes.Add(n1);
                }
                var n2 = new TreeNode(r.Fecha.ToString()) {Name = r.Fecha.ToString()};
                n.Nodes[r.ToString()].Nodes.Add(n2);
            }

            AM = "\\ul\\b\\fs24 Resultados de las Pruebas de Amplitud de Memoria\\ulnone :\\fs20\\b0\\par\\par";
            c_AM = 0;
            PVA = "\\ul\\b\\fs24 Resultados de las Pruebas de Pares Visuales Asociados\\ulnone :\\fs20\\b0\\par\\par";
            c_PVA = 0;
            MF = "\\ul\\b\\fs24 Resultados de las Pruebas de Memoria de Figuras\\ulnone :\\fs20\\b0\\par\\par";
            c_MF = 0;
            RL = "\\ul\\b\\fs24 Resultados de las Pruebas de Aprendizaje de Palabras\\ulnone :\\fs20\\b0\\par\\par";
            c_RL = 0;
            ASS = "\\ul\\b\\fs24 Resultados de las Pruebas de Atención Sostenida Simple\\ulnone :\\fs20\\b0\\par\\par";
            c_ASS = 0;
            ET = "\\ul\\b\\fs24 Resultados de las Pruebas de Estimación del Movimiento\\ulnone :\\fs20\\b0\\par\\par";
            c_ET = 0;
            TRS = "\\ul\\b\\fs24 Resultados de las Pruebas de Tiempo de Reacción (simple)\\ulnone :\\fs20\\b0\\par\\par";
            c_TRS = 0;
            TRC = "\\ul\\b\\fs24 Resultados de las Pruebas de Tiempo de Reacción (compleja)\\ulnone :\\fs20\\b0\\par\\par";
            c_TRC = 0;
            foreach (Resultado r in p.Resultados)
            {
                //if (r is Resultado_Amplitud_Memoria)
                //{
                //    AM += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        AM += " (INCOMPLETO)";
                //    AM += "\\par";
                //    AM += "\\tab\\b Cantidad máxima de digitos recordados hacia adelante: \\b0 " + ((Resultado_Amplitud_Memoria)r).Maximo_Hacia_Alante+"\\par";
                //    AM += "\\tab\\b Puntos obtenidos hacia alante: \\b0 " + ((Resultado_Amplitud_Memoria)r).Puntos_Hacia_Alante + "\\par";
                //    AM += "\\tab\\b Cantidad máxima de digitos recordados hacia atrás: \\b0 " + ((Resultado_Amplitud_Memoria)r).Maximo_Hacia_Atras + "\\par";
                //    AM += "\\tab\\b Puntos obtenidos hacia atrás: \\b0 " + ((Resultado_Amplitud_Memoria)r).Puntos_Hacia_Atras + "\\par";
                //    AM += "\\par";
                //    c_AM++;
                //}
                //else if (r is Resultado_Memoria_Figuras)
                //{
                //    MF += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        MF += " (INCOMPLETO)";
                //    MF += "\\par";
                //    MF += "\\tab\\b Cantidad de Errores: \\b0 " + ((Resultado_Memoria_Figuras)r).Errores + "\\par";
                //    MF += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Memoria_Figuras)r).Aciertos+ "\\par";
                //    MF += "\\tab\\b Cantidad de Omisiones: \\b0 " + ((Resultado_Memoria_Figuras)r).Omisiones + "\\par";
                //    MF += "\\par";
                //    c_MF++;
                //}
                //else if (r is Resultado_Pares_Visuales_Asociados)
                //{
                //    PVA += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        PVA += " (INCOMPLETO)";
                //    PVA += "\\par";
                //    PVA += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Pares_Visuales_Asociados)r).Aciertos + "\\par";
                //    PVA += "\\par";
                //    c_PVA++;
                //}
                //else if (r is Resultado_Pares_Visuales_Asociados_2)
                //{
                //    PVA += "\\b Segunda Etapa \\b0\\par";
                //    PVA += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        PVA += " (INCOMPLETO)";
                //    PVA += "\\par";
                //    PVA += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Pares_Visuales_Asociados_2)r).Aciertos + "\\par";
                //    PVA += "\\par";
                //    c_PVA++;
                //} else
                if (r is Resultado_AS && ((Resultado_AS)r).TipoAtencion == TypeAS.Simple)
                {
                    ASS += string.Format( "\\b Fecha: \\b0 {0}, \\b", r.Fecha );// Hora: \\b0 ";// +r.Hora.ToString();
                    if (!r.Completo)
                        ASS += " (INCOMPLETO)";
                    ASS += "\\par";
                    ASS += "\\tab\\b Bloques: \\tab ";
                    string blok_aciertos = "\\tab\\b Aciertos: \\b0\\tab";
                    string blok_omisiones = "\\tab\\b Omisiones: \\b0\\tab";
                    string blok_equivocaciones = "\\tab\\b Equivocaciones: \\b0";
                    for (int i = 0; i < ((Resultado_AS)r).Aciertos.Length; i++)
                    {
                        ASS += "\\tab " + (i + 1);
                        blok_aciertos += "\\tab " + ((Resultado_AS)r).Aciertos[i];
                        blok_omisiones += "\\tab " + ((Resultado_AS)r).Omisiones[i];
                        blok_equivocaciones += "\\tab " + ((Resultado_AS)r).Equivocaciones[i];
                    }
                    ASS += "\\b0\\par";
                    blok_aciertos += "\\par ";
                    blok_omisiones += "\\par ";
                    blok_equivocaciones += "\\par ";
                    ASS += blok_aciertos + blok_omisiones + blok_equivocaciones;
                    ASS += string.Format( "\\tab\\b Media: \\b0 {0}\\par", ((Resultado_AS)r).Media );
                    ASS += string.Format( "\\tab\\b Desviación: \\b0 {0}\\par", ((Resultado_AS)r).Desviacion );
                    ASS += "\\par";
                    c_ASS++;
                }
                //else if (r is Resultado_Recuerdo_Libre)
                //{
                //    RL += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        RL += " (INCOMPLETO)";
                //    RL += "\\par";
                //    RL += "\\tab\\b Cantidad de Equivocaciones: \\b0 " + ((Resultado_Recuerdo_Libre)r).Equivocaciones + "\\par";
                //    RL += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Recuerdo_Libre)r).Aciertos + "\\par";
                //    RL += "\\tab\\b Cantidad de Omisiones: \\b0 " + ((Resultado_Recuerdo_Libre)r).Omisiones + "\\par";
                //    RL += "\\tab\\b Cantidad de palabras recordadas en la primera etapa: \\b0 " + ((Resultado_Recuerdo_Libre)r).Recordadas1 + "\\par";
                //    RL += "\\tab\\b Cantidad de palabras recordadas en la segunda etapa: \\b0 " + ((Resultado_Recuerdo_Libre)r).Recordadas2 + "\\par";
                //    RL += "\\par";
                //    c_RL++;
                //}
                //else if (r is Resultado_Estimacion_Tiempo)
                //{
                //    ET += "\\b Fecha: \\b0 " + r.Fecha.ToString() +", \\b Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        ET += " (INCOMPLETO)";
                //    ET += "\\par";
                //    ET += "\\tab\\b Cantidad de reacciones correctas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Correcto + "\\par";
                //    ET += "\\tab\\b Cantidad de reacciones anticipadas visibles: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Antecipados + "\\par";
                //    ET += "\\tab\\b Cantidad de reacciones anticipadas ocultas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Dentro + "\\par";
                //    ET += "\\tab\\b Cantidad de reacciones retardadas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Retardados + "\\par";
                //    ET += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Omisiones + "\\par";
                //    ET += "\\par";
                //    c_ET++;
                //}
                //else if (r is Resultado_Tiempo_Reaccion_Simple)
                //{
                //    TRS += "\\b Fecha: \\b0 " + r.Fecha.ToString() +", \\b Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        TRS += " (INCOMPLETO)";
                //    TRS += "\\par";
                //    TRS += "\\tab\\b Cantidad de Reacciones en tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).EnTiempo + "\\par";
                //    TRS += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).MedEnTiempo + "\\par";
                //    TRS += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).DesvEnTiempo + "\\par";
                //    TRS += "\\tab\\b Cantidad de Reacciones fuera de tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).FueraDeTiempo + "\\par";
                //    TRS += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).MedFueraDeTiempo + "\\par";
                //    TRS += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).DesvFueraDeTiempo + "\\par";
                //    TRS += "\\tab\\b Cantidad de Reacciones anticipadas: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).Anticipadas + "\\par";
                //    TRS += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).Omisiones + "\\par";
                //    TRS += "\\par";
                //    c_TRS++;
                //}
                //else if (r is Resultado_Tiempo_Reaccion_Complejo)
                //{
                //    TRC += "\\b Fecha: \\b0 " + r.Fecha.ToString() +", \\b Hora: \\b0 ";// +r.Hora.ToString();
                //    if (!r.Completo)
                //        TRC += " (INCOMPLETO)";
                //    TRC += "\\par";
                //    TRC += "\\tab\\b Cantidad de Reacciones en tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).EnTiempo + "\\par";
                //    TRC += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).MedEnTiempo + "\\par";
                //    TRC += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).DesvEnTiempo + "\\par";
                //    TRC += "\\tab\\b Cantidad de Reacciones fuera de tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).FueraDeTiempo + "\\par";
                //    TRC += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).MedFueraDeTiempo + "\\par";
                //    TRC += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).DesvFueraDeTiempo + "\\par";
                //    TRC += "\\tab\\b Cantidad de Reacciones anticipadas: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Anticipadas + "\\par";
                //    TRC += "\\tab\\b Cantidad de Reacciones invertidas: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Invertidas + "\\par";
                //    TRC += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Omisiones + "\\par";
                //    TRC += "\\par";
                //    c_TRC++;
                //}
                
            }
        }

        public Reporte(Paciente p, Resultado r):this(p)
        {            
            string actual = "\\ul\\b\\fs24 Resultado de la Prueba de "+ r+ "\\ulnone :\\fs20\\b0\\par\\par";
            //if (r is Resultado_Amplitud_Memoria)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 " + r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad máxima de digitos recordados hacia adelante: \\b0 " + ((Resultado_Amplitud_Memoria)r).Maximo_Hacia_Alante + "\\par";
            //    actual += "\\tab\\b Puntos obtenidos hacia alante: \\b0 " + ((Resultado_Amplitud_Memoria)r).Puntos_Hacia_Alante + "\\par";
            //    actual += "\\tab\\b Cantidad máxima de digitos recordados hacia atrás: \\b0 " + ((Resultado_Amplitud_Memoria)r).Maximo_Hacia_Atras + "\\par";
            //    actual += "\\tab\\b Puntos obtenidos hacia atrás: \\b0 " + ((Resultado_Amplitud_Memoria)r).Puntos_Hacia_Atras + "\\par";
            //    actual += "\\par";
            //}
            //else if (r is Resultado_Memoria_Figuras)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Errores: \\b0 " + ((Resultado_Memoria_Figuras)r).Errores + "\\par";
            //    actual += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Memoria_Figuras)r).Aciertos + "\\par";
            //    actual += "\\tab\\b Cantidad de Omisiones: \\b0 " + ((Resultado_Memoria_Figuras)r).Omisiones + "\\par";
            //    actual += "\\par";
            //}
            //else if (r is Resultado_Pares_Visuales_Asociados)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Pares_Visuales_Asociados)r).Aciertos + "\\par";
            //    actual += "\\par";
            //}
            //else if (r is Resultado_Pares_Visuales_Asociados_2)
            //{
            //    actual += "\\b Segunda Etapa \\b0\\par";
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Pares_Visuales_Asociados_2)r).Aciertos + "\\par";
            //    actual += "\\par";
            //} else
            if (r is Resultado_AS && ((Resultado_AS)r).TipoAtencion == TypeAS.Simple)
            {
                actual += "\\b Fecha: \\b0 " + r.Fecha + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
                if (!r.Completo)
                    actual += " (INCOMPLETO)";
                actual += "\\par";
                actual += "\\tab\\b Bloques: \\tab ";
                string blok_aciertos = "\\tab\\b Aciertos: \\b0\\tab";
                string blok_omisiones = "\\tab\\b Omisiones: \\b0\\tab";
                string blok_equivocaciones = "\\tab\\b Equivocaciones: \\b0";
                for (int i = 0; i < ((Resultado_AS)r).Aciertos.Length; i++)
                {
                    actual += string.Format( "\\tab {0}", (i + 1) );
                    blok_aciertos += string.Format( "\\tab {0}", ((Resultado_AS)r).Aciertos[i] );
                    blok_omisiones += string.Format( "\\tab {0}", ((Resultado_AS)r).Omisiones[i] );
                    blok_equivocaciones += string.Format( "\\tab {0}", ((Resultado_AS)r).Equivocaciones[i] );
                }
                actual += "\\b0\\par";
                blok_aciertos += "\\par ";
                blok_omisiones += "\\par ";
                blok_equivocaciones += "\\par ";
                actual += blok_aciertos + blok_omisiones + blok_equivocaciones;
                actual += string.Format( "\\tab\\b Media: \\b0 {0}\\par", ((Resultado_AS)r).Media );
                actual += string.Format( "\\tab\\b Desviación: \\b0 {0}\\par", ((Resultado_AS)r).Desviacion );
                actual += "\\par";
            }
            //else if (r is Resultado_Recuerdo_Libre)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b";// Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Equivocaciones: \\b0 " + ((Resultado_Recuerdo_Libre)r).Equivocaciones + "\\par";
            //    actual += "\\tab\\b Cantidad de Aciertos: \\b0 " + ((Resultado_Recuerdo_Libre)r).Aciertos + "\\par";
            //    actual += "\\tab\\b Cantidad de Omisiones: \\b0 " + ((Resultado_Recuerdo_Libre)r).Omisiones + "\\par";
            //    actual += "\\tab\\b Cantidad de palabras recordadas en la primera etapa: \\b0 " + ((Resultado_Recuerdo_Libre)r).Recordadas1 + "\\par";
            //    actual += "\\tab\\b Cantidad de palabras recordadas en la segunda etapa: \\b0 " + ((Resultado_Recuerdo_Libre)r).Recordadas2 + "\\par";
            //    actual += "\\par";
            //}
            //else if (r is Resultado_Estimacion_Tiempo)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de reacciones correctas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Correcto + "\\par";
            //    actual += "\\tab\\b Cantidad de reacciones anticipadas visibles: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Antecipados + "\\par";
            //    actual += "\\tab\\b Cantidad de reacciones anticipadas ocultas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Dentro + "\\par";
            //    actual += "\\tab\\b Cantidad de reacciones retardadas: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Retardados + "\\par";
            //    actual += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Estimacion_Tiempo)r).Omisiones + "\\par";
            //    actual += "\\par";
            //}
            //else if (r is Resultado_Tiempo_Reaccion_Simple)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones en tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).EnTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).MedEnTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).DesvEnTiempo + "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones fuera de tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).FueraDeTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).MedFueraDeTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).DesvFueraDeTiempo + "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones anticipadas: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).Anticipadas + "\\par";
            //    actual += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Tiempo_Reaccion_Simple)r).Omisiones + "\\par";
            //    actual += "\\par";                
            //}
            //else if (r is Resultado_Tiempo_Reaccion_Complejo)
            //{
            //    actual += "\\b Fecha: \\b0 " + r.Fecha.ToString() + ", \\b Hora: \\b0 ";// +r.Hora.ToString();
            //    if (!r.Completo)
            //        actual += " (INCOMPLETO)";
            //    actual += "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones en tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).EnTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).MedEnTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).DesvEnTiempo + "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones fuera de tiempo: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).FueraDeTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Media: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).MedFueraDeTiempo + "\\par";
            //    actual += "\\tab\\tab\\b Desviación: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).DesvFueraDeTiempo + "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones anticipadas: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Anticipadas + "\\par";
            //    actual += "\\tab\\b Cantidad de Reacciones invertidas: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Invertidas + "\\par";
            //    actual += "\\tab\\b Cantidad de omisiones: \\b0 " + ((Resultado_Tiempo_Reaccion_Complejo)r).Omisiones + "\\par";
            //    actual += "\\par";
            //}
            this.richTextBoxReporte.Rtf = Inicia_Documento() + Datos_Generales() + actual + Finaliza_Documento();
        }

        #endregion

        #region RTF methods
        private static string Inicia_Documento()
        { 
            return "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fswiss\\fcharset0 Arial;}}"+"{\\*\\generator Msftedit 5.41.15.1507;}\\viewkind4\\uc1\\pard\\f0\\fs20";
        }

        private static string Finaliza_Documento()
        {
            return "\\par}";
        }

        private string Datos_Generales()
        { 
            string aux2 = "";
            aux2+= "\\ul\\b\\fs24 Datos Generales del Paciente\\ulnone :\\fs20\\b0\\par\\par";
            aux2+= "\\b Nombre y Apellidos: \\b0 "+p.Nombre+" "+p.Apellido1+" "+p.Apellido2+"\\par";
            aux2+= "\\b Código: \\b0 " + p.Codigo + "\\par";
            aux2+= "\\b Edad: \\b0 " + p.Edad + "\\par";
            aux2+= "\\b Sexo: \\b0 " + p.Sexo + "\\par";
            aux2+= "\\b Nivel de Escolaridad: \\b0 " + p.Escolaridad + "\\par";
            aux2+= "\\b Dirección Particular: \\b0 " + p.Direccion + "\\par";
            aux2 += "\\par";
            return aux2;
        }
        private string AmplitudMemoria()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_AM != 0)
                aux2 += AM;
            
            return aux2;
        }
        private string RecuerdoLibre()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_RL != 0)
                aux2 += RL;

            return aux2;
        }
        private string MemoriaFiguras()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_MF != 0)
                aux2 += MF;

            return aux2;
        }
        private string ParesVisualesAsociados()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_PVA != 0)
                aux2 += PVA;

            return aux2;
        }
        private string AtencionSostenidaSimple()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_ASS != 0)
                aux2 += ASS;

            return aux2;
        }
        private string EstimacionTiempo()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_ET != 0)
                aux2 += ET;

            return aux2;
        }
        private string TiempoReaccionSimple()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_TRS != 0)
                aux2 += TRS;
            return aux2;
        }
        private string TiempoReaccionCompleja()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_TRC != 0)
                aux2 += TRC;
            return aux2;
        }
        
        private string Todos()
        {
            string aux2 = "";
            aux2 += Datos_Generales();
            aux2 += "\\par";
            if (c_AM != 0)
                aux2 += AM;
            if (c_MF != 0)
                aux2 += MF;
            if (c_PVA != 0)
                aux2 += PVA;
            if (c_ASS != 0)
                aux2 += ASS;
            if (c_RL != 0)
                aux2 += RL;
            if (c_ET != 0)
                aux2 += ET;
            if (c_TRS != 0)
                aux2 += TRS;
            if (c_TRC != 0)
                aux2 += TRC;
            return aux2;
        }
        #endregion
        
        #region Eventos
        private void treeViewResult_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            SelectNode(e.Node);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string path = this.saveFileDialog.FileName;
            var st = new StreamWriter(path, false);            
            st.Write(this.richTextBoxReporte.Rtf);
            st.Close();
        }

        private void treeViewResult_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SelectNode(e.Node);
        }

        private void SelectNode(TreeNode e)
        {
            switch (e.Text)
            {
                case "Resultados":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + Todos() + Finaliza_Documento();
                    return;
                case "Amplitud de Memoria":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + AmplitudMemoria() + Finaliza_Documento();
                    return;
                case "Memoria de Figuras":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + MemoriaFiguras() + Finaliza_Documento();
                    return;
                case "Pares Visuales Asociados":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + ParesVisualesAsociados() + Finaliza_Documento();
                    return;
                case "Aprendizaje de Palabras":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + RecuerdoLibre() + Finaliza_Documento();
                    return;
                case "Atención Sostenida Simple":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + AtencionSostenidaSimple() + Finaliza_Documento();
                    return;
                case "Estimación del Movimiento":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + EstimacionTiempo() + Finaliza_Documento();
                    return;
                case "Tiempo se Reacción Simple":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + TiempoReaccionSimple() + Finaliza_Documento();
                    return;
                case "Tiempo se Reacción Compleja":
                    this.richTextBoxReporte.Rtf = Inicia_Documento() + TiempoReaccionCompleja() + Finaliza_Documento();
                    return;
                default:
                    int ini = this.richTextBoxReporte.Find(e.Text);
                    if (ini != -1)
                        this.richTextBoxReporte.Select(ini, e.Text.Length);
                    else 
                    { 
                        TreeNode padre = e.Parent;
                        SelectNode(padre);
                        ini = this.richTextBoxReporte.Find(e.Text);
                        if (ini != -1)
                            this.richTextBoxReporte.Select(ini, e.Text.Length);
                    }
                    break;
            }
        }
        #endregion
 
    }
}