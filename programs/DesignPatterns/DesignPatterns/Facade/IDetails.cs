//-----------------------------------------------------------------------
// <copyright file="IDetails.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// interface of details
    /// </summary>
   public interface IDetails
    {
        /// <summary>
        /// name input from user
        /// </summary>
        /// <returns>returns the name</returns>
        public string Name();

        /// <summary>
        /// city input from user
        /// </summary>
        /// <returns>returns the city name</returns>
        public string City();

        /// <summary>
        /// state user input
        /// </summary>
        /// <returns>returns the name of state</returns>
        public string State();

        /// <summary>
        /// user input to take zip code
        /// </summary>
        /// <returns>returns zip code</returns>
        public long ZipCode();

        /// <summary>
        /// contact details input from user
        /// </summary>
        /// <returns>returns contact number</returns>
        public long ContactNumber();
    }
}
