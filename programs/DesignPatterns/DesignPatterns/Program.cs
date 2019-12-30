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
                Console.WriteLine("\n 1 : Singleton creational pattern \n 2 : ");
                Console.WriteLine("Enter your choice  : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        break;
                    case 2:
                        flag = false;
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
