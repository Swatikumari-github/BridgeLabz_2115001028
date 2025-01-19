using System;
namespace ConsApi
{
    class Program8
	{  
	   static double Power(double baseV, int exponent)
	   {
	    if(exponent == 0) return 1;
		if(exponent > 0)
		     return baseV*Power(baseV, exponent - 1);
		else
		    return 1 / Power(baseV, -exponent);
		}
		 
	   
	   static void Main(String [] args)
	   {
	      Console.WriteLine("enter the base");
		  double baseV=double.Parse(Console.ReadLine());
		  Console.WriteLine("enter the exponent");
		  int exponent=int.Parse(Console.ReadLine());
		  double result=Power(baseV,exponent);
		  Console.WriteLine("ans is:" result);
		  Console.ReadLine();
		  
		 }
	}
}
