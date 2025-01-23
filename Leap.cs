using System;
class Leap{
   static void LeapYear(int year)
   {
       if (year >= 1582)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("the" +year +" " +"is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine("the" +year +" " +"is a not Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine("the" +year +" " +"is a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("the" +year +" " +"is not a Leap Year.");
            }
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