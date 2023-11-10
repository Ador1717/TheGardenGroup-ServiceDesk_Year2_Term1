using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using DAL;

namespace UI
{
    public partial class ResetPassword : Form
    {
        User user;

        OTPService otpService = OTPService.GetOTPService();
        public ResetPassword(User user)
        {
            this.user = user;
            InitializeComponent();

            if (user == null || user.email == "")
            {
                MessageBox.Show("User email is not provided!");
                this.Hide();
                new UserAuthentication().Show();
                return;
            }

            string otp = otpService.newOtp();
            otpService.store(otp, user);
            SendReseSPasswordEmail(user, otp);
        }


        public void SendReseSPasswordEmail(User user, string otp)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("thegardengroupteam@gmail.com");
                mail.To.Add(user.email);
                mail.Subject = "Reset Password";
                mail.Body = "otp for the user " + user.username + " is : " +otp;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("thegardengroupteam@gmail.com", "haed muen qhtu utzj"); // tedy123#@!
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string otp= otpTextBox.Text;
            User user = otpService.get(otp);
            if (user == null || user.email != this.user.email)
            {
                MessageBox.Show("Invalid OTP");
                return;
            }

            passwordTextBox.Enabled = true;
            confirmPasswordTextBox.Enabled = true;
            submitBtn.Enabled = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            if (password != confirmPassword)
            {
                MessageBox.Show("Invalid password");
                return;
            }

            string hashedPassword = HashUtil.HashPassword(password, user.salt);

            new UserDAO().HashedPassword(this.user.email, hashedPassword);
            MessageBox.Show("Password is updated succesfully.");
            this.Close();
            new UserAuthentication().Show();
        }
    }
}
