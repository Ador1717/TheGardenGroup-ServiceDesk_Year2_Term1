using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class HashUtil
    {
        
        //Generates a random salt using RNGCryptoServiceProvider
        public static string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }

            //Converts the salt bytes to string
            string salt = Convert.ToBase64String(saltBytes);
            return salt;
        }

        //Hashes a password using the SHA256 algorithim 
        public static string HashPassword(string password, string salt)
        {
            //combines password with salt
            string passwordWithSalt = password + salt;

            using (SHA256 sha256 = SHA256.Create())
            {
                //Creates the hash with password and salt
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordWithSalt));
                //converts hash to string
                string hashedPassword = Convert.ToBase64String(hashBytes);
                return hashedPassword;
            }
        }

    }
}
