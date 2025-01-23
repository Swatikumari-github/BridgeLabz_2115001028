using System;

class Factor
 
{
     static void GreatestFactor(int number)
	 {
	     int GFactor=1;
		 for(int i=number-1;i>=1;i--)
		 { 
		 if(number%i==0){
		    GFactor=i;
			break;
		}
		}
		Console.WriteLine(GFactor);
		 
	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		GreatestFactor(number);
		Console.ReadLine();
    }
}

