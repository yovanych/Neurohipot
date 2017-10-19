namespace PsicoTests.Yovany
{
	/// <summary>
	/// Summary description for Recuerdo_Libre.
	/// </summary>
	public class Recuerdo_Libre : IPrueba
	{
       
        #region Predeterminados
        public static int PTiempoVisualizacion1 = 1500;
        public static int PTiempoOcultamiento1 = 1000;
        public static int PTiempoVisualizacion15 = 60000;
        public static int PTiempoVisualizacion2 = 1500;
        public static int PTiempoOcultamiento2 = 1000;
        public static string PCorrecta = "[Enter]";
        public static string PIncorrecta = "[Espacio]";
        #endregion

		public string [] memorizar;
		public string [] distractoras;
		public bool [] esta; 
		public bool flag = false;
		public int recordadas1;
		public int recordadas2;
		public int aciertos;
		public int errores;
		public int omisiones;
		public int count1;
		public int count2;
		public int fase;
		public System.Windows.Forms.Timer control;
		public Recuerdo_Libre(System.Windows.Forms.Timer control)
		{
			fase = 1;
            this.count1 = 0;
            this.count2 = 0;
			this.control = control;
			memorizar = new[]{"sombra","correr","rojo","estrella","descansar",
									"suave","silla","tapa","caliente","tijera","escribir",
									"grande","tapiz","pagar","intenso"};
			distractoras = new[]{"cuchara","luna","grande","arbusto","estrella",
										"silla","tapiz","carro","tejado","cocinar","sombra",
										"leer","tapa","descansar","intenso","embarcar",
										"correr","echar","pagar","caliente","trabajar",
										"cómodo","escribir","suave","torpe",
										"sencillo","fácil","difícil","rojo","tijera"};
			esta = new[]{false, false, true, false, true, true, true, false, false, 
								false, true, false, true, true, true, false, true, false,
								true, true, false, false, true, true, false, false, false,
								false, true, true};

		}

		public void Start()
		{
			control.Start();
		}
        public void Stop()
        { }

        public void click(int x, int y)
        { }
		public bool pertenece (int x)
		{
			return esta[x];
		}
	}

    
}
