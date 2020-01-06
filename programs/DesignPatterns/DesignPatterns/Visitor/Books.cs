//-----------------------------------------------------------------------
// <copyright file="Books.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
using System;
using System.Collections.Generic;
using System.Text;

     /// <summary>
     /// class to implement interface
     /// </summary>
     /// <seealso cref="DesignPatterns.IElements" />
    public class Books : IElements
    {
         /// <summary>
         /// The price
         /// </summary>
         private int price;

         /// <summary>
         /// The book number
         /// </summary>
         private string isbnNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Books"/> class.
        /// </summary>
        /// <param name="cost">The cost.</param>
        /// <param name="isbn">The book number.</param>
        public Books(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns>returns the price</returns>
        public int GetPrice()
        {
          return this.price;
        }

        /// <summary>
        /// Gets the book number.
        /// </summary>
        /// <returns>returns the number</returns>
        public string GetIsbnNumber()
        {
          return this.isbnNumber;
        }

         /// <summary>
         /// Accepts the specified visitor.
         /// </summary>
         /// <param name="visitor">The visitor.</param>
         /// <returns>the number of visitors</returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
