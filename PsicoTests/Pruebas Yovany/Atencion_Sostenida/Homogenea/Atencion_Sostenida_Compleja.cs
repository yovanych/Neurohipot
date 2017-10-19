using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using DALayer;
using System.Linq;

namespace PsicoTests.Yovany.ASC.Homogeneas
{
    public class Atencion_Sostenida_Compleja : Prueba_Psicológica
    {
        #region Predeterminados
        public static int PBloques = 4;
        public static int PEstimulosBloque = 10;
        public static int PTiempoOcultamiento = 500;
        public static int PTiempoVisualizacion = 500;
        public static string PTeclaTarget = "[Espacio]";
        public static int PIndexDiana1 = 8;
        public static int PIndexDiana2 = 14;
        public static Color PColorFondo = Color.FromArgb(101,99, 102);
   
        #endregion

        #region Campos
        public int index, index1, bloques, estimulos, miliseg, count;
        public bool[] secuencia;
        public int[] secuencia_imagen;   ////annadir en ass miliseg, y activo
        public bool hide = true;
        public int[] omisiones;
        public int[] equivocaciones;
        public int[] aciertos;
        public int[] aciertos_ext;
        public double[] medias_tr;
        public double[] desviaciones_tr;
        public List<int> tiempos;
        public List<int>[] tiempos_tr;
        public bool activo;
        

        #endregion

        #region Constructores
        public Atencion_Sostenida_Compleja( Resultado r, int index, int index1, int bloques, int estimulos, int cantidad )
            : base(r)
        {
            this.tiempos = new List<int>();
            this.index = index;
            this.index1 = index1;
            this.bloques = bloques;
            this.estimulos = estimulos;
            Init_tiempos(bloques);
            secuencia = new bool[100 * bloques];
            omisiones = new int[bloques];
            equivocaciones = new int[bloques];
            aciertos = new int[bloques];
            secuencia_imagen = new int[100 * bloques];
            medias_tr = new double[bloques];
            desviaciones_tr = new double[bloques];
            aciertos_ext=new int[bloques];
            var rand = new Random(Environment.TickCount);
            ArrayList target;
            int x;
            for (int i = 0; i < bloques; i++)
            {
                target = new ArrayList();
                for (int j = 0; j < 99; j++)
                {
                    target.Add(j);
                }
                for (int k = 0; k < estimulos; k++)
                {
                    x = rand.Next(0, target.Count);
                    var y = (int)target[x];
                    secuencia[100 * i + y + 1] = true;
                    secuencia_imagen[100 * i + y] = index;
                    secuencia_imagen[100 * i + y + 1] = index1;
                    target.RemoveAt(x);
                    if (x < target.Count)
                    {
                        if ((int)target[x] == y + 1) target.RemoveAt(x);
                    }
                    if (x > 0)
                    {
                        if ((int)target[x - 1] == y - 1) target.RemoveAt(x - 1);
                    }
                }

            }

            if (secuencia[1] == false)
            {
                x = rand.Next(0, cantidad);
                this.secuencia_imagen[0] = x;
            }


            for (int i = 1; i < 100 * bloques - 1; i++)
            {
                if (secuencia[i + 1] == false && secuencia[i]==false)
                {
                    x = rand.Next(0, cantidad);

                    if (x == index1 && secuencia_imagen[i - 1] == index)
                        x = index1 < cantidad-1 ? rand.Next(index1 + 1, cantidad) : rand.Next(0, cantidad-1);
                    secuencia_imagen[i] = x;
                }
            }
            if (secuencia[100 * bloques - 1] == false)
            {
                x = rand.Next(0, cantidad);
                if (x == index1 && secuencia_imagen[100 * bloques - 2] == index)
                    x = index1 < cantidad-1 ? rand.Next(index1 + 1, cantidad) : rand.Next(0, cantidad-1);
                secuencia_imagen[100 * bloques - 1] = x;

            }
        }
        #endregion

        #region Metodos
        private void Init_tiempos(int cant)
        {
            tiempos_tr = new List<int>[bloques];
            for (int i = 0; i < bloques; i++)
            {
                tiempos_tr[i] = new List<int>();
            }
        }
        public void Calcula_estadistica()
        {
            for (int i = 0; i < bloques; i++)
            {
                double mediaux = media(tiempos_tr[i]);
                medias_tr[i] = mediaux;
                desviaciones_tr[i] = desv_est(tiempos_tr[i], mediaux);
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
            this.activo = false;
            if (x == 0) this.equivocaciones[(this.count - 1) / 100]++;
            else
            {
                int tiempo_reac = x - this.miliseg;
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
