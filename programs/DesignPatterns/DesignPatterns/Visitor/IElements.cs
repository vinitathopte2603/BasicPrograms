//-----------------------------------------------------------------------
// <copyright file="IElements.cs" Author="Vinita Thopte" company="Bridgelabz">
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
    public interface IElements
    {
        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <returns>returns visitors</returns>
        public int Accept(IShoppingCartVisitor visitor);
    }
}
