//-----------------------------------------------------------------------
// <copyright file="AddressBook.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// Perform operations on address book
    /// </summary>
   public class AddressBook
    {
        /// <summary>
        /// call to methods performing operations on address book according to choice of the user.
        /// </summary>
        public static void AddressBookCall()
        {
            bool flag = true;
            try
            {
                do
                {
                    Console.WriteLine("\n 1 : Insert into addreess book \n 2 : Display address-book \n 3 : Edit Information \n 4 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Utility.AddressBookInput();
                            break;
                        case 2:
                            Utility.DisplayAddressBook();
                            break;
                        case 3:
                            Utility.EditInformation();
                            break;
                        case 4:
                            flag = false;
                            break;
                    }
                }
                while (flag);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
