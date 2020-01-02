//-----------------------------------------------------------------------
// <copyright file="SelectForAppointment.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

    /// <summary>
    /// booking a appointment
    /// </summary>
   public class SelectForAppointment
    {
        /// <summary>
        /// Selects the option.
        /// </summary>
        /// <param name="option">The option.</param>
        public static void SelectOption(string option)
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Doctors.json";
            string jsonData = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<Doctors>>(jsonData);
            List<Doctors> list = jsonObjectArray;
            foreach (Doctors doctors in list)
            {
                if (doctors.Speciality == option)
                {
                    Console.WriteLine();
                    Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                    Console.WriteLine("Doctor's availability : " + doctors.Availability);
                    Console.WriteLine("Doctor's Id : " + doctors.Id);
                }
            }
        }
    }
}
