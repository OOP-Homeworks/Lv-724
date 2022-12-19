using System;
using System.Collections.Generic;
using System.Text;

namespace HW9
{
    public class Square : Shape
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }
        }

        public Square(string name, double side) : base(name)
        {
            this.side = side;
        }

        public override double Area()
        {
            return Math.Pow(side, 2);
        }

        public override double Perimeter()
        {
            return side * 4;
        }
    }
}
