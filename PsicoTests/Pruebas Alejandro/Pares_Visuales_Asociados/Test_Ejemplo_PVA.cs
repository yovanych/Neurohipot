using System.Drawing;

namespace PsicoTests.Alejandro
{
    internal class Test_Ejemplo_PVA
    {
        public Image[] matriz;
        public int[] color;

        public Test_Ejemplo_PVA( Image[] matriz, int[] colores )
        {
            this.matriz = matriz;
            color = colores;
        }
        public bool diana( int fila, int ronda )
        {
            return (fila == color[ronda]);
        }
    }
}
