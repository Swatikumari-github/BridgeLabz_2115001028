using System;
class ques16{
   static void EvenOdd()
   {
       Console.WriteLine("enter the number");
	   int num=Convert.ToInt32(Console.ReadLine());
	  
	    for(int i=1;i<=num;i++)
		{
		  if(i%2==0){
		  
		  Console.WriteLine("the number is" +i +" " + "and it is a even number");
		  }
		  else
		  {
		   Console.WriteLine("the number is" +i +" " + "and it is a odd number");
		   }
		  
		}
		
	}
	static void Main(string [] args)
	{
	  
	  EvenOdd();
	  Console.ReadLine();
	 }
}