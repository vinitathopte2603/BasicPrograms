//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;

    /// <summary>
    /// Entry point of the application
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <exception cref="Exception">returns any type of exception occurred</exception>
        public static void Main(string[] args)
        {
            try
            {
                bool flag = true;

                while (flag)
                {
                    Console.WriteLine("\n 1 : Replace string \n 2 : Flip Coin \n 3 : Leapyear \n 4 : Power of two \n 5 : Harmonic Series \n 6 : Prime Factors \n 7 : Gambler \n 8 : Two Dimensional Array \n 9 : Addition to zero \n 10 : Distance between two points \n 11 : Random coupon numbers \n 12 : Stop watch \n 13 : Tic Tac Toe \n 14 : Permutations of a string  \n 15 : Wind chill \n 16 : Roots of X \n 17 : Exit");
                    Console.WriteLine("Enter Your Choice");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ReplaceString.ReplaceStringResult();
                            break;
                        case 2:
                            FlipCoin.FlipCoinResult();
                            break;
                        case 3:
                            LeapYear.IsLeapYear();
                            break;
                        case 4:
                            PowerOfTwo.PowerofTwo();
                            break;
                        case 5:
                            HarmonicSeries.Harmonicseries();
                            break;
                        case 6:
                            PrimeFactors.Factors();
                            break;
                        case 7:
                            GamblerGame.GamblerResult();
                            break;
                        case 8:
                            TwoDArray.Array();
                            break;
                        case 9:
                            AdditionToZero.Addition();
                            break;
                        case 10:
                            Distance.DistanceResult();
                            break;
                        case 11:
                            CouponNumbers.DistinctCouponNumbers();
                            break;
                        case 12:
                            StopWatch.StopWatchTime();
                            break;
                        case 13:
                            TicTacToe.TicTacToeResult();
                            break;
                        case 14:
                            PermutationString.StringPermute();
                            break;
                        case 15:
                            WindChill.WindChillResult();
                            break;
                        case 16:
                            Quadratic.QuadraticEquations();
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

            Console.ReadLine();
        }
    }
}
