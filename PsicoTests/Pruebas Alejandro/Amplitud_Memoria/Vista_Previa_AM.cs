using System;
using System.Windows.Forms;
using DALayer;

namespace PsicoTests.Alejandro
{
    public class Vista_Previa_AM : IVistaPrevia
    {
        #region Campos
        readonly long[] hacia_delante;
        readonly long[] hacia_detras;

        public Label label;
        public TextBox box;
        public Resultado r;
        public Timer t1, t2;

        readonly Control c;

        private int ronda, char_;
        private bool adelante, en_Curso;
        #endregion

        public Vista_Previa_AM(Control c)
        {
            this.c = c;
            hacia_delante = new long[] { 352, 140, 4532, 8233, 92936, 75736 };
            hacia_detras = new long[] { 25, 68, 749, 315, 1274, 2948 };
            t1 = new Timer {Interval = 300};
            t2 = new Timer {Interval = 1};
            t1.Tick += t1_tick;
            t2.Tick += t2_tick;
            this.char_ = 0;
            ronda = 0;
            adelante = true;
            en_Curso = true;

            int y = (c.Height) / 2;

            this.label = new Label();
            this.box = new TextBox();
            float fpt = c.Width / 20.4f;
            int xL = (c.Width - label.Width) / 2 + 10;
            int xB = (c.Width - box.Width) / 2 + 10;
            var largo_label_box = (int)(c.Width / 2.6);
            var ancho_label = c.Height / 7 + 10;
            var ancho_box = (int)(c.Height / 9.2 + 10);

            #region LABEL
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", fpt + 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(largo_label_box, ancho_label);
            this.label.Location = new System.Drawing.Point(xL, y - box.Height - 20);
            this.label.TabIndex = 0;
            this.label.Text = "";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            c.Controls.Add(this.label);
            #endregion

            #region BOX
            this.box.BackColor = System.Drawing.SystemColors.Control;
            this.box.BorderStyle = BorderStyle.FixedSingle;
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", fpt, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.box.Size = new System.Drawing.Size(largo_label_box, ancho_box);
            this.box.Location = new System.Drawing.Point(xB, y);
            this.box.Name = "box";
            this.box.TabIndex = 1;
            this.box.Text = "";
            this.box.TextAlign = HorizontalAlignment.Center;
            this.box.Visible = false;
            this.c.Controls.Add(this.box);
            this.c.Paint += Paint;
            #endregion
        }

        private void t2_tick(object sender, EventArgs e)
        {
            if (t2.Interval == 1)
            {
                this.box.Text = "";
                this.box.Visible = true;
                //this.box.Focus();
                t2.Interval = 5000;
            }
            else
                if (t2.Interval == 5000)
                {
                    this.box.Visible = false;
                    this.t2.Interval = 1;
                    this.t2.Stop();
                    //this.label.Parent.Focus();                
                    ronda++;
                    this.Start();
                    if (adelante)
                    {
                        if (ronda == hacia_delante.Length)
                        {
                            adelante = false;
                            ronda = 0;
                        }
                    }
                    else
                    {
                        if (ronda == hacia_detras.Length)
                        {
                            adelante = true;
                            ronda = 0;
                        }
                    }
                }
        }

        private void t1_tick(object sender, EventArgs e)
        {
            string s = adelante ? (hacia_delante[ronda].ToString()) : (hacia_detras[ronda].ToString());

            if (this.t1.Interval == 300)
            {
                this.t1.Interval = 700;
                this.label.Visible = true;
                this.label.Text = "" + s[char_++];
            }
            else
                if (this.t1.Interval == 700)
                {
                    this.label.Visible = false;
                    this.t1.Interval = 300;
                    if (char_ == s.Length)
                    {
                        t1.Stop();
                        t2.Start();
                        char_ = 0;
                    }
                }
        }

        public void Stop()
        {
            this.t1.Stop();
            this.t2.Stop();
            en_Curso = true;
            this.ronda = 0;
            this.adelante = true;
            c.Controls.Clear();
        }

        public void Start()
        {
            if (en_Curso)
            {
                this.box.Visible = false;
                this.label.Text = "";
                t1.Start();
            }
        }

        public bool En_Curso
        {
            get
            {
                return en_Curso;
            }
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            //this.c.BackColor = Color.FromArgb(255, 235, 217);
        }

    }
}
