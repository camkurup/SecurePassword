using System.Data.SqlClient;

namespace SecurePassword
{
    internal class Dal
    {
        public string GetConnectionString()
        {
            string connectionString = @"Server=localhost;Database=SecurePassword;Trusted_Connection=True;";

            return connectionString;
        }

        public void FindUser(string userName, byte[] salt, byte[] hashed)
        {
            //with the single plings I protected my code from sql injection
            //Insert statement
            var stm = $"INSERT INTO Users VALUES ('{userName}', '{Convert.ToBase64String(salt)}', '{Convert.ToBase64String(hashed)}')";

            using var con = new SqlConnection(GetConnectionString());
            con.Open();

            using var cmd = new SqlCommand(stm, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
