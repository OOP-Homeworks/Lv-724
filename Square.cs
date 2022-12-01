using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Square : Shape
    {
        double side;
        virtual public double Side { get { return side; } set { side = value; } }
        public Square(string name,double side) : base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        override public void Print()
        {
            Console.WriteLine($"Shape: {Name}\t side: {side}\t area: {Math.Round(side * side, 2)}\t perimeter: {Math.Round(4 * side, 2)}");
        }
    }
}
