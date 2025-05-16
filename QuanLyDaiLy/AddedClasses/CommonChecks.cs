using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI_QuanLy.CommonClass
{
    public class CommonChecks
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
                return false;

            // Regex cho số điện thoại Việt Nam
            string pattern = @"^(03|05|07|08|09)\d{8}$";
            return Regex.IsMatch(phone, pattern);
        }
    }
}
