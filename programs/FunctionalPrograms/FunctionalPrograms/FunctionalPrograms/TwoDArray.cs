//-----------------------------------------------------------------------
// <copyright file="TwoDArray.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// 2 D Array
    /// </summary>
   public class TwoDArray
    {
        /// <summary>
        /// user input to implement two dimensional array
        /// </summary>
        public static void Array()
        {
            Console.WriteLine("Enter the number of rows and colums ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
            Utility.TwoDimArray(rows, columns);
        }
    }
}
