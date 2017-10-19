using System.Drawing;

namespace PsicoTests.Alejandro
{
    public class Test_Ejemplo_MF
    {
        public Image[] matriz;
        public int indice;

        public Test_Ejemplo_MF( Image[] matriz, int indice )
        {
            this.matriz = matriz;
            this.indice = indice;
        }
        public bool diana( int columna )
        {
            return columna == indice;
        }
    }
}
