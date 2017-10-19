using System.Drawing;

namespace PsicoTests.Alejandro
{
    internal class Test_PVA
    {
        public Image[] matriz;
        public Color[] color;
        public int[] orden_mostrar;
        public int Aciertos;

        readonly bool[] Ass;
        readonly bool[] Err;

        public Test_PVA( Image[] matriz, int[] orden_mostrar )
            : this( matriz, orden_mostrar, new[] { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Violet, Color.Cyan } )
        { }
        public Test_PVA( Image[] matriz, int[] orden_mostrar, Color[] colores )
        {
            this.matriz = matriz;
            this.orden_mostrar = orden_mostrar;
            Aciertos = 0;
            Ass = new bool[6];
            Err = new bool[6];
            color = new[]{colores[3],colores[0], 
		                                   colores[5], colores[1],
										 colores[2],colores[4]};
        }


        public bool diana( Color c, int ronda )
        {
            //int indice = 2*fila + columna;			
            if ( c == color[ronda] )
            {
                if ( !Ass[ronda] && !Err[ronda] )
                {
                    Ass[ronda] = true;
                    //if(!ya)
                    Aciertos++;
                }
                return true;
            }
            Err[ronda] = true;
            return false;
        }
    }
}
