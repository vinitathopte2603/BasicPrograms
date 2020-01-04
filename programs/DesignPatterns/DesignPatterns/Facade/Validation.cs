using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DesignPatterns
{
    class Validation
    {
        public static string ValidateName()
        {
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isNameValid;
            string name;
            do
            {
                Console.WriteLine("First name : ");
                name = Console.ReadLine();
                isNameValid = Regex.IsMatch(name, namePattern);
                if (!isNameValid)
                {
                    Console.WriteLine("Enter valid First name");
                }
            }
            while (!isNameValid);
            return name;
        }
        public static string ValidateCity()
        {
            string cityNamePattern = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
            string city;
            bool isCityValid;
            do
            {
                Console.WriteLine("Enter city ");
                city = Console.ReadLine();
                isCityValid = Regex.IsMatch(city, cityNamePattern);
                if (!isCityValid)
                {
                    Console.WriteLine("Enter valid city");
                }
            }
            while (!isCityValid);
            return city;
        }

        public static string ValidateState()
        {
            string stateNamePattern = @"^([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$";
            string state;
            bool isStateValid;
            do
            {
                Console.WriteLine("Enter state ");
                state = Console.ReadLine();
                isStateValid = Regex.IsMatch(state, stateNamePattern);
                if (!isStateValid)
                {
                    Console.WriteLine("Enter valid city");
                }
            }
            while (!isStateValid);
            return state;
        }
        public static long ValidateZipCode()
        {
            string zipCodePattern = @"^\d{6}$";
            long zipCode;
            bool isZipCodeValid;
            do
            {
                Console.WriteLine("Zip code : ");
                zipCode = Convert.ToInt64(Console.ReadLine());
                isZipCodeValid = Regex.IsMatch(zipCode.ToString(), zipCodePattern);
                if (!isZipCodeValid)
                {
                    Console.WriteLine("Enter valid zip code");
                }
            }
            while (!isZipCodeValid);
            return zipCode;
        }
        public static long ValidateContactNumber()
        {
            string phonepattern = @"^{1}[1-9]{1}[0-9]{9}$";
            long contactNumber;
            bool isPhoneNumberValid;
            do
            {
                Console.WriteLine("Contact Number : ");
                contactNumber = Convert.ToInt64(Console.ReadLine());
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
