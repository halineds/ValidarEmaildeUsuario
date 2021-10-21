using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidarCsharp {
    public static class Validar {
        public static bool IsValidEmail(string email) {
            try
                {
                var enderecoEmail = new System.Net.Mail.MailAddress(email);
                return enderecoEmail.Address == email;
            }
            catch {
                return false;
            }
        }
    }
}
