//-----------------------------------------------------------------------
// <copyright file="ShuffleCardsQueue.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// shuffles the cards and distributed using queue
    /// </summary>
   public class ShuffleCardsQueue
    {
        /// <summary>
        /// Plays the game.
        /// </summary>
        public static void PlayGame()
        {
            string[] suit = { "D", "C", "H", "S" };
            string[] rank = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
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

            CardsQueue(cards);
        }

        /// <summary>
        /// inserts cards into the queue
        /// </summary>
        /// <param name="deckCards">The deck of cards.</param>
        public static void CardsQueue(string[] deckCards)
        {
            string[] cardsAfterShuffling = Shuffle(deckCards);
            Queue queue = new Queue();
            Queue queue1 = new Queue();
            Queue queue2 = new Queue();
            Queue queue3 = new Queue();
            Queue queue4 = new Queue();
            for (int i = 0; i < cardsAfterShuffling.Length; i++)
            {
                queue.Insert(cardsAfterShuffling[i]);
            }

            queue.Display();
            Console.WriteLine();
            int count1 = 0;
            while (count1 != 10)
            {
                queue1.Insert(queue.front.nextnode.data);
                count1++;
                queue.Remove();
            }

            Console.WriteLine();
            queue1.Display();
            Console.WriteLine("\nSorted cards of player 1 : ");
            queue1.Sort(queue1);
            queue1.Display();
            Console.WriteLine();

            int count2 = 0;
            while (count2 != 10)
            {
                queue2.Insert(queue.front.data);
                count2++;
                queue.Remove();
            }

            Console.WriteLine();
            queue2.Display();
            Console.WriteLine("\nSorted cards of player 2 : ");
            queue2.Sort(queue2);
            queue2.Display();
            Console.WriteLine();

            int count3 = 0;
            while (count3 != 10)
            {
                queue3.Insert(queue.front.data);
                count3++;
                queue.Remove();
            }

            Console.WriteLine();
            queue3.Display();
            Console.WriteLine("\nSorted cards of player 3 : ");
            queue3.Sort(queue3);
            queue3.Display();
            Console.WriteLine();

            int count4 = 0;
            while (count4 != 10)
            {
                queue4.Insert(queue.front.data);
                count4++;
                queue.Remove();
            }

            Console.WriteLine();
            queue4.Display();
            Console.WriteLine("\nSorted cards of player 4 : ");
            queue4.Sort(queue4);
            queue4.Display();
            Console.WriteLine();
        }

        /// <summary>
        /// Shuffles the cards.
        /// </summary>
        /// <param name="cards">The cards.</param>
        /// <returns>array of shuffled cards</returns>
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
    }
}
