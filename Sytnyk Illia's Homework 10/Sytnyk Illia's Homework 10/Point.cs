using System;
using System.Collections.Generic;
using System.Text;

namespace Sytnyk_Illia_s_Homework_10
{
    public struct Point
    {
        public int X, Y;
        public Point(int x, int y) { this.X = x; this.Y = y; }
        public override string ToString()
        {
            return $"Point: {X}, {Y}";
        }
    }
}
