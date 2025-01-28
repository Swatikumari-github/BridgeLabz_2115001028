using System;

class EuclideanDistance
{
    static void Main(string[] args)
    {
        // Input for two points (x1, y1) and (x2, y2)
        Console.Write("Enter the coordinates of Point 1 (x1 y1): ");
        string[] point1 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(point1[0]), y1 = double.Parse(point1[1]);

        Console.Write("Enter the coordinates of Point 2 (x2 y2): ");
        string[] point2 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(point2[0]), y2 = double.Parse(point2[1]);

        // Calculate and display the Euclidean distance
        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine("\nEuclidean Distance between Point 1 and Point 2: " + distance);

        // Calculate and display the equation of the line
        double[] lineEquation = CalculateLineEquation(x1, y1, x2, y2);
        double slope = lineEquation[0];
        double intercept = lineEquation[1];
        Console.WriteLine("\nEquation of the line: y = " + slope + "*x + " + intercept);
    }

    // Method to calculate the Euclidean distance
    static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    // Method to calculate the slope and y-intercept of the line
    static double[] CalculateLineEquation(double x1, double y1, double x2, double y2)
    {
        // Calculate slope (m)
        double m = (y2 - y1) / (x2 - x1);

        // Calculate y-intercept (b)
        double b = y1 - (m * x1);

        return new double[] { m, b };
    }
}
