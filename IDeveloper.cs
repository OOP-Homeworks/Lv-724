using System;
using System.Collections.Generic;
using System.Text;

namespace _5HW_Cherniak
{
	internal interface IDeveloper : IComparable<IDeveloper>
	{
		void Create();
		void Destroy();

		public string Tool
		{
			get;
			set;
		}
	}
}
