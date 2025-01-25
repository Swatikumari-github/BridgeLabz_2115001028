using System;

class Program
{
    static void BMI()
    {
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());
        
        double[] height = new double[numPersons];
        double[] weight = new double[numPersons];
        double[] bmi = new double[numPersons];
        string[] weightStatus = new string[numPersons];

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("\nPerson " + (i + 1)); // Fix concatenation
            Console.Write("Enter height (in meters): ");
            height[i] = double.Parse(Console.ReadLine());

            Console.Write("Enter weight (in kg): ");
            weight[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmi[i] = weight[i] / (height[i] * height[i]);

            // Determine weight status based on BMI
            if (bmi[i] < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi[i] >= 25 && bmi[i] < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        Console.WriteLine("\nDetails of each person:");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Person | Height (m) | Weight (kg) | BMI     | Weight Status");
        Console.WriteLine("---------------------------------------------------");

        for (int i = 0; i < numPersons; i++)
        {
            // Fixed string interpolation and formatting
            Console.WriteLine("{0,6} | {1,12:F2} | {2,11:F2} | {3,7:F2} | {4,12}",
                      i + 1, height[i], weight[i], bmi[i], weightStatus[i]);
        }
    }

    static void Main(string[] args)
    {
        BMI();
    }
}
