using System;
using System.Collections.Generic;
using System.Text;

namespace Sytnyk_Illia_s_Homework_9
{
    public class Square : Shape
    {
        double side;
        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }
        public double Radius { get { return side; } }
        public override double Area()
        {
            double area = Math.Pow(side, 2);
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = 4* side;
            return perimeter;
        }
    }
}
