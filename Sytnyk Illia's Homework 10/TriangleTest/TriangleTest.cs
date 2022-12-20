using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sytnyk_Illia_s_Homework_10
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Dist_p1_X1Y4_p2_X2Y3_2_returned()
        {
            Point point1 = new Point();
            point1.X = 2;
            point1.Y = 7;

            Point point2 = new Point();
            point2.X = 1;
            point2.Y = 4;
            double expected = 4;

            Triangle t = new Triangle();

            double actual = Math.Ceiling(t.Distance(point1, point2));

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Perimetr_10and20and15_45returned()
        {
            Triangle t = new Triangle();
            t.Side1 = 3;
            t.Side2 = 4;
            t.Side3 = 5;
            double expected = 12;

            double actual = t.Perimeter();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Square_10and20and15_73returned()
        {
            Triangle t = new Triangle();
            t.Side1 = 3;
            t.Side2 = 4;
            t.Side3 = 5;
            double expected = 6;

            double actual = Math.Ceiling(t.Square());

            Assert.AreEqual(expected, actual);
        }
    }
}
