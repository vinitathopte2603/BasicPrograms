//-----------------------------------------------------------------------
// <copyright file="Factory.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to return the system type specifications
    /// </summary>
   public class Factory
    {
        /// <summary>
        /// Gets the computer.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="ram">The RAM.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The CPU.</param>
        /// <returns>returns the specifications of the systems</returns>
        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if ("PCs".Equals(type))
            {
                return new PCs(ram, hdd, cpu);
            }
            else if ("Laptop".Equals(type))
            {
                return new Laptop(ram, hdd, cpu);
            }
            else if ("Servers".Equals(type))
            {
                return new Servers(ram, hdd, cpu);
            }

            return null;
        }
    }
}
