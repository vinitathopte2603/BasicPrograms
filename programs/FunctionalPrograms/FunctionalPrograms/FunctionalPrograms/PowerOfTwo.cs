using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerOfTwo
    {
        public static void PowerofTwo()
        {
            Console.WriteLine("Enter the number of terms : ");
            int terms = Convert.ToInt32(Console.ReadLine());
            Utility.Power(terms);
        }
    }
}
