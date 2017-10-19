using System.Collections.Generic;
using System.Drawing;
using DALayer;

namespace PsicoTests.Yovany
{
    public class TiempoReaccionSimple
    {
        #region Predeterminados
        public static int PMaxEstimulos = 30;
        public static int PTiempoVisualizacion = 500;
        public static int PTiempoReaccion = 200;
        public static int PDiametro = 180;
        public static string PTecla1 = "[Espacio]";
        public static Color PColor1 = Color.White;
        public static TiempoReaccion.Figura PFigura = TiempoReaccion.Figura.Circulo;

        #endregion

        public List<int> tiempostiempo;
        public List<int> tiempospasado;
        public bool target;
        public bool hide = true;
        public int count = 0;
        public int milisec = 0;
        public Color color_target;
       
       
        
        public int omisiones;
        public int  estimulos, time, reaccion, reaccanti, visualizacion;

        public TiempoReaccionSimple(Resultado r,  Color color_target, int estimulos, int reaccion, int visualizacion)
        {
            this.visualizacion = visualizacion;
            this.reaccion = reaccion;
            this.estimulos = estimulos;
            tiempostiempo = new List<int>();
            tiempospasado = new List<int>();
            
            this.color_target = color_target;
      
        }        


        public void click(int x)
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
    
}

    

