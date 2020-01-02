using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SingletonDesignPattern
    {
        public static void SingletonCreationalDesignPattern()
        {
            try
            {
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("\n 1 : Eager initialisation \n 2 : Lazy initialisation \n 3 : Thread safe singleton \n 4 : Exit");
                    Console.WriteLine("Enter your choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            EagerInitialise();
                            break;
                        case 2:
                            LazyInitialise();
                            break;
                        case 3:
                            ThreadSafe();
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
        public static void EagerInitialise()
        {
            EagerInitialisation first = EagerInitialisation.SingleInstance;
            first.Display("first call eager initialisation");
            EagerInitialisation second = EagerInitialisation.SingleInstance;
            second.Display("second call eager initialisation");
        }
        public static void LazyInitialise()
        {
            LazyInitialisation first = LazyInitialisation.SingleInstance;
            first.Display("first call lazy initialisation");
            LazyInitialisation second = LazyInitialisation.SingleInstance;
            second.Display("second call lazy initialisation");

        }
        public static void ThreadSafe()
        {
            Parallel.Invoke(
                ()=> ThreadSafeFirst(),
                () => ThreadSafeSecond()
                );
        }

        private static void ThreadSafeSecond()
        {
            ThreadSafeSingleton second = ThreadSafeSingleton.SingleInstance;
            second.Display("second call thread safe singleton");
        }

        private static void ThreadSafeFirst()
        {
            ThreadSafeSingleton first = ThreadSafeSingleton.SingleInstance;
            first.Display("first call thread safe singleton");
        }
    }
}
