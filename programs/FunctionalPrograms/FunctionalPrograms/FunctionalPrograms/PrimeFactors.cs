//-----------------------------------------------------------------------
// <copyright file="PrimeFactors.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Prime factors of a number
    /// </summary>
    public class PrimeFactors
    {
        /// <summary>
        /// user input of the number to determine its factors
        /// </summary>
        public static void Factors()
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Utility.Primefactors(number);
        }
    }
}
