using System;

namespace Smart.Pdf
{
	
	public struct PdfTextAlign
	{
		internal string h,v;
		private PdfTextAlign(string h,string v)
		{
			this.h=h;
			this.v=v;
		}
		public static PdfTextAlign MiddleCenter
		{
			get
			{
				return new PdfTextAlign("center","middle");
			}
		}
		public static PdfTextAlign MiddleLeft
		{
			get
			{
				return new PdfTextAlign("left","middle");
			}
		}
		public static PdfTextAlign MiddleRight
		{
			get
			{
				return new PdfTextAlign("right","middle");
			}
		}
		public static PdfTextAlign TopCenter
		{
			get
			{
				return new PdfTextAlign("center","top");
			}
		}
		public static PdfTextAlign TopLeft
		{
			get
			{
				return new PdfTextAlign("left","top");
			}
		}
		public static PdfTextAlign TopRight
		{
			get
			{
				return new PdfTextAlign("right","top");
			}
		}
		public static PdfTextAlign BottomCenter
		{
			get
			{
				return new PdfTextAlign("center","bottom");
			}
		}
		public static PdfTextAlign BottomLeft
		{
			get
			{
				return new PdfTextAlign("left","bottom");
			}
		}
		public static PdfTextAlign BottomRight
		{
			get
			{
				return new PdfTextAlign("right","bottom");
			}
		}
	}
}
