//-----------------------------------------------------------------------
// <copyright file="Volts.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// gets and sets the value of volts
    /// </summary>
   public class Volts
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volts"/> class.
        /// </summary>
        /// <param name="v">The v.</param>
        public Volts(int v)
        {
            this.volts = v;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns>returns the volt value</returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Sets the value volts.
        /// </summary>
        /// <param name="volts">The volts.</param>
        public void SetVolts(int volts)
        {
            this.volts = volts;
        }
    }
}
