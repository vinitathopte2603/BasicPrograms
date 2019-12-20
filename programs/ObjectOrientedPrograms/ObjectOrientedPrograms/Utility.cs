//-----------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

    /// <summary>
    /// class having logic to read data from file and perform operations on data
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// all the content from a file is read in the variable
        /// </summary>
         private static string jsondata = File.ReadAllText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Grains.json");

        /// <summary>
        /// reads data from file and displays the output 
        /// </summary>
        public static void GrainsInventoryMgnt()
        {
            var jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            string grain = jsonObjectArray.rice[2].name;
            Console.WriteLine(/*jsonObjectArray.Rice[2].weight*/grain);
            double total = 0;
            for (int i = 0; i < 3; i++)
            {
                total = jsonObjectArray.rice[i].pricePerkg * jsonObjectArray.rice[i].weight;
                Console.WriteLine("Cost of total available " + jsonObjectArray.rice[i].name + " is :" + total);
            }
        }

        /// <summary>
        /// allows user to purchase any grain
        /// </summary>
        /// <param name="grainName">Name of the grain.</param>
        /// <param name="quantity">The quantity.</param>
        /// <returns>returns the remaining quantity of food grain in inventory</returns>
        public double InventoryManagementCustomer(string grainName, double quantity)
        {
            var jsonObjectsArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            double amount;
            double priceToPay;
            double newWeight = 0;
            for (int i = 0; i < jsondata.Length; i++)
            {
                if (grainName == jsonObjectsArray.rice[i].name)
                {
                    amount = jsonObjectsArray.rice[i].weight;
                    priceToPay = quantity * jsonObjectsArray.rice[i].pricePerkg;
                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                else if (grainName == jsonObjectsArray.wheat[i].name)
                {
                    amount = jsonObjectsArray.wheat[i].weight;
                    priceToPay = quantity * jsonObjectsArray.wheat[i].pricePerkg;
                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                else if (grainName == jsonObjectsArray.pulses[i].name)
                {
                    amount = jsonObjectsArray.pulses[i].weight;
                    priceToPay = quantity * jsonObjectsArray.pulses[i].pricePerkg;

                    Console.WriteLine("amount to be paid : " + priceToPay);
                    newWeight = amount - quantity;
                    break;
                }
                ////else
                ////{
                ////    Console.WriteLine("Given grain not available");
                ////}
            }

            return newWeight;
        }

        /// <summary>
        /// Displays the inventory.
        /// </summary>
        public void DisplayInventory()
        {
            var jsonObjectsArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            Console.WriteLine("Total stock present in the inventory");
            List<Properties> rice = jsonObjectsArray.rice;
            foreach (Properties details in rice)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }

            Console.WriteLine();
            List<Properties> wheat = jsonObjectsArray.wheat;
            foreach (Properties details in wheat)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }

            Console.WriteLine();
            List<Properties> pulses = jsonObjectsArray.pulses;
            foreach (Properties details in pulses)
            {
                Console.Write("\n" + details.name + " : " + details.pricePerkg + " per/kg " + ", stock present in inventory : " + details.weight);
            }
        }
    }
}
