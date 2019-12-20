//-----------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    /// <summary>
    /// Class for inventory management of grains
    /// </summary>
    public class InventoryManagement
    {
        /// <summary>
        /// all the content from a file is read in the variable
        /// </summary>
       private static string jsondata = File.ReadAllText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Grains.json");

        /// <summary>
        /// calls the inventory
        /// </summary>
        public static void InventoryCall()
        {
            var jsonObjectArray = JsonConvert.DeserializeObject<InventoryStructure>(jsondata);
            Utility ut = new Utility();
            ut.DisplayInventory();
            Console.WriteLine("\nEnter the grain you want to purchase ");
            string name = Console.ReadLine();
            string grainName = name.ToLower();
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (jsonObjectArray.rice[i].name != grainName && jsonObjectArray.pulses[i].name != grainName && jsonObjectArray.wheat[i].name != grainName)
                {
                    count++;
                }
            }

            if (count == 3)
            {
                Console.WriteLine("grain not available in inventory");
            }
            else
            {
                Console.WriteLine("\nEnter amount of grain you want to purchase");
            }

            double quantity = Convert.ToDouble(Console.ReadLine());
            double newWeight = ut.InventoryManagementCustomer(grainName, quantity);
            Console.WriteLine(newWeight);
            for (int i = 0; i < jsondata.Length; i++)
            {
                if (jsonObjectArray.rice[i].name == grainName)
                {
                    jsonObjectArray.rice[i].weight = newWeight;
                    break;
                }

                if (jsonObjectArray.wheat[i].name == grainName)
                {
                    jsonObjectArray.wheat[i].weight = newWeight;
                    break;
                }

                if (jsonObjectArray.pulses[i].name == grainName)
                {
                    jsonObjectArray.pulses[i].weight = newWeight;
                    break;
                }
            }
         
            using (StreamWriter file = File.CreateText(@"D:\bridgelabz\programs\ObjectOrientedPrograms\ObjectOrientedPrograms\Grains.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, jsonObjectArray);
            }
        }
    }
}
