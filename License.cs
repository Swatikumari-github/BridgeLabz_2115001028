

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class LicensePlateValidator
    {
        public static string ValidateLicensePlate(string licensePlate)
        {
            // Define the regex pattern for a valid license plate
            string pattern = @"^[A-Z]{2}\d{4}$";

            // Check if the license plate matches the pattern
            if (Regex.IsMatch(licensePlate, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }

    class Liscense
    {
        static void Main()
        {
            // Test cases
            Console.WriteLine(LicensePlateValidator.ValidateLicensePlate("AB1234"));  // Valid
            Console.WriteLine(LicensePlateValidator.ValidateLicensePlate("A12345"));  // Invalid (only one letter at the start)
            Console.WriteLine(LicensePlateValidator.ValidateLicensePlate("AB12A4"));  // Invalid (letters and digits mixed)
            Console.WriteLine(LicensePlateValidator.ValidateLicensePlate("AB123"));   // Invalid (too few digits)
            Console.WriteLine(LicensePlateValidator.ValidateLicensePlate("AB12345")); // Invalid (too many digits)
        }
    }

}
