using System;
using System.ComponentModel;
using System.Windows.Forms;
using DALayer;
using HerrmDiag.Properties;

namespace HerrmDiag.Formularios.CommonForms
{
    public partial class EditResults : Form
    {
        private readonly Paciente p;
        public EditResults(Paciente p, Usuario u)
        {
            InitializeComponent();

            this.p = p;
            if (u.Categoria == Categoria_Usuario.Aplicador)
            {
                //this.eliminarToolStripMenuItem.Enabled = false;
            }
            
            this.textBoxNombre.Text = p.Nombre;
            this.textBoxApellido1.Text = p.Apellido1;
            this.textBoxApellido2.Text = p.Apellido2;
            this.textBoxCodigo.Text = p.Codigo;
            this.Text = string.Format( "{0} [{1}]", Resources.TITLE_Results, p.Codigo );
            foreach (Resultado r in p.Resultados)
            {
                var i = new ListViewItem();                
                i.SubItems.Add(r.ToString());
                i.SubItems.Add(r.Fecha.ToString());
                //switch (r.Tipo)
                //{
                //    case Resultado.ResultType.AM:
                //        i.Group = this.listView1.Groups["AM"];
                //        break;
                //    case Resultado.ResultType.MF:
                //        i.Group = this.listView1.Groups["MF"];
                //        break;
                //    case Resultado.ResultType.PVA2:
                //    case Resultado.ResultType.PVA:
                //        i.Group = this.listView1.Groups["PVA"];
                //        break;
                //    case Resultado.ResultType.ASS:
                //        i.Group = this.listView1.Groups["ASS"];
                //        break;
                //    case Resultado.ResultType.ASC:
                //        i.Group = this.listView1.Groups["ASC"];
                //        break;
                //    case Resultado.ResultType.RL:
                //        i.Group = this.listView1.Groups["RL"];
                //        break;
                //    case Resultado.ResultType.ET:
                //        i.Group = this.listView1.Groups["ET"];
                //        break;
                //    case Resultado.ResultType.TRS:
                //        i.Group = this.listView1.Groups["TRS"];
                //        break;
                //    case Resultado.ResultType.TRC:
                //        i.Group = this.listView1.Groups["TRC"];
                //        break;
                //}
                i.Group = this.listView1.Groups[r.Tipo.ToString()];
                this.listView1.Items.Add(i);
            }
        }

        public override sealed string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int r = this.listView1.SelectedIndices[0];
                this.propertyGrid.SelectedObject = p.Resultados[r];
            }
            else
            {
                this.propertyGrid.SelectedObject = null;
            }
        }

        private void mostrarPorGuposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.mostrarPorGuposToolStripMenuItem.Checked)
            {
                this.mostrarPorGuposToolStripMenuItem.Checked = false;
                this.listView1.ShowGroups = false;
            }
            else 
            {
                this.mostrarPorGuposToolStripMenuItem.Checked = true;
                this.listView1.ShowGroups = true;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

/*
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count != 0)
            {
                int pos = this.listView1.SelectedIndices[0];
                this.listView1.Items.Remove(listView1.SelectedItems[0]);
                this.p.Resultados.RemoveAt(pos);
                this.propertyGrid.SelectedObject = null;
            }
        }
*/

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //this.eliminarToolStripMenuItem.Enabled = (this.listView1.SelectedItems.Count != 0);
        }        

    }
}