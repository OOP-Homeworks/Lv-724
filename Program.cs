using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FedusVladuslav_HW_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> shapes = new List<Triangle>();
            shapes.Add(new Triangle("Triangle 1", new Point(1, 2), new Point(5, 3), new Point(18, 7)));
            shapes.Add(new Triangle("Triangle 2", new Point(2, 3), new Point(8, 4), new Point(9, 2)));
            shapes.Add(new Triangle("Triangle 3", new Point(10, 1), new Point(5, 7), new Point(12, 3)));

            foreach (Triangle triangle in shapes)
            {
                triangle.Print();
            }  
        }
    }
}

