using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Practice
{
    internal class Sq
    {
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                Console.WriteLine("Input must be a non-negative number.");
            }
            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }
    }
}
