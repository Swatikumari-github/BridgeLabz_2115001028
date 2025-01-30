using System;

class TempConversion
{
   static double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    static double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    
    static void Main()
    {
         Console.WriteLine("Temperature Converter");
        Console.Write("Enter temperature in celcius: ");
		 Console.Write("Enter temperature in fahrenheit: ");
		 double C=Convert.ToDouble(Console.ReadLine()); 
		 double F=Convert.ToDouble(Console.ReadLine()); 
		 Console.WriteLine("Temperature  in celcius is " +FahrenheitToCelsius(C));
		  Console.WriteLine("Temperature  in Fahrenheit is " +CelsiusToFahrenheit(F));
		  Console.ReadLine()
		 
    }
}