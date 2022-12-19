using System;
using System.Collections.Generic;
using System.Text;


namespace Sytnyk_Illia_s_Homework_8
{
    public class Circle : Shape
    {
        double radius;
        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }
        public double Radius { get { return radius; } }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
    
