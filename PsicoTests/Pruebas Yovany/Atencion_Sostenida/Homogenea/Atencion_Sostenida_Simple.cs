using System;
using System.Collections.Generic;
using System.Drawing;
using DALayer;
using System.Linq;

namespace PsicoTests.Yovany.ASS.Homogeneas
{
	public class Atencion_Sostenida_Simple : Prueba_Psicológica
	{

        #region Predeterminados
        public static int PBloques = 7;
        public static int PEstimulosBloque = 10;
        public static int PTiempoOcultamiento = 500;
        public static int PTiempoVisualizacion = 500;
        public static string PTeclaTarget = "[Espacio]";
        public static int PIndexDiana = 8;
        public static Color PColorFondo = Color.FromArgb(101, 99, 102);
       
        #endregion

        #region Campos
        public List<int> tiempos;
        public List<int>[] tiempos_tr;
		public bool hide = true;
        public bool activo;
        public bool[] secuencia;
		public int count;
		public int milisec;
		public int[] secuencia_imagen;
		
		public int[] omisiones;
		public int[] equivocaciones;
		public int[] aciertos;
        public int[] aciertos_ext;
        public double[] medias_tr;
        public double[] desviaciones_tr;
        public int bloques, estimulos, index, miliseg;
        #endregion

        #region Constructores
        public Atencion_Sostenida_Simple( Resultado r, int index, int bloques, int estimulos, int cantidad )
            :base(r)
		{
            this.bloques = bloques;
            this.estimulos = estimulos;
			tiempos = new List<int>();
            Init_tiempos(bloques);
			omisiones = new int[bloques];
			equivocaciones = new int[bloques];
			aciertos = new int[bloques];
            aciertos_ext = new int[bloques];
            medias_tr = new double[bloques];
            desviaciones_tr=new double[bloques];
            secuencia_imagen = new int[100*bloques];
            secuencia = new bool[100 * bloques];
            this.index = index;
			var rand = new Random(Environment.TickCount);
			int s;
            var numeros = new int[100];

            for (int i = 0; i < 100 * bloques; i++)
            {
                s = rand.Next(0, cantidad);
                if (s == index) 
                {
                    s = index == cantidad - 1 ? rand.Next(0, cantidad - 1) : rand.Next(index + 1, cantidad);                        
                }
                secuencia_imagen[i] = s;
            }

            //Ubica de forma aleatoria la imagen diana
			for(int i=0; i<bloques; i++)
			{
                for (int k = 0; k < 100; k++)
                { 
                  numeros[k]=k;
                }
				for(int j=0; j<estimulos; j++)
				{
					s = rand.Next(0,100 - j);

                    secuencia_imagen[100 * i + numeros[s]] = index;
                    secuencia[100 * i + numeros[s]] = true;
                    int aux = numeros[s];
                    numeros[s] = numeros[99 - j];
                    numeros[99 - j] = aux;				
				}				
			}
            
		}

	    #endregion

        #region Metodos
        private void Init_tiempos(int cant)
        {
            tiempos_tr = new List<int>[bloques];
            for (int i = 0; i < bloques; i++)
            {
                tiempos_tr[i]=new List<int>();
            }
        }
        public void Calcula_estadistica ()
        {
            double mediaux;
            for (int i = 0; i < bloques; i++)
            {
                mediaux = media(tiempos_tr[i]);
                medias_tr[i] = mediaux;
                desviaciones_tr[i] = desv_est(tiempos_tr[i],mediaux);
            }
            
        }
        private static double media(ICollection<int> tiempos)
        {
            if (tiempos.Count == 0) return 0;
            double s = 0;
            s += tiempos.Sum();
            return s / tiempos.Count;
        }
        private static double desv_est(ICollection<int> tiempos, double media)
        {
            if (tiempos.Count == 0) return 0;
            double f = tiempos.Sum(t => Math.Pow(t - media, 2));
            return Math.Sqrt(f / tiempos.Count);
        }
        #endregion

        #region Override
        public override void Start()
        { }

        public override void Stop() 
        { }

		public override void click(int x, int y)
		{
            int tiempo_reac;
            this.activo = false;
            if (x == 0) this.equivocaciones[(this.count - 1) / 100]++;
            else
            {
                tiempo_reac = x - this.miliseg;
                this.miliseg = 0;
                if (tiempo_reac < 100)
                {
                    this.aciertos_ext[(this.count - 1) / 100]++;
                }
                else
                {
                    tiempos.Add(tiempo_reac);
                    tiempos_tr[(this.count - 1) / 100].Add(tiempo_reac);
                    this.aciertos[(this.count - 1) / 100]++;
                }
            }
        }
        #endregion
    }

    
}
