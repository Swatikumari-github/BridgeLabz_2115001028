using System;

class RandomValueAnalyzer
{
     public static int[] Generate4DigitRandomArray(int size)
    {
        int[] randomNumbers = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            randomNumbers[i] = random.Next(1000, 10000); // Generate 4-digit random numbers
        }

        return randomNumbers;
    }

    // Method to find average, min, and max value of an array
    public static double[] FindAverageMinMax(int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        double sum = 0;

        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
            sum += number;
        }

        double average = sum / numbers.Length;
        return new double[] { average, min, max };
    }
    
		

    static void Main(string[] args)
    {
       Console.Write("Enter the number of 4-digit random values to generate: ");
        int size = int.Parse(Console.ReadLine());

        int[] randomNumbers = Generate4DigitRandomArray(size);

        Console.WriteLine("Generated 4-digit random numbers:");
        foreach (int number in randomNumbers)
        {
            Console.WriteLine(number);
        }

        double[] results = FindAverageMinMax(randomNumbers);

        Console.WriteLine("\nResults:");
        Console.WriteLine("Average: {0}", results[0]);
        Console.WriteLine("Minimum: {0}", results[1]);
        Console.WriteLine("Maximum: {0}", results[2]);
		Console.ReadLine();
    }
}
