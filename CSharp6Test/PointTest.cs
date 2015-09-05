using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp6;

namespace CSharp6Test
{
    [TestClass]
    public class PointTest
    {
        Point _point;

        [TestInitialize]
        public void SetUp()
        {
            _point = new Point(0, 16);
        }

        [TestMethod]
        public void TestGetter()
        {
            Assert.AreEqual(0, _point.X);
            Assert.AreEqual(16, _point.Y);
        }

        [TestMethod]
        public void TestSetter()
        {
            //_point.X = 3;
        }

        [TestMethod]
        public void TestDistance()
        {
            Assert.AreEqual(16, _point.Dist);
        }

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual("(0, 16)", _point.ToString());
        }
    }
}
