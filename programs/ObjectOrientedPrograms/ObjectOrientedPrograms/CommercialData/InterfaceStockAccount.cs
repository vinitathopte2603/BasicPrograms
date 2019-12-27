using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    interface InterfaceStockAccount
    {
        void Buy(long NumberOfShares, double price, string symbol);
        void PrintReport();
        void Sell(string symbol);
        void PrintSymbols();
        double ValueOf();

    }
}
