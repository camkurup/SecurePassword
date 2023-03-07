using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassword
{
    internal class GetPassword
    {
        public string GetSalt()
        {
            return "";
        }

        public string GetHash()
        {
            return "";
        }

        public string AddSaltToPassword(string salt, string password)
        {
            return salt + password;
        }
    }
}
