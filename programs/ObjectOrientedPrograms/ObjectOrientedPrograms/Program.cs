//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    /// <summary>
    /// Entry point of the application
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            bool flag = true;
            try
            {
                while (flag == true)
                {
                    Console.WriteLine("\n 1 : Inventory management \n 2 : Inventory management customers \n 3 : Address book \n 4 : Replace string \n 5 : Exit");
                    Console.WriteLine("Enter your choice  : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1: GrainsInventory.GrainInventoryCall();
                             break;
                        case 2:
                            InventoryManagement.InventoryCall();
                            break;
                        case 3:
                            AddressBook.AddressBookCall();
                            break;
                        case 4:
                            ReplaceStringUsingRegex.UserDetailsInput();
                            break;
                        case 5:
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
    }
}
