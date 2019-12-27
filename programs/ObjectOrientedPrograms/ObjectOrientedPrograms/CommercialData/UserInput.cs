using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class UserInput
    {
        public void InputFromUser()
        {
            try
            {
                Console.WriteLine("\n 1 : Buy a Share \n 2 : Sell a share \n 3 : Print symbols \n 4 : Print report \n 5 : Value of a specific share \n 6 : Exit");
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        StockAccountUtility.BuyShares();
                        break;
                       

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
