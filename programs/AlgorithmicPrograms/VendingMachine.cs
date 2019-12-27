//-----------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace AlgorithmicPrograms
{
    using System;
using System.Collections.Generic;
using System.Text;

    /// <summary>
    /// Vending machine
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// returns the number of notes required to get the given amount as input
        /// </summary>
        public static void VendingMachineNotes()
        {
            Console.WriteLine("Enter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Utility.VendingMachines(amount);
        }
    }
}
