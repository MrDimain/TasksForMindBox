using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaFigureCalcLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigureCalcLib.Tests
{
    [TestClass()]
    public class TriangleFigureTests
    {
        private static TriangleFigure triangle;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            // Инициализация экземпляра треугольника
            triangle = new TriangleFigure();
        }

        [TestMethod()]
        public void GetAreaTest_1_2_3_Equal_0()
        {
            // Arrange
            triangle.SideA = 1;
            triangle.SideB = 2;
            triangle.SideC = 3;

            double expected = 0;

            // Act
            double actual = triangle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }
        
        [TestMethod()]
        public void GetAreaTest_3_3_3_Equal_3_89()
        {
            // Arrange
            triangle.SideA = 3;
            triangle.SideB = 3;
            triangle.SideC = 3;

            double expected = 3.89;

            // Act
            double actual = triangle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }
        
        [TestMethod()]
        public void GetAreaTest_3_4_5_Equal_6()
        {
            // Arrange
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;

            double expected = 6;

            // Act
            double actual = triangle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void GetAreaTest_3_5__4_5__5_5_Equal_7_85()
        {
            // Arrange
            triangle.SideA = 3.5;
            triangle.SideB = 4.5;
            triangle.SideC = 5.5;

            double expected = 7.85;

            // Act
            double actual = triangle.GetArea();

            // Assert            
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod()]
        public void IsRightTtriangleTest_1_2_3_false()
        {
            // Arrange
            triangle.SideA = 1;
            triangle.SideB = 2;
            triangle.SideC = 3;

            // Act
            bool actual = triangle.IsRightTtriangle;

            // Assert            
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsRightTtriangleTest_3_3_3_false()
        {
            // Arrange
            triangle.SideA = 3;
            triangle.SideB = 3;
            triangle.SideC = 3;

            // Act
            bool actual = triangle.IsRightTtriangle;

            // Assert            
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsRightTtriangleTest_3_4_5_true()
        {
            // Arrange
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;

            // Act
            bool actual = triangle.IsRightTtriangle;

            // Assert            
            Assert.IsTrue(actual);
        }

    }
}