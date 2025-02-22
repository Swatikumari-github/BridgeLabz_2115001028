


namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class UsernameValidator
    {
        public static string ValidateUsername(string username)
        {
            // Define the regex pattern for a valid username
            string pattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,14}$";

            // Check if the username matches the pattern
            if (Regex.IsMatch(username, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Test cases
            Console.WriteLine(UsernameValidator.ValidateUsername("user_123"));  // Valid
            Console.WriteLine(UsernameValidator.ValidateUsername("123user"));  // Invalid (starts with a number)
            Console.WriteLine(UsernameValidator.ValidateUsername("us"));       // Invalid (too short)
            Console.WriteLine(UsernameValidator.ValidateUsername("valid_user123")); // Valid
            Console.WriteLine(UsernameValidator.ValidateUsername("invalid#user")); // Invalid (contains special characters)
            Console.WriteLine(UsernameValidator.ValidateUsername("toolonguser123456")); // Invalid (too long)
        }
    }

}
