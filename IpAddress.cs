

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;

    public class IPAddressValidator
    {
        public static bool IsValidIPv4(string input)
        {
            // Regular expression pattern to validate IPv4 address
            string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            // Use Regex.IsMatch to check if the input matches the IPv4 pattern
            return Regex.IsMatch(input, pattern);
        }
    }

    class IpAddress
    {
        static void Main()
        {
            // Example IP addresses
            string ip1 = "192.168.1.1";
            string ip2 = "256.256.256.256";
            string ip3 = "192.168.01.1";
            string ip4 = "10.0.0.256";

            // Validate the IP addresses
            Console.WriteLine($"IP {ip1} is valid: {IPAddressValidator.IsValidIPv4(ip1)}");
            Console.WriteLine($"IP {ip2} is valid: {IPAddressValidator.IsValidIPv4(ip2)}");
            Console.WriteLine($"IP {ip3} is valid: {IPAddressValidator.IsValidIPv4(ip3)}");
            Console.WriteLine($"IP {ip4} is valid: {IPAddressValidator.IsValidIPv4(ip4)}");
        }
    }

}
