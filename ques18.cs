using System;
class ques18{
   static void Table()
   {
       Console.WriteLine("enter the number");
	  
	  int number=Convert.ToInt32(Console.ReadLine());
	 
	  for(int i=6;i<=9;i++)
	  {
	   Console.WriteLine(number + " * " + i + " = " + (number * i));
	  }
	   
   }
	static void Main(string [] args)
	{
	  
	  Table();
	  Console.ReadLine();
	 }
}