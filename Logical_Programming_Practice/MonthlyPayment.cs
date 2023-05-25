using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Practice
{
    internal class MonthlyPayment
    {
        public static double CalculateMonthlyPayment(double P, double Y, double R)
        {
            // Number of monthly payments
            double n = 12 * Y;

            // Monthly interest rate
            double r = R / (12 * 100);

            // Calculate the monthly payment
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));

            return payment;
        }

    }
}