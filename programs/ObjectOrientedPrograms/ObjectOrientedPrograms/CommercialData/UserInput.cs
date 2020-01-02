//-----------------------------------------------------------------------
// <copyright file="UserInput.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// takes input from user to perform various operations
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// Inputs from user.
        /// </summary>
        public static void InputFromUser()
        {
            StockAccount stockAccount = new StockAccount();
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Buy the Share \n 2 : Sell a Share \n 3 : View Existing Shares \n 4 : View Symbol Purchased \n 5 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            CommercialUtility.BuyStake();
                            break;

                        case 2:
                            CommercialUtility.SellStake();
                            break;

                        case 3:
                            CommercialUtility.PrintReport();
                            break;

                        case 4:
                            CommercialUtility.PrintSymbol();
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
