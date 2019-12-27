//-----------------------------------------------------------------------
// <copyright file="BubbleSortAlgo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class for sorting elements of an array using bubble sort algorithm
    /// </summary>
   public class BubbleSortAlgo
    {
        /// <summary>
        /// Bubble sort algorithm for sorting elements of an array
        /// </summary>
        public static void BubbleSortIntegerAlgo()
        {
            int[] arr = new int[10];
            Console.WriteLine("Enter elements into the array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Sorted array : ");
            Utility.BubbleSortInteger(arr);
        }
    }
}
