using System;


namespace ObjectOrientedPrograms
{
    class StockUtility
    {
        public static void PrintStock(Stock[] stock, double totalShareCost)
        {
            for (int i = 1; i < stock.Length; i++)
            {
                Console.WriteLine("Name of the stock : " + stock[i].stockName);
                Console.WriteLine("Number of shares available : " + stock[i].numberOfShares);
                Console.WriteLine("Price of each stock : " + stock[i].sharePrice);
                Console.WriteLine("total share price " + stock[i].sharePrice*stock[i].numberOfShares);
                totalShareCost = totalShareCost + stock[i].sharePrice * stock[i].numberOfShares;
                Console.WriteLine();
            }
            Console.WriteLine("total cost of all shares : " + totalShareCost);
        }
    }
}
