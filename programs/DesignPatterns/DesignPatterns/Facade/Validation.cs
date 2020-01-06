//-----------------------------------------------------------------------
// <copyright file="Validation.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Text.RegularExpressions;

    /// <summary>
    /// class to do validations on input data
    /// </summary>
   public class Validation
    {
        /// <summary>
        /// Validates the name.
        /// </summary>
        /// <returns>returns the valid name</returns>
        public static string ValidateName()
        {
            BookInputFromUser addressBookInput = new BookInputFromUser();
            string name;
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isNameValid;
            do
            {
                name = addressBookInput.Name();
                isNameValid = Regex.IsMatch(name, namePattern);
                if (!isNameValid)
                {
                    Console.WriteLine("Enter valid First name");
                }
            }
            while (!isNameValid);
            return name;
        }

        /// <summary>
        /// Validates the city.
        /// </summary>
        /// <returns>returns valid city name</returns>
        public static string ValidateCity()
        {
            BookInputFromUser addressBookInput = new BookInputFromUser();
            string cityNamePattern = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
            string city;
            bool isCityValid;
            do
            {
                city = addressBookInput.City();
                isCityValid = Regex.IsMatch(city, cityNamePattern);
                if (!isCityValid)
                {
                    Console.WriteLine("Enter valid city");
                }
            }
            while (!isCityValid);
            return city;
        }

        /// <summary>
        /// Validates the state.
        /// </summary>
        /// <returns>returns valid state name</returns>
        public static string ValidateState()
        {
            BookInputFromUser addressBookInput = new BookInputFromUser();
            string stateNamePattern = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
            string state;
            bool isStateValid;
            do
            {
                state = addressBookInput.State();
                isStateValid = Regex.IsMatch(state, stateNamePattern);
                if (!isStateValid)
                {
                    Console.WriteLine("Enter valid state");
                }
            }
            while (!isStateValid);
            return state;
        }

        /// <summary>
        /// Validates the zip code.
        /// </summary>
        /// <returns>returns valid zip code</returns>
        public static long ValidateZipCode()
        {
            BookInputFromUser addressBookInput = new BookInputFromUser();
            string zipCodePattern = @"^\d{6}$";
            long zipCode;
            bool isZipCodeValid;
            do
            {
                zipCode = addressBookInput.ZipCode();
                isZipCodeValid = Regex.IsMatch(zipCode.ToString(), zipCodePattern);
                if (!isZipCodeValid)
                {
                    Console.WriteLine("Enter valid zip code");
                }
            }
            while (!isZipCodeValid);
            return zipCode;
        }

        /// <summary>
        /// Validates the contact number.
        /// </summary>
        /// <returns>returns valid contact number</returns>
        public static long ValidateContactNumber()
        {
            BookInputFromUser addressBookInput = new BookInputFromUser();
            string phonepattern = @"^{1}[1-9]{1}[0-9]{9}$";
            long contactNumber;
            bool isPhoneNumberValid;
            do
            {
                contactNumber = addressBookInput.ContactNumber();
                isPhoneNumberValid = Regex.IsMatch(contactNumber.ToString(), phonepattern);
                if (!isPhoneNumberValid)
                {
                    Console.WriteLine("Enter valid phone number");
                }
            }
            while (!isPhoneNumberValid);
            return contactNumber;
        }
    }
}
