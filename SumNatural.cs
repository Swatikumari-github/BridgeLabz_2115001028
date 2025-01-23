using System;
class ques4{
   static void SumNatural(int num)
   {
        if(num>0){
	    int sum=num*(num+1)/2;
		Console.WriteLine("The number is a natural number and the sum of" +num + "natural numbers is:" +sum );
		}
		else{
		Console.WriteLine("The number is not a natural number");
		}
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the number:");
	   int num=Convert.ToInt32(Console.ReadLine());
	   SumNatural(num);
	   Console.ReadLine();
	 }
}