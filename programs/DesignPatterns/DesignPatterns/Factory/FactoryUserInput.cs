using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class FactoryUserInput
    {
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
                            Console.WriteLine("Configurations of the laptop is  : " + laptop.tostring());
                            break;
                        case 2:
                            Computer pc = Factory.GetComputer("PCs", "2 GB", "500 GB", "2.4 GHz");
                            Console.WriteLine("Configurations of the personal computer is  : " + pc.tostring());
                            break;
                        case 3:
                            Computer server = Factory.GetComputer("Servers", "16 GB", "12 TB", "2.9 GHz");
                            Console.WriteLine("Configurations of the Server is  : " + server.tostring());
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
