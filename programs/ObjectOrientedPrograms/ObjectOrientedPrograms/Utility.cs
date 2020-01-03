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
            try
            {
                var jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
                string grain = jsonObjectArray.rice[2].name;
                Console.WriteLine(/*jsonObjectArray.Rice[2].weight*/grain);
                double total;
                for (int i = 0; i < 3; i++)
                {
                    total = jsonObjectArray.rice[i].pricePerkg * jsonObjectArray.rice[i].weight;
                    Console.WriteLine("Cost of total available " + jsonObjectArray.rice[i].name + " is :" + total);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            try
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// input given to the address book
        /// </summary>
        public static void AddressBookInput()
        {
            try
            {
                string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json";
                char answer;
                string jsonfiledata;
                List<AddressBookDetails> user = new List<AddressBookDetails>();
                do
                {
                    Console.WriteLine("Enter your details : ");
                    AddressBookInputAndValidation userinput = new AddressBookInputAndValidation();
                    user.Add(userinput.InputAndValidation());
                    jsonfiledata = JsonConvert.SerializeObject(user);
                    Console.WriteLine("Do you wan to continue ? ");
                    answer = Convert.ToChar(Console.ReadLine());
                }
                while (answer == 'y' || answer == 'Y');
                File.AppendAllText(path, jsonfiledata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Displays the address book.
        /// </summary>
        public static void DisplayAddressBook()
        {
            try
            {
                string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json";
                string jsondata = File.ReadAllText(path);
                var objectArray = JsonConvert.DeserializeObject<List<AddressBookDetails>>(jsondata);
                List<AddressBookDetails> list = objectArray;
                foreach (AddressBookDetails details in list)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(details.firstName + " " + details.lastName);
                    Console.WriteLine("Contact Number : " + details.contactNumber);
                    Console.WriteLine("Email address : " + details.emailAddress);
                    Console.WriteLine("Residential address : " + details.address);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Edits the information.
        /// </summary>
        public static void EditInformation()
        {
            try
            {
                Console.WriteLine("Enter first name of the person whose data to be edited : ");
                string name = Console.ReadLine();
                string path = @"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json";
                string jsondata = File.ReadAllText(path);
                var objectArray = JsonConvert.DeserializeObject<List<AddressBookDetails>>(jsondata);
                List<AddressBookDetails> list = objectArray;
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].firstName)
                    {
                        Console.WriteLine("select data to edit : ");
                        Console.WriteLine("\n 1 : Firstname \n 2 : Lastname \n 3 : Contact number \n 4 : Email address \n 5 : Address");
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter new first name  : ");
                                string newFirstName = Console.ReadLine();
                                list[i].firstName = newFirstName;
                                break;
                            case 2:
                                Console.WriteLine("Enter new last name : ");
                                string newLastName = Console.ReadLine();
                                list[i].lastName = newLastName;
                                break;
                            case 3:
                                Console.WriteLine("Enter new contact number : ");
                                long newContactNumber = Convert.ToInt64(Console.ReadLine());
                                list[i].contactNumber = newContactNumber;
                                break;
                            case 4:
                                Console.WriteLine("Enter new email address : ");
                                string newEmailAdress = Console.ReadLine();
                                list[i].emailAddress = newEmailAdress;
                                break;
                            case 5:
                                Console.WriteLine("Enter new address : ");
                                string newAddress = Console.ReadLine();
                                list[i].address = newAddress;
                                break;
                            case 6:
                                Console.WriteLine("Enter valid choice");
                                break;
                        }
                    }
                }

                using (StreamWriter file = File.CreateText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\AddressBook.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, list);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Replaces the string with given input data input.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="contactNumber">The contact number.</param>
        /// <returns>returns the message string</returns>
        public static string ReplaceStringInputValidation(string message, string firstName, string lastName, long contactNumber)
        { 
            string frstName = Utility.ReplaceStringValidateName(firstName);
            string fullName = frstName + " " + Utility.ReplaceStringValidateName(lastName);
            long contactNum = Utility.ReplaceStringValidateContactNumber(contactNumber);
            string date = DateTime.Today.ToString("dd/mm/yyyy");
            message = message.Replace("<<name>>", frstName);
            message = message.Replace("<<fullName>>", fullName);
            message = message.Replace("xxxxxxxxxx", contactNum.ToString());
            message = message.Replace("xx/xx/xxxx", date);
            Console.WriteLine();
            return message;
        }

        /// <summary>
        /// validates the string input
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>returns the valid name</returns>
        private static string ReplaceStringValidateName(string name)
        {
            string namePattern = @"^[A-Z][a-zA-Z]*$";
            bool isFirstNameValid;
            do
            {
                isFirstNameValid = Regex.IsMatch(name, namePattern);
                if (!isFirstNameValid)
                {
                    Console.WriteLine("Enter valid name");
                    break;
                }
            }
            while (!isFirstNameValid);
            return name;
        }

        /// <summary>
        /// validate contact number.
        /// </summary>
        /// <param name="contactNumber">The contact number.</param>
        /// <returns>valid contact number</returns>
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
