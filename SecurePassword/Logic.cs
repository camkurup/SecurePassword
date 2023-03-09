using System.Security.Cryptography;

namespace SecurePassword
{
    internal class Logic
    {
        public byte[] GenerateSalt(string input)
        {
            const int saltLength = 32;

            using (var randomSaltGenerator = new RNGCryptoServiceProvider())
            {
                var salt = new byte[saltLength];
                randomSaltGenerator.GetBytes(salt);

                return salt;
            }
        }
        private byte[] CombinePasswordAndSalt(byte[] passwordArray, byte[] saltArray)
        {
            var passwordAndSalt = new byte[passwordArray.Length + saltArray.Length];

            Buffer.BlockCopy(passwordArray, 0, passwordAndSalt, 0, passwordArray.Length);
            Buffer.BlockCopy(saltArray, 0, passwordAndSalt, passwordArray.Length, saltArray.Length);

            return passwordAndSalt;
        }
        public byte[] HashPasswordWithSalt(byte[] toBeHashed, byte[] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(CombinePasswordAndSalt(toBeHashed, salt));
            }
        }

        public void CompareHasshedPasswords(byte[] userInput, byte[] fromDB)
        {



        }
    }
}
