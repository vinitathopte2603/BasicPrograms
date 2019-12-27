using System;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
   public class StockReportClass
    {
        
        public static void StockReport()
        {
            try
            {
                double totalShareCost = 0.0;
                string fileContent = File.ReadAllText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Stocks.json");
                Console.WriteLine(fileContent);
                Stock[] stocks = JsonConvert.DeserializeObject<Stock[]>(fileContent);
                StockUtility.PrintStock(stocks, totalShareCost);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
