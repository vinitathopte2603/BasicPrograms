using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    class Appointment
    {
        public static void AppointmentBooking()
        {
            bool[] arr = new bool[12];
            int appointments = 0;
            char slot = ' ';
            int time;
            if (appointments == 5)
            {
                Console.WriteLine("Appointments full");
            }
            else
            {
                do
                {
                    while (appointments < 5)
                    {
                        Console.WriteLine("\nEnter the time slot for appointment : ");
                        time = Convert.ToInt32(Console.ReadLine());
                        if (!arr[time])
                        {
                            arr[time] = true;
                            Console.Write("\n Appointment time : " + time);
                        }
                        else
                        {
                            Console.WriteLine("Time slot already booked");
                        }
                        appointments++;
                        Console.WriteLine("\nDo you want to book more time slot : ");
                        slot = Convert.ToChar(Console.ReadLine());
                    }
                }
                while (slot == 'Y' && slot == 'y');
            }
          
              
        }
    }
}
