using System.Data.SqlClient;
using System.Text;

SecurePassword.SafePassword safePassword = new SecurePassword.SafePassword();
SecurePassword.GetPassword getPassword= new SecurePassword.GetPassword();



Console.WriteLine("input username: ");
var userName = Console.ReadLine();
Console.WriteLine("input password: ");
var password = Console.ReadLine();

var salt = safePassword.GenerateSalt(password);
var hashed = safePassword.HashPasswordWithSalt(
    Encoding.UTF8.GetBytes(password),
    salt); ;

Console.WriteLine("Hashed Password = " + Convert.ToBase64String(hashed));



//DB connection and communication
var conString = @"Server=localhost;Database=SecurePassword;Trusted_Connection=True;";
//with the single plings I protected my code from sql injection
//Insert statement
var stm = $"INSERT INTO Users VALUES ('{userName}', '{salt}', '{hashed}')";

using var con = new SqlConnection(conString);
con.Open();

using var cmd = new SqlCommand(stm, con);
cmd.ExecuteNonQuery();
con.Close();
