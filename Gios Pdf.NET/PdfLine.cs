using System;
using System.Drawing;
using System.Text;

namespace SmartPdf
{
	public class PdfLine : PdfObject
	{
		internal PointF start,end;
		internal Color color;
		internal double strokeWidth;
		public Color Color
		{
			set
			{
				this.color=value;
			}
			get
			{
				return this.color;
			}
		}
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
		public PointF Start
		{
			get
			{
				return this.start;
			}
			set
			{
				this.start=value;
			}
		}
		public PointF End
		{
			get
			{
				return this.end;
			}
			set
			{
				this.end=value;
			}
		}
		public PdfLine(PointF Start,PointF End,Color Color,double StrokeWidth)
		{
			this.start=Start;
			this.end=End;
			this.color=Color;
			this.strokeWidth=StrokeWidth;
		}
		
		internal string ToLineStream()
		{
			string text="";
			
			text+=this.start.X.ToString("0.##")+" ";
			text+=(842-this.start.Y).ToString("0.##")+" ";
			text+="m\n";
			
			text+=this.end.X.ToString("0.##")+" ";
			text+=(842-this.end.Y).ToString("0.##")+" ";
			text+="l\n";

			text+="S\n";
		
			text=text.Replace(",",".");
			return text;
		}
		internal string ToLineStreamWithColorAndWidth()
		{
			string text="";
			text+=Utility.ColorRGLine(this.color);
			text+=this.strokeWidth.ToString("0.##")+" ";
			text+="w\n";
			text=text.Replace(",",".");
			text+=this.ToLineStream();
			return text;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				int num=this.id;
				string text="";
				text+=this.ToLineStreamWithColorAndWidth();
				
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
