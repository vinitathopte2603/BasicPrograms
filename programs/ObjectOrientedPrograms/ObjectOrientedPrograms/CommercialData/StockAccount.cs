//-----------------------------------------------------------------------
// <copyright file="StockAccount.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

    /// <summary>
    /// class implementing the methods from given interface
    /// </summary>
    /// <seealso cref="ObjectOrientedPrograms.InterfaceStockAccount" />
    public class StockAccount : InterfaceStockAccount
    {
        /// <summary>
        /// The path of file
        /// </summary>
       private static string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Company.json";

        /// <summary>
        /// Buys the specified share.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="share">The share.</param>
        /// <param name="price">The price.</param>
        public void Buy(string name, string symbol, int share, int price)
        {
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                var jsonObjectArray = JsonConvert.DeserializeObject<List<Companies>>(jsonData);
                List<Companies> list = jsonObjectArray;
                Companies companies = new Companies();
                companies.Name = name;
                companies.Symbol = symbol;
                companies.Share = share;
                companies.Price = price;
                companies.PurchaseDate = DateTime.Now.ToString();
                list.Add(companies);
                string jsonContent = JsonConvert.SerializeObject(list);
                File.WriteAllText(path, jsonContent);
            }   
        }

        /// <summary>
        /// Prints the report.
        /// </summary>
        public void PrintReport()
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<Companies>>(jsondata);
            List<Companies> list = objectArray;
            foreach (Companies details in list)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Name of company : " + details.Name);
                Console.WriteLine("Symbol : " + details.Symbol);
                Console.WriteLine("Number of shares : " + details.Share);
                Console.WriteLine("Price of the shares : " + details.Price);
                Console.WriteLine("Purchased time : " + details.PurchaseDate);
            }
        }

        /// <summary>
        /// Sells the specified share.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        public void Sell(string symbol)
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<Companies>>(jsondata);
            List<Companies> list = objectArray;
            int count = 0;
           foreach (Companies details in list)
            { 
                count++;
                if (details.Symbol.Equals(symbol))
                {
                    list.Remove(details);
                    Console.WriteLine("Shares sold");
                    string data = JsonConvert.SerializeObject(list);
                    File.WriteAllText(path, data);
                    break;
                }  
            }
        }

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        public void PrintSymbols()
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<Companies>>(jsondata);
            List<Companies> list = objectArray;
            Stack stack = new Stack();
            Companies companies = new Companies();
           foreach (Companies companies1 in list)
            { 
                stack.Push(companies1.Symbol);
            }

            stack.Display();
        }
    }
}
