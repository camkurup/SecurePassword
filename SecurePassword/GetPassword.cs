using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassword
{
    internal class GetPassword
    {
        public string GetSalt(string userName)
        {
            return "";
        }

        public string GetHash(string userName)
        {
            return "";
        }

        public string AddSaltToPassword(string salt, string password)
        {
            return salt + password;
        }

        public bool CompareInputAndDB(string userName )
        {
            return false;
        }
    }
}
