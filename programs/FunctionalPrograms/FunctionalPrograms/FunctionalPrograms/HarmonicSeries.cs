//-----------------------------------------------------------------------
// <copyright file="HarmonicSeries.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// calculate harmonic series.
    /// </summary>
   public class HarmonicSeries
    {
        /// <summary>
        /// numbers of terms as input from user to determine the series
        /// </summary>
        public static void Harmonicseries()
        {
            Console.WriteLine("enter the number of terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            double result = Utility.Harmonicseries(terms);
            Console.WriteLine("= " + result);
        }
    }
}
