using System;
using System.Windows.Forms;
using PsicoTests.Alejandro;

namespace HerrmDiag.UserControls
{
    public partial class ConfMemoriaFigurasUC : UserControl
    {
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.numericUpDown1.Value = conf.Presentacion_MF;
                this.numericUpDown2.Value = conf.Muestra_MF;
            }
            get { return conf; }
        }

        #region Propiedades
        public bool ShowCancelButton
        {
            set { this.bCancelar.Visible = value; }
            get { return this.bCancelar.Visible; }
        }
        #endregion

        #region Eventos publicos
        public delegate void Clic_Delegate( object sender, EventArgs e );
        public event Clic_Delegate AfterAcept;
        private void Aceptar_Click( object sender, EventArgs e )
        {
            conf.Presentacion_MF = (int)this.numericUpDown1.Value;
            conf.Muestra_MF = (int)this.numericUpDown2.Value;

            if ( AfterAcept != null )
                AfterAcept( sender, e );
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click( object sender, EventArgs e )
        {
            this.numericUpDown1.Value = Memoria_Figuras.Ppresentacion;
            this.numericUpDown2.Value = Memoria_Figuras.Pmuestra;

            if ( AfterPresets != null )
                AfterPresets( sender, e );
        }
        public event Clic_Delegate AfterCancel;
        private void Cancel_Click( object sender, EventArgs e )
        {
            if ( AfterCancel != null )
                AfterCancel( sender, e );
        }
        #endregion

        public ConfMemoriaFigurasUC()
        {
            InitializeComponent();
        }

    }
}
