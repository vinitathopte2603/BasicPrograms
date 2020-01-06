//-----------------------------------------------------------------------
// <copyright file="InputOutput.cs" Author="Vinita Thopte" company="Bridgelabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

    /// <summary>
    /// class to do input output operations
    /// </summary>
   public class InputOutput
    {
        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void WriteToFile(string path)
        {
            InputData inputData = new InputData();

            List<InputData> businessBook = ReadFromFile(path);
            inputData.Name = Validation.ValidateName();
            inputData.City = Validation.ValidateCity();
            inputData.State = Validation.ValidateState();
            inputData.ZipCode = Validation.ValidateZipCode();
            inputData.ContactNumber = Validation.ValidateContactNumber();
            businessBook.Add(inputData);
            string jsonString = JsonConvert.SerializeObject(businessBook);
            File.WriteAllText(path, jsonString);
        }

        /// <summary>
        /// Reads from file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns>the data read from file</returns>
        public static List<InputData> ReadFromFile(string path)
        {
            string jsonContent = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<InputData>>(jsonContent);
            return jsonObjectArray;
        }
    }
}
