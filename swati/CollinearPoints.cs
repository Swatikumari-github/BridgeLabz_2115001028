
using System;

class CollinearPoints
{
    static void Main()
    {
        // Taking user input for coordinates of the points
        Console.Write("Enter the coordinates of Point A (x1 y1): ");
        string[] pointA = Console.ReadLine().Split(' ');
        int x1 = int.Parse(pointA[0]), y1 = int.Parse(pointA[1]);

        Console.Write("Enter the coordinates of Point B (x2 y2): ");
        string[] pointB = Console.ReadLine().Split(' ');
        int x2 = int.Parse(pointB[0]), y2 = int.Parse(pointB[1]);

        Console.Write("Enter the coordinates of Point C (x3 y3): ");
        string[] pointC = Console.ReadLine().Split(' ');
        int x3 = int.Parse(pointC[0]), y3 = int.Parse(pointC[1]);

        Console.WriteLine("\nUsing Slope Formula:");
        if (ArePointsCollinearBySlope(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("The points are collinear.");
        else
            Console.WriteLine("The points are not collinear.");

        Console.WriteLine("\nUsing Area of Triangle Formula:");
        if (ArePointsCollinearByArea(x1, y1, x2, y2, x3, y3))
            Console.WriteLine("The points are collinear.");
        else
            Console.WriteLine("The points are not collinear.");
    }

    static bool ArePointsCollinearBySlope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double slopeAB = (double)(y2 - y1) / (x2 - x1);
        double slopeBC = (double)(y3 - y2) / (x3 - x2);
        double slopeAC = (double)(y3 - y1) / (x3 - x1);

        return slopeAB == slopeBC && slopeBC == slopeAC;
    }

    static bool ArePointsCollinearByArea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return area == 0;
    }
}

