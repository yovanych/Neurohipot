using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BusinessObjects;
using DALayer;
using HerrmDiag.Activation;
using ImgSet;
using PsicoTests.Alejandro;
using PsicoTests.Yovany;

namespace HerrmDiag
{
    [Serializable]
    public class Config
    {
        #region Codigo unico para pacientes
        private string prefijo;
        private long numero;

        public string siguiente_codigo()
        {
            var p = new Paciente();
            if (numero == long.MaxValue)
            {
                numero = 0;
                prefijo = next_prefix(prefijo);
            }
            numero++;
            string codigo = this.prefijo + this.numero;
            if (!p.Existe_Paciente(codigo)) return codigo;
            recuperar(p.Lista_Codigos_Pacientes());
            return this.prefijo + this.numero;
        }
        public void recuperar(List<string> pacientes)
        {   
            var mayor = pacientes[0];
            foreach (string cod in pacientes)
            {
                if (cod.CompareTo(mayor) > 0)
                    mayor = cod;  
            }
            mayor = prfix(mayor);
            prefijo = next_prefix(mayor);
            numero = 0;
        }
        #endregion

        public ActivationSettings GenerationSettings { get; set; }
        public bool ActivationExecuted
        {
            get { return this.GenerationSettings != null; }
        }

        #region Datos de la prueba Memoria de Figuras

        public ImageSet Imagenes_MF { get; set; }
        public int Presentacion_MF { get; set; }
        public int Muestra_MF { get; set; }
        public int Descanso_MF { get; set; }

        #endregion

        #region Datos de la prueba Atencion Sostenida Simple

        public ImageSet Imagenes_ASS_FIG { get; set; }
        public ImageSet Imagenes_ASS_IMG { get; set; }
        //public ImageSet Imagenes_ASS_LET { get; set; }
        public int Estimulo_ASS { get; set; }
        public string TeclaTarget_ASS { get; set; }
        public int ImageIndex_ASS { get; set; }
        public int TiempoOcultamiento_ASS { get; set; }
        public int TiempoVisualizacion_ASS { get; set; }
        public int EstimulosBloques_ASS { get; set; }
        public int Bloques_ASS { get; set; }
        public Color Color_Fondo_ASS { get; set; }

        #endregion

        #region Datos de la prueba Atencion Sostenida Simple Letras (Homogeneas)

        public int Letra_Diana_ASS_L { get; set; }
        public string TeclaTarget_ASS_L { get; set; }
        public int TiempoOcultamiento_ASS_L { get; set; }
        public int TiempoVisualizacion_ASS_L { get; set; }
        public int EstimulosBloques_ASS_L { get; set; }
        public int Bloques_ASS_L { get; set; }
        public Color Color_Letras_ASS_L { get; set; }
        public Color Color_Fondo_ASS_L { get; set; }
        public string Letras_ASS_L { get; set; }

        #endregion

        #region Datos de la prueba Atencion Sostenida Simple Letras (En Colores)

        public int Letra_Diana_CASS_L { get; set; }
        public string TeclaTarget_CASS_L { get; set; }
        public int TiempoOcultamiento_CASS_L { get; set; }
        public int TiempoVisualizacion_CASS_L { get; set; }
        public int EstimulosBloques_CASS_L { get; set; }
        public int Bloques_CASS_L { get; set; }
        public Color Color_LetraDiana_CASS_L { get; set; }
        public Color Color_Fondo_CASS_L { get; set; }
        public string Letras_CASS_L { get; set; }

        #endregion

        #region Datos de la prueba Atencion Sostenida Compleja

        public ImageSet Imagenes_ASC_FIG { get; set; }
        public ImageSet Imagenes_ASC_IMG { get; set; }
        //public ImageSet Imagenes_ASC_LET { get; set; }
        public string TeclaTarget_ASC { get; set; }
        public int Estimulo_ASC { get; set; }
        public int ImageIndex1_ASC { get; set; }
        public int ImageIndex2_ASC { get; set; }
        public int TiempoOcultamiento_ASC { get; set; }
        public int TiempoVisualizacion_ASC { get; set; }
        public int EstimulosBloques_ASC { get; set; }
        public int Bloques_ASC { get; set; }
        public Color Color_Fondo_ASC { get; set; }

        #endregion

        #region Datos de la prueba Atencion Sostenida Compleja Letras

        public int Index_Diana1_ASC_L { get; set; }
        public int Index_Diana2_ASC_L { get; set; }
        public string TeclaTarget_ASC_L { get; set; }
        public int TiempoOcultamiento_ASC_L { get; set; }
        public int TiempoVisualizacion_ASC_L { get; set; }
        public int EstimulosBloques_ASC_L { get; set; }
        public int Bloques_ASC_L { get; set; }
        public Color Color_Fondo_ASC_L { get; set; }
        public Color Color_Letras_ASC_L { get; set; }
        public string Letras_ASC_L { get; set; }

        #endregion

        #region Datos de la prueba Pares Visuales Asociados

        public ImageSet Imagenes_PVA { get; set; }
        public Color[] Colores_PVA { get; set; }
        public int Presentacion_PVA { get; set; }
        public int Muestra_PVA { get; set; }
        public int Descanso_PVA { get; set; }

        #endregion

        #region Datos de la prueba Aprendizaje de Palabras

        public int TiempoVisualizacion1_RL { get; set; }
        public int TiempoOcultamiento1_RL { get; set; }
        public int TiempoVisualizacion2_RL { get; set; }
        public int TiempoOcultamiento2_RL { get; set; }
        public int TiempoVisualizacion15_RL { get; set; }
        public string Correcta_RL { get; set; }
        public string Incorrecta_RL { get; set; }

        #endregion

        #region Datos de la prueba Amplitud de Memoria

        public int Exp_Digito_AM { get; set; }
        public int Intervalo_AM { get; set; }
        public int Reaccion_AM { get; set; }
        public int Desasiertos_AM { get; set; }

        #endregion

        #region Datos de la prueba Estimación de Tiempo

        public int TeclaReaccion_ET { get; set; }
        public Color ColorZonaOpaca_ET { get; set; }
        public Color Estimulo_ET { get; set; }
        public int AreaCorrecta_ET { get; set; }
        public int ZonaOpaca_ET { get; set; }
        public int AltoEstimulo_ET { get; set; }
        public int AnchoEstimulo_ET { get; set; }
        public int IntervaloSalida_ET { get; set; }
        public int MaxEstimulos_ET { get; set; }

        #endregion
        
        #region Datos de la prueba Tiempo de Reaccion (compleja)

        public TiempoReaccion.Figura Figura_TRC { get; set; }
        public int MaxEstimulos_TRC { get; set; }
        public int TiempoVisualizacion_TRC { get; set; }
        public int TiempoReaccion_TRC { get; set; }
        public string Tecla1_TRC { get; set; }
        public string Tecla2_TRC { get; set; }
        public Color Color1_TRC { get; set; }
        public Color Color2_TRC { get; set; }

        #endregion       
        
        #region Datos de la prueba Tiempo de Reaccion (simple)

        public TiempoReaccion.Figura Figura_TRS { get; set; }
        public int MaxEstimulos_TRS { get; set; }
        public int TiempoVisualizacion_TRS { get; set; }
        public int TiempoReaccion_TRS { get; set; }
        public string Tecla1_TRS { get; set; }
        public Color Color1_TRS { get; set; }

        #endregion       
        
        #region Imagenes de Ejemplo

        public ImageSet Imagenes_Ej { get; set; }

        #endregion
        
        public Config()
        {
            this.numero = 0;
            this.prefijo = "A";
            this.GenerationSettings = null;
                        
            #region Inicializar Memoria de figuras
            this.Muestra_MF = Memoria_Figuras.Pmuestra;
            this.Presentacion_MF = Memoria_Figuras.Ppresentacion;
            this.Descanso_MF = Memoria_Figuras.Pdescanso;
            var binaryFormatter = new BinaryFormatter();
            var stream = new FileStream( "ImgMF.ips", FileMode.Open );
            this.Imagenes_MF = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            #endregion

            #region Inicializar Pares Visuales Asociados
            this.Colores_PVA = Pares_Visuales_Asociados.Pcolores;
            this.Presentacion_PVA = Pares_Visuales_Asociados.Ppresentacion;
            this.Muestra_PVA = Pares_Visuales_Asociados.Pmuestra;
            this.Descanso_PVA = Pares_Visuales_Asociados.Pdescanso;
            binaryFormatter = new BinaryFormatter();
            stream = new FileStream( "ImgPVA.ips", FileMode.Open );
            this.Imagenes_PVA = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            #endregion

            #region Inicializar Amplitud de Memoria
            this.Exp_Digito_AM = Amplitud_Memoria.PExp_digito;
            this.Intervalo_AM = Amplitud_Memoria.PIntervalo;
            this.Reaccion_AM = Amplitud_Memoria.PReaccion;
            this.Desasiertos_AM = Amplitud_Memoria.PDesasiertos;
            #endregion

            #region Inicializar Atencion sostenida Simple
            this.Bloques_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PBloques;
            this.EstimulosBloques_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PEstimulosBloque;
            this.TiempoOcultamiento_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PTiempoOcultamiento;
            this.TiempoVisualizacion_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PTiempoVisualizacion;
            this.Color_Fondo_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PColorFondo;
            //this.imageIndex = ASS.PImageIndex;
            this.TeclaTarget_ASS = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple.PTeclaTarget;
            binaryFormatter = new BinaryFormatter();
            stream = new FileStream( "ImgASS_IMG.ips", FileMode.Open );
            this.Imagenes_ASS_IMG = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            stream = new FileStream( "ImgASS_FIG.ips", FileMode.Open );
            this.Imagenes_ASS_FIG = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            //stream = new FileStream("ImgASS_LET.ips", FileMode.Open);
            //this.Imagenes_ASS_LET = (ImageSet)binaryFormatter.Deserialize(stream);
            //stream.Close();
            #endregion

            #region Inicializar Atencion sostenida Simple Letras
            this.Letra_Diana_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PLetraDiana;
            this.TeclaTarget_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PTeclaTarget;
            this.TiempoOcultamiento_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PTiempoOcultamiento;
            this.TiempoVisualizacion_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PTiempoVisualizacion;
            this.EstimulosBloques_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PEstimulosBloque;
            this.Bloques_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PBloques;
            this.Color_Letras_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PColorLetras;
            this.Color_Fondo_ASS_L = PsicoTests.Yovany.ASS.Homogeneas.Atencion_Sostenida_Simple_Letras.PColorFondo;
            this.Letras_ASS_L = "ABCDEFHKLMNOPRSTVZ";
            #endregion

            #region Inicializar Atencion sostenida Simple Letras (En colores)
            this.Letra_Diana_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PLetraDiana;
            this.TeclaTarget_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PTeclaTarget;
            this.TiempoOcultamiento_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PTiempoOcultamiento;
            this.TiempoVisualizacion_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PTiempoVisualizacion;
            this.EstimulosBloques_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PEstimulosBloque;
            this.Bloques_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PBloques;
            this.Color_LetraDiana_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PColorDiana;
            this.Color_Fondo_CASS_L = PsicoTests.Yovany.ASS.Colores.Atencion_Sostenida_Simple.PColorFondo;
            this.Letras_CASS_L = "ABCDEFHKLMNOPRSTVZ";
            #endregion

            #region Inicializar Atencion sostenida Compleja
            this.Bloques_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PBloques;
            this.EstimulosBloques_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PEstimulosBloque;
            this.TiempoOcultamiento_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PTiempoOcultamiento;
            this.TiempoVisualizacion_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PTiempoVisualizacion;
            this.TeclaTarget_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PTeclaTarget;
            this.ImageIndex1_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PIndexDiana1;
            this.Color_Fondo_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PColorFondo;
            //this.teclaTarget2 = ASC.PTeclaTarget2;
            this.ImageIndex2_ASC = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja.PIndexDiana2;
            binaryFormatter = new BinaryFormatter();
            stream = new FileStream( "ImgASC_IMG.ips", FileMode.Open );
            this.Imagenes_ASC_IMG = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            stream = new FileStream( "ImgASC_FIG.ips", FileMode.Open );
            this.Imagenes_ASC_FIG = (ImageSet)binaryFormatter.Deserialize( stream );
            stream.Close();
            //stream = new FileStream("ImgASC_LET.ips", FileMode.Open);
            //this.Imagenes_ASC_LET = (ImageSet)binaryFormatter.Deserialize(stream);
            //stream.Close();
            #endregion

            #region Inicializar Atencion sostenida Compleja Letras
            this.Index_Diana1_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PIndexDiana1;
            this.Index_Diana2_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PIndexDiana2;
            this.TeclaTarget_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PTeclaTarget;
            this.TiempoOcultamiento_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PTiempoOcultamiento;
            this.TiempoVisualizacion_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PTiempoVisualizacion;
            this.EstimulosBloques_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PEstimulosBloque;
            this.Bloques_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PBloques;
            this.Color_Fondo_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PColorFondo;
            this.Color_Letras_ASC_L = PsicoTests.Yovany.ASC.Homogeneas.Atencion_Sostenida_Compleja_Letras.PColorLetras;
            this.Letras_ASC_L = "ABCDEFHKLMNOPRSTVZ";
            #endregion

            #region Aprendizaje de palabras
            this.TiempoVisualizacion1_RL = Recuerdo_Libre.PTiempoVisualizacion1;
            this.TiempoOcultamiento1_RL = Recuerdo_Libre.PTiempoOcultamiento1;
            this.TiempoVisualizacion2_RL = Recuerdo_Libre.PTiempoVisualizacion2;
            this.TiempoOcultamiento2_RL = Recuerdo_Libre.PTiempoOcultamiento2;
            this.TiempoVisualizacion15_RL = Recuerdo_Libre.PTiempoVisualizacion15;
            this.Correcta_RL = Recuerdo_Libre.PCorrecta;
            this.Incorrecta_RL = Recuerdo_Libre.PIncorrecta;
            #endregion

            #region Estimacion de Tiempo
            this.MaxEstimulos_ET = Estimacion_Tiempo.PmaxEstimulos;
            this.IntervaloSalida_ET = Estimacion_Tiempo.PintervaloSalida;
            this.AnchoEstimulo_ET = Estimacion_Tiempo.PanchoEstimulo;
            this.AltoEstimulo_ET = Estimacion_Tiempo.PaltoEstimulo;
            this.ZonaOpaca_ET = Estimacion_Tiempo.PzonaOpaca;
            this.AreaCorrecta_ET = Estimacion_Tiempo.PareaCorrecta;
            this.Estimulo_ET = Estimacion_Tiempo.Pestimulo;
            this.ColorZonaOpaca_ET = Estimacion_Tiempo.PcolorZonaOpaca;
            this.TeclaReaccion_ET = Estimacion_Tiempo.PteclaReaccion;
            #endregion

            #region Tiempo de Reaccion Compleja
            MaxEstimulos_TRC = TiempoReaccion.PMaxEstimulos;
            TiempoVisualizacion_TRC = TiempoReaccion.PTiempoVisualizacion;
            TiempoReaccion_TRC = TiempoReaccion.PTiempoReaccion;
            Tecla1_TRC = TiempoReaccion.PTecla1;
            Tecla2_TRC = TiempoReaccion.PTecla2;
            Color1_TRC = TiempoReaccion.PColor1;
            Color2_TRC = TiempoReaccion.PColor2;
            //binaryFormatter = new BinaryFormatter();
            //stream = new FileStream("ImgASC.ips", FileMode.Open);
            //this.imagenes_ASC = (ImageSet)binaryFormatter.Deserialize(stream);
            //stream.Close();
            this.Figura_TRC = TiempoReaccion.PFigura;
            #endregion

            #region Tiempo de Reaccion Simple
            MaxEstimulos_TRS = TiempoReaccionSimple.PMaxEstimulos;
            TiempoVisualizacion_TRS = TiempoReaccionSimple.PTiempoVisualizacion;
            TiempoReaccion_TRS = TiempoReaccionSimple.PTiempoReaccion;
            Tecla1_TRS = TiempoReaccionSimple.PTecla1;
            Color1_TRS = TiempoReaccionSimple.PColor1;
            //binaryFormatter = new BinaryFormatter();
            //stream = new FileStream("ImgASS.ips", FileMode.Open);
            //this.imagenes_ASS = (ImageSet)binaryFormatter.Deserialize(stream);
            //stream.Close();
            this.Figura_TRS = TiempoReaccionSimple.PFigura;
            #endregion

            #region Inicializar Imagenes de Ejemplo
            binaryFormatter = new BinaryFormatter();
            stream = new FileStream("ImgEj.ips", FileMode.Open);
            this.Imagenes_Ej = (ImageSet)binaryFormatter.Deserialize(stream);
            stream.Close();
            #endregion
        }

        #region Métodos Privados
        private static string next_prefix(string s)
        {
            string pr;   
            char final = s[s.Length - 1];
            string ant = s.Substring(0, s.Length - 1);
            if (final == 90)
            {
                pr = ant + "AA";
            }
            else
                pr = ant + ((char)(final + 1));
            return pr;
        }
        private static string prfix(IEnumerable<char> s)
        {
            string pr = "";
            foreach (char c in s)
            {
                if (c >= 65 && c <= 90)
                    pr += c.ToString();
                else break;
            }
            return pr;
        }
        #endregion

        
    }    
}
