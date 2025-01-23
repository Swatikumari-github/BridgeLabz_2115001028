using System;
class ques2{
   static void Smallest(int a,int b,int c)
   {
       if(a<b && a<c){
	      Console.WriteLine("yes the first number is smallest than the other two numbers");
		}
		else{
		   Console.WriteLine("No, the first number is not the smallest than the other two");
		  }
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the first number:");
	   int a=Convert.ToInt32(Console.ReadLine());
	   Console.WriteLine("enter the second number:");
	   int b=Convert.ToInt32(Console.ReadLine());
	   Console.WriteLine("enter the third number:");
	   int c=Convert.ToInt32(Console.ReadLine());
	   Smallest(a,b,c);
	   Console.ReadLine();
	 }
}
	   
	   