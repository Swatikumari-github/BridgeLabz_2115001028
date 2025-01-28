using System;

class LeapYear
{
    static void CheckLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
        else
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine(year + " is a Leap Year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is not a Leap Year.");
                    }
                }
                else
                {
                    Console.WriteLine(year + " is a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year.");
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        CheckLeapYear(year);
    }

}