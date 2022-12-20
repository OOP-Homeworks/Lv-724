using System;
using System.Collections.Generic;
using System.Text;

namespace Sytnyk_Illia_s_Homework_10
{
    public class Triangle
    {
        public Point Vertex1, Vertex2, Vertex3;
        public double Side1, Side2, Side3;

        public Triangle(Point a, Point b, Point c)
        {
            Vertex1 = a;
            Vertex2 = b;
            Vertex3 = c;
        }
        public Triangle() { }

        public double Distance(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public double Square()
        {
            double semiperimeter = (Side1 + Side2 + Side3) / 2;
            double square = Math.Sqrt(semiperimeter * (semiperimeter - Side1) * (semiperimeter - Side2) * (semiperimeter - Side3));
            return square;
        }

        public void Print()
        {
            Console.WriteLine($"Triangle Perimeter: {Perimeter():F3}, Squere: {Square():F3}");
        }
    }
}
