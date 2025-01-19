using System;
namespace ConsApi
{
    class Program9
	{  
	   
	   
	   static void Main(String [] args)
	   {
	      Console.WriteLine("enter the number1");
		  int num1=Convert.ToInt32(Console.ReadLine());
		  Console.WriteLine("enter the number2");
		  int num2=Convert.ToInt32(Console.ReadLine());
		  Console.WriteLine("enter the number3");
		  int num3=Convert.ToInt32(Console.ReadLine());
		  float res=(num1+num2+num3)/3.0f;
		
		  Console.WriteLine("avg of 3 number is:" +res);
		  Console.ReadLine();
		  
		 }
	}
}
