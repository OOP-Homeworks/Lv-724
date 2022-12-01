using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    abstract class Shape :IComparable<Shape>
    {
        string name;

        public Shape(string name)
        {
            this.name = name;
        }

       virtual public string Name { get { return name; } set { name = value; } }

        public abstract double Area();

        public abstract double Perimeter();
 
        public virtual void Print()
        {
            Console.WriteLine($"This is shape: {name}");
        }
        public int CompareTo(Shape p)
        {
            Shape d = p as Circle;
            Shape t = p as Square;
            if (d != null)
                return this.Area().CompareTo(d.Area());
            else if (t != null)
                return this.Area().CompareTo(t.Area());
            else
                throw new Exception("Unable to compare two objects");
        }
    }
}
