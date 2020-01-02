using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   abstract class Computer
    {
        public abstract string GetRam();
        public abstract string GetHDD();
        public abstract string GetCPU();
        public string tostring()
        {
            return "RAM = " + this.GetRam() + ", HDD = " + this.GetHDD() + ", CPU = " + this.GetCPU();
        }

    }
}
