//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;

    /// <summary>
    /// Entry point of the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Exception">any type of exception that occurs is returned </exception>
       public static void Main(string[] args)
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : String anagram \n 2 : Prime numbers \n 3 : Prime anagram and prime palindrome \n 4 : Searching \n 5 : Binary search in recurssion \n 6 : Binary search Word from a file \n 7 : Insertion sort \n 8 : Bubble Sort \n 9 : Merge Sort \n 10 : Vending Machine \n 11 : Day of week \n 12 : Temperature conversion \n 13 : Monthly payment \n 14 : Square root \n 15 : Decimal to binary \n 16 : Swap nibbles \n 17 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            StringAnagram.Anagram();
                            break;
                        case 2:
                            PrimeNumbers.PrimeNumber();
                            break;
                        case 3:
                            PrimePalindromeAnagram.PrimePalindrome();
                            PrimePalindromeAnagram.PrimeAnagram();
                            break;
                        case 4:
                            SortingAlgorithms.InsertionSortStr();
                            break;
                        case 5:
                            BinarySearchRecurssion.BinSearch();
                            break;
                        case 6:
                            BinarySearchWord.BinarySearchWrd();
                            break;
                        case 7:
                            InsertionSortAlgo.InsertionSortStringAlgo();
                            break;
                        case 8:
                            BubbleSortAlgo.BubbleSortIntegerAlgo();
                            break;
                        case 9:
                            MergeSort.MergeSortArray();
                            break;
                        case 10:
                            VendingMachine.VendingMachineNotes();
                            break;
                        case 11:
                            DayOfWeek.DaysOfWeek();
                            break;
                        case 12:
                            TemperatureConversion.TempConv();
                            break;
                        case 13:
                            MonthlyPayment.MonthlyPay();
                            break;
                        case 14:
                            SquareRoot.SqrtRoot();
                            break;
                        case 15:
                            ToBinary.BinaryConversion();
                            break;
                        case 16:
                            Binary.BinConvert();
                            break;
                        case 17:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
