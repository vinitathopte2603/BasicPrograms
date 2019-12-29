using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class UserInput
    {
        public void InputFromUser()
        {
            StockAccount stockAccount = new StockAccount();
            try
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Buy the Share");
                    Console.WriteLine("2.Sell a Share");
                    Console.WriteLine("3.View Existing Shares");
                    Console.WriteLine("4.View Symobol Purchased");
                    string input = Console.ReadLine();

                    ////convert that number to an integer type
                    int option = Convert.ToInt32(input);

                    //// Calls the method of user's choice
                    switch (option)
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

                        default:
                            return;
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
