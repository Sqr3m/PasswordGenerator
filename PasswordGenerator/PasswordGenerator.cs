namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        public static string Generate(long passwordLength)
        {
            string password = "";
            string letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890!@#$%^&*_+";
            
            Random random = new();

            if (passwordLength >= 8)
            {
                for (int i = 0; i < passwordLength; i++)
                {
                password += $"{letters[random.Next(letters.Length)]}";
                }
                
                return $"Password ({passwordLength} symbols):\n{password}\n\n";
            }
            else
            {
                return "Password must not be null.";
            }
        }
    }
}
