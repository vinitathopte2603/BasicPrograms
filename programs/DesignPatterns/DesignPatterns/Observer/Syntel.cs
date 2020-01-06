//-----------------------------------------------------------------------
// <copyright file="Syntel.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// implementation of abstract class stock
    /// </summary>
    /// <seealso cref="DesignPatterns.Stock" />
   public class Syntel : Stock
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Syntel"/> class.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        /// <param name="price">The price.</param>
        public Syntel(string symbol, double price) : base(symbol, price)
        {
        }
    }
}
