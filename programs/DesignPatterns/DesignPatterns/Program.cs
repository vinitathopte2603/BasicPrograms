//-----------------------------------------------------------------------
// <copyright file="Program.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Entry point to the application
    /// </summary>
   public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
       public static void Main()
        {
            bool flag = true;

            try
            {
                while (flag)
                {
                    Console.WriteLine("\n 1 : Singleton creational pattern \n 2 : Factory creational pattern \n 3 : Prototype design pattern \n 4 : Adapter design pattern \n 5 : Facade design pattern \n 6 : Visitor design pattern \n 7 : Mediator design pattern \n 8 : Proxy design pattern \n 9 : Observer design pattern \n 10 : Exit");
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
                            FacadeTestClass.TestFacadePattern();
                            break;
                        case 6:
                            VisitorPatternTest.VisitorTest();
                            break;
                        case 7:
                            MediatorTestClass.TestMediator();
                            break;
                        case 8:
                            ProxyDesignPatternTest.TestProxy();
                            break;
                        case 9:
                            ObserverPatternTest.MakeChanges();
                            break;
                        case 10:
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
