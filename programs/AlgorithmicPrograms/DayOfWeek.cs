//-----------------------------------------------------------------------
// <copyright file="DayOfWeek.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// to determine the day of week
    /// </summary>
    public class DayOfWeek
    {
        /// <summary>
        /// method to determine the day of week on which the given date falls
        /// </summary>
        public static void DaysOfWeek()
        {
            Console.WriteLine("Enter date : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (date <= 31 && month <= 12 && year > 999 && year <= 9999)
            {
                int day = Utility.DayOfTheWeek(date, month, year);
                if (day == 1)
                {
                    Console.WriteLine("Sunday");
                }

                if (day == 2)
                {
                    Console.WriteLine("Monday");
                }

                if (day == 3)
                {
                    Console.WriteLine("Tuesday");
                }

                if (day == 4)
                {
                    Console.WriteLine("Wednesday");
                }

                if (day == 5)
                {
                    Console.WriteLine("Thursday");
                }

                if (day == 6)
                {
                    Console.WriteLine("Friday");
                }

                if (day == 7)
                {
                    Console.WriteLine("Saturday");
                }
            }
        }
    }
}
