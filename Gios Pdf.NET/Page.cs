using System;
using System.Collections;
using System.Text;

namespace SmartPdf
{
	public class Page 
	{
		private PdfPage pdfPage;
		internal PdfPage PdfPage
		{
			get
			{
				return this.pdfPage;
			}
		}
		public Page()
		{
			pdfPage=new PdfPage();
		}
		public void AddText(string fontname,int fontsize,int posx,int posy,string text)
		{
			this.PdfPage.PagePdfObjects.Add(new PdfText(General.GetNextId,fontname,fontsize,posx,posy,text));
		}
		public void AddImage(string file,int posx,int posy)
		{
			int imageid=General.GetNextId;
			PdfImage pi=new PdfImage(imageid,file);
			this.PdfPage.PagePdfObjects.Add(pi);
			this.PdfPage.PagePdfObjects.Add(new PdfImageContent(General.GetNextId,"I"+imageid,imageid,pi.Width,pi.Height,posx,posy));
		}


	}
}
