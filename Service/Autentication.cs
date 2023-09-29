using System.Security.Cryptography;
using System.Text;
using DAL;
using Model;

namespace Service;

public class Autentication
{
    public bool AutenticateUser(string userName, string password)
    {
        // load the data from db
        // hash the password

        // compare the hash
        // return true or false

        UserDAO userData = new UserDAO();
        User user = userData.GetByUsername(userName);
        if (user == null) return false;


        byte[] tmpPassword = Encoding.ASCII.GetBytes(password);

        byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpPassword);

        StringBuilder hashString = new StringBuilder();
        foreach (byte b in tmpHash) hashString.Append(b.ToString("x2"));

        if (user.password != hashString.ToString()) return false;


        return true;
    }
}