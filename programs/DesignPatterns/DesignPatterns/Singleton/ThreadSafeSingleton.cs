//-----------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to implement thread safe singleton pattern
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// The object
        /// </summary>
        private static readonly object Obj = new object();

        /// <summary>
        /// The count
        /// </summary>
        private static int count = 0;

        /// <summary>
        /// The single instance
        /// </summary>
        private static ThreadSafeSingleton singleInstance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
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
        public static ThreadSafeSingleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    lock (Obj)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new ThreadSafeSingleton();
                        }
                    }
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
