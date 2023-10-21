using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using DAL;
using Model;

namespace Service;

public class Autentication
{
    public User AutenticateUser(string userName, string password)
    {
        UserDAO userData = new UserDAO();
        User user = userData.GetByUsername(userName);
        if (user == null) return null;

        string hashedPassword = HashUtil.HashPassword(password, user.salt);
        if (user.hashedPassword != hashedPassword)
        {
            return null;
        }

        return user;
    }


    public User GetUserForForgetPassword(string username)
    {
        UserDAO userData = new UserDAO();
        User user = userData.GetByUsername(username);
        return user;
    }


    
}