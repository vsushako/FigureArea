using System;
using FigureArea.Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureArea.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleArea_TestZero_ExceptOk()
        {
            var r = 0;
            var circle = new Circle {Radius = r};

            Assert.AreEqual(0, circle.Area);
        }

        [TestMethod]
        public void CircleArea_TestOne_ExceptOk()
        {
            var r = 1;
            var circle = new Circle {Radius = r};

            Assert.AreEqual(Math.PI, circle.Area);
        }

        [TestMethod]
        public void CircleArea_TestDouble_ExceptOk()
        {
            var r = 5.12324d;
            var circle = new Circle {Radius = r};

            Assert.AreEqual(Math.PI * r * r, circle.Area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CircleArea_TestNull_ExceptException()
        {
            var circle = new Circle();
            var test = circle.Area;
        }

        [TestMethod]
        public void CircleArea_TestChange_ExceptOk()
        {
            var r = 5.12324d;
            var circle = new Circle { Radius = r };

            Assert.AreEqual(Math.PI * r * r, circle.Area);
            circle.Radius = 6;

            Assert.AreEqual(Math.PI * 6 * 6, circle.Area);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CircleArea_TestChangeToNull_ExceptException()
        {
            var r = 5.12324d;
            var circle = new Circle { Radius = r };

            Assert.AreEqual(Math.PI * r * r, circle.Area);
            circle.Radius = null;
            var test = circle.Area;
        }
    }
}
