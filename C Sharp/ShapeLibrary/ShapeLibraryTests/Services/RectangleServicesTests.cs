using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary.Helper;
using ShapeLibrary.Services;
using ShapeLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Services.Tests
{
    [TestClass()]
    public class RectangleServicesTests
    {
        [TestMethod()]
        public void GivenW5_H5_WhenComputeAreaTest_Then25()
        {
            double expected = 25;
            Rectangle input = new Rectangle();
            input.Width = 5;
            input.Height = 5;
            RectangleServices serv = new RectangleServices();
            serv.Target = input;
            double actual = serv.ComputeArea();
            Assert.AreEqual(expected,actual);
        }
        [TestMethod()]
        [DataRow(5)]
        //[DataRow(6)]
        public void WhenComputePerimeter(int i)
        {
            double expected = 2 * 3.14 * i;
            Circle input = new Circle();
            input.Radius = i;
            CircleServices serv = new CircleServices();
            serv.Target = input;
            double actual = serv.ComputePerimeter();
            Assert.AreEqual(expected, actual, 0.1);
        }
        [TestMethod()]
        [DataRow(5)]
        [DataRow(7)]
        public void Test(int i)
        {
            Circle j = new Circle { Radius = i };
            Assert.AreEqual(78.53, ShapeHelper.ComputeArea(j), 0.01);
        }
    }
}