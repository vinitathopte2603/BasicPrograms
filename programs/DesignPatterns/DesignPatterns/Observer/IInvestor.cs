//-----------------------------------------------------------------------
// <copyright file="IInvestor.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// method declaration
    /// </summary>
    public interface IInvestor
    {
        /// <summary>
        /// Updates the specified stock.
        /// </summary>
        /// <param name="stock">The stock.</param>
        void Update(Stock stock);
    }
}
