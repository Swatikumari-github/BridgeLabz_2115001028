using System;
class ques7{
  public static int sum=0;
   static void sumNatural(int num)
   
   {
         for(int i=1;i<=num;i++)
		 {
		  sum+=i;
		  
		 }
   }
   public static void display()
   {
   Console.WriteLine("The sum of n natural number is:" +sum);
   }
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the num:");
	   int num=Convert.ToInt32(Console.ReadLine());
	   sumNatural(num);
	   display();
	   Console.ReadLine();
	 }
}