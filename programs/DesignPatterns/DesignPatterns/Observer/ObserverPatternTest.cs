//-----------------------------------------------------------------------
// <copyright file="ObserverPatternTest.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// test the implementation of observer pattern
    /// </summary>
   public class ObserverPatternTest
    {
        /// <summary>
        /// Makes the changes.
        /// </summary>
        public static void MakeChanges()
        {
            Syntel syntel = new Syntel("Syntel", 120.00);
            syntel.Attach(new Investor("Atos"));
            syntel.Attach(new Investor("Infosys"));
            syntel.Price = 120.00;
            syntel.Price = 121.00;
        }
    }
}
