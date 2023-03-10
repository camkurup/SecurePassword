namespace SecurePassword
{
    internal class UserModel
    {
        public string UserName { get; set; }
        public string Salt { get; set; }
        public string HashedPassword { get; set; }
    }
}
