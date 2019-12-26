//-----------------------------------------------------------------------
// <copyright file="CalendarQueue.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// implementation of calendar
    /// </summary>
    public class CalendarQueue
    {
        /// <summary>
        /// Input from user to represent calendar of the specific month
        /// </summary>
        public static void CalendarQue()
        {
            try
            {
                Console.WriteLine("Enter year : ");
                string yearInput = Console.ReadLine();
                string digitPattern = @"^[0-9]*$";
                if (Regex.IsMatch(yearInput.ToString(), digitPattern))
                {
                    int year = Convert.ToInt32(yearInput);
                    if (!MonthlyCalender.IsYearValid(year))
                    {
                        Console.WriteLine("Enter valid year");
                    }
                    else
                    {
                        Console.WriteLine("Enter month : ");
                        int month = Convert.ToInt32(Console.ReadLine());

                        if (!MonthlyCalender.IsMonthValid(month))
                        {
                            Console.WriteLine("Enter valid month!");
                        }
                        else
                        {
                            Utility.CalendarUsingQueue(year, month);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter valid input");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
