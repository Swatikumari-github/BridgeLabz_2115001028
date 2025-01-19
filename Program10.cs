using System;
namespace ConsApi
{
    class Program10
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      Console.WriteLine("enter the km");
		  int kilometer=Convert.ToInt32(Console.ReadLine());
		 
		  float miles=kilometer*0.621371f;
		
		  Console.WriteLine("dist in miles is:" +miles);
		  Console.ReadLine();
		  
		 }
	}
}