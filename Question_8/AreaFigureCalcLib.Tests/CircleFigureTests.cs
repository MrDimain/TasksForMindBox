using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFigureCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AreaFigureCalcLib.Tests
{
    [TestClass()]
    public class CircleFigureTests
    {
        private static CircleFigure сircle;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Инициализация экземпляра треугольника
            сircle = new CircleFigure();
        }

        [TestMethod()]
        public void GetArea_0_Equal_0()
        {
            // Arrange
            сircle.Radius = 0;

            double expected = 0;

            // Act
            double actual = сircle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void GetArea_1_Equal_3_14()
        {
            // Arrange
            сircle.Radius = 1;

            double expected = 3.14;

            // Act
            double actual = сircle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void GetArea_m1_Equal_3_14()
        {
            // Arrange
            сircle.Radius = -1;

            double expected = 3.14;

            // Act
            double actual = сircle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }


    }
}