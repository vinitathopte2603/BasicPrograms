//-----------------------------------------------------------------------
// <copyright file="BusinessBookDetails.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;

    /// <summary>
    /// class to take user input
    /// </summary>
   public class BusinessBookDetails
    {
        /// <summary>
        /// The path
        /// </summary>
       private static string path = @"D:\bridgelabz\programs\DesignPatterns\DesignPatterns\BusinessBook.json";

        /// <summary>
        /// User's choice
        /// </summary>
        public static void UserChoiceBusinessBook()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Input to business book \n 2 : Display \n 3 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            InputFromUser();
                            break;
                        case 2:
                            DisplayData();
                            break;
                        case 3:
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

        /// <summary>
        /// Inputs from user.
        /// </summary>
        private static void InputFromUser()
        {
            InputOutput.WriteToFile(path);
        }

        /// <summary>
        /// Displays the data.
        /// </summary>
        private static void DisplayData()
        {
            List<InputData> data = InputOutput.ReadFromFile(path);
            foreach (InputData inputData in data)
            {
                Console.WriteLine();
                Console.WriteLine("Name : " + inputData.Name);
                Console.WriteLine("City : " + inputData.City);
                Console.WriteLine("State : " + inputData.State);
                Console.WriteLine("Zipcode : " + inputData.ZipCode);
                Console.WriteLine("Contact number : " + inputData.ContactNumber);
            }
        }
    }
}
