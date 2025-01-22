using System;

class ques14
{
    static void Main(string[] args)
    {
        // Conversion factors
        const int feetPerYard = 3;
        const int yardsPerMile = 1760;

        // Prompt the user to enter the distance in feet
        Console.WriteLine("Enter the distance in feet:");
        double feet = Convert.ToDouble(Console.ReadLine());

        // Convert feet to yards
        double yards = feet / feetPerYard;

        // Convert yards to miles
        double miles = yards / yardsPerMile;

        // Display the results
        Console.WriteLine("The distance in:");
        Console.WriteLine("yards" +yards);
		Console.WriteLine("miles" +miles);

        Console.ReadLine(); // Wait for user input before exiting
    }
}
