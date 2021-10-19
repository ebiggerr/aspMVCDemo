namespace aspMVCDemo.HelperServices
{
    public static class Authentication
    {
        public static string Hashing(string password)
        {

            return "dsdadasda";
        }

        public static bool ValidatePassword(string dBPassword, string inputPassword)
        {
            return true;
        }

        public static bool PasswordConfirmation(string password, string confirmPassword)
        {
            return password.Equals(confirmPassword);
        }
    }
}