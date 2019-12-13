using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Quadratic
    {
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
