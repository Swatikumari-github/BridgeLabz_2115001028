using System;

class Factors
 
{
     static void multiple(int number)
	 {
	    for(int i=1;i<number;i++)
		{
		   if(number%i==0)
		     {
		       Console.WriteLine(i);
		     }
		}

	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
	    multiple(number);
		Console.ReadLine();
    }
}