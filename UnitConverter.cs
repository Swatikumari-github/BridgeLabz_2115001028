using System;
class ques4
{
    public static double ConvertKmToMiles() {
	    Console.WriteLine("enter the distance in km:");
	 double km=Convert.ToDouble(Console.ReadLine());
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm() {
	    Console.WriteLine("enter the distance in miles:");
	    double miles=Convert.ToDouble(Console.ReadLine());
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet() {
	    Console.WriteLine("enter the distance in meters:");
	 double meters=Convert.ToDouble(Console.ReadLine());
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters() {
	Console.WriteLine("enter the distance in feet:");
	 double feet=Convert.ToDouble(Console.ReadLine());
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

 static void Main(string [] args)
 {
       Console.WriteLine("10 kilometers to miles: " + ConvertKmToMiles());
       Console.WriteLine("10 miles to kilometers: " + ConvertMilesToKm());
        Console.WriteLine("10 meters to feet: " + ConvertMetersToFeet());
        Console.WriteLine("10 feet to meters: " + ConvertFeetToMeters());
		Console.ReadLine();
 }
}