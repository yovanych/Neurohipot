using System;
using System.Text;
using System.Drawing;

namespace SmartPdf
{
	public class PdfRectangle : PdfObject
	{
		
		internal PdfArea rectangleArea;
		public PdfArea RectangleArea
		{
			get
			{
				return this.rectangleArea;
			}
		}
		internal Color BorderColor=Color.Black,FillingColor;
		internal bool bordered,filled;
		internal double strokeWidth;
		public double StrokeWidth
		{
			set
			{
				this.strokeWidth=value;
			}
			get
			{
				return this.strokeWidth;
			}
		}		
		
		public PdfRectangle(PdfArea RectangleArea,Color BorderColor)
		{
			this.rectangleArea=RectangleArea;
			this.BorderColor=BorderColor;
			this.bordered=true;
			this.strokeWidth=1;
		}
		public PdfRectangle(PdfArea RectangleArea,Color BorderColor,double BorderWidth)
		{
			this.rectangleArea=RectangleArea;
			this.BorderColor=BorderColor;
			this.bordered=true;
			this.strokeWidth=BorderWidth;
		}
		
		public PdfRectangle(PdfArea RectangleArea,Color BorderColor,Color FillingColor)
		{
			this.rectangleArea=RectangleArea;
			this.BorderColor=BorderColor;
			this.FillingColor=FillingColor;
			this.filled=true;
			this.strokeWidth=1;
			this.bordered=true;
		}
		public PdfRectangle(PdfArea RectangleArea,Color BorderColor,double BorderWidth,Color FillingColor)
		{
			this.rectangleArea=RectangleArea;
			this.BorderColor=BorderColor;
			this.FillingColor=FillingColor;
			this.filled=true;
			this.strokeWidth=BorderWidth;
			this.bordered=true;
		}
		
		public void Fill(Color Color)
		{
			if (!bordered)
			{
				this.bordered=true;
				this.BorderColor=Color;
			}
			this.FillingColor=Color;
			this.filled=true;
		}
		public void Border(Color Color)
		{
			this.bordered=true;
			this.BorderColor=Color;
		}
		internal string ToLineStream()
		{
			string text="";
			if (this.bordered)
			{
				text+=Utility.ColorRGLine(this.BorderColor);
				if (filled) text+=Utility.ColorrgLine(this.FillingColor);
				
				text+=this.strokeWidth.ToString("0.##")+" ";
				text+="w\n";
				
				//text+="100 600 300 100 re\n";
				text+=this.RectangleArea.PosX.ToString("0.##");
				text+=" "+(842-this.rectangleArea.PosY-this.RectangleArea.Height).ToString("0.##")+" ";
				text+=this.RectangleArea.Width.ToString("0.##");
				text+=" "+this.RectangleArea.Height.ToString("0.##")+" re\n";
				if (filled) text+="B";else text+="s";
				text=text.Replace(",",".");
			} else text+="BT\nET";
			text+="\n";
			return text;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				int num=this.id;
				string text=this.ToLineStream();
				string s="";
				s+=num.ToString()+" 0 obj\n";
				s+="<< /Lenght "+text.Length+" >>\n";
				s+="stream\n";
				s+=text;
				s+="endstream\n";
				s+="endobj\n";

				return ASCIIEncoding.ASCII.GetBytes(s);
			}

		}
	}
}
