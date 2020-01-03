using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Socket
    {
        public Volts GetVolts()
        {
            return new Volts(120);
        }
    }
}
