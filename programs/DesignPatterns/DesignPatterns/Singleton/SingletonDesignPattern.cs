//-----------------------------------------------------------------------
// <copyright file="SingletonDesignPattern.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// class to implement singleton design pattern
    /// </summary>
    public class SingletonDesignPattern
    {
        /// <summary>
        /// singleton design pattern implementation
        /// </summary>
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

        /// <summary>
        /// eager initialization implementation
        /// </summary>
        public static void EagerInitialise()
        {
            EagerInitialisation first = EagerInitialisation.SingleInstance;
            first.Display("first call eager initialisation");
            EagerInitialisation second = EagerInitialisation.SingleInstance;
            second.Display("second call eager initialisation");
        }

        /// <summary>
        /// implementation of lazy initialization
        /// </summary>
        public static void LazyInitialise()
        {
            LazyInitialisation first = LazyInitialisation.SingleInstance;
            first.Display("first call lazy initialisation");
            LazyInitialisation second = LazyInitialisation.SingleInstance;
            second.Display("second call lazy initialisation");
        }

        /// <summary>
        /// invoke two methods simultaneously
        /// </summary>
        public static void ThreadSafe()
        {
            Parallel.Invoke(
                () => ThreadSafeFirst(),
                () => ThreadSafeSecond());
        }

        /// <summary>
        /// method invoking the singleton class
        /// </summary>
        private static void ThreadSafeSecond()
        {
            ThreadSafeSingleton second = ThreadSafeSingleton.SingleInstance;
            second.Display("second call thread safe singleton");
        }

        /// <summary>
        /// method invoking the singleton class
        /// </summary>
        private static void ThreadSafeFirst()
        {
            ThreadSafeSingleton first = ThreadSafeSingleton.SingleInstance;
            first.Display("first call thread safe singleton");
        }
    }
}
