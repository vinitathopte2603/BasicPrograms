using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    class ClinicUtility
    {
        
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
        public static void BookAnAppointment()
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Doctors.json";
            string jsonData = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<Doctors>>(jsonData);
            List<Doctors> list = jsonObjectArray;
            try
            {
                Console.WriteLine("\n 1 : Physician \n 2 : Orthopaediatric \n 3 : Opthalmologist \n 4 : ENT \n 5 : Dermatologist \n 6 : Dietician \n 7 : Physiologist");
                Console.WriteLine("Enter your option : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Available doctors : ");
                if (choice == 1)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Physician")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 2)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Orthopaediatric")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 3)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Opthalmologist")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 4)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "ENT")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 5)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Dermatologist")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 6)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Dietician")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }
                    }
                }
                if (choice == 7)
                {
                    foreach (Doctors doctors in list)
                    {
                        if (doctors.Speciality == "Physiologist")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Doctor's Name : " + doctors.DoctorName);
                            Console.WriteLine(doctors.Availability);
                        }

                    }
                    Appointment.AppointmentBooking();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

    }
}
