using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class StockAccountUtility
    {
        StockAccount account = new StockAccount();
        public static void BuyShares()
        {
            Console.WriteLine("Enter number of shares : ");
            long numberOfShares = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter price of each share : ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter symbol : ");
            string symbol = Console.ReadLine();
           StockAccount.Buy(numberOfShares, price, symbol);
        }
    }
}
