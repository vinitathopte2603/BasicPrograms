//-----------------------------------------------------------------------
// <copyright file="VisitorPatternTest.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
 using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// test visitor pattern
    /// </summary>
    public class VisitorPatternTest
    {
        /// <summary>
        /// tests the visitor pattern
        /// </summary>
        public static void VisitorTest()
        {
                IElements[] items = new IElements[]
                {
                    new Books(20, "1234"), new Books(100, "5678"),
                    new Fruits(10, 2, "Banana"), new Fruits(5, 5, "Apple")
                };

            int total = CalculatePrice(items);
            Console.WriteLine("Total Cost = " + total);
        }

        /// <summary>
        /// Calculates the price.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <returns>returns the sum</returns>
        private static int CalculatePrice(IElements[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitor();
            int sum = 0;
            foreach (IElements item in items)
            {
               sum = sum + item.Accept(visitor);
            }
             
            return sum;
        }
    }
}
