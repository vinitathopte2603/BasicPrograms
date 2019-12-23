//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// class having logic to read data from file and perform operations on data
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// all the content from a file is read in the variable
        /// </summary>
         private static string jsondata = File.ReadAllText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Grains.json");

        /// <summary>
        /// reads data from file and displays the output 
        /// </summary>
        public static void GrainsInventoryMgnt()
        {
            var jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            string grain = jsonObjectArray.rice[2].name;
            Console.WriteLine(/*jsonObjectArray.Rice[2].weight*/grain);
            double total = 0;
            for (int i = 0; i < 3; i++)
            {
                total = jsonObjectArray.rice[i].pricePerkg * jsonObjectArray.rice[i].weight;
                Console.WriteLine("Cost of total available " + jsonObjectArray.rice[i].name + " is :" + total);
            }
        }

        /// <summary>
        /// allows user to purchase any grain
        /// </summary>
        /// <param name="grainName">Name of the grain.</param>
        /// <param name="quantity">The quantity.</param>
        /// <returns>returns the remaining quantity of food grain in inventory</returns>
        public double InventoryManagementCustomer(string grainName, double quantity)
        {
            var jsonObjectsArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            double amount;
            double priceToPay;
            double newWeight = 0;
            for (int i = 0; i < jsondata.Length; i++)
            {
                if (grainName == jsonObjectsArray.rice[i].name)
                {
                    amount = jsonObjectsArray.rice[i].weight;
                    priceToPay = quantity * jsonObjectsArray.rice[i].pricePerkg;
                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                else if (grainName == jsonObjectsArray.wheat[i].name)
                {
                    amount = jsonObjectsArray.wheat[i].weight;
                    priceToPay = quantity * jsonObjectsArray.wheat[i].pricePerkg;
                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                else if (grainName == jsonObjectsArray.pulses[i].name)
                {
                    amount = jsonObjectsArray.pulses[i].weight;
                    priceToPay = quantity * jsonObjectsArray.pulses[i].pricePerkg;

                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                ////else
                ////{
                ////    Console.WriteLine("Given grain not available");
                ////}
            }

            return newWeight;
        }

        /// <summary>
        /// Displays the inventory.
        /// </summary>
        public void DisplayInventory()
        {
            var jsonObjectsArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            Console.WriteLine("Total stock present in the inventory");
            List<Properties> rice = jsonObjectsArray.rice;
            foreach (Properties details in rice)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }

            Console.WriteLine();
            List<Properties> wheat = jsonObjectsArray.wheat;
            foreach (Properties details in wheat)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }

            Console.WriteLine();
            List<Properties> pulses = jsonObjectsArray.pulses;
            foreach (Properties details in pulses)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }
        }
        public static void AddressBookInput()
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json";
            char answer = ' ';
            string jsonfiledata;
            List<AddressBookDetails> user = new List<AddressBookDetails>();
           // List<AddressBookUserDetails> user = new List<AddressBookUserDetails>();
              AddressBookDetails bookdetails = new AddressBookDetails();
           // AddressBookUserDetails bookdetails = new AddressBookUserDetails();
            do
            {
                Console.WriteLine("Enter your details : ");
                 AddressBookInputAndValidation userinput = new AddressBookInputAndValidation();
               // AddressBookInputAndValidation.InputAndValidation();
                user.Add(userinput.InputAndValidation());
                jsonfiledata = JsonConvert.SerializeObject(user);
                Console.WriteLine(jsonfiledata);
                Console.WriteLine("Do you wan to continue ? ");
                answer = Convert.ToChar(Console.ReadLine());
            }
            while (answer == 'y' || answer == 'Y');
            File.WriteAllText(path, jsonfiledata);
        }
        public static void DisplayAddressBook()
        {
            string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json";
            string jsondata = File.ReadAllText(path);
            var objectArray = JsonConvert.DeserializeObject<List<AddressBookDetails>>(jsondata);
            List<AddressBookDetails> list = objectArray;
            foreach(AddressBookDetails details in list)
            {
                Console.WriteLine(" ");
                Console.WriteLine(details.firstName + " " + details.lastName);
                Console.WriteLine("Contact Number : " + details.contactNumber);
                Console.WriteLine("Email address : " + details.emailAddress);
                Console.WriteLine("Residential address : " + details.address);
            }
           
        }
        public static void ReplaceStringInputValidation()
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
            string fName = Utility.ReplaceStringValidateName(firstName);
            string fullName = fName + " " + Utility.ReplaceStringValidateName(lastName);
            long contactNum = Utility.ReplaceStringValidateContactNumber(contactNumber);
            string date = DateTime.Today.ToString("dd-mm-yyyy");
            message = message.Replace("<<name>>", fName);
            message = message.Replace("<<fullName>>", fullName);
            message = message.Replace("xxxxxxxxxx", contactNum.ToString());
            message = message.Replace("xx/xx/xxxx", date);
            Console.WriteLine();
            Console.WriteLine(message);

        }
        private static string ReplaceStringValidateName(string name)
        {
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isFirstNameValid;
            do
            {
                isFirstNameValid = Regex.IsMatch(name, namePattern);
                if (!isFirstNameValid)
                {
                    Console.WriteLine("Enter valid First name");
                }
            }
            while (!isFirstNameValid);
            return name;
        }
        private static long ReplaceStringValidateContactNumber(long contactNumber)
        {
            string phonepattern = @"^{1}[1-9]{1}[0-9]{9}$";
            bool isPhoneNumberValid; 
            do
            {
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
