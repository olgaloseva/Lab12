using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    static class Circle
    {
        public static double GetCircumference (double r)
        {
            return 2 * Math.PI * r;
        }

        public static double GetAreaCircle (double r)
        {
            return Math.PI * r * r;
        }

        public static bool GetIsLocatedInCircle(double x, double y, double r)
        {
            double distance = Math.Sqrt(x * x + y * y);
            if (r>= distance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
