using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassword
{
    internal class SafePassword
    {
        public string GenerateSalt(string userName)
        {
            var userInput = Console.ReadLine();
            return userInput;
        }

        public string AddSalt()
        {
            return "";
        }

        public void SafePasswordInDB()
        {
            
        }
    }
}
