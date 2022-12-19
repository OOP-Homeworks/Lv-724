using System;
using System.Collections.Generic;

namespace HM10.Dima
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle("Triangle 1", new Point(1, 2), new Point(3, 4), new Point(5, 6)));
            triangles.Add(new Triangle("Triangle 2", new Point(7, 8), new Point(9, 10), new Point(11, 12)));
        }
    }
}
