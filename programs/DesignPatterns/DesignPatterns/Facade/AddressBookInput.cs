using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class AddressBookInput:IDetails
    {
        public string  Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long ZipCode { get; set; }
        public long ContactNumber { get; set; }
    }
}
