using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class Stock
    {
        public string stockName { get; set; }
        public long numberOfShares { get; set; }
        public double sharePrice { get; set; }
        public Stock(string name, long shares, double price)
        {
            this.stockName = name;
            this.numberOfShares = shares;
            this.sharePrice = price;
        }
    }
}
