using System;
using System.Collections.Generic;
using System.Text;

namespace HM8.Dima
{
    class Square: Shape
    {
        int side;
        public Square(string name, int side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}
