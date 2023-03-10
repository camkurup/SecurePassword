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

        public void CreateUser(string userName, byte[] salt, byte[] hashed)
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

        public void FindUserByUserName(string userName)
        {
            var stm = $"SELECT * FROM Users WHERE UserName like '{userName}'";

            using var con = new SqlConnection(GetConnectionString());
            con.Open();

            using var cmd = new SqlCommand(stm, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            UserModel userModel = new UserModel();
            while (reader.Read())
            {
                userModel.UserName = reader["UserName"].ToString();
                userModel.Salt = reader["Salt"].ToString();
                userModel.HashedPassword = reader["HashedPassword"].ToString();
            }

            con.Close();
            Console.WriteLine(userModel.UserName); 
        }
    }
}
