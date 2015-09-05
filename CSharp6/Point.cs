using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public override string ToString()
        {
            return string.Format("({0}, {1})", X, Y);
        }
    }
}
