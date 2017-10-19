using System;
using System.Collections;

namespace SmartPdf
{
	public class PdfTextArea : PdfObject
	{
		private static System.Windows.Forms.Label l=new System.Windows.Forms.Label();
		private static System.Drawing.Graphics g=l.CreateGraphics(); 
		public string text;
		public ArrayList TextLines;
		public PdfArea TextArea;
		public System.Drawing.Font Font;
		public System.Drawing.Color Color=System.Drawing.Color.Black;
		public int maxlines;
		public bool LineFits
		{
			get
			{
				return ((this.LineHeight)>=(this.Font.Height*0.6));
			}
		}
		public bool WidthOverflow
		{
			get
			{
				bool of=false;
				ArrayList al=this.RenderLines();
				for(int index=0;((index<al.Count)&&(index<this.maxlines));index++)
				{
					string line=al[index] as string;
					if (Difference(this.Font,this.TextArea,line,1).Width<0) of=true;
				}
				return of;
			}
		}
		internal int DrawnLines
		{
			get
			{
				int l=this.RenderLines().Count;
				if (l>this.maxlines) return maxlines;
				return l;
			}

		}
		public string OverFlowText
		{
			get
			{
				ArrayList lines=this.RenderLines();
				string s="";
				for (int index=this.maxlines;index<lines.Count;index++)
				{
					s+=lines[index];
				}
				return s;
			}
		}
		private float LineHeight
		{
			get
			{
				return this.TextArea.Height/this.maxlines;
			}
		}
		public TextAlign textAlign;
		public PdfTextArea(System.Drawing.Font Font,System.Drawing.Color Color,PdfArea TextArea,TextAlign TextAlign,int MaxLines,string Text)
		{
			this.Font=Font;
			this.Color=Color;
			this.TextArea=TextArea;
			this.text=Text;
			this.textAlign=TextAlign;
			this.maxlines=MaxLines;
		}
		public static System.Drawing.SizeF Difference(System.Drawing.Font font,PdfArea TextArea,string text,int lines)
		{
			System.Drawing.SizeF s=new System.Drawing.SizeF(0,0);
			System.Drawing.SizeF sizef=g.MeasureString(text,font);
			s.Width=TextArea.Width-(float)(sizef.Width/96*70.2);
			s.Height=TextArea.Height-(float)((sizef.Height/96*70.2)*lines);
			return s;
		}
		public ArrayList RenderLines()
		{
			ArrayList tl=new ArrayList();
			string line="",oldline="";
			text=text.Replace("\n"," \n");
			foreach (string s2 in text.Split(' '))
			{
				string s=s2+" ";
				oldline=line;
				line+=s;
				
				if (Difference(Font,TextArea,line,1).Width<0)
				{
					if (oldline!="")
						tl.Add(oldline);
					line=s;
				}
				if (s.StartsWith("\n"))
				{
					tl.Add(oldline);
					line=s.Replace("\n","");
				}
				
			}
			tl.Add(line);
			return tl;
		}
		internal string ToLineStream()
		{
			string text="";
			float posx,posy;
			ArrayList al=this.RenderLines();
			if (this.LineFits)
			for(int index=0;((index<al.Count)&&(index<this.maxlines));index++)
			{
				string line=al[index] as string;
				posx=TextArea.PosX;
				posy=TextArea.PosY;
				float xdiff=0,ydiff=0;
				if (this.textAlign.h!="left")
				{
					xdiff=Difference(this.Font,TextArea,line,al.Count).Width;
					if (this.textAlign.h=="center") xdiff=xdiff/2;
				}
				if ((this.textAlign.v!="top"))
				{
					ydiff=(float)(this.LineHeight-(this.Font.Height*0.6)
						+(this.maxlines-this.DrawnLines)*this.LineHeight);
					if (this.textAlign.v=="middle") ydiff=ydiff/2;
				}
				posy+=ydiff;
				text+="1 0 0 1 ";
				text+=(posx+xdiff).ToString("#.##").Replace(",",".")+" "+(842-posy-(this.LineHeight*(index))-(Font.Height/2)).ToString("#.##").Replace(",",".")+" Tm ("+line.Replace("(","\\(").Replace(")","\\)");
				text+=") Tj\n";
			}
			return text;
		}
		internal string CompleteLineStream()
		{
			string text="";
			text+="BT\n";
			text+="/"+this.Font.Name+" "+this.Font.Size.ToString()+" Tf\n";
			text+=Utility.ColorrgLine(this.Color);
			text+=this.ToLineStream();
			text+="ET\n";
			return text;
		}
		internal override Byte[] ByteStream
		{
			get
			{
				int num=this.id;
				string text=this.CompleteLineStream();
				string s="";
				s+=num.ToString()+" 0 obj\n";
				s+="<< /Lenght "+text.Length+" >>\n";
				s+="stream\n";
				s+=text;
				s+="endstream\n";
				s+="endobj\n";
				return System.Text.ASCIIEncoding.ASCII.GetBytes(s);
			}

		}
	}
}
