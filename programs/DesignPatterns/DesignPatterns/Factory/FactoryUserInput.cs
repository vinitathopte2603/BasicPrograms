//-----------------------------------------------------------------------
// <copyright file="FactoryUserInput.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// class to give input to the factory
    /// </summary>
   public class FactoryUserInput
    {
        /// <summary>
        /// input to the factory
        /// </summary>
        public static void FactoryInput()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine(" \n 1 : Laptops \n 2 : PCs \n 3 : Servers \n 4 : Exit");
                    Console.WriteLine("Enter your choice  : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Computer laptop = Factory.GetComputer("Laptop", "12 GB", "200 GB", "2.4 GHz");
                            Console.WriteLine("Configurations of the laptop is  : " + laptop.Tostring());
                            break;
                        case 2:
                            Computer pc = Factory.GetComputer("PCs", "2 GB", "500 GB", "2.4 GHz");
                            Console.WriteLine("Configurations of the personal computer is  : " + pc.Tostring());
                            break;
                        case 3:
                            Computer server = Factory.GetComputer("Servers", "16 GB", "12 TB", "2.9 GHz");
                            Console.WriteLine("Configurations of the Server is  : " + server.Tostring());
                            break;
                        case 4:
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
