namespace PsicoTests.Alejandro
{
    internal class Test_AM
    {
        public long[] hacia_delante, hacia_detras;

        internal int maximo_delante;
        internal int ptos_delante;
        internal int maximo_detras;
        internal int ptos_detras;
        private bool ambos_delante, ambos_detras;

        public Test_AM()
        {
            this.maximo_detras = 0;
            this.maximo_delante = 0;
            this.ptos_delante = 0;
            this.ptos_detras = 0;

            ambos_delante = false;
            ambos_detras = false;
            this.hacia_delante = new long[] { 582, 649, 6439, 7286, 42731, 75836, 619473, 392487, 5917428, 4179386, 58192647, 38293174, 275862584, 713542568 };
            this.hacia_detras = new long[] { 24, 58, 649, 415, 3279, 4968, 15286, 61843, 539418, 724856, 8129365, 4739128, 94376258, 72819653 };
        }
        public int diana(long n, bool a_delante, int ronda)
        {
            if (a_delante)
            {
                bool diana = hacia_delante[ronda] == n;
                if (!diana)
                    return 1;
                maximo_delante = ronda / 2 + 3;
                if ((ronda + 1) % 2 == 0)
                {
                    ptos_delante++;
                    ambos_delante = ptos_delante == 2;
                }
                else
                {
                    ptos_delante = 1;
                }
                return 0;
            }
            else
            {
                long numero = invierte(hacia_detras[ronda]);
                bool diana = numero == n;
                if (!diana)
                    return 1;
                maximo_detras = ronda / 2 + 2;
                if (ronda + 1 % 2 == 0)
                {
                    ptos_detras++;
                    ambos_detras = ptos_detras == 2;
                }
                else
                {
                    ptos_detras = 1;
                }
                return 0;
            }
        }
        
        private static long invierte(long l)
        {
            string n_aux = l.ToString();
            string n_res = "";
            for (int i = n_aux.Length - 1; i >= 0; i--)
                n_res += n_aux[i];
            return long.Parse(n_res);
        }

    }
}
