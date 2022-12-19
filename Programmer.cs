using System;
using System.Collections.Generic;
using System.Text;

namespace _5HW_Cherniak
{
	internal class Programmer : IDeveloper, IComparable<IDeveloper>
	{
		private string name;
		private string language;
		public string Tool
		{
			get { return language; }
			set { language = value; }
		}
		public Programmer(string name, string language)
		{
			this.name = name;
			this.language = language;
		}	
		public void Create()
		{
			Console.WriteLine($"Programmer {name} creates task with {language} help ");
		}
		public void Destroy()
		{
			Console.WriteLine($"Programmer {name} destroys task with {language} help ");
		}
		int IComparable<IDeveloper>.CompareTo(IDeveloper different)
		{
			return String.Compare(this.Tool, different.Tool);
		}
	}
}
