//-----------------------------------------------------------------------
// <copyright file="InventoryStructure.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// properties of grains
    /// </summary>
    public class InventoryStructure
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<Properties> rice { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<Properties> wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<Properties> pulses { get; set; }
    }
}
