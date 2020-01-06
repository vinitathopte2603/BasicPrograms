//-----------------------------------------------------------------------
// <copyright file="Investor.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// implementation of interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IInvestor" />
   public class Investor : IInvestor
    {
        /// <summary>
        /// The stock
        /// </summary>
        private Stock stock;

        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Investor"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Investor(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets or sets the stock.
        /// </summary>
        /// <value>
        /// The stock.
        /// </value>
        public Stock Stock
        {
            get 
            {
                return this.stock;
            }

            set
            {
                this.stock = value;
            }
        }

        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        public void Update(Stock stock)
        {
            try
            {
                Console.WriteLine("Notified {0} of its changes in stock price to {2:C}", this.name, stock.Symbol, stock.Price);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
