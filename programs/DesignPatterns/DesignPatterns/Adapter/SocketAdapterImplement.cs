using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class SocketAdapterImplement : Socket, SocketAdapter
    {
        public Volts Get120Volts()
        {
            return GetVolts();
        }
        public Volts Get12Volts()
        {
            Volts volts = GetVolts();
            return ConvertVolts(volts, 10);
        }
        public Volts Get3Volts()
        {
            Volts volts = GetVolts();
            return ConvertVolts(volts, 40);
        }
        private Volts ConvertVolts(Volts v, int i)
        {
            return new Volts(v.getVolts() / i);
        }
    }
}
