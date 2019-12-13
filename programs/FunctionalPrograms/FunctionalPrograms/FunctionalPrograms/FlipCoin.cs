  using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
       public static void FlipCoinResult()
        {
            Console.WriteLine("Enter the number of times you want to flip the coin: ");
            int flips = Convert.ToInt32(Console.ReadLine());
            Utility.FlipCoin(flips);
            
        }
    }
}
