//-----------------------------------------------------------------------
// <copyright file="ToBinary.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// conversion of decimal into binary number
    /// </summary>
    public class ToBinary
    {
        /// <summary>
        /// Binary conversion of given decimal number
        /// </summary>
        public static void BinaryConversion()
        {
            Console.WriteLine("Enter a number  : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int binary = Utility.DecToBin(number);
            Console.WriteLine("Binary conversion of " + number + " is : " + binary);
        }
    }
}
