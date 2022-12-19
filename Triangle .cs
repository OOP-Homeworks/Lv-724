using System;
using System.Collections.Generic;
using System.Text;

namespace HM10.Dima
{
    public class Triangle
    {
        private Point a, b, c;
        private double vertex1, vertex2, vertex3;
        private double perimeter;
        public Triangle(string v, Point b, Point a, Point c)
        {
            a = a;
            b = b;
            c = c;
            Distance();
        }
        public void Distance()
        {
            vertex1 = Math.Pow(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2), 2);
            vertex2 = Math.Pow(Math.Pow(a.x - c.x, 2) + Math.Pow(b.y - c.y, 2), 2);
            vertex3 = Math.Pow(Math.Pow(c.x - a.x, 2) + Math.Pow(c.y - a.y, 2), 2);
        }
        public double Perimeter()
        {
            perimeter = Math.Round(vertex1 + vertex2 + vertex3, 2);
            return perimeter;
        }

    }
}
