//-----------------------------------------------------------------------
// <copyright file="ClinicUtility.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.IO;
    using System.Linq;
    using Newtonsoft.Json;

    /// <summary>
    /// clinic management operations
    /// </summary>
   public class ClinicUtility
    {
        /// <summary>
        /// prints the list of available doctors
        /// </summary>
        public static void DoctorAvailability()
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Doctors.json";
            string jsonData = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<Doctors>>(jsonData);
            List<Doctors> list = jsonObjectArray;
            foreach (Doctors doctors in list)
            {
                Console.WriteLine();
                Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                Console.WriteLine("Doctor's Id : " + doctors.Id);
                Console.WriteLine("Specialisation : " + doctors.Speciality);
                Console.WriteLine("Availability : " + doctors.Availability);
            }
        }

        /// <summary>
        /// prints the information of patients
        /// </summary>
        public static void PatientInformation()
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Patients.json";
            string jsonData = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<Patients>>(jsonData);
            List<Patients> list = jsonObjectArray;
            foreach (Patients patients in list)
            {
                Console.WriteLine();
                Console.WriteLine("Patient's Name : " + patients.PatientName);
                Console.WriteLine("Patient's Id : " + patients.Id);
                Console.WriteLine("contact number : " + patients.MobileNumber);
                Console.WriteLine("Age of patient : " + patients.Age);
            }
        }

        /// <summary>
        /// Books an appointment.
        /// </summary>
        public static void BookAnAppointment()
        {
            try
            {
                Console.WriteLine("\n 1 : Physician \n 2 : Orthopediac \n 3 : Opthalmologist \n 4 : ENT \n 5 : Dermatologist \n 6 : Dietician \n 7 : Physiologist");
                Console.WriteLine("Enter your option : ");
                string choice = Console.ReadLine();
                Console.WriteLine("Available doctors : ");
                string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Doctors.json";
                string jsonData = File.ReadAllText(path);
                var jsonObjectArray = JsonConvert.DeserializeObject<List<Doctors>>(jsonData);
                List<Doctors> list = jsonObjectArray;
                for (int i = 1; i < 8; i++)
                {
                    if (choice == list[i].Speciality)
                    {
                        SelectForAppointment.SelectOption(list[i].Speciality);
                        Console.WriteLine("Enter doctor's Id : ");
                        int doctorsId = Convert.ToInt32(Console.ReadLine());
                        int count = 0;
                        char ans;
                        do
                        {
                            count++;
                            Appointment.AppointmentBooking(doctorsId);
                            Console.WriteLine("Do you want to book another appointment : ");
                            ans = Convert.ToChar(Console.ReadLine());
                        }
                        while ((ans == 'y' || ans == 'Y') && (count < 5));
                        if (count >= 5)
                        {
                            Console.WriteLine("Appointment full !");
                        }
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
