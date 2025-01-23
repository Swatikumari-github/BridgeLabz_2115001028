using System;
class DayOfWeek{
   static void Day(string [] args)
   {
       if (args.Length != 3)
        {
            Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
            return;
        }

        // Parse input arguments
        int m = int.Parse(args[0]); // Month
        int d = int.Parse(args[1]); // Day
        int y = int.Parse(args[2]); // Year

        // Calculate intermediate values
        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        // Print the day of the week
        Console.WriteLine(d0);
	}
	 static void Main(String [] args)
	 { 
	   
		Day(args);
		Console.ReadLine();
		}
	}
	
