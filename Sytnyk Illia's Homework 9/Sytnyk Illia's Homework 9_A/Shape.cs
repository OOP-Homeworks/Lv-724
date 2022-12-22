using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sytnyk_Illia_s_Homework_9
{
    public abstract class Shape : IComparable<Shape>
    {
        public string name;
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        public int CompareTo(Shape p)
        {
            Shape c = p as Circle;
            Shape s = p as Square;
            if (c != null)
                return this.Area().CompareTo(c.Area());
            else if (s != null)
                return this.Area().CompareTo(s.Area());
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
