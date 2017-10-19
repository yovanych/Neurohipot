using System;
using System.Text;

namespace SmartPdf
{
	internal class PdfImageContent : PdfObject
	{
		private string name,imagename;
		private int imageid,width,height;
		double posx,posy;
		public string Name
		{
			get
			{
				return this.name;
			}
		}
		public PdfImageContent(int id,string imagename,int imageid,int width,int height,double posx,double posy)
		{
			this.name=name;
			this.imagename=imagename;
			this.imageid=imageid;
			this.id=id;
			this.height=height;
			this.width=width;
			this.posx=posx;
			this.posy=posy;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				string s="";
				s+="q\n";
				s+=this.width.ToString()+" 0 0 ";
				s+=this.height.ToString()+" "+posx.ToString("0.##")+" "+posy.ToString("0.##")+" cm\n";
				s+="/"+this.imagename+" Do\n";
				s+="Q\n";
				
				s=s.Replace(",",".");

				Byte[] b=ASCIIEncoding.ASCII.GetBytes(s);
				
				string r=this.HeadObj;
				r+="<< /Lenght "+b.Length.ToString()+">>\n";
				r+="stream\n";
				r+=s;

				r+="endstream\n";
				r+="endobj\n";

				return ASCIIEncoding.ASCII.GetBytes(r);

			}
		}
	}
	
}