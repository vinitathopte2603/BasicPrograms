//-----------------------------------------------------------------------
// <copyright file="AddressBookInputAndValidation.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Text.RegularExpressions;

    /// <summary>
    /// validations of input from user
    /// </summary>
    public class AddressBookInputAndValidation
    {
        /// <summary>
        /// validates the input
        /// </summary>
        /// <returns>returns the values</returns>
        public AddressBookDetails InputAndValidation()
        {
            AddressBookDetails details = new AddressBookDetails();
            string firstName = FirstNameInputAndValidation();
            string lastName = LastNameInputAndValidation();
            long contactNumber = PhoneNumberInputAndValidation();
            string email = EmailAddressInputAndValidation();
            Console.WriteLine("Permanent address : ");
            string address = Console.ReadLine();
            details.firstName = firstName;
            details.lastName = lastName;
            details.contactNumber = contactNumber;
            details.emailAddress = email;
            details.address = address;

            return details;
        }

        /// <summary>
        /// contact number input from user and validation of given input
        /// </summary>
        /// <returns>returns the valid contact number</returns>
        private static long PhoneNumberInputAndValidation()
        {
            string phonepattern = @"^{1}[1-9]{1}[0-9]{9}$";
            bool isPhoneNumberValid;
            long contactNumber;
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

        /// <summary>
        /// email address input from user and validation of the same
        /// </summary>
        /// <returns>returns valid email address</returns>
        private static string EmailAddressInputAndValidation()
        {
            string emailpattern = "^[a-zA-Z0-9_+&*-]+(?:\\." +
                            "[a-zA-Z0-9_+&*-]+)*@" +
                            "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                            "A-Z]{2,7}$";
            bool isEmailAddressValid;
            string emailAddress;
            do
            {
                Console.WriteLine("Email address : ");
                emailAddress = Console.ReadLine();
                isEmailAddressValid = Regex.IsMatch(emailAddress, emailpattern);
                if (!isEmailAddressValid)
                {
                    Console.WriteLine("Enter valid email address");
                }
            }
            while (!isEmailAddressValid);
            return emailAddress;
        }

        /// <summary>
        /// name input from user and validation of the same
        /// </summary>
        /// <returns>returns valid first name</returns>
        private static string FirstNameInputAndValidation()
        {
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isFirstNameValid;
            string firstName;
            do
            {
                Console.WriteLine("First name : ");
                firstName = Console.ReadLine();
                isFirstNameValid = Regex.IsMatch(firstName, namePattern);
                if (!isFirstNameValid)
                {
                    Console.WriteLine("Enter valid First name");
                }
            }
            while (!isFirstNameValid);
            return firstName;
        }

        /// <summary>
        /// last name input from user and validation of the same
        /// </summary>
        /// <returns>returns valid name</returns>
        private static string LastNameInputAndValidation()
        {
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isLastNameValid;
            string lastName;
            do
            {
                Console.WriteLine("last name : ");
                lastName = Console.ReadLine();
                isLastNameValid = Regex.IsMatch(lastName, namePattern);
                if (!isLastNameValid)
                {
                    Console.WriteLine("Enter valid last name");
                }
            }
            while (!isLastNameValid);
            return lastName;
        }
    }
}
