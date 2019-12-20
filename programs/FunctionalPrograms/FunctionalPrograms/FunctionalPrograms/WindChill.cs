//-----------------------------------------------------------------------
// <copyright file="WindChill.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// calculates wind chill
    /// </summary>
   public class WindChill
    {
        /// <summary>
        /// takes user input to calculate wind chill
        /// </summary>
        public static void WindChillResult()
        {
            Console.WriteLine("Enter the temperature in temperature : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter speed of wind : ");
            double speed = Convert.ToDouble(Console.ReadLine());
            double windchill = Utility.WindChillCal(temperature, speed);
            Console.WriteLine("Windchill : " + windchill);
        }
    }
}
