using System.Text;

SecurePassword.Dal dal = new SecurePassword.Dal();
SecurePassword.Logic logic = new SecurePassword.Logic();

//CreateUser -- Start
Console.WriteLine("input username: ");
var CreateUserName = Console.ReadLine();
Console.WriteLine("input Password: ");
var createPassword = Console.ReadLine();

var salt = logic.GenerateSalt(createPassword);
var hashed = logic.HashPasswordWithSalt(
    Encoding.UTF8.GetBytes(createPassword),
    salt);
dal.CreateUser(CreateUserName, salt, hashed);
//CreateUser -- End

//Login -- Start

//Login -- End
