//-----------------------------------------------------------------------
// <copyright file="BinarySearchRecurssion.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Search an element from sorted list in recursion
    /// </summary>
    public class BinarySearchRecurssion
    {
        /// <summary>
        /// Search an element from a sorted list
        /// </summary>
        public static void BinSearch()
        {
            int[] arr = { 2, 5, 12, 16, 25, 30, 43, 46, 52, 55, 58, 62 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Enter the element to be searched : ");
            int searchele = Convert.ToInt32(Console.ReadLine());
            int result = Utility.BinarySearchRec(searchele, arr, 0, arr.Length - 1);
            Console.WriteLine("Element found at " + result + " position");
        }
    }
}
