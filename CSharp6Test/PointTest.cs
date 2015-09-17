using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharp6;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CSharp6Test
{
    [TestClass]
    public class PointTest
    {
        private Point _point;

        [TestInitialize]
        public void SetUp()
        {
            _point = new Point(0, 16);
        }

        [TestMethod]
        public void TestGetter()
        {
            AreEqual(0, _point.X);
            AreEqual(16, _point.Y);
        }

        [TestMethod]
        public void TestSetter()
        {
            //_point.X = 3;
        }

        [TestMethod]
        public void TestDistance()
        {
            AreEqual(16, _point.Dist);
        }

        [TestMethod]
        public void TestToString()
        {
            AreEqual("(X: 0, Y: 16)", _point.ToString());
        }

        [TestMethod]
        public void TestToJson()
        {
            var pointAsJson = _point.ToJson();
            AreEqual(_point.X, pointAsJson.Value<int>("x"));
            AreEqual(_point.Y, pointAsJson.Value<int>("y"));
        }

        [TestMethod]
        public void TestFromJson()
        {
            var pointAsJson = _point.ToJson();
            var point = Point.FromJson(pointAsJson);
            AreEqual(point, _point);
        }

        [TestMethod]
        public void TestFromJsonNull()
        {
            var point = Point.FromJson(null);
            IsNull(point);
        }

        [TestMethod]
        public void TestAdd()
        {
            var point = new Point(16, 0);
            _point.Add(point);
            AreEqual(16, _point.X);
            AreEqual(16, _point.Y);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullException()
        {
            _point.Add(null);
        }

        [TestMethod]
        public void TestAddNullExceptionString()
        {
            try
            {
                _point.Add(null);
            }
            catch (ArgumentNullException exception) when (exception.ParamName == "point")
            {

                IsTrue(exception.ParamName == "point");
            }
        }
    }
}