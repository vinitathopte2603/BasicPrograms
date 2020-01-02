using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Factory
    {
        public static Computer GetComputer(string type, string ram, string hdd, string cpu)
        {
            if ("PCs".Equals(type))
            {
                return new PCs(ram, hdd, cpu);
            }
            else if ("Laptop".Equals(type))
            {
                return new Laptop(ram, hdd, cpu);
            }
            else if ("Servers".Equals(type))
            {
                return new Servers(ram, hdd, cpu);
            }
            return null;
        }
    }
}
