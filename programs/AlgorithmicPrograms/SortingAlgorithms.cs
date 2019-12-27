//-----------------------------------------------------------------------
// <copyright file="SortingAlgorithms.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Sorting algorithms to arrange elements of the given array in ascending order
    /// </summary>
    public class SortingAlgorithms
    {
        /// <summary>
        /// binary search from an integer array
        /// </summary>
        public static void BinarySearchInte()
        {
            int[] arr = { 2, 5, 9, 12, 18, 21, 25, 30, 40 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nEnter the element to be searched : ");
            int searchElement = Convert.ToInt32(Console.ReadLine());
            int result = Utility.BinarySearchInt(arr, searchElement);
            if (result == -1)
            {
                Console.WriteLine("Element not found ");
            }
            else
            {
                Console.WriteLine("Element found at " + result + " position");
            }
        }

        /// <summary>
        /// binary search from array of strings
        /// </summary>
        public static void BinarySearchStri()
        {
            string[] arr = { "abc", "def", "ghi", "jkl", "mno", "pqr", "stu", "vwx" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nEnter element to be searched : ");
            string searchEle = Console.ReadLine();
            int result = Utility.BinarySearchStr(arr, searchEle);
            if (result == -1)
            {
                Console.WriteLine("Element not found ");
            }
            else
            {
                Console.WriteLine("Element found at " + result + " position");
            }
        }

        /// <summary>
        /// bubble sort algorithm for sorting elements of an integer array
        /// </summary>
        public static void BubbleSortInt()
        {
            int[] arr = { 12, 54, 3, 78, 18, 6, 55, 13, 2, 44 };
            Utility.BubbleSortInteger(arr);
        }

        /// <summary>
        /// bubble sort for arranging elements of an array in ascending order
        /// </summary>
        public static void BubbleSortStr()
        {
            string[] arr = { "xyz", "ghi", "pqr", "abc", "stu", "jkl", "vwx", "def", "mno" };
            Utility.BubbleSortString(arr);
        }

        /// <summary>
        /// insertion sort for array of integers
        /// </summary>
        public static void InsertionSortInt()
        {
            int[] arr = { 12, 54, 3, 78, 18, 6, 55, 13, 2, 44 };
            Utility.InsertionSortInteger(arr);
        }

        /// <summary>
        /// insertion sort for array of strings
        /// </summary>
        public static void InsertionSortStr()
        {
            string[] arr = { "jkl", "stu", "def", "mno", "abc", "vwx", "pqr", "ghi", "yz" };
            Utility.InsertionSortString(arr);
        }
    }
}
