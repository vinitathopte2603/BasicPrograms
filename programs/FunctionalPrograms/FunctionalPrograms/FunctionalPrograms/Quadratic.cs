//-----------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// roots of a quadratic equation
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// user input of values to determine roots of an equation
        /// </summary>
        public static void QuadraticEquations()
        {
            Console.WriteLine("Enter values of a : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter values of b : ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter values of c : ");
            double c = Convert.ToDouble(Console.ReadLine());
            Utility.QuadraticEquation(a, b, c);
        }      
    }
}
