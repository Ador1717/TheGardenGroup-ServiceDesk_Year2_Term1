using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } // Should store hashed and salted password, not plaintext.
        public List<string> TicketIDs { get; set; } // List of tickets associated with the user.
        public UserType Type { get; set; }
    }  
}
