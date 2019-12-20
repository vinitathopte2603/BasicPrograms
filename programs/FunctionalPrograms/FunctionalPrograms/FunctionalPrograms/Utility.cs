//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;
    using System.Threading;

    /// <summary>
    /// utility class containing logic
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// array representing tic tac toe board
        /// </summary>
        private static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>
        /// Player initialized to 1
        /// </summary>
        private static int player = 1;

        /// <summary>
        /// flag initialized to 0
        /// </summary>
        private static int flag = 0;

        /// <summary>
        /// choice taken from user
        /// </summary>
        private static int choice;

        /// <summary>
        /// Replaces the string.
        /// </summary>
        /// <param name="userName">Name of the user.</param>      
        public static void ReplaceString(string userName)
        {
                string str = "Hello username,How are you ?";
                if (userName.Length > 3)
                {
                    str = str.Replace("username", userName);
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("String length should be greater than 3");
                }
        }

        /// <summary>
        /// Flips the coin.
        /// </summary>
        /// <param name="flips">The flips.</param>
        public static void FlipCoin(int flips)
        {
            Random r = new Random();
            int heads = 0, tails = 0;
            for (int i = 1; i <= flips; i++)
            {
                double res = r.NextDouble();
                if (res > 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double per_head = (double)(heads * 100) / flips;
            double per_tail = (double)(tails * 100) / flips;
            Console.WriteLine("Head percentage " + per_head);
            Console.WriteLine("Tail percentage " + per_tail);
        }

        /// <summary>
        /// checks if the given year is leap year or not
        /// </summary>
        /// <param name="year">The year.</param>
        public static void LeapYear(int year)
        {
            if (year > 999 && year < 9999)
            {
                if ((year % 100 != 0 && year % 4 == 0) || year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year ");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid year"); 
            }
        }

        /// <summary>
        /// Powers the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        public static void Power(int number)
        {
            double result;
            if (number < 31)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = Math.Pow(2, i);

                    Console.WriteLine("2 raised to " + i + " is : " + result);
                }
            }
            else
            {
                Console.WriteLine("Enter valid range ");
            }          
        }

        /// <summary>
        /// calculates Nth term of the series
        /// </summary>
        /// <param name="terms">The terms.</param>
        /// <returns>returns the last element of the series</returns>
        public static double Harmonicseries(int terms)
        {
            double result = 0;
            for (int i = 1; i <= terms; i++)
            {
                result = result + ((double)1 / i);

                Console.Write("1/" + i + " +");
            }

            return result;
        }

        /// <summary>
        /// Prime factors of the specified number.
        /// </summary>
        /// <param name="number">The number.</param>
        public static void Primefactors(int number)
        {
            for (int i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i + " ,");
                }
            }
        }

        /// <summary>
        /// Gambler game
        /// </summary>
        /// <param name="stake">The stake.</param>
        /// <param name="goal">The goal.</param>
        /// <param name="trials">The trials.</param>
        public static void Gambler(int stake, int goal, int trials)
        {
            int wins = 0;
            Random r = new Random();
            for (int i = 1; i <= trials; i++)
            {
                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    double res = r.NextDouble();

                    if (res > 0.5)
                    {
                        cash++;
                    }
                    else
                    {
                        cash--;
                    }
                }

                if (cash == goal)
                {
                    wins++;
                }
            }

            double percentage_win = (double)(wins * 100) / trials;
            int lose = trials - wins;
            double percentage_lose = (double)(lose * 100) / trials;
            Console.WriteLine("Total wins " + wins);

            Console.WriteLine("Percentage wins  :" + percentage_win + " %");

            Console.WriteLine("Percentage lose  :" + percentage_lose + " %");
        }

        /// <summary>
        /// two dimensional array
        /// </summary>
        /// <param name="rows">The rows.</param>
        /// <param name="columns">The columns.</param>
        public static void TwoDimArray(int rows, int columns)
        {
            int[,] arr = new int[rows, columns];
            Console.WriteLine("Enter elements into the array : ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Addition of elements of array to the zero.
        /// </summary>
        public static void AdditiontoZero()
        {
            int[] arr = { 8, -3, 0, 5, -8, 2, 6, -5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Console.WriteLine(arr[i] + "," + arr[j] + "," + arr[k]);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Distance calculation.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>returns the distance between two points</returns>
        public static double DistanceCal(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        /// <summary>
        /// calculates the wind chill
        /// </summary>
        /// <param name="temperature">The temperature.</param>
        /// <param name="speed">The speed.</param>
        /// <returns>the value of wind chill</returns>
        public static double WindChillCal(double temperature, double speed)
        {
            double w = 0;
            if (temperature > 50)
            {
                Console.WriteLine("Enter valid temperature  : ");
            }
            else
            {
                w = 35.74 + (0.6215 * temperature) + (((0.4275 * temperature) - 35.75) * Math.Pow(speed, 0.16));
            }

            return w;
        }

        /// <summary>
        /// generates distinct coupon numbers
        /// </summary>
        /// <param name="number">The number.</param>
        public static void CouponNo(int number)
        {
            bool[] arr = new bool[100000];
            int distinct = 0;
            int count = 0;
            while (distinct != number)
            {
                count++;
                int value = Utility.RandomNumbers();
              ////  Console.Write(value + " ");
                if (!arr[value])
                {
                    arr[value] = true;
                    distinct++;
                    Console.Write(value + " ");
                }
            }

            Console.WriteLine("\n Total number of random numbers required : " + count);
        }

        /// <summary>
        /// calculates the time elapse.
        /// </summary>
        public static void StopWatch()
        {
            DateTime start = Utility.StartTime();
            Thread.Sleep(2000);
            DateTime stop = Utility.StopTime();
            Console.WriteLine("Time elapse " + (stop - start));
        }

        /// <summary>
        /// calculates roots of a quadratic equation
        /// </summary>
        /// <param name="a">value of a</param>
        /// <param name="b">value of b.</param>
        /// <param name="c">value of c.</param>
        public static void QuadraticEquation(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            double root1 = 0, root2 = 0;
            if (delta > 0)
            {
                 root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                 root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }

            Console.WriteLine("Square roots of x are {0} and {1}", root1, root2);
        }

        /// <summary>
        /// checks permutations in which string can be arranged
        /// </summary>
        /// <param name="str">string input</param>
        /// <param name="start">starting element</param>
        /// <param name="end">last element</param>
        public static void StringPermutation(string str, int start, int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    StringPermutation(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }

        /// <summary>
        /// Tic tac toe implementation
        /// </summary>
        public static void TicTacToeGame()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 : X and Player 2 : O");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance ");
                }
                else
                {
                    Console.WriteLine("Player 1 chance ");
                }

                Board();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                }
                else
                {
                    Console.WriteLine("The position is already marked !");
                    Thread.Sleep(1000);
                }

                flag = CheckWin();
            } 
            while (flag != 1 && flag != -1);
            if (flag == 1)
            {
                Console.WriteLine("The winner is " + ((player % 2) + 1));
            }
            else
            {
                Console.WriteLine("Match draw");
            }
        }

        /// <summary>
        /// display the tic tac toe board
        /// </summary>
        private static void Board()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("   |   |   ");
        }

        /// <summary>
        /// checks winning condition
        /// </summary>
        /// <returns>returns 1 if winning condition, 0 if game is still played, -1 if the game is draw</returns>
        private static int CheckWin()
        {
            ////horizontal winning condition

            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            ////verticle winning condition
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            //// diagonal winning condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            ////check if the game is draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            ////game not over 
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// swaps the elements of the string
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="firstele">first element to be swapped</param>
        /// <param name="secondele">second element to be swapped</param>
        /// <returns>returns the string after the elements are swapped</returns>
        private static string Swap(string str, int firstele, int secondele)
        {
            char temp;
            char[] arr = str.ToCharArray();
            temp = arr[firstele];
            arr[firstele] = arr[secondele];
            arr[secondele] = temp;
            string s = new string(arr);
            return s;
        }

        /// <summary>
        /// generates random numbers
        /// </summary>
        /// <returns>returns the random number generated</returns>
        private static int RandomNumbers()
        {
            Random r = new Random();
            int result = r.Next(100000);
            return result;
        }

        /// <summary>
        /// Starts the time.
        /// </summary>
        /// <returns>returns the current system time</returns>
        private static DateTime StartTime()
        {
            DateTime dt = DateTime.Now;
            return dt;
        }

        /// <summary>
        /// Stops the time.
        /// </summary>
        /// <returns>returns the current system time</returns>
        private static DateTime StopTime()
        {
            DateTime dtime = DateTime.Now;
            return dtime;
        }
    }
}
