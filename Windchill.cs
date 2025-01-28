using System;

class ques11
{
    public static double CalculateWindChill(double temperature, double windSpeed)
	{
	    double  windChill = 35.74 + 0.6215 *temperature + (0.4275*temperature - 35.75) * windSpeed*0.16;
		return windChill;
	}



    static void Main(string[] args)
    {
         Console.Write("Enter the  temperature: ");
         double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the  windSpeed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("the windchill is "+CalculateWindChill(temperature,windSpeed));
		Console.ReadLine();

      
    }
}