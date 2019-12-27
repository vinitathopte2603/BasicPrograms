//-----------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Class for binary conversion of a number.
    /// nibbles of the binary number are swapped to generate a new decimal number
    /// check if the new number generated is in power of two
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// Binary conversion of a number 
        /// </summary>
        public static void BinConvert()
        {
            Console.WriteLine("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Utility.SwapNibbles(number);
        }
    }
}
