using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Practice
{
    internal class Fibo
    {
        public static void fib(int n)
        {
            int a = 0, b = 1, c;
            if (n == 0)
            {
                //Console.Write("{0}\n", a);
            }
            else if (n == 1)
            {
                Console.Write("{0}\n", a);
                //Console.Write("{0}\n{1}\n", a, b);
            }
            else if (n == 2)
            {
                //Console.Write("{0}\n", a);
                Console.Write("{0}\n{1}\n", a, b);
            }
            else if (2 < n && n < 47)
            {
                Console.Write("{0}\n{1}\n", a, b);
                for (int i = 2; i < n; i++)
                {
                    c = a + b;
                    //Console.Write("{0}\n", c + "\tthis is Step no: "+(i+1));
                    Console.Write("{0}\n", c);
                    a = b;
                    b = c;
                }
            }
            else
            {
                Console.WriteLine("Enter a number from 0 till 46.");
            }
        }
    }
}
