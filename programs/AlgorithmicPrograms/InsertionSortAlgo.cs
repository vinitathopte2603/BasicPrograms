//-----------------------------------------------------------------------
// <copyright file="InsertionSortAlgo.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// sorting elements of an array in ascending order using insertion sort
    /// </summary>
   public class InsertionSortAlgo
    {
        /// <summary>
        /// insertion sort for arranging elements of an array
        /// </summary>
        public static void InsertionSortStringAlgo()
        {
            string[] arr = new string[10];
            Console.WriteLine("Enter elements into the array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine("Sorted array : ");
            Utility.InsertionSortString(arr);
        }
    }
}
