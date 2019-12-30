using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class EagerInitialisation
    {
        private static int count = 0;
        private static EagerInitialisation singleInstance = new EagerInitialisation();
        private EagerInitialisation()
        {
            count++;
            Console.WriteLine(count + "instance created ");
        }
        public static EagerInitialisation SingleInstance
        {
            get
            {
                return singleInstance;
            }
        }
    }
}
