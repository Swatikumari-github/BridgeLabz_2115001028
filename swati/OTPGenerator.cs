using System;

class OTPGenerator
{
    static void Main()
    {
        // Create an array to store the OTPs generated 10 times
        int[] otps = new int[10];

        // Create a single Random object for generating OTPs
        Random random = new Random();

        // Generate 10 OTPs
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP(random);
        }

        // Check if all OTPs are unique
        if (AreUnique(otps))
        {
            Console.WriteLine("All OTPs are unique.");
        }
        else
        {
            Console.WriteLine("Some OTPs are not unique.");
        }

        // Print the generated OTPs using a for loop
        Console.WriteLine("Generated OTPs: ");
        for (int i = 0; i < otps.Length; i++)
        {
            Console.WriteLine(otps[i]);
        }
    }

    // Method to generate a 6-digit OTP number
    static int GenerateOTP(Random random)
    {
        // Generate a random 6-digit number (100000 to 999999)
        int otp = random.Next(100000, 1000000);
        return otp;
    }

    // Method to check if all OTPs in the array are unique
    static bool AreUnique(int[] otps)
    {
        // Loop through the OTP array and compare each element with the rest
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;  // Found a duplicate, return false
                }
            }
        }
        return true;  // No duplicates found, return true
    }
}
