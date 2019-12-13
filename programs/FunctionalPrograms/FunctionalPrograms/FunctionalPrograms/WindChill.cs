using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static void WindChillResult()
        {
            Console.WriteLine("Enter the temperature in temperature : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter speed of wind : ");
            double speed = Convert.ToDouble(Console.ReadLine());
            double Windchill = Utility.WindChillCal(temperature, speed);
            Console.WriteLine("Windchill : "+Windchill);
        }
    }
}
