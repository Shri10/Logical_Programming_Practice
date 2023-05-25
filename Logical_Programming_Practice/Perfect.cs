using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Practice
{
    internal class Perfect
    {
        public static void IsPerfect(int n)
        {
            int sum = 1;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    if (i * i != n)
                        sum = sum + i + n / i;
                    else
                        sum = sum + i;
                }
            }
            if (sum == n && n != 1)
            {
                Console.WriteLine(n + " is a Perfect Number");
            }
            else
            {
                Console.WriteLine(n + " is not a Perfect Number");
            }

        }
    }
}
