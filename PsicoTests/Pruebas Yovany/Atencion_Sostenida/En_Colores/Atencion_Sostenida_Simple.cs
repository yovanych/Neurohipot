using System;
using System.Collections.Generic;
using System.Drawing;
using DALayer;

namespace PsicoTests.Yovany.ASS.Colores
{
	/// <summary>
	/// Summary description for ASS.
	/// </summary>
	public class Atencion_Sostenida_Simple : Prueba_Psicológica
	{

        #region Predeterminados
        public static int PBloques = 7;
        public static int PEstimulosBloque = 10;
        public static int PTiempoOcultamiento = 500;
        public static int PTiempoVisualizacion = 500;
        public static string PTeclaTarget = "[Espacio]";
        public static Color PColorDiana = Color.Yellow;
        //public static string PLetraDiana = "A";
        public static int PLetraDiana = 0;
        public static Color PColorFondo = Color.FromArgb(101, 99, 102);
       
        #endregion

        public bool[] secuencia;
		public List<int> tiempos;
		public bool hide = true;
        public bool activo;
        public int miliseg;
		public int count = 0;
		public int milisec = 0;
		public Color color_target;
		public string letra_target;
		public string[] letras;
		public string[] secuencia_letra;
		public Color[] secuencia_color;
		public int[] omisiones;
		public int[] equivocaciones;
		public int[] aciertos;
        int bloques, estimulos;

        public Atencion_Sostenida_Simple(Resultado r, string letra_target, Color color_target, int bloques, int estimulos)
            :base(r)
		{
            
            this.bloques = bloques;
            this.estimulos = estimulos;
            tiempos = new List<int>();
			omisiones = new int[bloques];
			equivocaciones = new int[bloques];
			aciertos = new int[bloques];
			this.color_target = color_target;              
			this.letra_target = letra_target;
			secuencia_letra = new string[100*bloques];
			secuencia_color = new Color[100*bloques];
            secuencia = new bool[100*bloques];

			letras = new[]{"A", "B", "C", "D", "E", "F", "G",
									 "H", "I", "J", "K", "L", "M", "N",
									 "O", "P", "Q", "R", "S", "T", "U",
									 "V", "W", "X", "Y", "Z"};
			var color = new[]{Color.Yellow, Color.Blue, Color.Green, Color.Red};
			
			var rand = new Random(Environment.TickCount);

            for(int i=0; i<bloques; i++)
			{
				for(int j=0; j<estimulos; j++)
				{
					int s = rand.Next(0,100);

					//Un pequeño parche para que trabaje la aleatorización
					if(s>50)
						while(secuencia_color[100*i + s]==color_target)
						{
							s--;
						}
					else
						while(secuencia_color[100*i + s]==color_target)
						{
							s++;
						}
					//termina aquí el parche

					secuencia_letra[100*i + s] = letra_target;
					secuencia_color[100*i + s] = color_target;
                    secuencia[100 * i + s] = true;
					
				}
				
			}
			for(int k=0; k<100*bloques; k++)
			{
				if(secuencia_letra[k] != letra_target)
				{
					int x = rand.Next(0,letras.Length);									
					int y = rand.Next(0,color.Length);
					if(letras[x]==this.letra_target)
						if(color[y]==this.color_target)
						{
							y = y < this.secuencia_color.Length-1 ? rand.Next(y+1,color.Length) : rand.Next(0,y);
						}
					
					secuencia_letra[k]=letras[x];	
                    secuencia_color[k]=color[y];
				}
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
