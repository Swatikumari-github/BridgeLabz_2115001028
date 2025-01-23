using System;

class counter
 
{
     static void Counter(int number)
	 {
	    int c=0;
		int originalNum=number;
		while(originalNum!=0)
		{
		 
		    c++;
		   originalNum/=10;
		 }
		Console.WriteLine("the number of digits in agiven number is:" +c);
  
	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
	    Counter(number);
		Console.ReadLine();
    }
}