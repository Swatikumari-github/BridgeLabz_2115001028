using System;


    class ques8
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      
		 double convFactor=0.621371;
		Console.WriteLine("emter the distance in km");
		
		double Km = Convert.ToDouble(Console.ReadLine());
		double Miles = Km*convFactor;
		
		Console.WriteLine(Km + " kilometers is equal to " + Miles + " miles.");
       

		 
		 Console.ReadLine();
		  
		}
	}