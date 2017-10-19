using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class GenCod : Form
    {
        private string prefijo;
        public GenCod(ArrayList pacientes)
        {
            InitializeComponent();
            this.progressBar1.Maximum = pacientes.Count + 3;
            this.progressBar1.Value = 0;
            var mayor = (string)pacientes[0];
            foreach (string cod in pacientes)
            {
                if (cod.CompareTo(mayor) > 0)
                    mayor = cod;
                this.progressBar1.Value ++;
            }
            //long numero = numeracion(mayor);
            this.progressBar1.Value++;          //1

            prefijo = prefix(mayor);
            this.progressBar1.Value++;          //2
            
            this.numericUpDown1.Value = 0;
            this.numericUpDown1.Minimum = 0;
            this.numericUpDown1.Maximum = 200000000;

            this.textBox1.Text = prefijo;
            this.progressBar1.Value++;          //3
            this.labelEstado.Text = Resources.MSG_Done;
            this.button1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if ((e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int a = this.textBox1.Text.CompareTo(prefijo);
            this.button1.Enabled = a >= 0;
        }

        private string prefix(IEnumerable<char> s)
        {
            string pr = s.Where(c => c >= 65 && c <= 90).Aggregate("", (current, c) => current + c.ToString());
            this.prefijo = pr;
            char final = pr[pr.Length - 1];
            string ant = pr.Substring(0, pr.Length -1);
            if (final == 90)
            {
                pr = ant + "AA";
            }
            else
                pr = ant + ((char)(final + 1));
            return pr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}