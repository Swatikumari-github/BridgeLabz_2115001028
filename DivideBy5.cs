using System;
class DivisibleBy5{
     static void Divide(int num){
	   if(num%5 == 0){
	     Console.WriteLine("the given number is divisible by 5");
		}
		else{
		   Console.WriteLine("the given number is not divisible by 5");
		  }
	}
	static void Main(String [] args){
	Console.WriteLine("enter the number");
	int num=Convert.ToInt32(Console.ReadLine());
	Divide(num);
	Console.ReadKey();
	}
}