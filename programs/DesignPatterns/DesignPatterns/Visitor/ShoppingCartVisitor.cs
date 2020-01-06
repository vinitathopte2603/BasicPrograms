//-----------------------------------------------------------------------
// <copyright file="ShoppingCartVisitor.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
using System;
using System.Collections.Generic;
using System.Text;

     /// <summary>
     /// interface implementation
     /// </summary>
     /// <seealso cref="DesignPatterns.IShoppingCartVisitor" />
    public class ShoppingCartVisitor : IShoppingCartVisitor
    {
        /// <summary>
        /// Visits the specified books.
        /// </summary>
        /// <param name="books">The books.</param>
        /// <returns>
        /// returns the books
        /// </returns>
        public int Visit(Books books)
        {
            int cost = 0;
            ////apply 5$ discount if book price is greater than 50
            if (books.GetPrice() > 50)
            {
                cost = books.GetPrice() - 5;
            }
            else
            {
                cost = books.GetPrice();
            }
            
             Console.WriteLine("Book ISBN::" + books.GetIsbnNumber() + " cost =" + cost);
            return cost;
        }

        /// <summary>
        /// Visits the specified fruits.
        /// </summary>
        /// <param name="fruits">The fruits.</param>
        /// <returns>
        /// returns the fruits
        /// </returns>
        public int Visit(Fruits fruits)
        {
            int cost = fruits.GetPricePerKg() * fruits.GetWeight();
            Console.WriteLine(fruits.GetName() + " cost = " + cost);
            return cost;
        }
    }
}
