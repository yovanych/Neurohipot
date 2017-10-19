using System;
using System.Windows.Forms;
using PsicoTests.Alejandro;

namespace HerrmDiag.UserControls
{
    public partial class ConfParesVisualesAsociadosUC : UserControl
    {
        private Config conf;
        public Config Configuracion
        {
            set
            {
                this.conf = value;
                this.panelColor1.BackColor = conf.Colores_PVA[0];
                this.panelColor2.BackColor = conf.Colores_PVA[1];
                this.panelColor3.BackColor = conf.Colores_PVA[2];
                this.panelColor4.BackColor = conf.Colores_PVA[3];
                this.panelColor5.BackColor = conf.Colores_PVA[4];
                this.panelColor6.BackColor = conf.Colores_PVA[5];
                this.numericUpDown1.Value = new decimal( conf.Presentacion_PVA );
                this.numericUpDown2.Value = new decimal( conf.Muestra_PVA ); 
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
            conf.Colores_PVA = new[]{this.panelColor1.BackColor,this.panelColor2.BackColor,
                                  this.panelColor3.BackColor,this.panelColor4.BackColor,
                                  this.panelColor5.BackColor,this.panelColor6.BackColor};
            conf.Presentacion_PVA = (int)this.numericUpDown1.Value;
            conf.Muestra_PVA = (int)this.numericUpDown2.Value;

            if ( AfterAcept != null )
                AfterAcept( sender, e );
        }
        public event Clic_Delegate AfterPresets;
        private void Predeterminados_Click( object sender, EventArgs e )
        {
            this.panelColor1.BackColor = Pares_Visuales_Asociados.Pcolores[0];
            this.panelColor2.BackColor = Pares_Visuales_Asociados.Pcolores[1];
            this.panelColor3.BackColor = Pares_Visuales_Asociados.Pcolores[2];
            this.panelColor4.BackColor = Pares_Visuales_Asociados.Pcolores[3];
            this.panelColor5.BackColor = Pares_Visuales_Asociados.Pcolores[4];
            this.panelColor6.BackColor = Pares_Visuales_Asociados.Pcolores[5];
            this.numericUpDown1.Value = new decimal( Pares_Visuales_Asociados.Ppresentacion );
            this.numericUpDown2.Value = new decimal( Pares_Visuales_Asociados.Pmuestra );

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

        public ConfParesVisualesAsociadosUC()
        {
            InitializeComponent();
        }

        #region Eventos
        private void panelColor_Click( object sender, EventArgs e )
        {
            this.colorDialog.Color = ((Panel)sender).BackColor;
            colorDialog.ShowDialog( this );
            ((Panel)sender).BackColor = colorDialog.Color;
        }
        #endregion
    }
}
