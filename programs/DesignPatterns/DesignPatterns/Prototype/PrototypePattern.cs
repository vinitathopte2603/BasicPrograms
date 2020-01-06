//-----------------------------------------------------------------------
// <copyright file="PrototypePattern.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// test the prototype design pattern
    /// </summary>
   public class PrototypePattern
    {
        /// <summary>
        /// test design pattern
        /// </summary>
        public static void PrototypePatternTest()
        {
            try
            {
                Employee employee = new Employee("abc", "12", 45000);
                Employee employee1 = (Employee)employee.Clone();
                Console.WriteLine("Original instance : ");
                Console.WriteLine(employee.Tostring());
                Console.WriteLine("Instance after cloning : ");
                Console.WriteLine(employee1.Tostring());
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
