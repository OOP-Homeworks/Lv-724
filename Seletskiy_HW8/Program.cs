﻿using System;
using System.Collections.Generic;

namespace HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> myList = new List<Shape>();

            int switchFlag = 0;

            while (switchFlag != -1)
            {
                switch (switchFlag)
                {
                    case 0:
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                    break;

                    case 1:
                        Console.WriteLine("Enter the name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the radius:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        myList.Add(new Circle(name, radius));
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Enter the name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter the side:");
                        double side = Convert.ToDouble(Console.ReadLine());
                        myList.Add(new Square(name, side));
                        Console.WriteLine("Enter 1 to enter a circle, 2 to enter a square or -1 to end the input:");
                        switchFlag = Convert.ToInt32(Console.ReadLine());
                    break;

                    default:
                        Console.WriteLine("Enter 1 or 2. -1 exits the loop");
                    break;
                }
            }

            double tempMaxPerimeter = 0;
            string tempMaxName = "";
            foreach (Shape shape in myList)
            {
                Console.WriteLine("Name: {0}, area: {1}, perimeter: {2}", shape.Name, shape.Area(), shape.Perimeter());
                if (shape.Perimeter() > tempMaxPerimeter)
                {
                    tempMaxPerimeter = shape.Perimeter();
                    tempMaxName = shape.Name;
                }
            }

            Console.WriteLine("Max perimeter is of {0} and equals {1}", tempMaxName, tempMaxPerimeter);

            myList.Sort();

            foreach (Shape shape in myList)
            {
                Console.WriteLine("Name: {0}, area: {1}, perimeter: {2}", shape.Name, shape.Area(), shape.Perimeter());
            }
        }
    }
}
