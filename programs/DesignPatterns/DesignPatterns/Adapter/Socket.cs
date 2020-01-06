//-----------------------------------------------------------------------
// <copyright file="Socket.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// socket class to get 120 volts
    /// </summary>
   public class Socket
    {
        /// <summary>
        /// Gets the value in volts.
        /// </summary>
        /// <returns>returns 120 volt value</returns>
        public Volts GetVolts()
        {
            return new Volts(120);
        }
    }
}
