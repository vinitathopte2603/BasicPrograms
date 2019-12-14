//-----------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to check if palindrome of the given string is possible
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Checks if palindrome possible.
        /// </summary>
        public static void CheckIfPalindrome()
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            if (Utility.IsPalindrome(str))
            {
                Console.WriteLine("Palindrome of the given string is possible");
            }
            else
            {
                Console.WriteLine("Palindrome of given string is not possible");
            }
        }
    }
}
