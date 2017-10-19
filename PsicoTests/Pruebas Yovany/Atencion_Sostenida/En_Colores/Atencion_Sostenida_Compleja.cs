using System;
using System.Collections;
using System.Collections.Generic;
using DALayer;

namespace PsicoTests.Yovany.ASC.Colores
{
    public class Atencion_Sostenida_Compleja : Prueba_Psicológica
    {
        #region Predeterminados
        public static int PBloques = 7;
        public static int PEstimulosBloque = 10;
        public static int PTiempoOcultamiento = 500;
        public static int PTiempoVisualizacion = 500;
        public static string PTeclaTarget = "[Espacio]";
        public static int PIndexDiana1 = 1;
        public static int PIndexDiana2 = 1;

        #endregion

        public int index, index1, bloques, estimulos, miliseg, count;
        public bool[] secuencia;
        public int[] secuencia_imagen;   ////annadir en ass miliseg, y activo
        public bool hide = true;
        public int[] omisiones;
        public int[] equivocaciones;
        public int[] aciertos;
        public List<int> tiempos;
        public bool activo;

        public Atencion_Sostenida_Compleja(Resultado r, int index, int index1, int bloques, int estimulos)
            : base(r)
        {
            this.tiempos = new List<int>();
            this.index = index;
            this.index1 = index1;
            this.bloques = bloques;
            this.estimulos = estimulos;
            secuencia = new bool[100 * bloques];
            omisiones = new int[bloques];
            equivocaciones = new int[bloques];
            aciertos = new int[bloques];
            secuencia_imagen = new int[100 * bloques];
            var rand = new Random(Environment.TickCount);
            var target = new ArrayList();
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
                x = rand.Next(0, 27);
                this.secuencia_imagen[0] = x;
            }


            for (int i = 1; i < 100 * bloques - 1; i++)
            {
                if (secuencia[i + 1] == false && secuencia[i]==false)
                {
                    x = rand.Next(0, 27);

                    if (x == index1 && secuencia_imagen[i - 1] == index)
                        x = index1 < 26 ? rand.Next(index1 + 1, 27) : rand.Next(0, 26);
                    secuencia_imagen[i] = x;
                }
            }
            if (secuencia[100 * bloques - 1] == false)
            {
                x = rand.Next(0, 27);
                if (x == index1 && secuencia_imagen[100 * bloques - 2] == index)
                    x = index1 < 26 ? rand.Next(index1 + 1, 27) : rand.Next(0, 26);
                secuencia_imagen[100 * bloques - 1] = x;

            }
        }
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
                tiempos.Add(x - this.miliseg);
                this.aciertos[(this.count - 1) / 100]++;
                this.miliseg = 0;
            }
        }
	}
    
}
