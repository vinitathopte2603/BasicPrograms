//-----------------------------------------------------------------------
// <copyright file="SocketAdapterImplement.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// get the values in volts
    /// </summary>
    /// <seealso cref="DesignPatterns.Socket" />
    /// <seealso cref="DesignPatterns.ISocketAdapter" />
   public class SocketAdapterImplement : Socket, ISocketAdapter
    {
        /// <summary>
        /// method to get 120 volt value
        /// </summary>
        /// <returns>
        /// returns 120 volts
        /// </returns>
        public Volts Get120Volts()
        {
            return this.GetVolts();
        }

        /// <summary>
        /// method to get 12 volt value
        /// </summary>
        /// <returns>
        /// returns 12 volts
        /// </returns>
        public Volts Get12Volts()
        {
            Volts volts = GetVolts();
            return this.ConvertVolts(volts, 10);
        }

        /// <summary>
        /// method to get 3 volt value
        /// </summary>
        /// <returns>
        /// returns 3 volts
        /// </returns>
        public Volts Get3Volts()
        {
            Volts volts = this.GetVolts();
            return this.ConvertVolts(volts, 40);
        }

        /// <summary>
        /// Converts the volts.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns>returns the converted value</returns>
        private Volts ConvertVolts(Volts v, int i)
        {
            return new Volts(v.GetVolts() / i);
        }
    }
}
