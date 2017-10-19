using System;
using System.Text;

namespace SmartPdf
{
	internal class PdfFont : PdfObject
	{
		private string name,typename;
		public string Name
		{
			get
			{
				return this.name;
			}
		}
		public PdfFont(int id,string name,string typename)
		{
			this.name=name;
			this.typename=typename;
			this.id=id;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				string text="";
				text+="/Type /Font\n/";
				text+="Subtype /Type1\n/";
				text+="Name /"+name+"\n";
				text+="/BaseFont /"+typename+"\n";
				text+="/Encoding /WinAnsiEncoding\n";
			
				string s="";
				s+=this.HeadObj+"\n";
				s+="<<\n";
				s+="/Type /Font\n/";
				s+="Subtype /Type1\n/";
				s+="Name /"+name+"\n";
				s+="/BaseFont /"+typename+"\n";
				s+="/Encoding /WinAnsiEncoding\n";
				s+=">>\n";
				s+="endobj\n";
				return ASCIIEncoding.ASCII.GetBytes(s);

			}
		}
	}
	
}
