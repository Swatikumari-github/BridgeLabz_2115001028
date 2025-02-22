

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class SSNValidator
    {
        public static bool IsValidSSN(string ssn)
        {
            // Regular expression to validate SSN in the format XXX-XX-XXXX
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            // Use Regex.IsMatch to check if the input matches the SSN format
            return Regex.IsMatch(ssn, pattern);
        }
    }

    class Security
    {
        static void Main()
        {
            // Example input SSNs
            string validSSN = "123-45-6789";
            string invalidSSN1 = "123456789";  // Invalid (missing hyphens)
            string invalidSSN2 = "123-45-678"; // Invalid (too short)
            string invalidSSN3 = "12-345-6789"; // Invalid (incorrect placement of hyphens)

            // Validate the SSNs
            Console.WriteLine($"{validSSN} is valid: {SSNValidator.IsValidSSN(validSSN)}");
            Console.WriteLine($"{invalidSSN1} is valid: {SSNValidator.IsValidSSN(invalidSSN1)}");
            Console.WriteLine($"{invalidSSN2} is valid: {SSNValidator.IsValidSSN(invalidSSN2)}");
            Console.WriteLine($"{invalidSSN3} is valid: {SSNValidator.IsValidSSN(invalidSSN3)}");
        }
    }

}
