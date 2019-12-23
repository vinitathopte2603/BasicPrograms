//-----------------------------------------------------------------------
// <copyright file="HashFunctionCall.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

    /// <summary>
    /// class to read input and execute the hash function and display elements.
    /// </summary>
   public class HashFunctionCall
    {
        /// <summary>
        /// a list to store elements
        /// </summary>
        static List<int> inputhash = new List<int>();

        /// <summary>
        /// The 2 D array to store elements
        /// </summary>
        static int[,] hasharray = new int[10, 10];

        /// <summary>
        /// reads input from the file and after performing operations on data, the data is printed
        /// </summary>
        public static void CallingHash()
        {
            StreamReader sr = new StreamReader(@"D:\bridgelabz\programs\DataStructures\DataStructures\HashingInput.txt");
            string filecontent = sr.ReadToEnd();
            string[] arr = filecontent.Split(",");
            for (int i = 0; i < arr.Length; i++)
            {
                inputhash.Add(Convert.ToInt32(arr[i]));
            }

            HashingFunction hash = new HashingFunction();
            hasharray = hash.HashFunction(inputhash);
            Console.WriteLine("Array elements");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (hasharray[i, j] != 0)
                    {
                        Console.Write(hasharray[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("-" + " ");
                    }

                }

                    Console.WriteLine();
            }

            Console.WriteLine("Enter the number to search : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element found at " + (hash.Search(number) + 1) + " index in hash table");
        }
    }
}
