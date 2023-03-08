using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurePassword
{
    internal class SafePassword
    {
        private static Random random = new Random();

        public void createPassword()
        {
            Console.WriteLine("Input Password: ");
            string password = Console.ReadLine();

        }

        public void createPassword(string password) { }
        public string GenerateSalt(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
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
