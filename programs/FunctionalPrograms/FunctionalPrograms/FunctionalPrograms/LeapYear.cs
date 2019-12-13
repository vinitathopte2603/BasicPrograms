using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public static void IsLeapYear()
        {
            Console.WriteLine("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Utility.LeapYear(year);
        }
    }
}
