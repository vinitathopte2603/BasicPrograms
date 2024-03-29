﻿//-----------------------------------------------------------------------
// <copyright file="ClinicManagement.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// class to perform clinic management
    /// </summary>
   public class ClinicManagement
    {
        /// <summary>
        /// takes user input
        /// </summary>
        public static void Appointment()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Doctor's Information \n 2 : Patient's Information \n 3 : Book an appointment \n 4 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ClinicUtility.DoctorAvailability();
                            break;
                        case 2:
                            ClinicUtility.PatientInformation();
                            break;
                        case 3:
                            ClinicUtility.BookAnAppointment();
                            break;
                        case 4:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
