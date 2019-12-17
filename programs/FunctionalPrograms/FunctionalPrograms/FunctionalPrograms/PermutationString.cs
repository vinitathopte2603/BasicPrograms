//-----------------------------------------------------------------------
// <copyright file="PermutationString.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

   /// <summary>
    /// permutation of a string
    /// </summary>
    public class PermutationString
    {
        /// <summary>
        /// String input from the user to determine the permutations of the same
        /// </summary>
        public static void StringPermute()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            Utility.StringPermutation(str, 0, str.Length - 1);
        }
    }
}
