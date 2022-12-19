using System;
using System.Collections.Generic;
using System.Text;

namespace HM9.Dima
{
    class Circle: Shape
    {
        private int radius;

        public Circle(string name, int radius) : base(name)
        {
            this.radius = radius;
        }
         public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2); 
        }
        public override double Perimeter()
        {
            return Math.PI * 2 * radius;
        }
    }
}
