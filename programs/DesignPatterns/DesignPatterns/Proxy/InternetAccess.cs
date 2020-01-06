//-----------------------------------------------------------------------
// <copyright file="InternetAccess.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// implementation of interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IOfficeInternetAccess" />
   public class InternetAccess : IOfficeInternetAccess
    {
        /// <summary>
        /// The employee name
        /// </summary>
        private string employeeName;

        /// <summary>
        /// Initializes a new instance of the <see cref="InternetAccess"/> class.
        /// </summary>
        /// <param name="empName">Name of the employee.</param>
        public InternetAccess(string empName)
        {
            this.employeeName = empName;
        }

        /// <summary>
        /// Grants the internet access.
        /// </summary>
        public void GrantInternetAccess()
        {
            Console.WriteLine("Internet Access granted for employee: " + this.employeeName);
        }
    }
}
