using System;
using System.Windows.Forms;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class Prepare2Begin : Form
    {
        private int time;
        public bool Procede { get; set; }

        public Prepare2Begin( int timeWait )
        {
            InitializeComponent();
            Procede = false;
            this.time = timeWait;
            updateTime();
        }

        private void buttonClose_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void Prepare2Begin_Load( object sender, EventArgs e )
        {
            this.buttonClose.Focus();
            this.timer.Start();
        }

        private void timer_Tick( object sender, EventArgs e )
        {
            if ( this.time <= 0 )
            {
                this.timer.Stop();
                this.Procede = true;
                this.Close();
            }
            updateTime();
            time--;
            this.buttonClose.Focus();
        }

        private void updateTime()
        {
            this.Text = string.Format( "{0} seg.", time );
            this.buttonBegin.Text = string.Format( "Comenzar ... {0} seg.", time );
        }

        private void buttonBegin_Click( object sender, EventArgs e )
        {
            this.Procede = true;
            this.Close();
        }
    }
}
