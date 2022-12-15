
using System.Drawing;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest_Triangle
    {
        [TestMethod]
        public void PerimeterTest()
        {
            //Arrange
            string name = "Triangle";
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point c = new Point(3, 3);
            double expected = 5.66;

           
            Triangle test = new Triangle(name, a, b, c);
            double actual = test.Perimeter();

            
            Assert.AreEqual(expected, actual);
        }

       [TestMethod]
        public void Square_p1_p2_p3_result()
        {
            //Arrange
            string name = "Triangle";
            Point a = new Point(1, 1);
            Point b = new Point(2, 2);
            Point c = new Point(3, 3);
            double expected = 17;

            //Actual
            Triangle test = new Triangle(name, a, b, c);
            double actual = test.Square();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}