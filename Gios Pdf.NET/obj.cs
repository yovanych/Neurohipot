using System;
using System.Text;

namespace PDF
{
	public class obj
	{
		public int objReference;
		private Byte[] buffer;
		public Byte[] Buffer
		{
			get
			{
				return this.buffer;
			}
			set
			{
				this.buffer=value;
			}
		}
		public obj(int objReference,Byte[] buffer)
		{
			this.buffer=buffer;
			this.objReference=objReference;
		}
		public obj()
		{}

		
	}
}
