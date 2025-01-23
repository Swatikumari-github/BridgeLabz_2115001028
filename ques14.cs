using System;
class ques14{
   static void Factorial()
   {
       Console.WriteLine("enter the number");
	   int num=Convert.ToInt32(Console.ReadLine());
	   int fact=1;
	  while(num>0){
		  fact=fact*num;
		  num--;
	  }
		  Console.WriteLine("factorial of the number is:" +fact);
		  
	   
		
	}
	static void Main(string [] args)
	{
	  
	  Factorial();
	  Console.ReadLine();
	 }
}
