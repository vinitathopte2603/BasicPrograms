using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class LazyInitialisation
    {
        private static int count = 0;
        private static Lazy<LazyInitialisation> singleInstance = new Lazy<LazyInitialisation>(() => new LazyInitialisation());
        private LazyInitialisation()
        {
            count++;
            Console.WriteLine(count + " instance created");
        }
        public static LazyInitialisation SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }
        public void Display(string str)
        {
            Console.WriteLine(str);
        }
    }
}
