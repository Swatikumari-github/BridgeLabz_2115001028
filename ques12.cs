using System;
class ques12
{
  static void Weight(float weight)
  {
	 float weightKg=(float)(weight*2.2);
	  
	  Console.WriteLine("the weight in kg is:" +weightKg);
  }
  static void Main(String [] args){
	  Console.WriteLine("enter the weight in pound");
	  float weight=float.Parse(Console.ReadLine());
	  
Weight(weight);
	  
	   Console.ReadKey();
	  
  }
}
		
	