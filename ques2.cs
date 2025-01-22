using System;


    class ques2
	{  
	   static void Operation(int a,int b,int c)
	   {
	   
	     Console.WriteLine(a+(b*c));
		 Console.WriteLine((a*b)+c);
		 Console.WriteLine(c+(a/b));
		  Console.WriteLine((a%b)+c);
			
		  
		 
		  
		
		
		
		
	   }
	   
	   static void Main(String [] args)
	   {
	     Console.WriteLine("enter the a");
	     int a=Convert.ToInt32(Console.ReadLine());
	     Console.WriteLine("enter the b");
	     int b=Convert.ToInt32(Console.ReadLine());
		 Console.WriteLine("enter the c");
	     int c=Convert.ToInt32(Console.ReadLine());
	    Operation(a,b,c);
		 Console.ReadKey();
		  
		}
}
