using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class HarmonicSeries
    {
        public static void Harmonicseries()
        {
            Console.WriteLine("enter the number of terms ");
            int terms = Convert.ToInt32(Console.ReadLine());
            double result = Utility.Harmonicseries(terms);
            Console.WriteLine("= "+result);
        }
    }
}
