using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public Address? Address { get; set; }

        public User(string name)
        {
            Name = name;
        }
        public User(string name, string? password, string? email, Address? address) 
        {
            Password = password;
            Email = email;
            Address = address;
        }
    }
}
