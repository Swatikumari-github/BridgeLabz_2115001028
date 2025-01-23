using System;

class multiple
 
{
     static void multiple2(int number)
	 {
	    for(int i=100;i>=1;i--)
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
		
	    multiple2(number);
		Console.ReadLine();
    }
}