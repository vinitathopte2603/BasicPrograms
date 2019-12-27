using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class ReplaceStringUsingRegex
    {
        public static void UserDetailsInput()
        {
            string message = " Hello <<name>>, we have your full name as <<fullName>> in our system.\n" +
        " Your contact number is 91-xxxxxxxxxx. Please let us know in case of any clarification.\n" +
        " Thank you, Bridgelabz \n" +
        " xx/xx/xxxx";
            Console.WriteLine("Enter your details : ");
            Console.WriteLine("Enter your firstname : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your lastname : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your contact number : ");
            long contactNumber = Convert.ToInt64(Console.ReadLine());
            string displayMessage = Utility.ReplaceStringInputValidation(message, firstName, lastName, contactNumber);
            Console.WriteLine(displayMessage);
        }      
    }
}
