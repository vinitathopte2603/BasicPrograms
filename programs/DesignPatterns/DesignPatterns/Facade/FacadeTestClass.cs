//-----------------------------------------------------------------------
// <copyright file="FacadeTestClass.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// class to test implementation of facade design pattern
    /// </summary>
   public class FacadeTestClass
    {
        /// <summary>
        /// Tests the facade pattern.
        /// </summary>
        public static void TestFacadePattern()
        {
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Address book \n 2 : Business book \n 3 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddressBookDetails.UserChoiceAddressBook();
                            break;
                        case 2:
                            BusinessBookDetails.UserChoiceBusinessBook();
                            break;
                        case 3:
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
