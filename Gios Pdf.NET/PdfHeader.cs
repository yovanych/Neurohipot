using System;
using System.Text;

namespace SmartPdf
{
	internal class PdfHeader : PdfObject
	{
		private string subject,title,author,creationdate;
		public PdfHeader(int id,string subject,string title,string author,string creationdate)
		{
			this.id=id;
			this.subject=subject;
			this.title=title;
			this.author=author;
			this.creationdate=creationdate;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				string s="";
				s+=this.HeadObj;
				s+="<<\n";
				s+="/Subject ("+subject+")\n/Title ("+title+")\n/Creator (Smart Solutions PDF4.NET)\n";
				s+="/Author ("+author+")\n/CreationDate ("+creationdate+")\n";
				s+=">>\n";
				s+="endobj\n";
				return ASCIIEncoding.ASCII.GetBytes(s);
			}
		}
	}
}