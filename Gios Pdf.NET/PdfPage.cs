using System;
using System.Collections;
using System.Text;

namespace SmartPdf
{
	public class PdfPage : PdfObject
	{
		private string FontsLine
		{
			get
			{
				string s= "Font << ";
				foreach (PdfFont pf in this.Doc.FontList) s+="/"+pf.Name+" "+pf.HeadR;
				s+=">>\n";
				return s;
			}
		}
		private ArrayList Contents;
		internal ArrayList PagePdfObjects;
		internal PdfDocument Doc;
		internal int Width=595,Height=842;
		private static System.Windows.Forms.Label l=new System.Windows.Forms.Label();
		private static System.Drawing.Graphics g=l.CreateGraphics(); 
		internal string MediaBoxLine
		{
			get
			{
				return "/MediaBox [0 0 "+this.Width+" "+this.Height+"]\n";
			}
		}
		internal string ContentsLine
		{
			get
			{
				string s="/Contents [";
				foreach (PdfObject po in this.PagePdfObjects) 
				{
					if (po.GetType()==typeof(PdfRectangle)) s+=po.HeadR;
					if (po.GetType()==typeof(PdfCircle)) s+=po.HeadR;
					if (po.GetType()==typeof(PdfLine)) s+=po.HeadR;
					//if (po.GetType()==typeof(PdfGrid)) s+=po.HeadR;
					if (po.GetType()==typeof(PdfTable)) s+=po.HeadR;
					if (po.GetType()==typeof(PdfTextArea)) s+=po.HeadR;
					if (po.GetType()==typeof(PdfImageContent)) s+=po.HeadR;
				}
				s+="]\n";
				return s;
			}
		}
		internal string XObjectLine
		{
			get
			{
				string s="/XObject <<";
				foreach (PdfObject po in this.PagePdfObjects) 
				{
					if (po.GetType()==typeof(PdfImage)) s+="/I"+po.ID+" "+po.HeadR;
				}
				s+=" >>\n";
				return s;
			}
		}
		
		internal PdfPage(int id)
		{
			Contents=new ArrayList();
			PagePdfObjects=new ArrayList();
			this.id=id;
		}
		
		public void Add(PdfImage PdfImage,double posx,double posy)
		{
			this.PagePdfObjects.Add(PdfImage);
			this.PagePdfObjects.Add(new PdfImageContent(Doc.GetNextId,"I"+PdfImage.ID,PdfImage.ID,PdfImage.Width,PdfImage.Height,posx,this.Height-posy-PdfImage.Height));
		}
		public void Add(PdfRectangle PdfRectangle)
		{
			PdfRectangle.ID=this.Doc.GetNextId;
			this.PagePdfObjects.Add(PdfRectangle);
		}
		/*public void Add(PdfGrid PdfGrid)
		{
			PdfGrid.ID=this.Doc.GetNextId;
			this.PagePdfObjects.Add(PdfGrid);
		}*/
		
		public void Add(PdfCircle PdfCircle)
		{
			PdfCircle.ID=this.Doc.GetNextId;
			this.PagePdfObjects.Add(PdfCircle);
		}
		public void Add(PdfLine PdfLine)
		{
			PdfLine.ID=this.Doc.GetNextId;
			this.PagePdfObjects.Add(PdfLine);
		}
		
		public void Add(PdfTextArea PdfTextArea)
		{
			PdfTextArea.ID=this.Doc.GetNextId;
			if (!this.Doc.FontList.Contains(PdfTextArea.Font.Name))
				this.Doc.AddFont(PdfTextArea.Font.Name,PdfTextArea.Font.Name);
			this.PagePdfObjects.Add(PdfTextArea);
		}
		
		internal override Byte[] ByteStream
		{
			get
			{
				string s="";
				s+=this.HeadObj;
				s+="<< /Type /Page\n/";
				s+="Parent "+Doc.PagesRoot+" 0 R\n";
				s+=this.MediaBoxLine;
				//s+="/ArtBox[54 54 540 738]\n";
				s+="/Resources\n";
				s+="<<\n/";
				s+=this.FontsLine;
				s+="/ProcSet [/PDF/ImageC/ImageI/ImageB/Text]\n";
				s+=this.XObjectLine;
				s+="\n>>\n";
				s+=this.ContentsLine;
				s+=" >>\n";
				s+="endobj\n";
				return ASCIIEncoding.ASCII.GetBytes(s);
			}
		}
		public PdfPage CreateCopy()
		{
			PdfPage clone=new PdfPage(this.Doc.GetNextId);
			clone.Doc=this.Doc;
			foreach (object o in this.PagePdfObjects) clone.PagePdfObjects.Add(o);
			return clone;
		}
		public void SaveToDocument ()
		{
			this.Doc.PdfObjects.Add(this.MemberwiseClone());
			foreach (PdfObject o2 in this.PagePdfObjects) 
			{
				if (o2.GetType()!=typeof(PdfImage))
					this.Doc.PdfObjects.Add(o2);
			}
		}
	}
}

