//-----------------------------------------------------------------------
// <copyright file="PowerOfTwo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// power of two
    /// </summary>
   public class PowerOfTwo
    {
        /// <summary>
        /// user input of terms
        /// </summary>
        public static void PowerofTwo()
        {
            Console.WriteLine("Enter the number of terms : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            Utility.Power(terms);
        }
    }
}
