using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Singleton creational pattern \n 2 : Factory creational pattern \n 3 : Prototype design pattern \n 4 : Adapter design pattern \n 5 : Exit");
                    Console.WriteLine("Enter your choice  : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            SingletonDesignPattern.SingletonCreationalDesignPattern();
                            break;
                        case 2:
                            FactoryUserInput.FactoryInput();
                            break;
                        case 3:
                            PrototypePattern.PrototypePatternTest();
                            break;
                        case 4:
                            AdapterPatternTest.TestClassAdapter();
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
