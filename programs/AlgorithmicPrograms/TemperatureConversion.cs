//-----------------------------------------------------------------------
// <copyright file="TemperatureConversion.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Conversion of temperature
    /// </summary>
   public class TemperatureConversion
    {
        /// <summary>
        /// converts temperature 
        /// </summary>
        public static void TempConv()
        {
            Console.WriteLine("Enter the value of temperature in celsius : ");
            double cel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of temperature in Farenheit : ");
            double far = Convert.ToDouble(Console.ReadLine());
            Utility.TemperatureConv(far, cel);
        }
    }
}
