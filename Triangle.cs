using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FedusVladuslav_HW_10
{
    public class Triangle
    {
        private double side1, side2, side3;
        private double perimeter;
        private Point p1, p2, p3;
        public string name;
        
        public string Name
        {
            get { return name; }
        }

        public Triangle(string name, Point a, Point b, Point c)
        {
            this.name = name; 
            p1 = a;
            p2 = b;
            p3 = c;
            Distance();
        }
        public void Distance()
        {
            side1 = Math.Pow(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2), 0.5);
            side2 = Math.Pow(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2), 0.5);
            side3 = Math.Pow(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2), 0.5);
        }
        public double Perimeter()
        {
            perimeter = Math.Round(side1 + side2 + side3, 2);
            return perimeter;
        }
        public double Square()
        {
            double square = Math.Round(Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3)),2);
            return square;
        }

        public void Print()
        {
            Console.WriteLine("\n{0} have perimeter: {1}, square: {2}", Name, Perimeter(), Square());
        }
       
    }
}