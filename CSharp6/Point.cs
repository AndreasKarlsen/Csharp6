using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using static System.Math;

namespace CSharp6
{
    public class Point
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist => Sqrt(X * X + Y * Y);

        protected bool Equals(Point other)
        {
            return X == other.X && Y == other.Y;
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
                return (X*397) ^ Y;
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
                throw new ArgumentNullException(nameof(point));
            }
            X += point.X;
            Y += point.Y;
            return this;
        }

        public override string ToString() => $"({nameof(X)}: {X}, {nameof(Y)}: {Y})";

        public JObject ToJson() => new JObject() {["x"] = X, ["y"] = Y};

        public static Point FromJson(JObject json)
        {
            if (
                json?["x"]?.Type == JTokenType.Integer &&
                json?["y"]?.Type == JTokenType.Integer)
            {
                return new Point(json.Value<int>("x"), json.Value<int>("y"));
            }
            return null;
        }
    }
}
