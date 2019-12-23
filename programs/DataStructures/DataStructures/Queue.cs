//-----------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DataStructures
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// executes cash counter 
    /// </summary>
    public class CashCountr
    {
        /// <summary>
        /// user input to perform operations on list
        /// </summary>
        public static void CashCounter()
        {
            Queue q = new Queue();        
            int choice;
            bool flag = true;
            while (flag)
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
                        flag = false;
                        break;
                }               
            } 
        }
    }
}
