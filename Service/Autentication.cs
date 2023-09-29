using DAL;
using Model;
using System.Text;
using System.Security.Cryptography;


namespace Service
{
    public class Autentication
    {
       
        public bool AutenticateUser(string userName, string password)
        {
            // load the data from db
            // hash the password

            // compare the hash
            // return true or false

            UserData userData = new UserData();
            User user = userData.GetByUsername(userName);
            if (user == null)
            {
                return false;
            }


            var tmpPassword = ASCIIEncoding.ASCII.GetBytes(password);

            var tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpPassword);

            StringBuilder hashString = new StringBuilder();
            foreach (byte b in tmpHash)
            {
                hashString.Append(b.ToString("x2"));
            }
            
            if (user.password != hashString.ToString())
            {
                return false;
            }


            return true;
       
        }

    }
}