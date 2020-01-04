using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   interface ISocketAdapter
    {
       public Volts Get120Volts();
       public Volts Get12Volts();
       public Volts Get3Volts();
    }
}
