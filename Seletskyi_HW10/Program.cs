using System;
using System.Collections.Generic;
using System.Linq;

namespace HW10
{
    class Program
    {
        /*
        public static double DistanceCalculator(Point a, Point b)
        {
            return Math.Pow(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2), 0.5);
        }
        */

        static void Main(string[] args)
        {
            List<Triangle> triangleList = new List<Triangle>();
            List<double> distancesList = new List<double>();
            triangleList.Add(new Triangle("Mason", new Point(42, 1), new Point(5, 1), new Point(10, 3)));
            triangleList.Add(new Triangle("Bermuda", new Point(2, 10), new Point(5, 5), new Point(1, 9)));
            triangleList.Add(new Triangle("Mercedes", new Point(2, 11), new Point(6, 3), new Point(9, 1)));

            /*
            this is supposed to print the minimal distance from a vertex to 0;0... 
            I couldn't come up with an idea how to get the triangle dynamically; however, 
            it's possible if we make 3 lists and compare the distances there, but that is
            awful and I won't do it
            Point zero = new Point(0, 0);
            foreach (Triangle triangle in triangleList)
            {
                triangle.Print();
                distancesList.Add(DistanceCalculator(zero, triangle.vertexOne));
                distancesList.Add(DistanceCalculator(zero, triangle.vertexTwo));
                distancesList.Add(DistanceCalculator(zero, triangle.vertexThree));
            }

            Console.WriteLine(distancesList.Min());
            */
        }
    }
}
