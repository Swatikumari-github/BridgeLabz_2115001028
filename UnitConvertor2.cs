 using System;
 class ques5{
     // Method to convert yards to feet
    public static double ConvertYardsToFeet() {
	    Console.WriteLine("Enter the yards");
		double yards=Convert.ToDouble(Console.ReadLine());
        double yards2feet = 3;
        return yards * yards2feet;
    }

    // Method to convert feet to yards
    public static double ConvertFeetToYards() {
	Console.WriteLine("Enter the feet");
		double feet=Convert.ToDouble(Console.ReadLine());
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    // Method to convert meters to inches
    public static double ConvertMetersToInches() {
	     Console.WriteLine("Enter the meter");
		double meter=Convert.ToDouble(Console.ReadLine());
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    // Method to convert inches to meters
    public static double ConvertInchesToMeters() {
	     Console.WriteLine("Enter the inches");
		double inches=Convert.ToDouble(Console.ReadLine());
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    // Method to convert inches to centimeters
    public static double ConvertInchesToCentimeters() {
	 Console.WriteLine("Enter the inches");
		double inches=Convert.ToDouble(Console.ReadLine());
        double inches2cm = 2.54;
        return inches * inches2cm;
    }
   static void Main(string [] args)
   {
         Console.WriteLine("10 yards to feet: " + ConvertYardsToFeet());
         Console.WriteLine("10 feet to yards: " + ConvertFeetToYards());
         Console.WriteLine("10 meters to inches: " + ConvertMetersToInches());
         Console.WriteLine("10 inches to meters: " + ConvertInchesToMeters();
         Console.WriteLine("10 inches to centimeters: " + ConvertInchesToCentimeters());
   }
}