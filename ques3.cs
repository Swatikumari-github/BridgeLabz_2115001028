using System;


    class ques3
	{  
	   static void Operation(double a,double b,double c)
	   {
	   
	     Console.WriteLine(a+(b*c));
		 Console.WriteLine((a*b)+c);
		 Console.WriteLine(c+(a/b));
		  Console.WriteLine((a%b)+c);
			
		  
		 
		  
		
		
		
		
	   }
	   
	   static void Main(String [] args)
	   {
	     Console.WriteLine("enter the a");
	     double a=Convert.ToDouble(Console.ReadLine());
	     Console.WriteLine("enter the b");
	     double b=Convert.ToDouble(Console.ReadLine());
		 Console.WriteLine("enter the c");
	     double c=Convert.ToDouble(Console.ReadLine());
	    Operation(a,b,c);
		 Console.ReadKey();
		  
		}
}
