using System;
using System.Text;

namespace SmartPdf
{
	internal class PdfCatalog : PdfObject
	{
		private int root;
		public PdfCatalog(int id,int root)
		{
			this.id=id;
			this.root=root;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				string s="";
				s+=this.HeadObj;
				s+="<<\n";
				s+="/Type /Catalog\n/Pages "+this.root.ToString()+" 0 R";
				s+=">>\n";
				s+="endobj\n";
				return ASCIIEncoding.ASCII.GetBytes(s);
			}
		}
	}
}
