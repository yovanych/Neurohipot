using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using BusinessObjects;
using DALayer;
using Encrypting;
using HermDiag;
using HerrmDiag.Activation;
using HerrmDiag.Formularios.CommonForms;
using HerrmDiag.Properties;
using PsicoTests;
using ImgSet;
using PsicoTests.Alejandro;
using PsicoTests.Yovany;
using PsicoTests.Yovany.VistaPrevia;
using ReadingXML;
using System.Xml;
using pica;

namespace HerrmDiag
{
    public class Aplicador
    {
        #region Variables y propiedades
        public XMLDocInformation XmlInfo { get; private set; }
        public IVistaPrevia VistaPrevia { get; private set; }
        public Usuario User { get; private set; }
        public Config Configuracion { get; private set; }
        public Paciente Paciente { get; private set; }
        private bool openSesion;
        public WinFormManager WinManager { get; private set; }
        #endregion

        public Aplicador()
        {
            this.openSesion = false;
            this.WinManager = new WinFormManager();
        }

        #region Activacion
        public bool SoftwareActivado()
        {
            string generation_code = ActivationManager.GenerationCode();

            #region Para si un dia se quiere que caduque la activación
            loadConfig();
            this.Configuracion.GenerationSettings = 
                new ActivationSettings( generation_code, DateTime.Now );
            saveConfig();
            #endregion

            string s = Code.Load( Resources.FILE_ActKey );
            string activation_code = Encryptor.Decrypt( s );

            #region Log activation
            //OperationsLog.LogOperation( string.Format( "{0}", Environment.MachineName ) );
            //OperationsLog.LogOperation( string.Format( "Activation Code: {0}", activation_code ) );
            //OperationsLog.LogOperation( string.Format( "Generation Code: {0}", generation_code ) );
            #endregion

            return generation_code == activation_code;
        }

        #endregion

        #region Actualizar Vista Previa
        public void Vsita_Previa_MF(Control c, ImageSet listaIMG)
        {
            try
            {
                if ( VistaPrevia != null )
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_MF( c, listaIMG );
                VistaPrevia.Start();
            }
            catch ( Exception )
            {
                throw new Exception( Resources.MSG_PreviewNotLoaded );
            }
        }
        public void Vsita_Previa_PVA(Control c, Color[] colores, ImageSet listaIMG) 
        {
            try
            {
                if ( VistaPrevia != null )
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_PVA( c, colores, listaIMG );
                VistaPrevia.Start();
            }
            catch ( Exception )
            {
                throw new Exception( Resources.MSG_PreviewNotLoaded );
            }
        }
        public void Vsita_Previa_AM(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_AM(c);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ASS(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                switch (this.Configuracion.Estimulo_ASS)
                {
                    case 0:
                        this.VistaPrevia = new Vista_Previa_AS(this.Configuracion.Color_Fondo_ASS, this.Configuracion.Imagenes_ASS_IMG, c);
                        break;
                    default://case 1:
                        this.VistaPrevia = new Vista_Previa_AS(this.Configuracion.Color_Fondo_ASS, this.Configuracion.Imagenes_ASS_FIG, c);
                        break;
                }
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ASS_Letras_Colores(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_AS_Letras_Colores(this.Configuracion.Letras_CASS_L[this.Configuracion.Letra_Diana_CASS_L].ToString(), 
                    this.Configuracion.Color_LetraDiana_CASS_L, c);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ASC(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                switch (this.Configuracion.Estimulo_ASC)
                {
                    case 0:
                        this.VistaPrevia = new Vista_Previa_AS(this.Configuracion.Color_Fondo_ASC, this.Configuracion.Imagenes_ASC_IMG, c);
                        break;
                    default: //case 1:
                        this.VistaPrevia = new Vista_Previa_AS(this.Configuracion.Color_Fondo_ASC, this.Configuracion.Imagenes_ASC_FIG, c);
                        break;
                }
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ASS_L(Control c)
        {
            try
            {
                this.VistaPrevia = new Vista_Previa_AS_Letras
                            (
                                this.Configuracion.Color_Fondo_ASS_L,
                                this.Configuracion.Color_Letras_ASS_L,
                                this.Configuracion.Letras_ASS_L, c
                            );
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ASC_L(Control c)
        {
            try
            {
                this.VistaPrevia = new Vista_Previa_AS_Letras
                            (
                                this.Configuracion.Color_Fondo_ASC_L,
                                this.Configuracion.Color_Letras_ASC_L,
                                this.Configuracion.Letras_ASC_L, c
                            );
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_TR_Compleja(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_TR(c);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_TRS(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_TRS(c);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_AP(Control c)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_AP(c);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Vsita_Previa_ET(Control c,  int intervaloSalida,
                                    int anchoEstimulo, int altoEstimulo, int zonaOpaca, int areaCorrecta,
                                    Color estimulo, Color colorZonaOpaca)
        {
            try
            {
                if (VistaPrevia != null)
                    VistaPrevia.Stop();
                this.VistaPrevia = new Vista_Previa_ET(c, intervaloSalida, anchoEstimulo, altoEstimulo, zonaOpaca, areaCorrecta, estimulo, colorZonaOpaca);
                VistaPrevia.Start();
            }
            catch (Exception)
            {
                throw new Exception(Resources.MSG_PreviewNotLoaded);
            }
        }
        public void Cerrar_Vista_Previa()
        {
            if (this.VistaPrevia != null)
                VistaPrevia.Stop();
        }
        #endregion

        public void Cerrar_Sesion()
        {
            if (openSesion)
            {
                if (VistaPrevia != null)
                    this.VistaPrevia.Stop();
                saveConfig();
                this.User = null;
                this.openSesion = false;                
            }
        }

        public bool Abrir_Sesion(string nombre, string password)
        {
            if (!openSesion)
            {
                if(this.User == null)
                    this.User = new Usuario();
                this.openSesion = this.User.Autenticate(nombre, password);
                if (!this.openSesion) return false;

                #region Cargar la configuracion
                loadConfig();
                #endregion

                #region Informacion d elas pruebas
                try 
                {
                    XmlReader r = new XmlTextReader(Resources.PATH_Xml);
                    this.XmlInfo = new XMLDocInformation( r );
                    r.Close();
                }
                catch (Exception)
                {
                    var rp = new Resp(Resources.MSG_InfoNotLoaded);
                    rp.Show();
                    return false;
                }
                #endregion
                return true;
            }
            return false;
        }

        #region [Pacientes]
        public List<Paciente> buscar_Paciente(List<Busqueda> criterios)
        {
            var paciente = new Paciente();
            if (criterios != null && criterios.Count != 0)
            {
                paciente.LoadByCriteria(criterios);
                return paciente.Lista_Pacientes();
            }
            paciente.loadAll();
            return paciente.Lista_Pacientes();
        }
        public Paciente Seleccionar_Paciente(string codigo)
        {
            if(this.Paciente == null)
                this.Paciente = new Paciente();
            this.Paciente.LoadByID(codigo);
           
            return this.Paciente;
        }
        public bool insertarPaciente(string codigo, string nombre, string apellido1, string apellido2, 
                                        string direccion, DateTime fecha_nacimiento, Sexo sexo, string escolaridad,
                                        string aplicador, string lugar)
        {
            var paciente = new Paciente();
            return paciente.Insert(codigo, nombre, apellido1, apellido2, direccion, fecha_nacimiento, sexo,
                                        escolaridad, aplicador, lugar);
        }

        public List<string> Lista_CodigoPacientes()
        {
            var paciente = new Paciente();
            return paciente.Lista_Codigos_Pacientes();
        }
        public void Eliminar_Paciente(string codigo)
        {
            if (this.Paciente != null && this.Paciente.Codigo == codigo)
                this.Paciente = null;
            var paciente = new Paciente();
            paciente.Delete(codigo);
        }

        public Paciente Obtener_Paciente(string codigo)
        {
            var paciente = new Paciente();
            paciente.LoadByID(codigo);
            return paciente;
        }

        public bool Modificar_Paciente(string codigo, string nombre, string apellido1, string apellido2,
                                        string direccion, DateTime fecha_nacimiento, Sexo sexo, string escolaridad,
                                        string aplicador, string lugar)
        {
            var paciente = new Paciente();
            return paciente.Update(codigo, nombre, apellido1, apellido2, direccion, fecha_nacimiento, sexo, escolaridad, aplicador, lugar);
        }
        public void Adicionar_Resultado(Resultado r)
        {
            r.Save();
        }
        #endregion

        #region [Usuarios]
        public bool agragar_Usuario(string login, string pass, Categoria_Usuario cat)
        {
            var usuario = new Usuario();
            return usuario.Insert(login, pass, cat);
        }
        public bool Eliminar_Usuario(string user)
        {
            if (this.User.Nombre == user)
                return false;
            var usuario = new Usuario();
            return usuario.Delete(user);
        }
        public bool cambiar_UserPass(string login, string passAnt, string newPass, string repNewPass)
        {
            var usuario = new Usuario();
            if (!usuario.Autenticate(login, passAnt))
                throw new Exception(Resources.MSG_AccessDenied);
            if (newPass != repNewPass)
                throw new Exception(Resources.MSG_CheckBothPassWD);
            return usuario.Update(login, newPass, usuario.Categoria);
        }
        public bool cambiar_UserCat(string login, Categoria_Usuario newCat)
        {
            if (this.User.Categoria == Categoria_Usuario.Aplicador)
                return false;
            var usuario = new Usuario();
            if(usuario.LoadByID(login) == 0)
                throw new Exception(Resources.MSG_Usuario_UserNotFoud);
            if (!usuario.Update(login, usuario.Password, newCat))
                throw new Exception(Resources.MSG_AccessDenied);
            return true;
        }
        internal List<UsuarioStruct> Listar_Usuarios()
        {
            var usuario = new Usuario();
            return usuario.Lista_Usuarios();
        }
        internal Categoria_Usuario categoria(string user)
        {
            var usuario = new Usuario();
            if (usuario.LoadByID(user) == 0)
                throw new Exception(Resources.MSG_CantFindUser);
            return usuario.Categoria;
        }
        #endregion           

        #region Private
        private void loadConfig()
        {
            if ( this.Configuracion == null )
            {
                var fi = new FileInfo( Resources.PATH_Config );
                if ( fi.Exists )
                {
                    IFormatter binaryFormatter = new BinaryFormatter();
                    var stream = new FileStream( Resources.PATH_Config, FileMode.Open );
                    this.Configuracion = (Config) binaryFormatter.Deserialize( stream );
                    stream.Close();
                }
                else
                    Configuracion = new Config();
            }
        }
        private void saveConfig()
        {
            IFormatter binaryFormatter = new BinaryFormatter();
            var stream = new FileStream( Resources.PATH_Config, FileMode.Create );
            binaryFormatter.Serialize( stream, this.Configuracion );
            stream.Close();
        }
        #endregion

        internal void ManageRunTest( Form mainForm, FormWithResultNUtils f2, int timeWait, bool hideCursor )
        {
            bool procede = true;
            if ( timeWait > 0 )
            {
                var p2b = new Prepare2Begin( timeWait );
                p2b.ShowDialog( mainForm );
                procede = p2b.Procede;
            }
            if ( procede )
            {
                if( hideCursor ) Cursor.Hide();
                f2.ShowDialog( mainForm );
                Adicionar_Resultado( f2.Resultado );
                if ( hideCursor ) Cursor.Show();
            }
        }

        public Resultado_AS ExtractResultFromPaciente()
        {
            if ( Paciente.Edad == FunctionLibrary.AgeFirstLevel )
            {
                foreach ( Resultado_AS r in Paciente.Resultados )
                    if ( r.TipoPrueba == TypeOf_AS_Test.H_Imagenes && r.TipoAtencion == TypeAS.Compleja )
                    {
                        return r;
                    }
            }
            if ( FunctionLibrary.InRange( Paciente.Edad, FunctionLibrary.AgeMinSecondLevel, FunctionLibrary.AgeMaxSecondLevel ) )
            {
                foreach ( Resultado_AS r in Paciente.Resultados )
                    if ( r.TipoPrueba == TypeOf_AS_Test.H_Letras && r.TipoAtencion == TypeAS.Compleja )
                    {
                        return r;
                    }
            }
            return null;
        }
    }
}
