using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HM9.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("one", 6));
            shapes.Add(new Square("two", 11));
            shapes.Add(new Square("three", 1));
            shapes.Add(new Square("four", 15));
            shapes.Add(new Circle("five", 5));
            shapes.Add(new Circle("amazing", 9));

            for (int i = 0; i < 6; i++)

                if (shapes[i].Area() > 10 && shapes[i].Area() < 100)
                {
                    Console.WriteLine($"(Area) the name is {shapes[i].Name}");
                }
            for (int i = 0; i < 6; i++)
                if (shapes[i].Name.Contains("a"))
                 {
                    Console.WriteLine($"(Letter) the name is {shapes[i].Name}");
                 }
            for (int i = 0; i < 6; i++)
                if (shapes[i].Perimeter() < 5)
                {
                    Console.WriteLine($"(Perimeter) the name is {shapes[i].Name}");
                }
              
        }
    }
}
