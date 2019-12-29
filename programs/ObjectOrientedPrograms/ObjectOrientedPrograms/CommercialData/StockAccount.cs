using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
   public class StockAccount:InterfaceStockAccount
    {
       static string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData.json";
        public void Buy(string name, string symbol, int share, int price)
        {
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                var jsonObjectArray = JsonConvert.DeserializeObject<Linkedlist<Companies>>(jsonData);
                Linkedlist<Companies> list = jsonObjectArray;
                Companies companies = new Companies();
                list.Insert(companies);
                string jsonContent = JsonConvert.SerializeObject(list);
                File.WriteAllText(path, jsonContent);

            }   
        }

       public void PrintReport()
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<Linkedlist<Companies>>(jsondata);
            Linkedlist<Companies> list = objectArray;
            Companies companies = new Companies();
            ////foreach (Companies details in list)
            ////{
            ////    Console.WriteLine(" ");
            ////    Console.WriteLine(details.Name);
            ////    Console.WriteLine(details.Symbol);
            ////    Console.WriteLine(details.Share);
            ////    Console.WriteLine(details.Price);
            ////}
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(companies.Name);
            }
        }
       public void Sell(string symbol)
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<Linkedlist<Companies>>(jsondata);
            Linkedlist<Companies> list = objectArray;
            Companies companies = new Companies();
            int count = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                count++;
                if (companies.Symbol.Equals(symbol))
                {
                    list.DeleteAtPosition(count);
                }
            }
        }
       public void PrintSymbols()
        {
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<Linkedlist<Companies>>(jsondata);
            Linkedlist<Companies> list = objectArray;
            Stack stack = new Stack();
            Companies companies = new Companies();
            for (int i = 0; i < list.Count(); i++)
            {
                stack.Push(companies.Symbol);
            }
            stack.Display();
        }

    }
}
