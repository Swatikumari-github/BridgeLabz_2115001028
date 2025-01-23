using System;
class ques15{
   static void Factorial()
   {
       Console.WriteLine("enter the number");
	   int num=Convert.ToInt32(Console.ReadLine());
	   int fact=1;
	    for(int i=1;i<=num;i++)
		{
		  fact=fact*i;
		  }
		  Console.WriteLine("factorial of the number is:" +fact);
		  
	   
		
	}
	static void Main(string [] args)
	{
	  
	  Factorial();
	  Console.ReadLine();
	 }
}