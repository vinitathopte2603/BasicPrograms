using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class CouponNumbers
    {
        public static void DistinctCouponNumbers()
        {
            Console.WriteLine("Enter the number of distinct coupons : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Utility.CouponNo(number);
        }
    }
}
