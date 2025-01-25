using System;
class Program{
   static void MeanHeight(double []height)
   {
      for(int i=0;i<10;i++)
	  {
	     height[i]=Convert.ToDouble(Console.ReadLine());
		 
	   }
	   double sum=0;
	    for(int i=0;i<10;i++)
	  {
	     sum+=height[i];
		 
	   }
	   double meanHeight=sum/11;
	   Console.WriteLine("meanHeight is:" +meanHeight);
	   
	}
	static void Main(string [] args)
	{ 
	Console.WriteLine("Enter the hieght:");
	  double []height=new double[11];
	 
      MeanHeight(height);
	  }
	 }
