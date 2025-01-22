using System;
class ques10
{
  static void Chocolate(int numberOfChocolates,int numberOfChildren)
  {
	  int chocolateGiven=numberOfChocolates/numberOfChildren;
	  int remainningChoco=numberOfChocolates%numberOfChildren;
	  Console.WriteLine("the no of chocolate given to each staudents is:" +chocolateGiven);
	  Console.WriteLine("the remaining chocolates are:" +remainningChoco);
  }
  static void Main(String [] args){
	  Console.WriteLine("enter the no of children");
	  int numberOfChildren=Convert.ToInt32(Console.ReadLine());
	    Console.WriteLine("enter the no of chocolate");
	   int numberOfChocolates=Convert.ToInt32(Console.ReadLine());
	   Chocolate(numberOfChocolates,numberOfChildren);
	   Console.ReadKey();
	  
  }
}
		
	