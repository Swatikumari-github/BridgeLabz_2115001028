using System;

class Program

{
   static int testNumber(int num)
   {
    if(num<0)
	{
	  return -1;
	 }
	 else if(num>0)
	 {
	 return 1;
	 }
	 else {
	 return 0;
	 }
	}
	static void display(int num)
	{
	Console.WriteLine("the ans is "   +  testNumber(num));
	}
	
    static void Main(string[] args)
    {
     Console.WriteLine("Enter the number:");
	 int num=Convert.ToInt32(Console.ReadLine());
	
	testNumber(num);
	 display(num);
	 
    }
}