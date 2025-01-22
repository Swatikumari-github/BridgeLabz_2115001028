using System;

class ques8 {
     static void totalDistance(double distanceFromToVia,int timeFromToVia, double distanceViaToFinalCity,int timeViaToFinalCity )
	 {
	    double totalDistance = distanceFromToVia + distanceViaToFinalCity;
        int totalTime = timeFromToVia + timeViaToFinalCity;
		Console.WriteLine("The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} km and the Total Time taken is {totalTime} minutes");
	  }
     public static void Main(string[] args) {

      
      string name = Console.ReadLine();
	  
      
      
      string fromCity = Console.ReadLine();
	  string viaCity = Console.ReadLine(); 
	  string toCity = Console.ReadLine();

  
      double distanceFromToVia = Convert.ToDouble(Console.ReadLine());
      int timeFromToVia = Convert.ToInt32(Console.ReadLine());
      double distanceViaToFinalCity = Convert.ToDouble(Console.ReadLine());
      int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine());

     totalDistance(distanceFromToVia,timeFromToVia,distanceViaToFinalCity,timeViaToFinalCity);
	 Console.ReadKey();

     
     
   }
}
