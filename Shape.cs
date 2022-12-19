using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HM8.Dima
{
    public abstract class Shape : IComparable<Shape>
    {
        string name;
        public Shape(string name)
        {
            this.name = name;
        }
        virtual public string Name
        {
            get { return name; }
        }

        public object Perimeter1 { get; internal set; }
        public object Area1 { get; internal set; }

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