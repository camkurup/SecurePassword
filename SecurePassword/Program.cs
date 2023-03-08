using System.Data.SqlClient;
using System.Text;

SecurePassword.SafePassword safePassword = new SecurePassword.SafePassword();
SecurePassword.GetPassword getPassword= new SecurePassword.GetPassword();
SecurePassword.Dal dal = new SecurePassword.Dal();


Console.WriteLine("input username: ");
var userName = Console.ReadLine();
Console.WriteLine("input password: ");
var password = Console.ReadLine();

var salt = safePassword.GenerateSalt(password);
var hashed = safePassword.HashPasswordWithSalt(
    Encoding.UTF8.GetBytes(password),
    salt); ;

Console.WriteLine("Hashed Password = " + Convert.ToBase64String(hashed));
dal.FindUser(userName, salt, hashed);

