//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
    using System.Text.RegularExpressions;

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
                    Console.WriteLine("\n 1 : 2D Array \n 2 : Palindrome checker \n 3 : Unordered linked list \n 4 : Balanced parenthesis \n 5 : Ordered linked list \n 6 : Queue \n 7 : Dequeue \n 8 : Prime anagram \n 9 : Stack using linked list \n 10 : Queue using linked list \n 11 : Hashing function \n 12 : Monthly calendar \n 13 : Calendar using queue \n 14 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    string choice = Console.ReadLine();
                    string choiceInputPattern = @"^(1[0-4]|[1-9])$";
                    string digitPattern = @"^[0-9]*$";
                    int choiceInput = 0;
                    if (Regex.IsMatch(choice.ToString(), digitPattern))
                    {
                        if (!Regex.IsMatch(choice.ToString(), choiceInputPattern))
                        {
                            Console.WriteLine("enter valid choice");
                        }
                        else
                        {
                            choiceInput = Convert.ToInt32(choice);
                        }
                    }
                    else
                    {
                        Console.WriteLine("enter valid input");
                    }

                    switch (choiceInput)
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
                            Calendar.MonthlyCalendarCall();
                            break;
                        case 13:
                            CalendarQueue.CalendarQue();
                            break;
                        case 14:
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
