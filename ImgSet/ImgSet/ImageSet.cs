using System;
using System.Collections.Generic;
using System.Drawing;

namespace ImgSet
{
    [Serializable]
    public class ImageSet
    {

        public int Count
        {
            get { return Imagenes.Count; }            
        }

        public List<Image> Imagenes { get; set; }

        public ImageSet()
        {
            Imagenes = new List<Image>();
        }
        ///// <summary>
        ///// Carga las imágenes del disco duro. Estas deben ser JPG y los nombres '1.jpg' hasta 'n.jpg'
        ///// </summary>
        ///// <param name="path">Dirección de donde se cargarán las imágenes</param>
        //public void Load(string path, int cantidad)
        //{
        //    try
        //    {
        //        for (int i = 0; i < cantidad; i++)
        //            lista.Add(Image.FromFile(path + (i + 1).ToString() + ".jpg"));
        //    }
        //    catch (Exception)
        //    {
        //        throw new InvalidOperationException("Error en la carga de imágenes");
        //    }
        //}

        public void Add(Image img)
        {
            Imagenes.Add(img);
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < this.Imagenes.Count)
                Imagenes.RemoveAt(index);
            else
                throw new InvalidOperationException("Intenta acceder a una imagen que no existe");
        }

        public void Remove(int begin, int end)
        {
            if (begin >= 0 && begin < this.Imagenes.Count && end >= 0 && end < this.Imagenes.Count)
                Imagenes.RemoveRange(begin, end - begin);
            else
                throw new InvalidOperationException("Rango incorrecto");
        }

        public Image this[int i]
        {
            get 
            {
                if(i <= -1 || i >= Imagenes.Count)
                    throw new InvalidOperationException("Intenta acceder a una imagen que no existe");
                return Imagenes[i];
            }
        }
    }
}
