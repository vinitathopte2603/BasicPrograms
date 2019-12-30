using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
   public class StockAccount:InterfaceStockAccount
    {
       static string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Company.json";
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
        public void Sell(string symbol)
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<Companies>>(jsondata);
            List<Companies> list = objectArray;
            int count = 0;
           foreach(Companies details in  list)
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
       public void PrintSymbols()
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<Companies>>(jsondata);
            List<Companies> list = objectArray;
            Stack stack = new Stack();
            Companies companies = new Companies();
           foreach(Companies companies1 in list)
            { 
                stack.Push(companies1.Symbol);
            }
            stack.Display();
        }

    }
}
