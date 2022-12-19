using System;
using System.Collections.Generic;
using System.Text;

namespace HW8_Cherniak
{
	internal class Square : Shape
	{
		private double side;
		public double Side { get { return side; } }

		public Square(string name, double side) : base(name)
		{
			this.side = side;
		}

		public override double Area()
		{
			return (side * side);
		}
		public override double Perimeter()
		{
			return 4 * side;
		}
		public override void Print()
		{
			Console.WriteLine($"Name: {name}, Area: {Area()}, Perimetr: {Perimeter()}");
		}
	}
}
