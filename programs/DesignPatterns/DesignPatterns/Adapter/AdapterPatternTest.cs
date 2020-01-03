using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
	class AdapterPatternTest
	{
		public static void TestClassAdapter()
		{
			SocketAdapter sockAdapter = new SocketAdapterImplement();
			Volts v3 = getVolt(sockAdapter, 3);
			Volts v12 = getVolt(sockAdapter, 12);
			Volts v120 = getVolt(sockAdapter, 120);
			Console.WriteLine("v3 volts using Class Adapter=" + v3.getVolts());
			Console.WriteLine("v12 volts using Class Adapter=" + v12.getVolts());
			Console.WriteLine("v120 volts using Class Adapter=" + v120.getVolts());
		}

		private static Volts getVolt(SocketAdapter sockAdapter, int i)
		{
			switch (i)
			{
				case 3: return sockAdapter.Get3Volts();
				case 12: return sockAdapter.Get12Volts();
				case 120: return sockAdapter.Get120Volts();
				default: return sockAdapter.Get120Volts();
			}
		}
	}
}
