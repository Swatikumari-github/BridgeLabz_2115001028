using System;

class FootballTeam
{
    static void Main(string[] args)
    {
        // Initialize array to store heights of 11 players
        int[] heights = new int[11];

        // Random object to generate random heights
        Random random = new Random();

        // Fill the heights array with random heights between 150 and 250 cm
        for (int i = 0; i < heights.Length; i++)
        {
            heights[i] = random.Next(150, 251);  // Random height between 150 and 250 cm
        }

        // Find the sum of the heights
        int sum = FindSum(heights);

        // Find the mean height
        double mean = FindMean(sum, heights.Length);

        // Find the shortest height
        int shortest = FindShortest(heights);

        // Find the tallest height
        int tallest = FindTallest(heights);

        // Display the results
        Console.WriteLine("Player Heights (in cms): ");
        Console.WriteLine(string.Join(", ", heights));
        Console.WriteLine("\nSum of all player heights: " + sum + " cms");
        Console.WriteLine("Mean height: " + mean + " cms");
        Console.WriteLine("Shortest height: " + shortest + " cms");
        Console.WriteLine("Tallest height: " + tallest + " cms");
    }

    // Method to find the sum of all elements in the heights array
    public static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Method to find the mean height
    public static double FindMean(int sum, int numberOfPlayers)
    {
        return (double)sum / numberOfPlayers;
    }

    // Method to find the shortest height
    public static int FindShortest(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Method to find the tallest height
    public static int FindTallest(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
