using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ObjectOrientedPrograms
{
   
   public class AddressBookDetails
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long contactNumber { get; set; }
        public string emailAddress { get; set; }
        public string address { get; set; }
    }
}
