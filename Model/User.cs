using System;

namespace Model
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userType { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string location { get; set; }
        public string password { get; set; }
        public string[] tickets { get; set; }
       //public string Id { get; set; }
       //public string Name { get; set; }
       //public string Username { get; set; }
       //public string Password { get; set; } // Should store hashed and salted password, not plaintext.
       //public List<string> TicketIDs { get; set; } // List of tickets associated with the user.
        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Regular,
        ServiceDesk
    }

}

