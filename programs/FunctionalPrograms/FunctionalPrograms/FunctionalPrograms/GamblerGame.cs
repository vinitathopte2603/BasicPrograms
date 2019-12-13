using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class GamblerGame
    {
        public static void GamblerResult()
        {
            Console.WriteLine("Enter the stake :");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the goal : ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of trials : ");
            int trials = Convert.ToInt32(Console.ReadLine());
            Utility.Gambler(stake, goal, trials);
        }
    }
}
