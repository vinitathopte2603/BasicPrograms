//-----------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Interface to implement the methods
    /// </summary>
   public interface ISocketAdapter
    {
        /// <summary>
        /// method to get 120 volt value
        /// </summary>
        /// <returns>returns 120 volts</returns>
        public Volts Get120Volts();

        /// <summary>
        /// method to get 12 volt value
        /// </summary>
        /// <returns>returns 12 volts</returns>
        public Volts Get12Volts();

        /// <summary>
        /// method to get 3 volt value
        /// </summary>
        /// <returns>returns 3 volts</returns>
        public Volts Get3Volts();
    }
}
