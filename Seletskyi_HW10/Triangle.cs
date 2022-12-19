using System;
using System.Collections.Generic;
using System.Text;

namespace HW10
{

    public struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return ("X: " + X + " Y: " + Y);
        }
    }

    public class Triangle
    {
        private double sideOne, sideTwo, sideThree;
        private double perimeter;
        public Point vertexOne, vertexTwo, vertexThree;
        public string name;

        public string Name
        {
            get 
            { 
                return name; 
            }
        }

        public double SideOne
        {
            get
            {
                return sideOne;
            }
        }

        public double SideTwo
        {
            get
            {
                return sideTwo;
            }
        }

        public double SideThree
        {
            get
            {
                return sideThree;
            }
        }

        public Triangle(string name, Point a, Point b, Point c)
        {
            this.name = name;
            vertexOne = a;
            vertexTwo = b;
            vertexThree = c;
            Distance();
        }
        public void Distance()
        {
            sideOne = Math.Pow(Math.Pow(vertexOne.X - vertexTwo.X, 2) + Math.Pow(vertexOne.Y - vertexTwo.Y, 2), 0.5);
            sideTwo = Math.Pow(Math.Pow(vertexTwo.X - vertexThree.X, 2) + Math.Pow(vertexTwo.Y - vertexThree.Y, 2), 0.5);
            sideThree = Math.Pow(Math.Pow(vertexThree.X - vertexOne.X, 2) + Math.Pow(vertexThree.Y - vertexOne.Y, 2), 0.5);
        }
        public double Perimeter()
        {
            perimeter = sideOne + sideTwo + sideThree;
            return perimeter;
        }

        public void Print()
        {
            Console.WriteLine("Triangle {0} with perimeter of {1}, sides: {2}, {3}, {4}", Name, Perimeter(), sideOne, sideTwo, sideThree);
        }

    }
}
