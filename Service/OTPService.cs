using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   
    public class OTPService
    {
        private static OTPService _instance = null;

        Dictionary<string, User> otpStorage;

        string chars = "ABCDEFGHIJKLMOPQRSTUVWXYZ";
        Random random = new Random();

        private OTPService()
        {
            this.otpStorage = new Dictionary<string, User>();
        }


        public static OTPService GetOTPService()
        {
            if (_instance == null)
            {
                _instance = new OTPService();
            }
            return _instance;
        }


        public void store(string otp, User user)
        {
            this.otpStorage.Add(otp, user);
        }

        public User get(string otp)
        {
            if (this.otpStorage.ContainsKey(otp))
            {
                return this.otpStorage[otp];
            }
            return null;
        }

        public string newOtp()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append(chars[this.random.Next()%26]);
            }
            return sb.ToString();
        }

    }
}
