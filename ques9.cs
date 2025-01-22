using System;
class ques9
{
  static void Rounds(double side1,double side2,double side3)
  { 
    
   double perimeter = side1 + side2 + side3;
   double distanceToRun = 5000;
   int rounds = (int)Math.Ceiling(distanceToRun / perimeter);
   Console.WriteLine("the total no of rounds to cover the distnace of 5km is:" +rounds);
  }
  static void Main(String [] args)
  {
        Console.WriteLine("Enter the length of the first side of the triangular park in meters:");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the second side of the triangular park in meters:");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the length of the third side of the triangular park in meters:");
        double side3 = Convert.ToDouble(Console.ReadLine());
		Rounds(side1,side2,side3);
		Console.ReadLine();
		}
	}