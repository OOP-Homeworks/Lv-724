using System;
using System.Collections.Generic;
using System.Text;

namespace HM10.Dima
{
    class Point
    {
        public int x;
        public int y;

        public Point(int x, int y) 
        { 
            this.x = x; this.y = y; 
        }
        public int Distance(Point point)
        {
            return (x + point.x) + (y + point.y);
        }
    }
}
