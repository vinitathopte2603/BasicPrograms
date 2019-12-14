//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Utility class containing logic 
    /// </summary>
   public class Utility
    {
        /// <summary>
        /// Finding prime numbers from 1 to 1000 and arranging them in two dimensional array
        /// </summary>
        public static void TwoDimArray()
        {
            int[,] arr = new int[10, 25];
            int first = 0, second = 0, third = 0, fourth = 0, fifth = 0, sixth = 0, seventh = 0, eighth = 0, ninth = 0, tenth = 0;
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 0)
                {
                    if (num > 0 && num < 101)
                    {
                        arr[0, first] = num;
                        first++;
                    }

                    if (num > 100 && num < 201)
                    {
                        arr[1, second] = num;
                        second++;
                    }

                    if (num > 200 && num < 301)
                    {
                        arr[2, third] = num;
                        third++;
                    }

                    if (num > 300 && num < 401)
                    {
                        arr[3, fourth] = num;
                        fourth++;
                    }

                    if (num > 400 && num < 501)
                    {
                        arr[4, fifth] = num;
                        fifth++;
                    }

                    if (num > 500 && num < 601)
                    {
                        arr[5, sixth] = num;
                        sixth++;
                    }

                    if (num > 600 && num < 701)
                    {
                        arr[6, seventh] = num;
                        seventh++;
                    }

                    if (num > 700 && num < 801)
                    {
                        arr[7, eighth] = num;
                        eighth++;
                    }

                    if (num > 800 && num < 901)
                    {
                        arr[8, ninth] = num;
                        ninth++;
                    }

                    if (num > 900 && num < 1001)
                    {
                        arr[9, tenth] = num;
                        tenth++;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Determines whether the specified string is palindrome.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(string str)
        {
            int no_of_characters = 256;
            int odd = 0;
            int[] count = new int[no_of_characters];
            Array.Fill(count, 0);
            for (int i = 0; i < str.Length; i++)
            {
                count[(int)str[i]]++;
            }

            for (int i = 0; i < no_of_characters; i++)
            {
                if (count[i] == 1)
                {
                    odd++;
                }

                if (odd > 1)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the specified expression is balanced.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns>returns a string mentioning whether the expression is balanced or not</returns>
        public static string IsBalanced(string expression)
        {
            Stack<char> stk = new Stack<char>();
            char[] arr = expression.ToCharArray();
            for (int i = 0; i < expression.Length; i++)
            {
                char current = arr[i];
                if (current == '[' || current == '(' || current == '{')
                {
                    stk.Push(current);
                }

                if (current == ']' || current == ')' || current == '}')
                {
                    if (stk.Count == 0)
                    {
                        return "Not balanced";
                    }

                    char last = stk.Peek();
                    if (current == ']' || current == ')' || current == '}')
                    {
                        stk.Pop();
                    }
                    else
                    {
                        return "Not Balanced";
                    }
                }
            }

            if (stk.Count == 0)
            {
                return "Balanced";
            }
            else
            {
                return "Not balanced";
            }
        }
    }
}
