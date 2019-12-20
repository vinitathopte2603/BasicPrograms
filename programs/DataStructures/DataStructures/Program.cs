//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;

    /// <summary>
    /// entry point of the program
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n 1 : 2D Array \n 2 : Palindrome checker \n 3 : Unordered linked list \n 4 : Balanced parenthesis \n 5 : Ordered linked list \n 6 : Queue \n 7 : Dequeue \n 8 : Prime anagram \n 9 : Stack using linked list \n 10 : Queue using linked list \n 11 : Hashing function \n 12 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            TwoDimensionalArray.TwoDArray();
                            break;
                        case 2:
                            PalindromeChecker.CheckIfPalindrome();
                            break;
                        case 3:
                            UnorderedList.UnorderedLinkedList();
                            break;
                        case 4:
                            BalancedParenthesis.BalanceParenthesis();
                            break;
                        case 5:
                            OrderedLnkdList.OrderedLinkedList();
                            break;
                        case 6:
                            CashCountr.CashCounter();
                            break;
                        case 7:
                            Dequeue.CheckPalindrome();
                            break;
                        case 8:
                            PrimeAnagram.PrimeAnag();
                            break;
                        case 9:
                            StackUsingLinkedList.PrimeAnagram();
                            break;
                        case 10:
                            QueueUsingLinkedList.PrimeAnagrm();
                            break;
                        case 11:
                            HashFunctionCall.CallingHash();
                            break;
                        case 12:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
