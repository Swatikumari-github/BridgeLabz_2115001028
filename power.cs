using System;

class Power
 
{
     static void power(int number,int pow)
	 {
	 int result=1;
	    
		  for (int i = 1; i <= pow; i++)
        {
            result *= number;
        }
		Console.WriteLine(result);

	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter the power:");
		int pow=Convert.ToInt32(Console.ReadLine());
	    power(number,pow);
		Console.ReadLine();
    }
}
