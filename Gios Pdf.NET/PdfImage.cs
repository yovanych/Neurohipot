using System;
using System.Drawing;
using System.IO;
using System.Text;

namespace SmartPdf
{
	public class PdfImage : PdfObject
	{
		internal MemoryStream ImageStream;
		string file;
		Bitmap bmp;
		public int Height
		{
			get
			{
				return bmp.Height;
			}
		}
		public int Width
		{
			get
			{
				return bmp.Width;
			}
		}
		
		internal PdfImage(int id,string file)
		{
			this.id=id;
			this.file=file;
			ImageStream=new MemoryStream();
			this.bmp=new Bitmap(file);
			
		}
		internal override Byte[] ByteStream
		{
			get
			{
				FileStream fs = File.OpenRead(this.file);
				byte[] data = new byte[fs.Length];
				
				System.Drawing.Image i=Image.FromFile(file);
				
				//i.Save(this.ImageStream,System.Drawing.Imaging.ImageFormat.Jpeg);
				//((data=ImageStream.ToArray();
				string text1="";
				text1+=this.HeadObj;
				//text1+="<< /Length "+ImageStream.Length.ToString()+" /Filter /FlateDecode>>\n";
				text1+="<</Type/XObject\n/Subtype/Image\n";
				text1+="/Width "+bmp.Width.ToString()+"\n/Height "+bmp.Height.ToString()+"\n";
				text1+="/BitsPerComponent 8\n";
				text1+="/Name/I"+this.ID+"\n";
				text1+="/ColorSpace/DeviceRGB\n";
				//text1+="/Filter /FlateDecode\n";
				text1+="/Filter[/DCTDecode]\n";
				//text1+="/DecodeParms[<<>>]\n";
				text1+="/Length "+data.Length.ToString()+"\n";
				
				text1+=">>\nstream\n";
				string text3="";
				text3+="\nendstream\n";
				text3+="endobj\n";

				Byte[] part1=ASCIIEncoding.ASCII.GetBytes(text1);
				//Byte[] part2=sr.BaseStream.
				fs.Read (data, 0, data.Length);

				//Byte[] part2=this.ImageStream.ToArray();
				Byte[] part3=ASCIIEncoding.ASCII.GetBytes(text3);
				
				MemoryStream m=new MemoryStream();
				m.Write(part1,0,part1.Length);
				m.Write(data,0,data.Length);
				m.Write(part3,0,part3.Length);
				
			
				return m.ToArray();

			}
		}
	}
}
