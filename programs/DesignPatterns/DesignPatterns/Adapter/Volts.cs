using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{

    class Volts
    {
        private int volts;

        public int getVolts()
        {
            return volts;
        }
        public void setVolts(int volts)
        {
            this.volts = volts;
        }
        public Volts(int v)
        {
            this.volts = v;
        }
    }
}
