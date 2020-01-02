//-----------------------------------------------------------------------
// <copyright file="StockUtility.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// prints the available grains present in the stock
    /// </summary>
    class StockUtility
    {
        /// <summary>
        /// Prints the stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        public static void PrintStock(Stock[] stock)
        {
            double totalShareCost = 0.0;
            for (int i = 1; i < stock.Length; i++)
            {
                Console.WriteLine("Name of the stock : " + stock[i].stockName);
                Console.WriteLine("Number of shares available : " + stock[i].numberOfShares);
                Console.WriteLine("Price of each stock : " + stock[i].sharePrice);
                Console.WriteLine("total share price " + (stock[i].sharePrice * stock[i].numberOfShares));
                totalShareCost = totalShareCost + (stock[i].sharePrice * stock[i].numberOfShares);
                Console.WriteLine();
            }

            Console.WriteLine("total cost of all shares : " + totalShareCost);
        }
    }
}
