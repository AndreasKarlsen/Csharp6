using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CSharp6
{
    public class Point
    {
        private int _X;
        public int X
        {
            get
            {
                return _X;
            }
        }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            _X = x;
            Y = y;
        }

        public double Dist
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        protected bool Equals(Point other)
        {
            return _X == other._X && Y == other.Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (_X*397) ^ Y;
            }
        }

        public static bool operator ==(Point left, Point right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !Equals(left, right);
        }

        public Point Add(Point point)
        {
            if (point == null)
            {
                throw new ArgumentNullException("point");
            }
            _X += point.X;
            Y += point.Y;
            return this;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }

        public JObject ToJson()
        {
            var result = new JObject();
            result["x"] = X;
            result["y"] = Y;
            return result;
        }

        public static Point FromJson(JObject json)
        {
            if (json != null &&
                json["x"] != null &&
                json["x"].Type == JTokenType.Integer &&
                json["y"] != null &&
                json["y"].Type == JTokenType.Integer)
            {
                return new Point(json.Value<int>("x"), json.Value<int>("y"));
            }
            return null;
        }
    }
}
