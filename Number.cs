using System;
class ques6{
   static void Numbers(int n)
   {
        if(n==0){
	    
		Console.WriteLine("The number is" +" "+n +" and it is a zero");
		}
		else if(n<0){
		Console.WriteLine("The number is" +" "+n +" and it is a negative number");
		}
		else{
		Console.WriteLine("The number is" +" "+n +" and it is a positive number");
		}
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the number:");
	   int n=Convert.ToInt32(Console.ReadLine());
	 Numbers(n);
	   Console.ReadLine();
	 }
}