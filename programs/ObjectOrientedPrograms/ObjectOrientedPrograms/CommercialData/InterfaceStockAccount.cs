//-----------------------------------------------------------------------
// <copyright file="InterfaceStockAccount.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// stock account  interface
    /// </summary>
   public interface InterfaceStockAccount
    {
        /// <summary>
        /// Buys the specified share.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="symbol">The symbol.</param>
        /// <param name="share">The share.</param>
        /// <param name="price">The price.</param>
        void Buy(string name, string symbol, int share, int price);

        /// <summary>
        /// Prints the report.
        /// </summary>
        void PrintReport();

        /// <summary>
        /// Sells the specified share.
        /// </summary>
        /// <param name="symbol">The symbol.</param>
        void Sell(string symbol);

        /// <summary>
        /// Prints the symbols.
        /// </summary>
        void PrintSymbols();
    }
}
