using System;
class ques6
{
   // Method to convert Fahrenheit to Celsius
    public static double ConvertFahrenheitToCelsius() {
	    Console.WriteLine("enter the temperature in fahrenheit:");
		double fahrenheit=Convert.ToInt32(Console.ReadLine());
        return (fahrenheit - 32) * 5 / 9;
    }

    // Method to convert Celsius to Fahrenheit
    public static double ConvertCelsiusToFahrenheit() {
	    Console.WriteLine("enter the temperature in celcius:");
		double celsius=Convert.ToInt32(Console.ReadLine());
        return (celsius * 9 / 5) + 32;
    }

    // Method to convert pounds to kilograms
    public static double ConvertPoundsToKilograms() {
	    Console.WriteLine("enter the weight in pounds:");
		double pounds=Convert.ToInt32(Console.ReadLine());
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    // Method to convert kilograms to pounds
    public static double ConvertKilogramsToPounds() {
	     Console.WriteLine("enter the weight in kg:");
		double kilograms=Convert.ToInt32(Console.ReadLine());
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    // Method to convert gallons to liters
    public static double ConvertGallonsToLiters() {
	      Console.WriteLine("enter the weight in gallons:");
		double gallons=Convert.ToInt32(Console.ReadLine());
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    // Method to convert liters to gallons
    public static double ConvertLitersToGallons() {
	     Console.WriteLine("enter thewight in litres:");
		double liters=Convert.ToInt32(Console.ReadLine());
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }
  static void Main(string [] args)
  {
     Console.WriteLine(" Fahrenheit to Celsius: " + ConvertFahrenheitToCelsius());
       Console.WriteLine(" Celsius to Fahrenheit: " + ConvertCelsiusToFahrenheit());
         Console.WriteLine(" pounds to kilograms: " + ConvertPoundsToKilograms());
        Console.WriteLine(" kilograms to pounds: " + ConvertKilogramsToPounds());
          Console.WriteLine(" gallons to liters: " + ConvertGallonsToLiters());
      Console.WriteLine(" liters to gallons: " + ConvertLitersToGallons());
   }
   }