using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    class StockAccount
    {   
       public static void Buy(long NumberOfShares, double price, string symbol)
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\CommercialData.json";
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                var jsonObjectArray = JsonConvert.DeserializeObject<LinkedList<CompanyShares>>(jsonData);
                LinkedList<CompanyShares> list = jsonObjectArray;
              //  list.Insert()
            }   
        }

        void PrintReport()
        { Console.WriteLine(); }
        void Sell(string symbol)
        { Console.WriteLine(); }
        void PrintSymbols()
        { Console.WriteLine(); }
        void ValueOf()
        { Console.WriteLine(); }

    }
}
