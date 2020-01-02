//-----------------------------------------------------------------------
// <copyright file="PrintDeckOfCards.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// shuffles and prints the deck of cards received by each player
    /// </summary>
    public class PrintDeckOfCards
    {
        /// <summary>
        /// Prints the deck cards.
        /// </summary>
        public static void PrintDeckCards()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Shuffle cards \n 2 : Shuffle cards using queue \n 3 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            DeckOfCards.PlayGame();
                            break;
                        case 2:
                            ShuffleCardsQueue.PlayGame();
                            break;
                        case 3:
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
