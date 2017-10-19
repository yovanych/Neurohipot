using System;

namespace SmartPdf
{
	/// <summary>
	/// 
	/// </summary>
	internal sealed class General
	{
		internal General()
		{
			// 
			// TODO: Add constructor logic here
			//
		}
		private static int _nextid=0;
		public static int GetNextId
		{
			get
			{
				_nextid++;
				return _nextid;
			}
		}
		public static int PagesRoot;
	}
}
