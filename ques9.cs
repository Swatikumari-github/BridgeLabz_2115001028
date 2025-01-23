using System;
class ques9{
   static void DownCounter(int counter)
   {
       for(int i = counter; i >= 1; i--){
		Console.WriteLine("the value of the counter is:" +i);

		
		}
		
	}
	static void Main(string [] args)
	{
	   Console.WriteLine("enter the value of  counter:");
	   int counter=Convert.ToInt32(Console.ReadLine());
	   DownCounter(counter);
	   Console.ReadLine();
	 }
}