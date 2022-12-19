using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace HM10._2.Dima
{
    [TestClass]
    public class UnitTest1
    {
        private double expected;

        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            public void PerimeterTest()
            {
                Point a = new Point(4, 5);
                Point b = new Point(5, 2);
                Point c = new Point(3, 2);
                double expected1 = 9;

               
                Triangle test = new Triangle(a, b, c);
                double actual = test.Perimeter();

                
                Assert.AreEqual(expected, actual);
            }

            //Шось взагалі не получилось це завдання( //
        }
    }
}
