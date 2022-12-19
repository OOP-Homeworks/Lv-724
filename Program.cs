using System;
using System.Collections.Generic;
using System.Linq;

namespace HM8.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shape = new List<Shape>();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter the {i} shape (circle or square)");
                string shapeInput = Console.ReadLine();
                if (shapeInput == "circle")
                {
                    Console.WriteLine("Enter the circle's name");
                    string circelName = Console.ReadLine();
                    Console.WriteLine("Enter the radius");
                    int radius = Convert.ToInt32(Console.ReadLine());
                    shape.Add(new Circle(circelName, radius));
                }
                else if (shapeInput == "square")
                {
                    Console.WriteLine("Enter the square's name");
                    string squareName = Console.ReadLine();
                    Console.WriteLine("Enter the side");
                    int side = Convert.ToInt32(Console.ReadLine());
                    shape.Add(new Square(squareName, side));
                }
                else
                {
                    Console.WriteLine("You made mistake");
                }
                foreach (Shape c in shape)
                {
                    Console.WriteLine($"{c.Name}");
                    c.Area();
                    c.Perimeter();
                }
                shape.Sort();

                foreach (Shape s in shape)
                {
                    Console.WriteLine($"{shape[i].Name}, {shape[i].Area()}");
                }
            }
        }
    }
}
