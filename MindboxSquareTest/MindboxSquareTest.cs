using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxSquareLib;

namespace MindboxSquareTest
{
    [TestClass]
    public class MindboxSquareTest
    {
        [TestMethod]
        public void TriangleTest()
        {
            IFigure figure = new Triangle(6, 10, 8);
            //
            double excepted = 24;
            double actual = figure.CalculateSquare();
            Assert.AreEqual(excepted, actual, 0.001, "Wrong CalculateSquare value");
            //
            Assert.IsTrue((figure as Triangle).IsRectangular(), "Wrong IsRectangular");
        }

        [TestMethod]
        public void CircleTest() 
        {
            IFigure figure = new Circle(6);
            //
            double excepted = 113.0973;
            double actual = figure.CalculateSquare();
            Assert.AreEqual(excepted, actual, 0.01, "Wrong CalculateSquare value");
        }
    }
}
