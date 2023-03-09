using System.Text;

SecurePassword.Dal dal = new SecurePassword.Dal();
SecurePassword.Logic logic = new SecurePassword.Logic();

//CreateUser -- Start
Console.WriteLine("input username: ");
var CreateUserName = Console.ReadLine();
Console.WriteLine("input createPassword: ");
var createPassword = Console.ReadLine();

var salt = logic.GenerateSalt(createPassword);
var hashed = logic.HashPasswordWithSalt(
    Encoding.UTF8.GetBytes(createPassword),
    salt);
dal.CreateUser(CreateUserName, salt, hashed);
//CreateUser -- End

//Login -- Start
Console.WriteLine("input username: ");
var inputUserName = Console.ReadLine();
Console.WriteLine("input createPassword: ");
var inputPassword = Console.ReadLine();

//Login -- End



Console.WriteLine("Hashed Password = " + Convert.ToBase64String(hashed));

