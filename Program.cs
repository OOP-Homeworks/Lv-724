
﻿using System;

using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Sytnyk_Illia_s_Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            const int LIST_COUNT = 10;
            for (int i = 0; i < LIST_COUNT; i++)
            {
                Console.Write("Enter what you want to add to list (circle/square/end): ");
                string shape_name = Console.ReadLine().ToLower();
                switch (shape_name)
                {
                    case "circle":
                        Console.Write("Enter the name of circle: ");
                        string name_circle = Console.ReadLine();
                        Console.Write("Enter the radius of circle: ");
                        double radius_circle = Convert.ToDouble(Console.ReadLine());
                        Shapes.Add(new Circle(name_circle, radius_circle));
                        Console.WriteLine("");
                        break;
                    case "square":
                        Console.Write("Enter the name of square: ");
                        string name_square = Console.ReadLine();
                        Console.Write("Enter the side of square: ");
                        double radius_square = Convert.ToDouble(Console.ReadLine());
                        Shapes.Add(new Square(name_square, radius_square));
                        Console.WriteLine("");
                        break;
                    case "end":
                        goto next_step;
                }
            }
            next_step:
            foreach(Shape s in Shapes)
            {
                Console.WriteLine("Shape name: {0}\t\t Area: {1:F3}\t\t Perimeter: {2:F3}", s.Name, s.Area(), s.Perimeter());
            }

            double max_per = 0;
            string max_per_name = "";
            foreach (Shape s in Shapes)
            {
                if(s.Perimeter() > max_per)
                {
                    max_per = s.Perimeter();
                    max_per_name = s.Name;

                }
            }
            Console.WriteLine($"\n\nShape with the largest perimeter, Name:{max_per_name} Perimeter: {max_per}");

            Shapes.Sort();
            Console.WriteLine("\nAfter sorting Shapes by area:");
            foreach (Shape s in Shapes)
            {
                Console.WriteLine($"Sorted shape name: {s.Name}\t\t Area: {s.Area():F3}\t\t Perimeter: {s.Perimeter():F3}");
            }
            Console.ReadKey();
        }
    }
}
