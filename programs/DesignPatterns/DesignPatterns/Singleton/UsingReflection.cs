using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace DesignPatterns
{
    class UsingReflection
    {
        private static int count = 0;
        private static UsingReflection usingReflection = new UsingReflection();
        private UsingReflection()
        {
            count++;
            Console.WriteLine("Instance created : " + count);
        }
    }
}
