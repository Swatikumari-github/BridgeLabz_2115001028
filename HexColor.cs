

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class HexColorValidator
    {
        public static string ValidateHexColor(string hexColor)
        {
            // Define the regex pattern for a valid hex color code
            string pattern = @"^#[0-9A-Fa-f]{6}$";

            // Check if the hex color matches the pattern
            if (Regex.IsMatch(hexColor, pattern))
            {
                return "Valid";
            }
            else
            {
                return "Invalid";
            }
        }
    }

    class HexColor
    {
        static void Main()
        {
            // Test cases
            Console.WriteLine(HexColorValidator.ValidateHexColor("#FFA500"));  // Valid
            Console.WriteLine(HexColorValidator.ValidateHexColor("#ff4500"));  // Valid
            Console.WriteLine(HexColorValidator.ValidateHexColor("#123"));     // Invalid (too short)
            Console.WriteLine(HexColorValidator.ValidateHexColor("#ff12345")); // Invalid (too long)
            Console.WriteLine(HexColorValidator.ValidateHexColor("FFA500"));   // Invalid (missing #)
        }
    }

}
