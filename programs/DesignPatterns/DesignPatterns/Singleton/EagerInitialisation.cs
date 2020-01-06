//-----------------------------------------------------------------------
// <copyright file="EagerInitialisation.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to implement eager initialization
    /// </summary>
    public sealed class EagerInitialisation
    {
        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The single instance
        /// </summary>
        private static EagerInitialisation singleInstance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialisation"/> class from being created.
        /// </summary>
        private EagerInitialisation()
        {
            count++;
            Console.WriteLine("Instance created : " + count);
        }

        /// <summary>
        /// Gets the single instance.
        /// </summary>
        /// <value>
        /// The single instance.
        /// </value>
        public static EagerInitialisation SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    singleInstance = new EagerInitialisation();
                }

                return singleInstance;
            }
        }

        /// <summary>
        /// Displays the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        public void Display(string str)
        {
            Console.WriteLine(str);
        }
    }
}
