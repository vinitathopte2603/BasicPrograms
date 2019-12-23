//-----------------------------------------------------------------------
// <copyright file="OrderedList.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// class to read elements from a file and perform sorting operation
    /// </summary>
   public class OrderedLnkdList
    {
        /// <summary>
        /// sorts the linked list in ascending order
        /// </summary>
        public static void OrderedLinkedList()
        {
            OrderedList lst = new OrderedList();
            ////string document = Directory.GetCurrentDirectory();
            ////string path = Path.Combine(Directory.GetCurrentDirectory(), "OrderedListFile.txt");
            StreamReader sr = new StreamReader(@"D:\bridgelabz\programs\DataStructures\DataStructures\OrderedListFile.txt");
            string filecontent = sr.ReadToEnd();
            string[] arr = filecontent.Split(",");
            int[] elements = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                elements[i] = Convert.ToInt32(arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                lst.InsertFirst(elements[i]);
            }

            lst.Display();
            Console.WriteLine("\n Sorted list");
            lst.Sort();
            lst.Display();
            Console.WriteLine("\nEnter element to be searched : ");
            int searchele = Convert.ToInt32(Console.ReadLine());
            lst.Search(searchele);
            lst.Sort();
            Console.WriteLine();
            lst.Display();
        }      
    }
}
////List<int> lst = new List<int>();
////StreamReader sr = new StreamReader(@"D:\bridgelabz\programs\DataStructures\DataStructures\OrderedListFile.txt");
////string fileContent = sr.ReadToEnd();
////string[] arr = fileContent.Split(",");
////int[] elements = new int[arr.Length];
////            for (int i = 0; i<arr.Length; i++)
////            {
////                elements[i] = Convert.ToInt32(arr[i]);
////            }
////            for (int i = 0; i<elements.Length; i++)
////            {
////                lst.Add(elements[i]);
////            }
////            lst.Sort();
////            Console.WriteLine("Sorted array");
////            foreach (int o in lst)
////            {
////                Console.Write(o+" ");
////            }
////            Console.WriteLine("\n Enter the element to be searched : ");
////            int search = Convert.ToInt32(Console.ReadLine());
////                if (lst.Contains(search))
////                {
////                    lst.Remove(search);
////                }
////                else
////                {
////                    lst.Add(search);
////                }
            
////            lst.Sort();
////            foreach (int o in lst)
////            {
////                Console.Write(o+" ");
////            }