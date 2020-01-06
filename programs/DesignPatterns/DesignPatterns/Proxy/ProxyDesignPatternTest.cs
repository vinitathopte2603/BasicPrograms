//-----------------------------------------------------------------------
// <copyright file="ProxyDesignPatternTest.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// tests the proxy design pattern
    /// </summary>
   public class ProxyDesignPatternTest
    {
        /// <summary>
        /// Tests the proxy design pattern
        /// </summary>
        public static void TestProxy()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            IOfficeInternetAccess access = new ProxyInternetAccess(name);          
            access.GrantInternetAccess();
        }
    }
}
