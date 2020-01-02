using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   public sealed class EagerInitialisation
    {
        private static int count = 0;
        private static EagerInitialisation singleInstance = null;
        private EagerInitialisation()
        {
            count++;
            Console.WriteLine("Instance created : " + count);
        }
        public static EagerInitialisation SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    singleInstance = new EagerInitialisation();
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
