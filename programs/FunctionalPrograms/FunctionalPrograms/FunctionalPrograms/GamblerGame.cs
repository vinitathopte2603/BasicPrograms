//-----------------------------------------------------------------------
// <copyright file="GamblerGame.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// implement a gambler game
    /// </summary>
    public class GamblerGame
    {
        /// <summary>
        /// takes input from user to execute a gambler's game
        /// </summary>
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
