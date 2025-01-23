using System;
class ques3{
   static void Largest(int a,int b,int c)
   {
       if(a>b && a>c){
	      Console.WriteLine("first number is largest than the other two numbers");
		}
		else if(b>a && b>c){
		   Console.WriteLine("second number is largest of the other two");
		}
		else{
		   Console.WriteLine("third number is largest of the other two");
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
	  Largest(a,b,c);
	   Console.ReadLine();
	 }
}