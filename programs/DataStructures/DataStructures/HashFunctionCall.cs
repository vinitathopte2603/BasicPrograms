using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructures
{
    class HashFunctionCall
    {
       static List<int> inputhash = new List<int>();
        static int[,] hasharray = new int[10, 10];
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
                    Console.Write(hasharray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the number to search : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Element found at "+(hash.Search(number)+1)+"index in hash table");
        }
    }
}
