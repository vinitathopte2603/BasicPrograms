using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class CommercialUtility
    {
        public static void BuyStake()
        {
            StockAccount stockAccount = new StockAccount();
            Console.WriteLine("Enter name of the company : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter symbol : ");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter number of shares : ");
            int shares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter price of each share : ");
            int price = Convert.ToInt32(Console.ReadLine());
            stockAccount.Buy(name, symbol, shares, price);
        }
        public static void SellStake()
        {
            StockAccount stockAccount = new StockAccount();
            Console.WriteLine("Enter the symbol of share you want to sell");
            string symbol = Console.ReadLine();
            stockAccount.Sell(symbol);
        }
        public static void PrintReport()
        {
            StockAccount stockAccount = new StockAccount();
            stockAccount.PrintReport();
        }
        public static void PrintSymbol()
        {
            StockAccount stockAccount = new StockAccount();
            stockAccount.PrintSymbols();
        }
    }
}
