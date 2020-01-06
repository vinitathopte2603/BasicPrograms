//-----------------------------------------------------------------------
// <copyright file="Computer.cs" Author="Vinita Thopte" company="Bridgelabz">
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
   public abstract class Computer
    {
        /// <summary>
        /// Gets the RAM.
        /// </summary>
        /// <returns>returns the RAM value</returns>
        public abstract string GetRam();

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>returns the value of HDD</returns>
        public abstract string GetHDD();

        /// <summary>
        /// Gets the CPU
        /// </summary>
        /// <returns>returns the speed of CPU</returns>
        public abstract string GetCPU();

        /// <summary>
        /// overrides the values
        /// </summary>
        /// <returns>returns the values</returns>
        public string Tostring()
        {
            return "RAM = " + this.GetRam() + ", HDD = " + this.GetHDD() + ", CPU = " + this.GetCPU();
        }
    }
}
