using System;
class Abundant{
   static void abundantNum(int number)
   {
      int sum=0;
	  for(int i=1;i<number;i++)
	    {
		   if(number%i==0)
		   {  
		     sum+=i;
			}
		}
	if(sum>number)
	{
	    Console.WriteLine("the given number is a abudant number");
	}
	else{
	   Console.WriteLine("the given number is a not abudant number");
	   }
	}
	 static void Main(String [] args)
	 { 
	    Console.WriteLine("enter the number");
	    int number=int.Parse(Console.ReadLine());
		abundantNum(number);
		Console.ReadLine();
		}
	}
	
