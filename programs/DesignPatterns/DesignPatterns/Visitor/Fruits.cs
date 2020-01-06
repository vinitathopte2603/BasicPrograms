//-----------------------------------------------------------------------
// <copyright file="Fruits.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
     using System;

     /// <summary>
     /// class implementing interface
     /// </summary>
     /// <seealso cref="DesignPatterns.IElements" />
    public class Fruits : IElements
    {
        /// <summary>
        /// The price per kg
        /// </summary>
        private int pricePerKg;

        /// <summary>
        /// The weight
        /// </summary>
        private int weight;

         /// <summary>
         /// The name
         /// </summary>
         private string name;
   
        /// <summary>
        /// Initializes a new instance of the <see cref="Fruits"/> class.
        /// </summary>
        /// <param name="priceKg">The price kg.</param>
        /// <param name="wt">The weight.</param>
        /// <param name="nm">The name.</param>
        public Fruits(int priceKg, int wt, string nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

         /// <summary>
         /// Gets the price per kg.
         /// </summary>
         /// <returns>returns the price</returns>
        public int GetPricePerKg()
        {
          return this.pricePerKg;
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        /// <returns>returns the weight</returns>
        public int GetWeight()
        {
          return this.weight;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns>returns the name</returns>
        public string GetName()
        {
          return this.name;
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>returns the total visitors</returns>
        public int Accept(IShoppingCartVisitor visitor)
        {
          return visitor.Visit(this);
        }
    }
}
