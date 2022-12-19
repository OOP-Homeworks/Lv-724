using System;
using System.Collections.Generic;
using System.Text;

namespace HW8_Cherniak
{
	public abstract class Shape : IComparable<Shape>	
	{
		public string name;
		public string Name
		{
			get { return name; }
		}

		public Shape(string name)
		{
			this.name = name;
		}

		public abstract double Area();
		public abstract double Perimeter();

		public int CompareTo(Shape different)
		{
			if (different == null) return 1;
			else
				return this.Area().CompareTo(different.Area());
		}
		public abstract void Print();
	}
}
