using System;
class ques9{
 
   static void quoRem(int dividend,int divisor)
   {
      int quo=dividend/divisor;
	  int rem=dividend%divisor;
      Console.WriteLine("the quotient is :" +quo);
	  Console.WriteLine("the remainder is :" +rem);
	}
   
  

	static void Main(string [] args)
	{
	   Console.WriteLine("enter the dividend:");
	   int dividend=Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("enter the divisor:");
	   int divisor=Convert.ToInt32(Console.ReadLine());
quoRem(dividend,divisor);
	
	   Console.ReadLine();
	 }
}