using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
    class AddressBook
    {
        public static void AddressBookCall()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("\n 1 : Insert into addreess book \n 2 : Display address-book \n 3 : Edit Information \n 4 : Exit");
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Utility.AddressBookInput(); ;
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
    }
}
