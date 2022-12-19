using System;
using System.Collections.Generic;
using System.Linq;

namespace HW8_Cherniak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Shape> shapeList = new List<Shape>();

			for (int i = 0; i < 2; i++)
			{
				Console.WriteLine("Input circle or square : ");
				string input = Console.ReadLine();
				if (input == "circle")
				{
					Console.WriteLine("Input the name of circle : ");
					string circleName = Console.ReadLine();
					Console.WriteLine("Input radius : ");
					int circleRadius = Convert.ToInt32(Console.ReadLine());

					shapeList.Add(new Circle(circleName, circleRadius));
				}
				else if (input == "square")
				{
					Console.WriteLine("Input the name of Square : ");
					string squareName = Console.ReadLine();
					Console.WriteLine("Input the side of squere : ");
					int squareSide = Convert.ToInt32(Console.ReadLine());
					shapeList.Add(new Square(squareName, squareSide));
				}
				else
				{
					Console.WriteLine("Mistake, please try again");
					i--;
				}
				foreach (Shape value in shapeList)
				{
					value.Print();
				}
				var result = shapeList.FirstOrDefault(s => s.Perimeter() == shapeList.Max(s1 => s1.Perimeter()));
				Console.WriteLine("Shape {0} have max perimeter: {1:F2}", result.Name, result.Perimeter());
				Console.WriteLine("Sorting list by area:");
				shapeList.Sort();
				foreach (Shape value in shapeList)
				{
					value.Print();
				}
			}
		}
	}
}
