using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ObjectOrientedPrograms
{
   public class AddressBookInputAndValidation
    {
        public AddressBookDetails InputAndValidation()
        {
            AddressBookDetails details = new AddressBookDetails();
            string firstName = FirstNameInputAndValidation();
            string lastName = LasttNameInputAndValidation();
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
        private static string LasttNameInputAndValidation()
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
