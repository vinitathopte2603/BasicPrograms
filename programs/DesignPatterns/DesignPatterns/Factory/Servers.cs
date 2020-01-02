using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Servers:Computer
    {
        private string ram;
        private string hdd;
        private string cpu;
        public Servers(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public override string GetRam()
        {
            return this.ram;
        }

        public override string GetHDD()
        {
            return this.hdd;
        }

        public override string GetCPU()
        {
            return this.cpu;
        }
    }
}
