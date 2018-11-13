using System;
using FigureArea.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureArea.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleArea_TestZero_ExceptOk()
        {
            var triangle = new Triangle { A  = 0, B = 0, C = 0 };

            Assert.AreEqual(0, triangle.Area);
        }

        [TestMethod]
        public void TriangleArea_TestOne_ExceptOk()
        {
            var triangle = new Triangle { A = 1, B = 1, C = 1 };
            
            Assert.AreEqual(Math.Sqrt(0.1875), triangle.Area);
        }

        [TestMethod]
        public void TriangleArea_TestDifferent_ExceptOk()
        {
            var triangle = new Triangle { A = 5, B = 2, C = 6 };

            Assert.AreEqual(Math.Sqrt(21.9375), triangle.Area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CircleArea_TestNull_ExceptException()
        {
            var circle = new Triangle();
            var test = circle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CircleArea_TestWithoutB_ExceptException()
        {
            var circle = new Triangle { C = 1, A = 1 };
            var test = circle.Area;
        }

        [TestMethod]
        public void TriangleArea_TestSquere_ExceptOk()
        {
            var triangle = new Triangle { A = 4, B = 5, C = 3 };

            Assert.AreEqual(Math.Sqrt(36), triangle.Area);
            Assert.IsTrue(triangle.IsSquare == true);
        }

        [TestMethod]
        public void TriangleArea_TestSquere1_ExceptOk()
        {
            var triangle = new Triangle { A = 3, B = 4, C = 5 };

            Assert.AreEqual(Math.Sqrt(36), triangle.Area);
            Assert.IsTrue(triangle.IsSquare == true);
        }

        [TestMethod]
        public void TriangleArea_TestSquere2_ExceptOk()
        {
            var triangle = new Triangle { A = 5, B = 4, C = 3 };

            Assert.AreEqual(Math.Sqrt(36), triangle.Area);
            Assert.IsTrue(triangle.IsSquare == true);
        }
    }
}
