//-----------------------------------------------------------------------
// <copyright file="Properties.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// properties are defined
    /// </summary>
    public class Properties
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double weight { get; set; }

        /// <summary>
        /// Gets or sets the price of one kilogram grain
        /// </summary>
        /// <value>
        /// The price of one kilogram grain
        /// </value>
        public double pricePerkg { get; set; }
    }
}
