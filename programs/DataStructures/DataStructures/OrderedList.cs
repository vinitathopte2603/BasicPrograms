namespace DataStructures
{
    using System;
using System.Collections.Generic;
    using System.IO;
using System.Text;
using System.Collections;
 


    class OrderedList
    {
        public static void OrderedLinkedList()
        {
            List<int> lst = new List<int>();
            StreamReader sr = new StreamReader(@"D:\bridgelabz\programs\DataStructures\DataStructures\OrderedListFile.txt");
            string fileContent = sr.ReadToEnd();
            string[] arr = fileContent.Split(",");
            int[] elements = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                elements[i] = Convert.ToInt32(arr[i]);
            }
            for (int i = 0; i < elements.Length; i++)
            {
                lst.Add(elements[i]);
            }
            lst.Sort();
            Console.WriteLine("Sorted array");
            foreach (int o in lst)
            {
                Console.Write(o+" ");
            }
            Console.WriteLine("\n Enter the element to be searched : ");
            int search = Convert.ToInt32(Console.ReadLine());
                if (lst.Contains(search))
                {
                    lst.Remove(search);
                }
                else
                {
                    lst.Add(search);
                }
            
            lst.Sort();
            foreach (int o in lst)
            {
                Console.Write(o+" ");
            }

        }
       
    }
}
