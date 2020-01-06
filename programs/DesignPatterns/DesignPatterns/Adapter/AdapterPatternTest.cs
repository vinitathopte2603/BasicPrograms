//-----------------------------------------------------------------------
// <copyright file="AdapterPatternTest.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// working of adapter pattern
    /// </summary>
    public class AdapterPatternTest
    {
        /// <summary>
        /// Tests the class adapter.
        /// </summary>
        public static void TestClassAdapter()
        {
            ISocketAdapter sockAdapter = new SocketAdapterImplement();
            Volts v3 = GetVolt(sockAdapter, 3);
            Volts v12 = GetVolt(sockAdapter, 12);
            Volts v120 = GetVolt(sockAdapter, 120);
            Console.WriteLine("v3 volts using Class Adapter=" + v3.GetVolts());
            Console.WriteLine("v12 volts using Class Adapter=" + v12.GetVolts());
            Console.WriteLine("v120 volts using Class Adapter=" + v120.GetVolts());
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="sockAdapter">object of interface.</param>
        /// <param name="i">The choice.</param>
        /// <returns>returns the volts</returns>
        private static Volts GetVolt(ISocketAdapter sockAdapter, int i)
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
