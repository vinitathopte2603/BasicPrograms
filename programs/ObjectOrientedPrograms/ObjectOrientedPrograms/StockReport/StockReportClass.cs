//-----------------------------------------------------------------------
// <copyright file="StockReportClass.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.IO;
using Newtonsoft.Json;

    /// <summary>
    /// prints stock report
    /// </summary>
    public class StockReportClass
    {
        /// <summary>
        /// file path given to print the stock report
        /// </summary>
        public static void StockReport()
        {
            try
            {
                string fileContent = File.ReadAllText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Stocks.json");
                Console.WriteLine(fileContent);
                var stocks = JsonConvert.DeserializeObject<Stock[]>(fileContent);
                StockUtility.PrintStock(stocks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
