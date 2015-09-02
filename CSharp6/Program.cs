using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            Overall:
            * No big new concepts
            * Many small features
            * Clean up your code, get rid of boilerplate
            
            Features:
            * Autoproperties
            * * Getter only is now allowed. Before, you had to make a private setter
            * * * The backing field is read-only, and can be assigned to from the constructor
            * * Can now be initialized directly

            * Using static, puts the static members directly into scope
            * * Examples: Collections of functions in Math library, Enums (weekdays, colors)

            * String interpolation with $
            * * The order of the placeholders and the arguments can become confusing
            * * String.Format("({0}, {1})", X, Y); becomes $"({X}, {Y})";

            * Expression bodied methods
            * * Just like lambda's, methods can now use the lambda arrow for expression bodies
            * * Example: public override string ToString() => $"({X}, {Y})";
            * * Example: public double Dist => Sqrt(X * X + Y * Y);

            * Index initializers - Object initializers are extended to allow initialization of indices
            * * Example: 
            public JObject ToJson()
            {
                var result = new JObject();
                result["x"] = X;
                result["y"] = Y;
                return result;
            }
            * Becomes
            public JObject ToJson() => new JObject() { ["x"] = X, ["y"] = Y };

            * Null condition operators
            * 

            * Links: 
            * * https://www.youtube.com/watch?v=YHWCFeE2L-4
            * * https://github.com/dotnet/roslyn/wiki/New-Language-Features-in-C%23-6
            */
        }
    }
}
