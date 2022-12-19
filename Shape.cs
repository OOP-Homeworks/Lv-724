using System;
using System.Collections.Generic;
using System.Text;

namespace HM9.Dima
{
    abstract class Shape
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
        public abstract double Area();
        public abstract double Perimeter();
    }
 }
