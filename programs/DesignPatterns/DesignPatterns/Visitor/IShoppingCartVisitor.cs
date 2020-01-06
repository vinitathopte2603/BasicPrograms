//-----------------------------------------------------------------------
// <copyright file="IShoppingCartVisitor.cs" Author="Vinita Thopte" company="Bridgelabz">
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
    public interface IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified books.
        /// </summary>
        /// <param name="books">The books.</param>
        /// <returns>returns the books</returns>
        int Visit(Books books);

        /// <summary>
        /// Visits the specified fruits.
        /// </summary>
        /// <param name="fruits">The fruits.</param>
        /// <returns>returns the fruits</returns>
        int Visit(Fruits fruits);
    }
}
