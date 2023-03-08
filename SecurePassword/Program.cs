using System.Data.SqlClient;

SecurePassword.SafePassword safePassword = new SecurePassword.SafePassword();
SecurePassword.GetPassword getPassword= new SecurePassword.GetPassword();




var userName = Console.ReadLine();
var salt = "xxx";
var hashed = "testxxx";


//DB connection and communication
var conString = @"Server=localhost;Database=SecurePassword;Trusted_Connection=True;";
//with the single plings I protected my code from sql injection
//Insert statement
var stm = $"INSERT INTO Users VALUES ('{userName}', 'salt', 'hash')";

using var con = new SqlConnection(conString);
con.Open();

using var cmd = new SqlCommand(stm, con);
cmd.ExecuteNonQuery();
con.Close();
