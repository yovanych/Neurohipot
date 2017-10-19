using System;
using System.Text;

namespace SmartPdf
{
	internal class PdfStandardObject : PdfObject
	{
		protected string text;
		public PdfStandardObject()
		{}
		public PdfStandardObject(int id,string completeText)
		{
			this.id=id;
			this.text=completeText;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				string s="";
				s+=this.HeadObj;
				s+="<<\n";
				s+=text+"\n";
				s+=">>\n";
				s+="endobj\n";
			   return ASCIIEncoding.ASCII.GetBytes(s);
		   }
		}
	}
}
	
