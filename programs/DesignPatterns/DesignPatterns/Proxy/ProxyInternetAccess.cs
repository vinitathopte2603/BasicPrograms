//-----------------------------------------------------------------------
// <copyright file="ProxyInternetAccess.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// implementation of interface
    /// </summary>
    /// <seealso cref="DesignPatterns.IOfficeInternetAccess" />
   public class ProxyInternetAccess : IOfficeInternetAccess
    {
        /// <summary>
        /// The employee name
        /// </summary>
        private string employeeName;

        /// <summary>
        /// The internet access object
        /// </summary>
        private InternetAccess realaccess;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyInternetAccess"/> class.
        /// </summary>
        /// <param name="employeeName">Name of the employee.</param>
        public ProxyInternetAccess(string employeeName)
        {
            this.employeeName = employeeName;
        }

        /// <summary>
        /// enumeration of employees
        /// </summary>
        private enum Enumemp
        {
            /// <summary>
            /// first employee
            /// </summary>
            Pooja = 1,

            /// <summary>
            /// second employee
            /// </summary>
            Ankit,

            /// <summary>
            /// third employee
            /// </summary>
            Prasad,

            /// <summary>
            /// fourth employee
            /// </summary>
            Arti,

            /// <summary>
            /// fifth employee
            /// </summary>
            Nikhil,

            /// <summary>
            /// sixth employee
            /// </summary>
            Jayashree,

            /// <summary>
            /// seventh employee
            /// </summary>
            Rishi
        }

        /// <summary>
        /// Grants the internet access.
        /// </summary>
        public void GrantInternetAccess()
        {
            if (this.GetRole(this.employeeName) > 2)
            {
                this.realaccess = new InternetAccess(this.employeeName);
                this.realaccess.GrantInternetAccess();
            }
            else
            {
                Console.WriteLine("No Internet access granted. Your job level is below 5");
            }
        }

        /// <summary>
        /// Gets the role.
        /// </summary>
        /// <param name="emplName">Name of the employees.</param>
        /// <returns>returns the rank of employee</returns>
        public int GetRole(string emplName)
        {
            int rank = 0;

            Array arr = Enum.GetValues(typeof(Enumemp));
            for (int i = 1; i <= arr.Length; i++)
            {
                if (emplName == Enum.GetName(typeof(Enumemp), i))
                {
                    rank = i;   
                }
            }

            return rank;
        }
    }
}
