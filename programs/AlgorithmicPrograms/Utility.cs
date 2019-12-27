//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
    using System.IO;
    using System.Text;
    
    /// <summary>
    /// utility class containing logic
    /// </summary>
   public class Utility
    {
        /// <summary>
        /// checking if given two strings are anagram
        /// </summary>
        /// <param name="string1">first string from user</param>
        /// <param name="string2">user input of second string</param>
        /// <returns>returns true if strings are anagram else returns false</returns>
        public static Boolean IsAnagram(string string1, string string2)
        {
            ////char[] arr1 = string1.ToCharArray();
            ////char[] arr2 = string2.ToCharArray();
            ////Array.Sort(arr1);
            ////Array.Sort(arr2);
            ////String s1 = new string(arr1);
            ////String s2 = new string(arr2);
            ////if (s1 == s2)
            ////{
            ////    return true;
            ////}
            ////else
            ////{
            ////    return false;
            ////}
            int no_Of_Characters = 256;
            char[] count1 = new char[no_Of_Characters];
            char[] count2 = new char[no_Of_Characters];
            if (string1.Length != string2.Length)
            {
                return false;
            }

            char[] arr1 = string1.ToCharArray();
            char[] arr2 = string2.ToCharArray();
            for (int i = 0; i < arr1.Length && i < arr2.Length; i++)
            {
                count1[arr1[i]]++;
                count2[arr2[i]]++;
            }

            for (int i = 0; i < no_Of_Characters; i++)
            {
                if (count1[i] != count2[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// primes numbers between 1 to 1000
        /// </summary>
        public static void Prime()
        {
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % 2 == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        /// <summary>
        /// checks if the primes are palindrome
        /// </summary>
        public static void PrimePalindrome()
        {
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
                    int reverse = 0;
                    int n = num;
                    while (n != 0)
                    {
                        int remainder = n % 10;
                        reverse = (reverse * 10) + remainder;
                        n = n / 10;
                    }

                    if (reverse == num)
                    {
                        Console.WriteLine(num + " is a palindrome ");
                    }
                }
            }
        }

        /// <summary>
        /// checks if the given prime numbers are anagram 
        /// </summary>
        public static void PrimeAnagram()
        {
            int j = 0;
            int num1 = 0, num2 = 0;
            int[] arr = new int[1000];
            for (int num = 2; num <= 1000; num++)
            {
                int temp = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % 2 == 0)
                    {
                        temp++;
                    }
                }

                if (temp == 0)
                {
                    arr[j] = num;
                    j++;
                   // arr[j] = num;
                }
            }

            Console.WriteLine("Enter two numbers : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (IsAnagram(num1, num2))
            {
                Console.WriteLine(num1 + " and " + num2 + " are anagram");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not anagram");
            }
        }

        /// <summary>
        /// searches an element from given array
        /// </summary>
        /// <param name="arr">array of integers</param>
        /// <param name="searchelement">element to be searched </param>
        /// <returns>returns the index at which the element is found</returns>
        public static int BinarySearchInt(int[] arr, int searchelement)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == searchelement)
                {
                    return mid;
                }

                if (arr[mid] < searchelement)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;     
                }
            }

            return -1;
        }

        /// <summary>
        /// Search element from the given array
        /// </summary>
        /// <param name="arr">array of strings</param>
        /// <param name="searchelement">element to be searched from the given array</param>
        /// <returns>returns the index at which the element is found</returns>
        public static int BinarySearchStr(string[] arr, string searchelement)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int result = searchelement.CompareTo(arr[mid]);
                if (result == 0)
                {
                    return mid;
                }
                else if (result < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;     
                }            
            }

            return -1;        
        }

        /// <summary>
        /// Sort the elements of an array in ascending array
        /// </summary>
        /// <param name="arr">array of integers</param>
        public static void BubbleSortInteger(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        /// <summary>
        /// sort elements of a string array in ascending array
        /// </summary>
        /// <param name="arr">array of strings</param>
        public static void BubbleSortString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        /// <summary>
        /// sorting elements of an array
        /// </summary>
        /// <param name="arr">array of integers </param>
        public static void InsertionSortInteger(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > temp)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                arr[j] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        /// <summary>
        /// sorting elements of an array 
        /// </summary>
        /// <param name="arr">array of a string</param>
        public static void InsertionSortString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[i]) > 0)
                    {
                        string temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

      /// <summary>
      /// searching an element from given array in recursion
      /// </summary>
      /// <param name="searchele">element to be searched</param>
      /// <param name="arr">array of elements</param>
      /// <param name="low">stating index of array</param>
      /// <param name="high">last index of the given array</param>
      /// <returns>return the index at which element is found</returns>
        public static int BinarySearchRec(int searchele, int[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                if (searchele == arr[mid])
                {
                    return mid;
                }

                if (searchele > arr[mid])
                {
                   return Utility.BinarySearchRec(searchele, arr, mid + 1, high); 
                }
                else
                {
                   return Utility.BinarySearchRec(searchele, arr, low, mid - 1);
                }
            }

            return -1;
        }

        /// <summary>
        /// takes input from a file to search an element 
        /// </summary>
        /// <param name="searchelement">element to be searched from a file</param>
        /// <returns>returns the index at which the element is found</returns>
        public static int BinarySearchWords(string searchelement)
        {
            StreamReader sr = new StreamReader(@"C:\Programs\AlgorithmicPrograms\AlgorithmicPrograms\BinSearchFile.txt");
            
                string fileContent = sr.ReadToEnd();
               
                    string[] arr = fileContent.Split(",");
            
            Array.Sort(arr);
           
            Console.WriteLine("Sorted array : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            if (searchelement != null)
            {
                int low = 0;
                int high = arr.Length - 1;
                while (low <= high)
                {
                    int mid = (low + high) / 2;
                    int result = searchelement.CompareTo(arr[mid]);
                    if (result == 0)
                    {
                        return mid;
                    }

                    if (result > 0)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Dividing given into halves
        /// </summary>
        /// <param name="arr">array of elements to be sorted</param>
        /// <param name="low">starting index of the array</param>
        /// <param name="high">higher index</param>
        public static void Sort(int[] arr, int low, int high)
        {
            int mid;
            if (low < high)
            {
                mid = (low + high) / 2;
                Sort(arr, low, mid);
                Sort(arr, mid + 1, high);
                Merge(arr, low, mid, high);
            }
        }

        /// <summary>
        /// returns the number of notes required to get given amount from vending machine
        /// </summary>
        /// <param name="amount">amount of money to be withdrawn from vending machine</param>
        public static void VendingMachines(int amount)
        {
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] counternotes = new int[10];
            for (int i = 0; i < 10; i++)
            {
                if (amount >= notes[i])
                {
                    counternotes[i] = amount / notes[i];
                    amount = amount % notes[i];
                   //// amount = amount - counternotes[i] * notes[i];
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(counternotes[i] + " notes of " + notes[i]);
            }
        }

        /// <summary>
        /// determines the day of week which the given date falls on
        /// </summary>
        /// <param name="date">date of a month</param>
        /// <param name="month">month of a year</param>
        /// <param name="year">input year</param>
        /// <returns>returns an integer value</returns>
        public static int DayOfTheWeek(int date, int month, int year)
        {
            double y = year - ((14 - month) / 12);
            double x = y + (y / 4) - (y / 100) + (y / 400);
            double m = month + (12 * ((14 - month) / 12)) - 2;
            int d = (int)(date + x + (31 * m / 12)) % 7;
            return d;
        }

        /// <summary>
        /// conversion of temperature
        /// </summary>
        /// <param name="tempFaren">temperature in fahrenheit</param>
        /// <param name="tempCel">temperature value in celsius</param>
        public static void TemperatureConv(double tempFaren, double tempCel)
        {
            double farenheit = (tempCel * 9 / 5) + 32;
            double celsius = (tempFaren - 32) * 5 / 9;
            Console.WriteLine("Degree to fahrenheit : " + farenheit);
            Console.WriteLine("Farenheit to Degree : " + celsius);
        }

        /// <summary>
        /// calculates the monthly payment
        /// </summary>
        /// <param name="year">number of years</param>
        /// <param name="principle">principle amount</param>
        /// <param name="interestRate">rate of interest</param>
        /// <returns>returns the total payment user gets</returns>
        public static double MonthPay(int year, double principle, double interestRate)
        {
            int n = 12 * year;
            double r = interestRate / (12 * 100);
            double payment = principle * r / (1 - Math.Pow(1 + r, -n));
            return payment;
        }

        /// <summary>
        /// square root of a number using newton's method
        /// </summary>
        /// <param name="c">input from user</param>
        /// <returns>returns square root of the given number</returns>
        public static double SqurtRoot(int c)
        {
            double t = c;
            double epsilon = 1e-15;
            while (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2.0;
            }

            return t;
        }

        /// <summary>
        /// converts decimal number to a binary number
        /// </summary>
        /// <param name="number">decimal number from a user</param>
        /// <returns>returns binary equivalent of given decimal number </returns>
        public static int DecToBin(int number)
        {
            int n = number;
            int binaryNumber = 0;
            int i = 1;
            while (n != 0)
            {
                int remainder = n % 2;
                n = n / 2;
                binaryNumber = binaryNumber + (remainder * i);
                i = i * 10;
            }

            return binaryNumber;
        }
       
        /// <summary>
        /// Swaps the nibbles of the binary number to generate new decimal number
        /// </summary>
        /// <param name="number">decimal number from user</param>
        public static void SwapNibbles(int number)
        {
            int binary = number;
            int num = (binary & 0x0F) << 4 | (binary & 0xF0) >> 4;
            Console.WriteLine("Decimal after swapping nibbles : " + num);
            Console.WriteLine(PowerOfTwo(num) ? num + " is in power of 2's" : num + " is not in power of 2's");
        }

        /// <summary>
        /// merging the divided array elements in ascending order
        /// </summary>
        /// <param name="arr">input array</param>
        /// <param name="low">starting index of the array</param>
        /// <param name="mid">middle index of the input array</param>
        /// <param name="high">higher index of the input array</param>
        private static void Merge(int[] arr, int low, int mid, int high)
        {
            int n1 = mid - low + 1;
            int n2 = high - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            for (int i = 0; i < n1; i++)
            {
                leftArray[i] = arr[low + i];
            }

            for (int j = 0; j < n2; j++)
            {
                rightArray[j] = arr[mid + 1 + j];
            }

            int k = 0, l = 0;
            int m = low;
            while (k < n1 && l < n2)
            {
                if (leftArray[k] > rightArray[l])
                {
                    arr[m] = rightArray[l];
                    l++;
                }
                else
                {
                    arr[m] = leftArray[k];
                    k++;
                }

                m++;
            }

            while (k < n1)
            {
                arr[m] = leftArray[k];
                m++;
                k++;
            }

            while (l < n2)
            {
                arr[m] = rightArray[l];
                m++;
                l++;
            }
        }

        /// <summary>
        /// Checks if the number is in power of 2
        /// </summary>
        /// <param name="number">input from user</param>
        /// <returns>returns true if the number is in power of two else returns false</returns>
        private static bool PowerOfTwo(int number)
        {
            if (number == 0)
            {
                return false;
            }

            while (number != 1)
            {
                if (number % 2 != 0)
                {
                    return false;
                }

                number = number / 2;
            }

            return true;
        }

        /// <summary>
        /// checks if given two numbers are anagram or not
        /// </summary>
        /// <param name="num1">first number</param>
        /// <param name="num2">second number</param>
        /// <returns>returns true if the numbers are anagram else returns false</returns>
        private static Boolean IsAnagram(int num1, int num2)
        {
            int[] arr1 = new int[9];
            int[] arr2 = new int[9];
            int n1 = num1;
            int n2 = num2;
            while (n1 != 0 && n2 != 0)
            {
                arr1[n1 % 10]++;
                n1 = n1 / 10;
                arr2[n2 % 10]++;
                n2 = n2 / 10;
            }

            for (int i = 0; i < 9; i++)
            {
                if (arr1.Length != arr2.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
