//-----------------------------------------------------------------------
// <copyright file="MergeSort.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// merge sort algorithm to sort elements of given array
    /// </summary>
    public class MergeSort
    {
        /// <summary>
        /// method to given input to sort function 
        /// </summary>
        public static void MergeSortArray()
        {
            int[] arr = { 5, 3, 8, 1, 2, 6, 7, 4, 9 };
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int n = arr.Length;
            Utility.Sort(arr, 0, n - 1);
            Console.WriteLine(" \nSorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
