using HW10;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingStuff
{
    [TestClass]
    public class TriangleUnitTest
    {

        [TestMethod]
        public void DistanceTest()
        {
            //arrange
            string name = "Illuminati";
            Point a = new Point(42, 1);
            Point b = new Point(5, 1);
            Point c = new Point(10, 3);
            double expected1 = 37;
            double expected2 = 5.385164807134504;
            double expected3 = 32.0624390837628;

            //actual
            Triangle test = new Triangle(name, a, b, c);
            double actual1 = test.SideOne;
            double actual2 = test.SideTwo;
            double actual3 = test.SideThree;

            //assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            //arrange
            string name = "Heaven's Gate";
            Point a = new Point(19, 62);
            Point b = new Point(8, 4);
            Point c = new Point(5, 1);
            double expected = 125.86247017297646;

            //actual
            Triangle test = new Triangle(name, a, b, c);
            double actual = test.Perimeter();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
