using System.Drawing;

namespace PsicoTests.Alejandro
{
    public class Test_MF
    {
        public Image[] matriz;
        public int[] indices;
        public int Aciertos, Omisiones, Errores;
        private int cont;

        private readonly int[] Ass;

        public Test_MF( Image[] matriz, int[] indices )
        {
            this.matriz = matriz;
            this.indices = indices;
            Ass = new int[3];
            Aciertos = 0;
            Omisiones = 0;
            Errores = 0;
            this.cont = 0;
        }
        public bool diana( int fila, int columna )
        {
            int indice = 3 * fila + columna;

            cont++;
            if ( indice == indices[0] )
            {
                if ( Ass[0] == 0 && cont <= 3 )
                {
                    Ass[0]++;
                    Aciertos++;
                }
                return true;
            }
            if ( indice == indices[1] )
            {
                if ( Ass[1] == 0 && cont <= 3 )
                {
                    Ass[1]++;
                    Aciertos++;
                }
                return true;
            }
            if ( indice == indices[2] )
            {
                if ( Ass[2] == 0 && cont <= 3 )
                {
                    Ass[2]++;
                    Aciertos++;
                }
                return true;
            }
            if ( Errores + Aciertos < 3 && cont <= 3 )
                Errores++;
            return false;
        }
        public void fin_test()
        {
            Omisiones = 3 - Aciertos - Errores;
        }
    }
}
