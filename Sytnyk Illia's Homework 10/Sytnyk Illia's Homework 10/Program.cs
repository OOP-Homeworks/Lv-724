using System;
using static Sytnyk_Illia_s_Homework_10.Program;
using System.Collections.Generic;

namespace Sytnyk_Illia_s_Homework_10
{
    internal class Program
    {
        static void Main()
        {
            Point p1, p2, p3, p4, p5, p6, p7, p8, p9;
            List<Triangle> triangles = new List<Triangle>();

            p1 = new Point(2, 7);
            p2 = new Point(1, 4);
            p3 = new Point(2, 0);

            p4 = new Point(5, 9);
            p5 = new Point(7, 6);
            p6 = new Point(2, 3);

            p7 = new Point(0, 1);
            p8 = new Point(4, 3);
            p9 = new Point(1, 5);

            triangles.Add(new Triangle(p1, p2, p3));
            triangles.Add(new Triangle(p4, p5, p6));
            triangles.Add(new Triangle(p7, p8, p9));

            foreach (Triangle triangle in triangles)
            {
                triangle.Side1 = triangle.Distance(triangle.Vertex1, triangle.Vertex2);
                triangle.Side2 = triangle.Distance(triangle.Vertex2, triangle.Vertex3);
                triangle.Side3 = triangle.Distance(triangle.Vertex3, triangle.Vertex1);
                triangle.Print();
            }
        }
    }
}
