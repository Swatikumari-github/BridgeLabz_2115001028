using System;


    class ques7
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      
		 double radiusKm=6371;
		 double radiusMiles=3958.8;
		
		double volumeKm = (4.0/3.0)*Math.PI*Math.Pow(radiusKm,3);
		double volumeMiles = (4.0/3.0)*Math.PI*Math.Pow(radiusMiles,3);
		
		Console.WriteLine("volume of earth in km^3 is:" + volumeKm);
        Console.WriteLine("volume of earth in miles^3 is:" + volumeMiles);

		 
		 Console.ReadLine();
		  
		}
	}
