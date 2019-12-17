//-----------------------------------------------------------------------
// <copyright file="Distance.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace FunctionalPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Determine distance between two points
    /// </summary>
   public class Distance
    {
        /// <summary>
        /// calculate distance between two points.
        /// </summary>
        public static void DistanceResult()
        {
            Console.WriteLine("Enter the X co-ordinate :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y co-ordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());
            double distance = Utility.DistanceCal(x, y);
            Console.WriteLine("Distance between two points : " + distance);
        }
    }
}
