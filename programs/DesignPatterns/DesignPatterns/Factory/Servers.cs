//-----------------------------------------------------------------------
// <copyright file="Servers.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// gets specifications of server
    /// </summary>
    /// <seealso cref="DesignPatterns.Computer" />
   public class Servers : Computer
    {
        /// <summary>
        /// The RAM
        /// </summary>
        private string ram;

        /// <summary>
        /// The HDD
        /// </summary>
        private string hdd;

        /// <summary>
        /// The CPU
        /// </summary>
        private string cpu;

        /// <summary>
        /// Initializes a new instance of the <see cref="Servers"/> class.
        /// </summary>
        /// <param name="ram">The RAM.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The CPU.</param>
        public Servers(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        /// <summary>
        /// Gets the RAM.
        /// </summary>
        /// <returns>
        /// returns the RAM value
        /// </returns>
        public override string GetRam()
        {
            return this.ram;
        }

        /// <summary>
        /// Gets the HDD.
        /// </summary>
        /// <returns>
        /// returns the value of HDD
        /// </returns>
        public override string GetHDD()
        {
            return this.hdd;
        }

        /// <summary>
        /// Gets the CPU
        /// </summary>
        /// <returns>
        /// returns the speed of CPU
        /// </returns>
        public override string GetCPU()
        {
            return this.cpu;
        }
    }
}
