using System;
using System.Drawing;
using System.Text;

namespace SmartPdf
{
	public class PdfCircle : PdfObject
	{
		private PdfArea axesArea;
		public PdfArea AxesArea
		{
			get
			{
				return this.axesArea;
			}
			set
			{
				this.axesArea=value;
			}
		}
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
		internal Color BorderColor;
		public System.Drawing.PointF Center
		{
			get
			{
				return new PointF(this.axesArea.PosX+(this.axesArea.Width/2)
					,this.axesArea.PosY+(this.axesArea.Height/2));
			}
		}
		internal PdfCircle()
		{
			this.strokeWidth=1;
		}
		public PdfCircle(float posx,float posy,float ray,Color Color)
		{
			this.axesArea=new PdfArea(posx-ray,posy-ray,ray*2,ray*2);
			this.BorderColor=Color;
			this.strokeWidth=1;
		}
		internal string ToLineStream()
		{
			string text="";
			
			text+=Utility.ColorRGLine(this.BorderColor);
			
			text+=this.strokeWidth.ToString("0.##")+" ";
			text+="w\n";
			
			text+=this.Center.X.ToString("0.##")+" ";
			text+=(842-this.axesArea.PosY).ToString("0.##")+" m\n";

			text+=(this.axesArea.BottomRightCornerX+this.axesArea.Width/6).ToString("0.##")+" ";
			text+=(842-this.axesArea.PosY).ToString("0.##")+" ";
			text+=(this.axesArea.BottomRightCornerX+this.axesArea.Width/6).ToString("0.##")+" ";
			text+=(842-this.axesArea.BottomRightCornerY).ToString("0.##")+" ";
			text+=this.Center.X.ToString("0.##")+" ";
			text+=(842-this.axesArea.BottomRightCornerY).ToString("0.##")+" c \n";
			
			text+=(this.axesArea.PosX-this.axesArea.Width/6).ToString("0.##")+" ";
			text+=(842-this.axesArea.BottomRightCornerY).ToString("0.##")+" ";
			text+=(this.axesArea.PosX-this.axesArea.Width/6).ToString("0.##")+" ";
			text+=(842-this.axesArea.PosY).ToString("0.##")+" ";
			text+=this.Center.X.ToString("0.##")+" ";
			text+=(842-this.axesArea.PosY).ToString("0.##")+" c\n";

			text+="s\n";
		
			text=text.Replace(",",".");
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
