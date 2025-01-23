using System;
class LeapFor{
   static void LeapYear(int year)
   {
        if (year >= 1582 && ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine("the year" +year +" " +" is a Leap Year.");
        }
        else if (year >= 1582)
        {
            Console.WriteLine("the year" +year +" " +" is not a Leap Year.");
        }
        else
        {
            Console.WriteLine("Year must be >= 1582.");
        }
	}
	static void Main(String [] args)
	{
	  Console.WriteLine("enter the year");
	  int year=Convert.ToInt32(Console.ReadLine());
	  LeapYear(year);
	}
}