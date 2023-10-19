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
        // load the data from db
        // hash the password

        // compare the hash
        // return true or false

        UserDAO userData = new UserDAO();
        User user = userData.GetByUsername(userName);
        if (user == null) return null;

        // TODO: Hash the password and validate

        return user;
    }


    public User ResetPassword(string username)
    {
        using (MailMessage mail = new MailMessage())
        {
            string otp = OTPService.getOTPService().newOtp();
            mail.From = new MailAddress("thegardengroupteam@gmail.com");
            mail.To.Add("unlibertario19@gmail.com");
            mail.Subject = "test subject";
            mail.Body = otp;
            mail.IsBodyHtml = true;
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential("thegardengroupteam@gmail.com", "haed muen qhtu utzj"); // tedy123#@!
                smtp.EnableSsl = true;
                smtp.Send(mail);
            }

        }


        return null;
    }
}