using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UserBuilder
    {
        public User user;
        public UserBuilder(string name)
        {
            user =new User(name);
            
        }

        public UserBuilder SetEmail(string email)
        {
            user.Email = email; return this;
        }

        public UserBuilder SetPassword(string password)
        {
            user.Password = password; return this;
        }

        public UserBuilder SetAddress(Address address)
        {
            user.Address = address;
            return this;
        }

        public UserBuilder SetName(string name)
        {
            user.Name = name;
            return this;
        }
        public User Build()
        {
            return user;
        }

    }
}
