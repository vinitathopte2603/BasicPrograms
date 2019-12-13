using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public static void DistanceResult()
        {
            Console.WriteLine("Enter the X co-ordinate :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y co-ordinate : ");
            int y = Convert.ToInt32(Console.ReadLine());
            double distance = Utility.DistanceCal(x, y);
            Console.WriteLine("Distance between two points : "+distance);
        }
    }
}
