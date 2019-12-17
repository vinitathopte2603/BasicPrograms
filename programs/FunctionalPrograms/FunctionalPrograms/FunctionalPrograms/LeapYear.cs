//-----------------------------------------------------------------------
// <copyright file="LeapYear.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// determine if the given year is leap year.
    /// </summary>
    public class LeapYear
    {
        /// <summary>
        /// Determines whether [is leap year]. Takes year as input from user.
        /// </summary>
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Utility.LeapYear(year);
        }
    }
}
