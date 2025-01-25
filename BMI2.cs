using System;

class Program
{
    static void BMI2()
    {
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Create a multi-dimensional array to store height, weight, and BMI
        double[,] personData = new double[numPersons, 3]; // personData[i, 0] = height, personData[i, 1] = weight, personData[i, 2] = BMI
        string[] weightStatus = new string[numPersons]; // Array to store weight status for each person

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson" +(i + 1));

            // Input height and validate
            double height;
            do
            {
                Console.Write("Enter height (in meters, positive value): ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                {
                    Console.WriteLine("Height must be a positive value. Please enter again.");
                }
            } while (height <= 0);
            personData[i, 0] = height; // Store height in the array

            // Input weight and validate
            double weight;
            do
            {
                Console.Write("Enter weight (in kg, positive value): ");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                {
                    Console.WriteLine("Weight must be a positive value. Please enter again.");
                }
            } while (weight <= 0);
            personData[i, 1] = weight; // Store weight in the array

            // Calculate BMI and store it
            personData[i, 2] = weight / (height * height); // BMI = weight / height^2

            // Determine weight status based on BMI
            if (personData[i, 2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        // Display the results for each person
        Console.WriteLine("\nDetails of each person:");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI     | Weight Status");
        Console.WriteLine("---------------------------------------------------");

        // Print the details for each person
        for (int i = 0; i < numPersons; i++)
        {
            // Use the values from personData directly
            Console.WriteLine("{0,6} | {1,12:F2} | {2,11:F2} | {3,7:F2} | {4,12}",
                              i + 1, personData[i, 0], personData[i, 1], personData[i, 2], weightStatus[i]);
        }
    }

    static void Main(string[] args)
    {
        BMI2(); // Call the BMI method
    }
}
