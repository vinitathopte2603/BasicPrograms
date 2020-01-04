using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class FacadeTestClass
    {
        public static void TestFacadePattern()
        {
            bool flag = true;
            try
            {
                while(flag)
                {
                    Console.WriteLine("\n 1 : Address book \n 2 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddressBookDetails.InputFromUser();
                            break;
                        case 2:
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
