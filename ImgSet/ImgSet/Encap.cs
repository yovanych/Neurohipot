using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ImgSet
{
    partial class Encap : Form
    {
        readonly ImageSet listaImagenes;
        public Encap()
        {
            InitializeComponent();
            listaImagenes = new ImageSet();
        }
        
        #region Eventos
        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (this.listaImagenes.Count == 0)
                return;
            this.listaImagenes.RemoveAt((int)this.nud.Value);
            RefreshStatus();
        }
        private void bEliminarVarias_Click(object sender, EventArgs e)
        {
            var r = new Rango(this.listaImagenes.Count - 1);
            r.ShowDialog(this);
            if (r.Eliminar)
                listaImagenes.Remove(r.Principio, r.Final);
            RefreshStatus();
        }
        private void bCargarCapsula_Click(object sender, EventArgs e)
        {
            this.openFileCapsula.ShowDialog(this);
        }
        private void bCargarImágenes_Click(object sender, EventArgs e)
        {
            this.openFileImagenes.ShowDialog(this);
        }
        private void bBrowse_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog(this);
            this.tbPath.Text = this.folderBrowserDialog.SelectedPath;
        }
        private void numericUpDownEj_ValueChanged(object sender, EventArgs e)
        {
            Image img = this.listaImagenes[(int)nud.Value];
            this.pictureBoxEj.Image = img;
        }
        private void openFileImagenes_FileOk(object sender, CancelEventArgs e)
        {
            string[] paths = this.openFileImagenes.FileNames;
            foreach (string t in paths)
            {
                Image img = Image.FromFile(t);
                listaImagenes.Add(img);
            }
            RefreshStatus();
        }
        private void openFileCapsula_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void bEncapsular_Click(object sender, EventArgs e)
        {
            if (this.tbPath.Text.Trim().Equals(string.Empty))
                return;
            IFormatter binaryFormatter = new BinaryFormatter();
            Stream stream = null;
            string name = this.tbPath.Text + "\\";
            switch (this.cbPrueba.SelectedIndex)
            {
                case 0:
                    switch (this.cbTipoImagen.SelectedIndex)
                    {
                        case 0:
                            name += "ImgASS_IMG.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                        case 1:
                            name += "ImgASS_FIG.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                        case 2:
                            name += "ImgASS_LET.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                    }
                    break;
                case 1:
                    switch (this.cbTipoImagen.SelectedIndex)
                    {
                        case 0:
                            name += "ImgASC_IMG.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                        case 1:
                            name += "ImgASC_FIG.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                        case 2:
                            name += "ImgASC_LET.ips";
                            stream = new FileStream(name, FileMode.Create);
                            binaryFormatter.Serialize(stream, this.listaImagenes);
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (stream != null) stream.Close();
        }
        #endregion
        
        private void RefreshStatus()
        {
            this.nud.Minimum = 0;
            this.nud.Maximum = this.listaImagenes.Count - 1;
            this.pictureBoxEj.Image = this.listaImagenes[(int)this.nud.Value];
        }
    }
}