//-----------------------------------------------------------------------
// <copyright file="MonthlyPayment.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to calculate monthly payment
    /// </summary>
   public class MonthlyPayment
    {
        /// <summary>
        /// Monthly payment 
        /// </summary>
        public static void MonthlyPay()
        {
            Console.WriteLine("Enter the principle amount : ");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter rate of interest : ");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            double payment = Utility.MonthPay(year, principle, interestRate);
            Console.WriteLine("Payment received : " + payment);
        }
    }
}
