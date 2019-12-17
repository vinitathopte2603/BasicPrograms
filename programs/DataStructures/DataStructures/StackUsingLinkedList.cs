using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StackUsingLinkedList
    {
        public static void PrimeAnagram()
        {
            AnagramStack stk = new AnagramStack();
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
            ////for (int i = 0; i < anagram.Length; i++)
            ////{
            ////    Console.Write(anagram[i] + " ");
            ////}
            for (int i = 0; i < anagram.Length; i++)
            {
                for (int k = i + 1; k < anagram.Length; k++)
                {
                    if (Utility.IsAnagram(anagram[i], anagram[k]))
                    {
                        stk.Push(anagram[i]);
                        stk.Push(anagram[k]);
                    }
                }
                
            }
            stk.Reverse();
            stk.Display();
        }
    }
}
