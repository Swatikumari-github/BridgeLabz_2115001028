using System;

class Armstrong
 
{
     static void checkArmstrong(int number)
	 {
	    int sum=0;
		int originalNum=number;
		while(originalNum!=0)
		{
		   int rem=originalNum%10;
		   sum+=rem*rem*rem;
		   originalNum/=10;
		 }
		 if(sum==number){
		 Console.WriteLine("the given number is a armstrong number");
		 }
		 else{
		     Console.WriteLine("the given number is a armstrong number");
			}
  
	 }
    static void Main()
    {
        Console.WriteLine("enter the number:");
		int number=Convert.ToInt32(Console.ReadLine());
		
	    checkArmstrong(number);
		Console.ReadLine();
    }
}