using System;

class ques11
{
    
 public static double[] CalculateTrigonometricFunctions(double angle)
    {
        // Convert angle to radians
        double radians = angle * (Math.PI / 180);

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Return the results as an array
        return new double[] { sine, cosine, tangent };
    }


    static void Main(string[] args)
    {
         Console.Write("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        // Call the method to calculate trigonometric functions
        double[] results = CalculateTrigonometricFunctions(angle);

        // Display the results
        Console.WriteLine("Sine of " +angle +"degrees: " +results[0]);
        Console.WriteLine("CoSine of " +angle +"degrees: " +results[1]);
        Console.WriteLine("tangent of " +angle +"degrees: " +results[2]);
		Console.ReadLine();

      
    }
}