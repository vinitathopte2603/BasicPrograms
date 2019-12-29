using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
   public interface InterfaceStockAccount
    {
        void Buy(string name, string symbol, int share, int price);
        void PrintReport();
        void Sell(string symbol);
        void PrintSymbols();

    }
}
