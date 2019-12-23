//-----------------------------------------------------------------------
// <copyright file="QueueUsingLinkedList.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class to determine anagram numbers those are prime
    /// </summary>
    public class QueueUsingLinkedList
    {
        /// <summary>
        /// checks if two given prime numbers from list are anagram or not
        /// </summary>
        public static void PrimeAnagrm()
        {
            Queue queue = new Queue();
            int[] anagram = new int[170];
            int j = 0;
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 0)
                {
                    anagram[j] = num;
                    j++;
                }
            }

            for (int i = 0; i < anagram.Length; i++)
            {
                for (int k = i + 1; k < anagram.Length; k++)
                {
                    if (Utility.IsAnagram(anagram[i], anagram[k]))
                    {
                        queue.Insert(anagram[i]);
                        queue.Insert(anagram[k]);
                    }
                }
            }

            queue.Display();
        }  
    }
}
