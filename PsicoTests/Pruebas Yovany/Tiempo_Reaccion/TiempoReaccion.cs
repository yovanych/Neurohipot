using System.Collections.Generic;
using System.Drawing;
using DALayer;


namespace PsicoTests.Yovany
{
    /// <summary>
    /// Summary description for ASS.
    /// </summary>
    public class TiempoReaccion : Prueba_Psicológica
    {
        public enum Figura { Circulo, Cuadrado, Triangulo }

        #region Predeterminados
        public static int PMaxEstimulos = 30;
        public static int PTiempoVisualizacion = 500;
        public static int PTiempoReaccion = 200;
        public static Figura PFigura = Figura.Circulo;
        public static string PTecla1 = "[Espacio]";
        public static string PTecla2 = "[Enter]";
        public static Color PColor1 = Color.Yellow;
        public static Color PColor2 = Color.Blue;

        #endregion

        public List<int> tiempostiempo, tiempospasado;
        public bool hide = true;
        public int count = 0;
        public int milisec = 0;
        public Color color_target, color_target1;
       
       
        public Color[] secuencia_color;
        public int omisiones;
        public int equivocaciones;
        public int visualizacion, reaccion,  estimulos, reaccanti, time, color_activo;

        public TiempoReaccion(Resultado r, Color color_target, Color color_target1, int estimulos, int visualizacion, int reaccion)
            : base(r)
        {           
            this.estimulos = estimulos;
            this.tiempostiempo = new List<int>();
            tiempospasado = new List<int>();
            this.visualizacion = visualizacion;
            this.estimulos = estimulos;
            this.reaccion = reaccion;
            this.color_target = color_target;
            this.color_target1 = color_target1;
        }

        

        public override void Start()
        { }

        public override void Stop()
        { }

        public  override void click(int x, int y)
        {
            if (y + this.color_activo == 1)//si se equivoco al marcar
            {
                if (this.hide)
                {
                    if (time == 0) this.reaccanti++;
                    else
                    {
                        this.equivocaciones++;
                        this.time = 0;
                    }
                }
                else
                {
                    if ((time > 0) && (x - this.time > this.reaccion))
                    {
                        this.equivocaciones++;
                        this.time = 0;
                    }
                    else this.reaccanti++;
                }
                            
              

            }
            else  // si marco consecuentemente
            {
                if (this.hide)
                {
                    if (time == 0) this.reaccanti++;
                    else
                    {
                        this.tiempospasado.Add(x - this.time);
                        this.time = 0;
                    }
                }
                else
                {
                    if (this.time != 0)
                    {
                        int temp = x - this.time;
                        if (temp < this.reaccion)
                            this.reaccanti++;
                        else this.tiempostiempo.Add(temp);
                        this.time = 0;
                    }
                }
            }
        }
        public void click1(int x, int y)
        { 
        
        }
        
    }

    
}
