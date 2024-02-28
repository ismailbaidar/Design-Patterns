using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Address
    {
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public Address(string name, string zipCode)
        {
            Name = name;
            ZipCode = zipCode;
        }
    }
}
