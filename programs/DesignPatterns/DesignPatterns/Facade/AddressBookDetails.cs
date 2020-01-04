using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DesignPatterns
{
    class AddressBookDetails
    {
        static string path = @"D:\bridgelabz\programs\DesignPatterns\DesignPatterns\Addressbook.json";
        public static void InputFromUser()
        {
            AddressBookInput addressBookInput = new AddressBookInput();
            string jsonContent = File.ReadAllText(path);
            var jsonObjectArray = JsonConvert.DeserializeObject<List<AddressBookInput>>(jsonContent);
            List<AddressBookInput> addressBooks = jsonObjectArray;
            addressBookInput.Name = Validation.ValidateName();
            addressBookInput.City = Validation.ValidateCity();
            addressBookInput.State = Validation.ValidateState();
            addressBookInput.ZipCode = Validation.ValidateZipCode();
            addressBookInput.ContactNumber = Validation.ValidateContactNumber();
            addressBooks.Add(addressBookInput);
            string jsonString = JsonConvert.SerializeObject(addressBooks);
            File.WriteAllText(path, jsonString);
        }
    }
}
