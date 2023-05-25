using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Logical_Programming_Practice
{
    internal class Coupons
    {
        public static void coup(int n)
        {
            int[] coupons = new int[n];
            for (int i = 0; i < n; i++)
            {
                coupons[i] = -1; // Initialize with a non-valid value
            }

            Random random = new Random();
            int distinctCoupons = 0;
            int totalCoupons = 0;

            int upperLimit = (int)Math.Pow(10, n.ToString().Length);
            // This part of the code will allow our code to have Flexible Range.

            while (distinctCoupons < n)
            {
                int newCoupon = random.Next(0, upperLimit); // Generate new coupon number
                totalCoupons++;

                if (!Contains(coupons, newCoupon))
                {
                    coupons[distinctCoupons] = newCoupon;
                    distinctCoupons++;
                }
            }
            Console.WriteLine("Total random numbers needed to generate all distinct numbers: " + totalCoupons);

        }
        /*
         * We generate random numbers, 
         * We ONLY Store it in to the array if that value isn't already a part of it< 
         * AND we count the total number of times we had to generate Random numbers
         */


        static bool Contains(int[] arr, int value)
        {
            foreach (int num in arr)
            {
                if (num == value)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
