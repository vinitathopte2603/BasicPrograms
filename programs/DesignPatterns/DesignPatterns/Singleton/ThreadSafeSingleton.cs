using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class ThreadSafeSingleton
    {
        private static int count = 0;
        private static ThreadSafeSingleton singleInstance = null;
        private static readonly object obj = new object();
        private ThreadSafeSingleton()
        {
            count++;
            Console.WriteLine("Instance created : " + count);
        }
        public static ThreadSafeSingleton SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    lock (obj)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new ThreadSafeSingleton();
                        }
                    }
                }
                return singleInstance;
            }
        }
        public void Display(string str)
        {
            Console.WriteLine(str);
        }
    }
}
