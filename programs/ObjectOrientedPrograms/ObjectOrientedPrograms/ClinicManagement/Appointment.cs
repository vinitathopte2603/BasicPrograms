//-----------------------------------------------------------------------
// <copyright file="Appointment.cs" Author="Vinita Thopte" company="Bridgelabz">
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
    /// class to book appoint for patients
    /// </summary>
   public class Appointment
    {
        /// <summary>
        /// books an appointment for patient
        /// </summary>
        public static void AppointmentBooking(int id)
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Patients.json";
            string jsonData = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<Patients>>(jsonData);
            List<Patients> list = jsonObjectArray;
            Patients patients = new Patients();
            string today = DateTime.Today.ToString("dd/mm/yyyy");
            Random r = new Random();
            Console.WriteLine("Enter patients's details : ");
            Console.WriteLine("patient's Name : ");
            string newPatientName = Console.ReadLine();
            int newPatientId = r.Next(100);
            Console.WriteLine("Enter Phone number : ");
            long newPhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Patient's age : ");
            int newPatientAge = Convert.ToInt32(Console.ReadLine());
            patients.PatientName = newPatientName;
            patients.Id = newPatientId;
            patients.MobileNumber = newPhoneNumber;
            patients.Age = newPatientAge;
            list.Add(patients);
            string patientdata = JsonConvert.SerializeObject(list);
            File.WriteAllText(path, patientdata);
            Console.WriteLine("your appointment is booked for the following date  : " + today);
        }
    }
}
