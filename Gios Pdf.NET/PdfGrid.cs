using System;
using System.Drawing;
using System.Text;

namespace SmartPdf
{
	public class PdfGrid : PdfObject
	{
		internal bool hRows=true,vRows=true,bounds=true;
		internal Color color=Color.Black;
		internal double strokeWidth=0.5;
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
		internal PdfArea gridArea;
		public PdfArea GridArea
		{
			get
			{
				return gridArea;
			}
			set
			{
				gridArea=value;
			}
		}
		internal int columns,rows;
		public int Columns
		{
			get
			{
				return columns;
			}
			set
			{
				columns=value;
			}
		}
		public int Rows
		{
			get
			{
				return rows;
			}
			set
			{
				rows=value;
			}
		}
		public PdfGrid(PdfArea GridArea,int Columns,int Rows,Color BorderColor)
		{
			this.rows=Rows;
			this.columns=Columns;
			this.gridArea=GridArea;
			this.color=BorderColor;
		}
		internal string ToLineStream()
		{
			string text="";
			if (this.hRows)
			{
				double vstep=(this.gridArea.height/this.rows);
				for (double y=this.gridArea.posy+vstep;y<this.gridArea.BottomRightCornerY;y+=vstep)
				{
					text+=new PdfLine(new PointF(gridArea.posx,(float)y),
						new PointF(gridArea.BottomRightCornerX,(float)y),color,strokeWidth).ToLineStream();
				}
			}
			if (this.vRows)
			{
				double hstep=(this.gridArea.width/this.columns);
				for (double x=this.gridArea.posx+hstep;x<this.gridArea.BottomRightCornerX;x+=hstep)
				{
					text+=new PdfLine(new PointF((float)x,gridArea.posy),
						new PointF((float)x,gridArea.BottomRightCornerY),color,strokeWidth).ToLineStream();
				}
			}
			if (this.bounds)
			{
				text+=new PdfRectangle(this.gridArea,this.color,this.strokeWidth).ToLineStream();
			}
			return text;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				int num=this.id;
				string text="";
				text+=Utility.ColorRGLine(this.color);
				text+=this.strokeWidth.ToString("0.##")+" ";
				text+="w\n";
				text=text.Replace(",",".");

				text+=this.ToLineStream();

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
