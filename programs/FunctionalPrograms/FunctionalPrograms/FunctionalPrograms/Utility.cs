namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;
    using System.Threading;

   public class Utility
    {
        public static void ReplaceString(string userName)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

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

        public static void LeapYear(int year)
        {
            if (year > 999 && year < 9999)
            {
                if (year % 4 == 0 || year % 100 == 0 || year % 400 == 0)
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

        public static double DistanceCal(int x, int y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        public static double WindChillCal(double temperature, double speed)
        {
            double w = 0;
            if (temperature > 50)
            {
                Console.WriteLine("Enter valid temperature  : ");
            }
            else
            {
                w = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature - 35.75) * Math.Pow(speed, 0.16));
            }

            return w;
        }

        public static void CouponNo(int number)
        {
            bool[] arr = new bool[number];
            int distinct = 0;
            int count = 0;
            while (distinct != number)
            {
                count++;
                int value = Utility.RandomNumbers(number);
                Console.Write(value + " ");
                if (!arr[value])
                {
                    arr[value] = true;
                    distinct++;
                }
            }

            Console.WriteLine("Total number of random numbers required : " + count);
        }

        public static void StopWatch()
        {
            DateTime start = Utility.StartTime();
            Thread.Sleep(2000);
            DateTime stop = Utility.StopTime();
            Console.WriteLine("Time elapse " + (stop - start));
        }

        public static void QuadraticEquation(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double root1 = 0, root2 = 0;
            if (delta > 0)
            {
                 root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                 root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            }
            Console.WriteLine("Square roots of x are {0} and {1}", root1, root2);

        }

        private static int RandomNumbers(int number)
        {
            Random r = new Random();
            int result = (int)r.NextDouble() * number;
            return result;
        }

        private static DateTime StartTime()
        {
            DateTime dt = DateTime.Now;
            return dt;
        }

        private static DateTime StopTime()
        {
            DateTime dtime = DateTime.Now;
            return dtime;
        }

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int flag = 0;
        static int choice;
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
            } while (flag != 1 && flag != -1);
            if (flag == 1)
            {
                Console.WriteLine("The winner is " + (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Match draw");
            }
        }
        private static void Board()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}",arr[1],arr[2],arr[3]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("   |   |   ");
        }
        private static int CheckWin()
        {
            //horizontal winning condition

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
            //verticle winning condition
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
            // diagonal winning condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            //check if the game is draw
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            //game not over 
            else
            {
                return 0;
            }
        }
        public static void StringPermutation(string str,int start,int end)
        {
            if (start == end)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = swap(str, start, i);
                    StringPermutation(str, start + 1, end);
                    str = swap(str, start, i);
                }
            }
        }
        private static string swap(string str, int firstele, int secondele)
        {
            char temp;
            char[] arr = str.ToCharArray();
            temp = arr[firstele];
            arr[firstele] = arr[secondele];
            arr[secondele] = temp;
            String s = new string(arr);
            return s;
        }
    }
}
