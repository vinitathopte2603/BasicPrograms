//-----------------------------------------------------------------------
// <copyright file="CommercialUtility.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// perform transactions
    /// </summary>
   public class CommercialUtility
    {
        /// <summary>
        /// Buys the stake.
        /// </summary>
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

        /// <summary>
        /// Sells the stake.
        /// </summary>
        public static void SellStake()
        {
            StockAccount stockAccount = new StockAccount();
            Console.WriteLine("Enter the symbol of share you want to sell");
            string symbol = Console.ReadLine();
            stockAccount.Sell(symbol);
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public static void PrintReport()
        {
            StockAccount stockAccount = new StockAccount();
            stockAccount.PrintReport();
        }

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        public static void PrintSymbol()
        {
            StockAccount stockAccount = new StockAccount();
            stockAccount.PrintSymbols();
        }
    }
}
