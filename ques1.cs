using System;


    class ques1
	{  
	   static void RemQuo(int dividend,int divisor)
	   {
	   if(divisor==0)
	   {
	      Console.WriteLine("error: division by zero is not allowed");
		  return;
		}
		int quotient=dividend/divisor;
		int remainder=dividend%divisor;
		Console.WriteLine("the quotient is:" +quotient);
		Console.WriteLine("the remainder is:" +remainder);
		
	   }
	   
	   static void Main(String [] args)
	   {
	     Console.WriteLine("enter the dividend");
	     int dividend=Convert.ToInt32(Console.ReadLine());
	     Console.WriteLine("enter the divisor");
	     int divisor=Convert.ToInt32(Console.ReadLine());
	     RemQuo(dividend,divisor);
		 Console.ReadKey();
		  
		}
}
