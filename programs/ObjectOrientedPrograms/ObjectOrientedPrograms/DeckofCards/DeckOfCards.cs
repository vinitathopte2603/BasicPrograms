//-----------------------------------------------------------------------
// <copyright file="DeckOfCards.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// shuffling and distributing the cards 
    /// </summary>
    public class DeckOfCards
    {
        /// <summary>
        /// Plays the game.
        /// </summary>
        public static void PlayGame()
        {
            string[] suit = { "D", "C", "H", "S" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "Queen", "King", "Ace" };
            string[] cards = new string[53];
            int i = 0;
            for (int j = 0; j < suit.Length; j++)
            {
                for (int k = 0; k < rank.Length; k++)
                {
                        cards[i] = suit[j] + rank[k];
                        i++;
                }
            }

            string[] shuffledCards = Shuffle(cards);
           PrintCards(shuffledCards);
        }

        /// <summary>
        /// Prints the cards.
        /// </summary>
        /// <param name="cards">The cards.</param>
        public static void PrintCards(string[] cards)
        {
            int noOfPlayers = 4;
            int totalCards = cards.Length - 1;
            int cardPerPlayer = totalCards / noOfPlayers;
            string[,] players = new string[noOfPlayers, cardPerPlayer];
            int i = 1; 
            int j = 0;
            int k = 0;
            while (i < totalCards)
            {
                j = j % noOfPlayers; 
                players[j, k] = cards[i];
                j++; 
                i++;
                if (j == noOfPlayers)
                {
                    k++;
                }
            }

            for (int l = 0; l < 4; l++)
            {
                for (int m = 0; m < 9; m++)
                {
                    Console.Write(players[l, m] + "  ");
                }

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Shuffles the cards.
        /// </summary>
        /// <param name="cards">The cards.</param>
        /// <returns>returns the array of shuffled cards</returns>
        private static string[] Shuffle(string[] cards)
        {
            Random r = new Random();
            for (int i = 0; i < 53; i++)
            {
                int random = r.Next(52 - i);
                string temp = cards[i];
                cards[i] = cards[random];
                cards[random] = temp;
            }

            return cards;
        }
    }
}
