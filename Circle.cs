using System;
using System.Collections.Generic;
using System.Text;

namespace HW8_Cherniak
{
	public class Circle : Shape
	{
		private double radius;
		public double Radius { get { return radius; } }

		public Circle(string name, double radius) : base(name)
		{
			this.radius = radius;
		}

		public override double Area()
		{
			return Math.PI * (radius * radius);
		}
		public override double Perimeter()
		{
			return Math.PI * 2 * radius;
		}
		public override void Print()
		{
			Console.WriteLine($"Name: {name}, Area: {Area()}, Perimetr: {Perimeter()}");
		}
	}
}
