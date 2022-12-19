using System;
using System.Collections.Generic;
using System.Text;

namespace _5HW_Cherniak
{
	internal class Builder : IDeveloper, IComparable<IDeveloper>
	{
		private string name;
		private string tool;
		public string Tool
		{
			get { return tool; }	
			set { tool = value; }	
		}
		public Builder(string name, string tool)
		{
			this.name = name;
			this.tool = tool;
		}	
		public void Create()
		{
			Console.WriteLine($"Builder {name} creates taks with {tool} help");
		}
		public void Destroy()
		{
			Console.WriteLine($"Builder {name} destroys task with {tool} help");
		}
		int IComparable<IDeveloper>.CompareTo(IDeveloper different)
		{
			return String.Compare(this.Tool, different.Tool);
		}
	}
}
