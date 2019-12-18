namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;


  class CashCountr
    { 
        public static void CashCounter()
        {
            Queue q = new Queue();
            int choice;
            do
            {
                Console.WriteLine("\n 1 : Deposite \n 2 : Withdraw \n 3 : Exit");
                Console.WriteLine("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Insert amount to be deposited : ");
                        int depo_amt = Convert.ToInt32(Console.ReadLine());
                        q.Insert(depo_amt);
                        q.Display();
                        break;
                    case 2:
                        Console.WriteLine("Insert amount to be withdrawn : ");
                        int wthdrw_amt = Convert.ToInt32(Console.ReadLine());
                        q.Remove();
                        q.Display();
                        break;
                    case 3:
                        Console.WriteLine("Enter valid choice ! ");
                        break;
                }
                
            }
            while (choice < 4);
        }
    }
}
