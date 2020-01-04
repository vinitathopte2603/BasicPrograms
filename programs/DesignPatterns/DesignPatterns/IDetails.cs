using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   interface IDetails
    {
         string Name { get; set; }
         string City { get; set; }
         string State { get; set; }
         long ZipCode { get; set; }
         long ContactNumber { get; set; }
    }
}
