using System;

namespace SmartPdf
{
	public abstract class PdfObject
	{
		internal PdfObject()
		{
			
		}
		internal PdfObject(Byte[] buffer,int id)
		{
			this.buffer=buffer;
			this.id=id;
		}
		
		#region properties
		protected int id;
		internal int ID
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id=value;
			}
		}
		private Byte[] buffer;
		protected string type;
		internal string Type
		{
			get
			{
				return type;
			}
		}
		internal string HeadR
		{
			get
			{
				return this.id.ToString()+" 0 R ";
			}
		}
		internal string HeadObj
		{
			get
			{
				return this.id.ToString()+" 0 obj\n";
			}
		}
		
		#endregion
		internal virtual Byte[] ByteStream
		{
			get
			{
				return this.buffer;
			}
		}
		/*internal PdfObject Clone()
		{
			return this.MemberwiseClone() as PdfObject;
		}*/
	}
}
