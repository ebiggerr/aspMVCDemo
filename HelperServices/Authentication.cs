namespace aspMVCDemo.HelperServices
{
    public static class Authentication
    {
        public static string Hashing(string password)
        {
            //anything above 10 would be recommended, too much while can kill the processor and it is impractical
            return BCrypt.Net.BCrypt.HashPassword(password, 14);
        }

        public static bool ValidatePassword(string dBPassword, string inputPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, dBPassword);
        }

        public static bool PasswordConfirmation(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }
    }
}