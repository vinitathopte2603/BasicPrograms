//-----------------------------------------------------------------------
// <copyright file="SquareRoot.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Square root a number
    /// </summary>
   public class SquareRoot
    {
        /// <summary>
        /// square root of a number using newton's method
        /// </summary>
        public static void SqrtRoot()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                double sqrt = Utility.SqurtRoot(num);
                Console.WriteLine("Square root of " + num + " is " + sqrt);
            }   
        }
    }
}
