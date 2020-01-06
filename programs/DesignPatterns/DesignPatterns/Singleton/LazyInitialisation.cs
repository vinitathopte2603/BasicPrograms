//-----------------------------------------------------------------------
// <copyright file="LazyInitialisation.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to implement lazy initialization
    /// </summary>
    public class LazyInitialisation
    {
        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The single instance
        /// </summary>
        private static Lazy<LazyInitialisation> singleInstance = new Lazy<LazyInitialisation>(() => new LazyInitialisation());

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialisation"/> class from being created.
        /// </summary>
        private LazyInitialisation()
        {
            count++;
            Console.WriteLine(count + " instance created");
        }

        /// <summary>
        /// Gets the single instance.
        /// </summary>
        /// <value>
        /// The single instance.
        /// </value>
        public static LazyInitialisation SingleInstance
        {
            get
            {
                return singleInstance.Value;
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
