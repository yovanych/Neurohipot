using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ImgSet;

namespace PsicoTests.Alejandro
{
    public class Vista_Previa_PVA : IVistaPrevia
    {
        private readonly Color[] colores;
        private const int presentacion = 2000;
        private const int muestra = 3000;
        private const int descanso = 500;

        private readonly Test_PVA[] tests;
        private readonly Thread th;
        private readonly Control control;
        private Test_PVA actual;
        private Estado_PVA estado;
        private int ronda;
        private readonly int[] orden_presentacion;


        public Vista_Previa_PVA(Control c, Color[] colores, ImageSet listaIMG)
        {
            this.colores = colores;
            orden_presentacion = new[] { 3, 2, 5, 0, 1, 4 };
            tests = new Test_PVA[3];
            cargar_imagenes(listaIMG);
            this.control = c;
            var ThSt = new ThreadStart(St);
            th = new Thread(ThSt);
            estado = Estado_PVA.Nulo;
            ronda = -1;
            this.control.Paint += this.Paint;
        }

        private void cargar_imagenes(ImageSet listaPVA)
        {
            var img = new Image[6];
            for (int j = 0; j < 6; j++)
            {
                img[j] = listaPVA[j + 7];
            }
            tests[0] = new Test_PVA(img, new[] { 2, 4, 1, 5, 0, 3 });
            tests[1] = new Test_PVA(img, new[] { 0, 1, 5, 3, 2, 4 });
            tests[2] = new Test_PVA(img, new[] { 4, 5, 3, 2, 0, 1 });
        }

        public void Start()
        {
            Graphics g = control.CreateGraphics();
            g.Clear(Color.DimGray);
            if (th.ThreadState == ThreadState.Unstarted)
            {
                th.Start();
            }
        }

        public void Stop()
        {
            Graphics g = this.control.CreateGraphics();
            g.Clear(Color.DimGray);
            this.th.Abort();
            ronda = -1;
            estado = Estado_PVA.Nulo;
        }

        private void St()
        {
            ronda = -1;
            int i = 0;
            while (true)
            {
                actual = tests[i];
                estado = Estado_PVA.Par;
                for (int k = 0; k < 6; k++)
                {
                    ronda++;
                    this.Paint(null, null);
                    Thread.Sleep(presentacion);
                }
                ronda = -1;
                estado = Estado_PVA.Seis;
                for (int k = 0; k < 6; k++)
                {
                    ronda++;
                    Paint(null, null);
                    Thread.Sleep(muestra);
                }
                estado = Estado_PVA.Descanso;
                Thread.Sleep(descanso);
                ronda = -1;
                i++;
                if (i >= 3)
                    i = 0;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            int W = this.control.Width;
            int H = this.control.Height;
            int a_f = W / 4;
            int a_c = 3 * W / 16;
            int b_f = H / 5;
            Graphics g = control.CreateGraphics();
            g.Clear(Color.DimGray);

            if (estado == Estado_PVA.Par)
            {
                g.DrawImage(actual.matriz[actual.orden_mostrar[ronda]], W / 8, 2 * H / 5, a_f, b_f);
                g.FillRectangle(new SolidBrush(colores[orden_presentacion[ronda]]), 5 * W / 8, 2 * H / 5, W / 4, H / 5);
                return;
            }
            if (estado == Estado_PVA.Seis)
            {
                g.DrawImage(actual.matriz[ronda], W / 8, 2 * H / 5, a_f, b_f);
                g.FillRectangle(new SolidBrush(colores[0]), W / 2, H / 10, a_c, H / 5);
                g.FillRectangle(new SolidBrush(colores[1]), 3 * W / 4, H / 10, a_c, H / 5);
                g.FillRectangle(new SolidBrush(colores[2]), W / 2, 4 * H / 10, a_c, H / 5);
                g.FillRectangle(new SolidBrush(colores[3]), 3 * W / 4, 4 * H / 10, a_c, H / 5);
                g.FillRectangle(new SolidBrush(colores[4]), W / 2, 7 * H / 10, a_c, H / 5);
                g.FillRectangle(new SolidBrush(colores[5]), 3 * W / 4, 7 * H / 10, a_c, H / 5);
            }

        }
    }	
}
