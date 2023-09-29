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


    }
}
