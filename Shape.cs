using System;
using System.Collections.Generic;
using System.Text;

namespace HW9
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public string Name {
            get {
                return name; 
            } 
        }

        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();

        public virtual int CompareTo(Shape secondShape)
        {
            Shape shapeOne = secondShape as Shape;
            if (shapeOne == null)
            {
                throw new ArgumentException("That's not a shape");
            }
            else
            {
                return this.Area().CompareTo(secondShape.Area());
            }
        }
    }
}