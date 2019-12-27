//-----------------------------------------------------------------------
// <copyright file="BinarySearchWord.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// search an element from a sorted string array
    /// </summary>
   public class BinarySearchWord
    {
        /// <summary>
        /// binary search string
        /// </summary>
        public static void BinarySearchWrd()
        {
            string[] arr = { "xyz", "def", "pqr", "abc", "ghi", "lmo", "jkl", "stu", "vwx" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Enter element to be searched : ");
            string element = Console.ReadLine();
            int result = Utility.BinarySearchWords(element);
            if (result == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("\n Element found at " + result + " position");
            }
        }
    }
}
