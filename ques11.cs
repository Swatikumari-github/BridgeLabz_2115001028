using System;
class ques11
{
  static void SI(float principal,float rate,float time)
  {
	 float SI=(principal*rate*time)/100;
	  
	  Console.WriteLine("the SI is:" +SI);
  }
  static void Main(String [] args){
	  Console.WriteLine("enter the principal");
	  float principal=float.Parse(Console.ReadLine());
	  Console.WriteLine("enter the no of rate");
	   float rate=float.Parse(Console.ReadLine());
	    Console.WriteLine("enter the no of time");
	   float time=float.Parse(Console.ReadLine());
	  SI(principal,rate,time);
	   Console.ReadKey();
	  
  }
}
		
	