//-----------------------------------------------------------------------
// <copyright file="Employee.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// implementation of interface
    /// </summary>
    /// <seealso cref="System.ICloneable" />
   public class Employee : ICloneable
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The identifier
        /// </summary>
        private string id;

        /// <summary>
        /// The salary
        /// </summary>
        private double salary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="salary">The salary.</param>
        public Employee(string name, string id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        /// <summary>
        /// To the string.
        /// </summary>
        /// <returns>returns the values</returns>
        public string Tostring()
        {
            return "Name : " + this.name + ", Id : " + this.id + ", Salary : " + this.salary;
        }
    }
}
