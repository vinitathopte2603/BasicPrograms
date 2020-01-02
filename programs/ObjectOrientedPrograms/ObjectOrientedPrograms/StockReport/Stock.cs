//-----------------------------------------------------------------------
// <copyright file="Stock.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// user defined data type for stocks
    /// </summary>
   public class Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="shares">The shares.</param>
        /// <param name="price">The price.</param>
        public Stock(string name, long shares, double price)
        {
            this.stockName = name;
            this.numberOfShares = shares;
            this.sharePrice = price;
        }

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string stockName { get; set; }

        /// <summary>
        /// Gets or sets the number of shares.
        /// </summary>
        /// <value>
        /// The number of shares.
        /// </value>
        public long numberOfShares { get; set; }

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public double sharePrice { get; set; }
    }
}
