using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImgSet
{
    public partial class Rango : Form
    {
        private int begin;
        private int end;
        private bool elm;

        public bool Eliminar
        {
            get { return elm; }        
        }
        public int Final
        {
            get { return end; }
        }
        public int Principio
        {
            get { return begin; }        
        }

        public Rango(int maximo)
        {
            InitializeComponent();
            elm = false;
            this.numericUpDownBegin.Maximum = new decimal(maximo);
            this.numericUpDownEnd.Maximum = new decimal(maximo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elm = true;
            this.begin = (int)numericUpDownBegin.Value;
            this.end = (int)numericUpDownEnd.Value;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            elm = false;
            this.Dispose();
        }
    }
}