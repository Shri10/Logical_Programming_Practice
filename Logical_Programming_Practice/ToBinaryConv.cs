using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming_Practice
{
    internal class ToBinaryConv
    {
        public static string toBinary(int num)
        {
            string binary = "";

            while (num > 0)
            {
                binary = (num % 2) + binary;
                num = num / 2;
            }
            //Console.WriteLine("Binary representation of the given decimal number: " + binary);
            return binary;
        }
    }
}
