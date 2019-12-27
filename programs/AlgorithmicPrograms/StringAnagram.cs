//-----------------------------------------------------------------------
// <copyright file="StringAnagram.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// check if strings are anagram 
    /// </summary>
    public class StringAnagram
    {
        /// <summary>
        /// checks if given two strings are anagram or not
        /// </summary>
        public static void Anagram()
        {
            Console.WriteLine("Enter first string : ");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter second string : ");
            string string2 = Console.ReadLine();
            if (Utility.IsAnagram(string1, string2))
            {
                Console.WriteLine("Strings are anagram ");
            }
            else
            {
                Console.WriteLine("Strings are not anagram ");
            }
        }
    }
}
