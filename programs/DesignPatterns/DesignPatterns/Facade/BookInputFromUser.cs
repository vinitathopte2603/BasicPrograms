//-----------------------------------------------------------------------
// <copyright file="BookInputFromUser.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

    /// <summary>
    /// class to implement interface
    /// </summary>
   public class BookInputFromUser : IDetails
    {
        /// <summary>
        /// method to get name of user
        /// </summary>
        /// <returns>returns the name</returns>
        public string Name()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            return name;
        }

        /// <summary>
        /// method to get city of user
        /// </summary>
        /// <returns>returns the city</returns>
        public string City()
        {
            Console.WriteLine("Enter your city : ");
            string city = Console.ReadLine();
            return city;
        }

        /// <summary>
        /// method to get state of user
        /// </summary>
        /// <returns>returns the state</returns>
        public string State()
        {
            Console.WriteLine("Enter your state : ");
            string state = Console.ReadLine();
            return state;
        }

        /// <summary>
        /// method to get zip code
        /// </summary>
        /// <returns>returns zip code</returns>
        public long ZipCode()
        {
            Console.WriteLine("Enter your zipcode : ");
            long zipCode = Convert.ToInt64(Console.ReadLine());
            return zipCode;
        }

        /// <summary>
        /// method to take contact number from user
        /// </summary>
        /// <returns>returns contact number</returns>
        public long ContactNumber()
        {
            Console.WriteLine("Enter your contact number : ");
            long contactNumber = Convert.ToInt64(Console.ReadLine());
            return contactNumber;
        }
    }
}
