//-----------------------------------------------------------------------
// <copyright file="CouponNumbers.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// generate distinct coupon numbers
    /// </summary>
    public class CouponNumbers
    {
        /// <summary>
        /// Distinct coupon numbers are generate.
        /// </summary>
        public static void DistinctCouponNumbers()
        {
            Console.WriteLine("Enter the number of distinct coupons : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Utility.CouponNo(number);
        }
    }
}
