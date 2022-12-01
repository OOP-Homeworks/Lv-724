﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Circle:Shape
    {
        double radius;
       
        double Radius { get { return radius; } set { radius = value; } }

        public Circle(string name,double radius) : base(name)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
             
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        override public void Print()
        {
            Console.WriteLine($"Shape: {Name}\t radius: {radius}\t area: {Math.Round(Math.PI * radius * radius)}\t perimeter: {Math.Round(2 * Math.PI * radius)}");
        }
    }
}
