using System;
using System.Linq;
using System.Net.Mail;

namespace GamingCafeAsset_InventorySystem
{
    internal class PhoneEmailValidation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);

                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string phone)
        {
            return phone.All(char.IsDigit) && phone.Length == 11;
        }
    }
}
