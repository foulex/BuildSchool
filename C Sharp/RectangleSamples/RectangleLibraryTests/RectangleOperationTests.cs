using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleLibrary.Tests
{
    [TestClass()]
    public class RectangleOperationTests
    {
        [TestMethod()]
        public void Given_Rectangle_When_Width_5_Height_5_Then_25()
        {
            int expected = 25;
            var give = new Rectangle { Width = 5, Height = 5 };
            var operation = new RectangleOperation { Target = give };
            int actual = operation.ComputeArea();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Given_Rect_When_W6_H6_Then_36()
        {
            int exc = 36;
            var give = new Rectangle { Width = 6, Height = 6 };
            var operation = new RectangleOperation { Target = give };
            int act = operation.ComputeArea();
            Assert.AreEqual(exc, act);
        }
        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void Give_Null()
        {
            Rectangle input = null;
            RectangleOperation operation = new RectangleOperation { Target = input };
            int actual = operation.ComputeArea();
        }

        [DataRow(3, 3, 9)]
        //[DataRow(4, 5, 6)]
        [DataRow(7, 8, 56)]
        [DataTestMethod]
        public void Given_Rect_When_A_B_ThenC(int w, int h, int expected)
        {
            var give = new Rectangle { Width = w, Height = h };
            var operation = new RectangleOperation { Target = give };
            int act = operation.ComputeArea();
            Assert.AreEqual(expected, act);
        }
        //↓動態取代DataRow
        [DynamicData(nameof(GetTestASDASDASDData), DynamicDataSourceType.Method)]
        [DataTestMethod]
        public void Dynamic(int w, int h, int expected)
        {
            var give = new Rectangle { Width = w, Height = h };
            var operation = new RectangleOperation { Target = give };
            int act = operation.ComputeArea();
            Assert.AreEqual(expected, act);
        }
        private static IEnumerable<object[]> GetTestASDASDASDData()
        {
            yield return new object[] { 5, 6, 30 };
            yield return new object[] { 3, 16, 48 };
            yield return new object[] { 9, 8, 72 };
        }
        //↑動態取代DataRow
        [DataRow(2,3,6)]
        [DataRow(5,3,15)]
        //[DataRow(5, 3, 16)]
        [DataTestMethod]
        public void GHelper(int a, int b, int expected)
        {
            Assert.AreEqual(expected, RectangleOperationHelper.ComArea(new Rectangle { Width = a, Height = b }));
        }
        public void GHelper2(int a, int b, int expected)
        {
            var X = new Rectangle();
            X.Width = a;
            X.Height = b;
            var Y = RectangleOperationHelper.ComArea(X);
            Assert.AreEqual(expected, Y);
        }
    }
}