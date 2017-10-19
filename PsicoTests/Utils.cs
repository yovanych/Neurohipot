using System;
using System.Media;
using System.Windows.Forms;
using DALayer;

namespace PsicoTests
{
    public interface IPrueba
    {
        void Stop();
        void Start();
        void click(int x, int y);
    }

    public interface IVistaPrevia
    {
        void Start();
        void Stop();
        void Paint(object sender, PaintEventArgs e);
    }

    public abstract class Prueba_Psicológica : Examen, IPrueba
	{
        protected Prueba_Psicológica(Resultado resultado)
		{
			this.Resultado = resultado;
		}
		public abstract void click(int x, int y);
		public abstract void Stop();
		public abstract void Start ();
	}

    public abstract class Ensayo_Prueba_Psicológica : IPrueba
    {
        public abstract void Stop();
        public abstract void Start();
        public abstract void click(int x, int y);
    }

    public class Examen 
    {
        public Resultado Resultado { get; set; }
    }

    public class FormWithResultNUtils : Form
    {
        public Resultado Resultado { get; set; }
        
        public FormWithResultNUtils()
        {
            initKeyPressPrevention();
        }

        #region (1) Key Press Prevention
        protected Timer timerKeyPressed;
        protected bool keyPressed;
        protected int timePresed;
        private int maxTimePressed;

        private void initKeyPressPrevention()
        {
            this.keyPressed = false;
            this.timePresed = 1;
            this.maxTimePressed = 3;
            this.timerKeyPressed = new Timer();
            this.timerKeyPressed.Tick += timerKeyPressed_Tick;
        }

        public void KeyHasBeenPressed()
        {
            if ( !this.keyPressed )
            {
                this.keyPressed = true;
                this.timePresed = 1;
                this.timerKeyPressed.Interval = 1000;
                this.timerKeyPressed.Start();
            }
        }

        protected void timerKeyPressed_Tick(object sender, EventArgs e)
        {
            if ( this.keyPressed && this.timerKeyPressed.Interval == 1000 )
            {
                if ( this.timePresed >= maxTimePressed )
                {
                    this.timerKeyPressed.Interval = 200;
                    SystemSounds.Beep.Play();
                }
                else timePresed++;
            }
            else if ( this.keyPressed && this.timerKeyPressed.Interval == 200 )
                SystemSounds.Beep.Play();
        }

        public void KeyHasBeenRelease()
        {
            this.keyPressed = false;
            this.timePresed = 1;
            this.timerKeyPressed.Stop();
        }
        #endregion
    }
}
