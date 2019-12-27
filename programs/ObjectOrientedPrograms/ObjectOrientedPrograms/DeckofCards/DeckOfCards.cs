using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class DeckOfCards
    {
        
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

            DeckOfCards.PrintCards(cards);
        }
        private static string[] Shuffle(string[] cards)
        {
            Random r = new Random();
            for (int i = 0; i < 53; i++)
            {
                int rand = r.Next(52 - i);
                string temp = cards[i];
                cards[i] = cards[rand];
                cards[rand] = temp;
            }
            return cards;
        }
        public static void PrintCards(string[] cards)
        {
            int noOfPlayers = 4;
            int totalCards = cards.Length-1;
            int cardPerPlayer = totalCards / noOfPlayers;
            string[,] players = new string[noOfPlayers, cardPerPlayer];
            int i = 0; int j = 0; int k = 0;
            while (i < totalCards)
            {
                j = j % noOfPlayers; 
                players[j, k] = cards[i];
                ++j; ++i;
                if (j == noOfPlayers) ++k; 	
            }
            for (int l = 0; l < 4; l++)
            {
                for (int m = 0; m < 9; m++)
                {
                    Console.Write(players[l,m] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
