//-----------------------------------------------------------------------
// <copyright file="Stock.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// declaration of abstract methods
    /// </summary>
    public abstract class Stock
    {
        /// <summary>
        /// The symbol
        /// </summary>
        private string symbol;

        /// <summary>
        /// The price
        /// </summary>
        private double price;

        /// <summary>
        /// The investors
        /// </summary>
        private List<IInvestor> investors = new List<IInvestor>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Stock"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="price">The price.</param>
        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        /// <summary>
        /// Gets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol
        {
            get
            {
                return this.symbol;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.price != value)
                {
                    this.price = value;
                    this.Notify();
                }
            }
        }

        /// <summary>
        /// Notifies the changes
        /// </summary>
        public void Notify()
        {
            foreach (IInvestor investor in this.investors)
            {
                investor.Update(this);
            }
        }

        /// <summary>
        /// Attaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Attach(IInvestor investor)
        {
            this.investors.Add(investor);
        }

        /// <summary>
        /// Detaches the specified investor.
        /// </summary>
        /// <param name="investor">The investor.</param>
        public void Detach(IInvestor investor)
        {
            this.investors.Remove(investor);
        }
    }
}
